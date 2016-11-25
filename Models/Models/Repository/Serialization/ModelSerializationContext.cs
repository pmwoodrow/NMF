﻿using NMF.Serialization.Xmi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NMF.Models.Repository.Serialization
{
    public class ModelSerializationContext : XmiSerializationContext
    {
        public ModelSerializationContext(IModelRepository repository, Model root) : base(root)
        {
            Repository = repository;
        }

        public IModelRepository Repository { get; private set; }

        public Model Model { get { return Root as Model; } }

        private static Regex colonRegex = new Regex(@"^\w+:\w+ ", RegexOptions.Compiled);

        protected override object OnNameClash(string id, Type type, IEnumerable<object> candidates, object source)
        {
            var modelElement = source as IModelElement;
            if (modelElement != null)
            {
                var newCandidates = candidates.OfType<IModelElement>();
                if (newCandidates.Count() == 1) return newCandidates.First();
                var siblingsOfCurrent = newCandidates.Where(c => c.Parent == modelElement.Parent);
                if (siblingsOfCurrent.Count() == 1) return siblingsOfCurrent.First();
                var childrenOfCurrent = newCandidates.Where(c => c.Parent == modelElement);
                if (childrenOfCurrent.Count() == 1) return childrenOfCurrent.First();
            }
            return base.OnNameClash(id, type, candidates, source);
        }

        public override object Resolve(string id, Type type, bool exactType = false, bool failOnConflict = true, object source = null)
        {
            if (string.IsNullOrEmpty(id)) return null;
            var match = colonRegex.Match(id);
            if (match.Success)
            {
                id = id.Substring(match.Length);
            }

            Uri uri;
            IModelElement resolved = null;
            int hashIndex = id.IndexOf('#');
            if (hashIndex != -1)
            {
                if (hashIndex == 0)
                {
                    resolved = Model.Resolve(id);
                }
                else if (Uri.TryCreate(id, UriKind.Absolute, out uri))
                {
                    resolved = Repository.Resolve(uri);
                }
                else
                {
                    if (Model.ModelUri != null)
                    {
                        var newUri = new Uri(Model.ModelUri, id);
                        resolved = Repository.Resolve(newUri);
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
                }
            }
            else
            {
                resolved = Model.Resolve(id);
            }
            if (resolved != null)
            {
                if (failOnConflict)
                {
                    if (exactType)
                    {
                        if (resolved.GetType() == type)
                        {
                            return resolved;
                        }
                        else
                        {
                            throw new InvalidOperationException($"The model element with the uri {id} has not the expected type {type.Name} but is a {resolved.GetType().Name} instead.");
                        }
                    }
                    else
                    {
                        if (type.IsInstanceOfType(resolved))
                        {
                            return resolved;
                        }
                        else
                        {
                            throw new InvalidOperationException($"The model element with the uri {id} has not the expected type {type.Name} but is a {resolved.GetType().Name}.");
                        }
                    }
                }
                else
                {
                    return resolved;
                }
            }
            return base.Resolve(id, type, exactType, failOnConflict, source);
        }
    }
}
