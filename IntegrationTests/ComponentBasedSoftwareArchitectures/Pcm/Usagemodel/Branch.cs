//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Pcm.Core;
using NMFExamples.Pcm.Core.Composition;
using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Parameter;
using NMFExamples.Pcm.Repository;
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
using global::System.Collections;
using global::System.Collections.Generic;
using global::System.Collections.ObjectModel;
using global::System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMFExamples.Pcm.Usagemodel
{
    
    
    /// <summary>
    /// The default implementation of the Branch class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/UsageModel/5.0")]
    [XmlNamespacePrefixAttribute("usagemodel")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//usagemodel/Branch")]
    [DebuggerDisplayAttribute("Branch {Id}")]
    public partial class Branch : AbstractUserAction, IBranch, IModelElement
    {
        
        private static Lazy<ITypedElement> _branchTransitions_BranchReference = new Lazy<ITypedElement>(RetrieveBranchTransitions_BranchReference);
        
        /// <summary>
        /// The backing field for the BranchTransitions_Branch property
        /// </summary>
        private BranchBranchTransitions_BranchCollection _branchTransitions_Branch;
        
        private static IClass _classInstance;
        
        public Branch()
        {
            this._branchTransitions_Branch = new BranchBranchTransitions_BranchCollection(this);
            this._branchTransitions_Branch.CollectionChanging += this.BranchTransitions_BranchCollectionChanging;
            this._branchTransitions_Branch.CollectionChanged += this.BranchTransitions_BranchCollectionChanged;
        }
        
        /// <summary>
        /// The branchTransitions_Branch property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("branchTransitions_Branch")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("branch_BranchTransition")]
        [ConstantAttribute()]
        public IListExpression<IBranchTransition> BranchTransitions_Branch
        {
            get
            {
                return this._branchTransitions_Branch;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new BranchChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new BranchReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//usagemodel/Branch")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveBranchTransitions_BranchReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Usagemodel.Branch.ClassInstance)).Resolve("branchTransitions_Branch")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the BranchTransitions_Branch property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void BranchTransitions_BranchCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("BranchTransitions_Branch", e, _branchTransitions_BranchReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the BranchTransitions_Branch property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void BranchTransitions_BranchCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("BranchTransitions_Branch", e, _branchTransitions_BranchReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int branchTransitions_BranchIndex = ModelHelper.IndexOfReference(this.BranchTransitions_Branch, element);
            if ((branchTransitions_BranchIndex != -1))
            {
                return ModelHelper.CreatePath("branchTransitions_Branch", branchTransitions_BranchIndex);
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "BRANCHTRANSITIONS_BRANCH"))
            {
                if ((index < this.BranchTransitions_Branch.Count))
                {
                    return this.BranchTransitions_Branch[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override global::System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "BRANCHTRANSITIONS_BRANCH"))
            {
                return this._branchTransitions_Branch;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._branchTransitions_Branch))
            {
                return "branchTransitions_Branch";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//usagemodel/Branch")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Branch class
        /// </summary>
        public class BranchChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Branch _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public BranchChildrenCollection(Branch parent)
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
                    count = (count + this._parent.BranchTransitions_Branch.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.BranchTransitions_Branch.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.BranchTransitions_Branch.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IBranchTransition branchTransitions_BranchCasted = item.As<IBranchTransition>();
                if ((branchTransitions_BranchCasted != null))
                {
                    this._parent.BranchTransitions_Branch.Add(branchTransitions_BranchCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.BranchTransitions_Branch.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.BranchTransitions_Branch.Contains(item))
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
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> branchTransitions_BranchEnumerator = this._parent.BranchTransitions_Branch.GetEnumerator();
                try
                {
                    for (
                    ; branchTransitions_BranchEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = branchTransitions_BranchEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    branchTransitions_BranchEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IBranchTransition branchTransitionItem = item.As<IBranchTransition>();
                if (((branchTransitionItem != null) 
                            && this._parent.BranchTransitions_Branch.Remove(branchTransitionItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.BranchTransitions_Branch).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Branch class
        /// </summary>
        public class BranchReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Branch _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public BranchReferencedElementsCollection(Branch parent)
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
                    count = (count + this._parent.BranchTransitions_Branch.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.BranchTransitions_Branch.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.BranchTransitions_Branch.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IBranchTransition branchTransitions_BranchCasted = item.As<IBranchTransition>();
                if ((branchTransitions_BranchCasted != null))
                {
                    this._parent.BranchTransitions_Branch.Add(branchTransitions_BranchCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.BranchTransitions_Branch.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.BranchTransitions_Branch.Contains(item))
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
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> branchTransitions_BranchEnumerator = this._parent.BranchTransitions_Branch.GetEnumerator();
                try
                {
                    for (
                    ; branchTransitions_BranchEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = branchTransitions_BranchEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    branchTransitions_BranchEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IBranchTransition branchTransitionItem = item.As<IBranchTransition>();
                if (((branchTransitionItem != null) 
                            && this._parent.BranchTransitions_Branch.Remove(branchTransitionItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.BranchTransitions_Branch).GetEnumerator();
            }
        }
    }
}
