//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Models.Meta
{
    
    
    /// <summary>
    /// The default implementation of the Type class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/nmeta/")]
    [XmlNamespacePrefixAttribute("nmeta")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/nmeta/#//Type")]
    [DebuggerDisplayAttribute("Type {Name}")]
    public abstract partial class Type : MetaElement, IType, NMF.Models.IModelElement
    {
        
        private static Lazy<ITypedElement> _namespaceReference = new Lazy<ITypedElement>(RetrieveNamespaceReference);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The Namespace property
        /// </summary>
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Types")]
        public INamespace Namespace
        {
            get
            {
                return ModelHelper.CastAs<INamespace>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new TypeReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//Type")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Namespace property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NamespaceChanging;
        
        /// <summary>
        /// Gets fired when the Namespace property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NamespaceChanged;
        
        private static ITypedElement RetrieveNamespaceReference()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(Type.ClassInstance)).Resolve("Namespace")));
        }
        
        /// <summary>
        /// Raises the NamespaceChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNamespaceChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NamespaceChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element is about to change
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanging(NMF.Models.IModelElement newParent, NMF.Models.IModelElement oldParent)
        {
            INamespace oldNamespace = ModelHelper.CastAs<INamespace>(oldParent);
            INamespace newNamespace = ModelHelper.CastAs<INamespace>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldNamespace, newNamespace);
            this.OnNamespaceChanging(e);
            this.OnPropertyChanging("Namespace", e, _namespaceReference);
        }
        
        /// <summary>
        /// Raises the NamespaceChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNamespaceChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NamespaceChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element changes
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanged(NMF.Models.IModelElement newParent, NMF.Models.IModelElement oldParent)
        {
            INamespace oldNamespace = ModelHelper.CastAs<INamespace>(oldParent);
            INamespace newNamespace = ModelHelper.CastAs<INamespace>(newParent);
            if ((oldNamespace != null))
            {
                oldNamespace.Types.Remove(this);
            }
            if ((newNamespace != null))
            {
                newNamespace.Types.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldNamespace, newNamespace);
            this.OnNamespaceChanged(e);
            this.OnPropertyChanged("Namespace", e, _namespaceReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override NMF.Models.IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "NAMESPACE"))
            {
                return this.Namespace;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "NAMESPACE"))
            {
                this.Namespace = ((INamespace)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "NAMESPACE"))
            {
                return new NamespaceProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//Type")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Type class
        /// </summary>
        public class TypeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private Type _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TypeReferencedElementsCollection(Type parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.Namespace != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.NamespaceChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.NamespaceChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                if ((this._parent.Namespace == null))
                {
                    INamespace namespaceCasted = item.As<INamespace>();
                    if ((namespaceCasted != null))
                    {
                        this._parent.Namespace = namespaceCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Namespace = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if ((item == this._parent.Namespace))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(NMF.Models.IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.Namespace != null))
                {
                    array[arrayIndex] = this._parent.Namespace;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(NMF.Models.IModelElement item)
            {
                if ((this._parent.Namespace == item))
                {
                    this._parent.Namespace = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<NMF.Models.IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.Namespace).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Namespace property
        /// </summary>
        private sealed class NamespaceProxy : ModelPropertyChange<IType, INamespace>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public NamespaceProxy(IType modelElement) : 
                    base(modelElement, "Namespace")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override INamespace Value
            {
                get
                {
                    return this.ModelElement.Namespace;
                }
                set
                {
                    this.ModelElement.Namespace = value;
                }
            }
        }
    }
}

