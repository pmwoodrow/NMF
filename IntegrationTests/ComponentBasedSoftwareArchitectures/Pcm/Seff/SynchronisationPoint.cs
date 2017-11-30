//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Identifier;
using NMFExamples.Pcm.Core;
using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Parameter;
using NMFExamples.Pcm.Reliability;
using NMFExamples.Pcm.Repository;
using NMFExamples.Pcm.Seff.Seff_performance;
using NMFExamples.Pcm.Seff.Seff_reliability;
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

namespace NMFExamples.Pcm.Seff
{
    
    
    /// <summary>
    /// The default implementation of the SynchronisationPoint class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/SEFF/5.0")]
    [XmlNamespacePrefixAttribute("seff")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/SynchronisationPoint")]
    public partial class SynchronisationPoint : ModelElement, ISynchronisationPoint, IModelElement
    {
        
        private static Lazy<ITypedElement> _outputParameterUsage_SynchronisationPointReference = new Lazy<ITypedElement>(RetrieveOutputParameterUsage_SynchronisationPointReference);
        
        /// <summary>
        /// The backing field for the OutputParameterUsage_SynchronisationPoint property
        /// </summary>
        private SynchronisationPointOutputParameterUsage_SynchronisationPointCollection _outputParameterUsage_SynchronisationPoint;
        
        private static Lazy<ITypedElement> _forkAction_SynchronisationPointReference = new Lazy<ITypedElement>(RetrieveForkAction_SynchronisationPointReference);
        
        private static Lazy<ITypedElement> _synchronousForkedBehaviours_SynchronisationPointReference = new Lazy<ITypedElement>(RetrieveSynchronousForkedBehaviours_SynchronisationPointReference);
        
        /// <summary>
        /// The backing field for the SynchronousForkedBehaviours_SynchronisationPoint property
        /// </summary>
        private SynchronisationPointSynchronousForkedBehaviours_SynchronisationPointCollection _synchronousForkedBehaviours_SynchronisationPoint;
        
        private static IClass _classInstance;
        
        public SynchronisationPoint()
        {
            this._outputParameterUsage_SynchronisationPoint = new SynchronisationPointOutputParameterUsage_SynchronisationPointCollection(this);
            this._outputParameterUsage_SynchronisationPoint.CollectionChanging += this.OutputParameterUsage_SynchronisationPointCollectionChanging;
            this._outputParameterUsage_SynchronisationPoint.CollectionChanged += this.OutputParameterUsage_SynchronisationPointCollectionChanged;
            this._synchronousForkedBehaviours_SynchronisationPoint = new SynchronisationPointSynchronousForkedBehaviours_SynchronisationPointCollection(this);
            this._synchronousForkedBehaviours_SynchronisationPoint.CollectionChanging += this.SynchronousForkedBehaviours_SynchronisationPointCollectionChanging;
            this._synchronousForkedBehaviours_SynchronisationPoint.CollectionChanged += this.SynchronousForkedBehaviours_SynchronisationPointCollectionChanged;
        }
        
        /// <summary>
        /// The outputParameterUsage_SynchronisationPoint property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("outputParameterUsage_SynchronisationPoint")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("synchronisationPoint_VariableUsage")]
        [ConstantAttribute()]
        public IListExpression<IVariableUsage> OutputParameterUsage_SynchronisationPoint
        {
            get
            {
                return this._outputParameterUsage_SynchronisationPoint;
            }
        }
        
        /// <summary>
        /// The forkAction_SynchronisationPoint property
        /// </summary>
        [XmlElementNameAttribute("forkAction_SynchronisationPoint")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("synchronisingBehaviours_ForkAction")]
        public IForkAction ForkAction_SynchronisationPoint
        {
            get
            {
                return ModelHelper.CastAs<IForkAction>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// The synchronousForkedBehaviours_SynchronisationPoint property
        /// </summary>
        [LowerBoundAttribute(1)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("synchronousForkedBehaviours_SynchronisationPoint")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("synchronisationPoint_ForkedBehaviour")]
        [ConstantAttribute()]
        public IListExpression<IForkedBehaviour> SynchronousForkedBehaviours_SynchronisationPoint
        {
            get
            {
                return this._synchronousForkedBehaviours_SynchronisationPoint;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new SynchronisationPointChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new SynchronisationPointReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/SynchronisationPoint")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ForkAction_SynchronisationPoint property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ForkAction_SynchronisationPointChanging;
        
        /// <summary>
        /// Gets fired when the ForkAction_SynchronisationPoint property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ForkAction_SynchronisationPointChanged;
        
        private static ITypedElement RetrieveOutputParameterUsage_SynchronisationPointReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Seff.SynchronisationPoint.ClassInstance)).Resolve("outputParameterUsage_SynchronisationPoint")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the OutputParameterUsage_SynchronisationPoint property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OutputParameterUsage_SynchronisationPointCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("OutputParameterUsage_SynchronisationPoint", e, _outputParameterUsage_SynchronisationPointReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the OutputParameterUsage_SynchronisationPoint property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OutputParameterUsage_SynchronisationPointCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("OutputParameterUsage_SynchronisationPoint", e, _outputParameterUsage_SynchronisationPointReference);
        }
        
        private static ITypedElement RetrieveForkAction_SynchronisationPointReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Seff.SynchronisationPoint.ClassInstance)).Resolve("forkAction_SynchronisationPoint")));
        }
        
        /// <summary>
        /// Raises the ForkAction_SynchronisationPointChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnForkAction_SynchronisationPointChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ForkAction_SynchronisationPointChanging;
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
        protected override void OnParentChanging(IModelElement newParent, IModelElement oldParent)
        {
            IForkAction oldForkAction_SynchronisationPoint = ModelHelper.CastAs<IForkAction>(oldParent);
            IForkAction newForkAction_SynchronisationPoint = ModelHelper.CastAs<IForkAction>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldForkAction_SynchronisationPoint, newForkAction_SynchronisationPoint);
            this.OnForkAction_SynchronisationPointChanging(e);
            this.OnPropertyChanging("ForkAction_SynchronisationPoint", e, _forkAction_SynchronisationPointReference);
        }
        
        /// <summary>
        /// Raises the ForkAction_SynchronisationPointChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnForkAction_SynchronisationPointChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ForkAction_SynchronisationPointChanged;
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
        protected override void OnParentChanged(IModelElement newParent, IModelElement oldParent)
        {
            IForkAction oldForkAction_SynchronisationPoint = ModelHelper.CastAs<IForkAction>(oldParent);
            IForkAction newForkAction_SynchronisationPoint = ModelHelper.CastAs<IForkAction>(newParent);
            if ((oldForkAction_SynchronisationPoint != null))
            {
                oldForkAction_SynchronisationPoint.SynchronisingBehaviours_ForkAction = null;
            }
            if ((newForkAction_SynchronisationPoint != null))
            {
                newForkAction_SynchronisationPoint.SynchronisingBehaviours_ForkAction = this;
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldForkAction_SynchronisationPoint, newForkAction_SynchronisationPoint);
            this.OnForkAction_SynchronisationPointChanged(e);
            this.OnPropertyChanged("ForkAction_SynchronisationPoint", e, _forkAction_SynchronisationPointReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        private static ITypedElement RetrieveSynchronousForkedBehaviours_SynchronisationPointReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Seff.SynchronisationPoint.ClassInstance)).Resolve("synchronousForkedBehaviours_SynchronisationPoint")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the SynchronousForkedBehaviours_SynchronisationPoint property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void SynchronousForkedBehaviours_SynchronisationPointCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("SynchronousForkedBehaviours_SynchronisationPoint", e, _synchronousForkedBehaviours_SynchronisationPointReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the SynchronousForkedBehaviours_SynchronisationPoint property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void SynchronousForkedBehaviours_SynchronisationPointCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("SynchronousForkedBehaviours_SynchronisationPoint", e, _synchronousForkedBehaviours_SynchronisationPointReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int outputParameterUsage_SynchronisationPointIndex = ModelHelper.IndexOfReference(this.OutputParameterUsage_SynchronisationPoint, element);
            if ((outputParameterUsage_SynchronisationPointIndex != -1))
            {
                return ModelHelper.CreatePath("outputParameterUsage_SynchronisationPoint", outputParameterUsage_SynchronisationPointIndex);
            }
            int synchronousForkedBehaviours_SynchronisationPointIndex = ModelHelper.IndexOfReference(this.SynchronousForkedBehaviours_SynchronisationPoint, element);
            if ((synchronousForkedBehaviours_SynchronisationPointIndex != -1))
            {
                return ModelHelper.CreatePath("synchronousForkedBehaviours_SynchronisationPoint", synchronousForkedBehaviours_SynchronisationPointIndex);
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
            if ((reference == "OUTPUTPARAMETERUSAGE_SYNCHRONISATIONPOINT"))
            {
                if ((index < this.OutputParameterUsage_SynchronisationPoint.Count))
                {
                    return this.OutputParameterUsage_SynchronisationPoint[index];
                }
                else
                {
                    return null;
                }
            }
            if ((reference == "SYNCHRONOUSFORKEDBEHAVIOURS_SYNCHRONISATIONPOINT"))
            {
                if ((index < this.SynchronousForkedBehaviours_SynchronisationPoint.Count))
                {
                    return this.SynchronousForkedBehaviours_SynchronisationPoint[index];
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
            if ((feature == "OUTPUTPARAMETERUSAGE_SYNCHRONISATIONPOINT"))
            {
                return this._outputParameterUsage_SynchronisationPoint;
            }
            if ((feature == "SYNCHRONOUSFORKEDBEHAVIOURS_SYNCHRONISATIONPOINT"))
            {
                return this._synchronousForkedBehaviours_SynchronisationPoint;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "FORKACTION_SYNCHRONISATIONPOINT"))
            {
                this.ForkAction_SynchronisationPoint = ((IForkAction)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "ForkAction_SynchronisationPoint"))
            {
                return new ForkAction_SynchronisationPointProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "ForkAction_SynchronisationPoint"))
            {
                return new ForkAction_SynchronisationPointProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._outputParameterUsage_SynchronisationPoint))
            {
                return "outputParameterUsage_SynchronisationPoint";
            }
            if ((container == this._synchronousForkedBehaviours_SynchronisationPoint))
            {
                return "synchronousForkedBehaviours_SynchronisationPoint";
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/SynchronisationPoint")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SynchronisationPoint class
        /// </summary>
        public class SynchronisationPointChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SynchronisationPoint _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SynchronisationPointChildrenCollection(SynchronisationPoint parent)
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
                    count = (count + this._parent.OutputParameterUsage_SynchronisationPoint.Count);
                    count = (count + this._parent.SynchronousForkedBehaviours_SynchronisationPoint.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.OutputParameterUsage_SynchronisationPoint.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.SynchronousForkedBehaviours_SynchronisationPoint.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.OutputParameterUsage_SynchronisationPoint.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.SynchronousForkedBehaviours_SynchronisationPoint.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IVariableUsage outputParameterUsage_SynchronisationPointCasted = item.As<IVariableUsage>();
                if ((outputParameterUsage_SynchronisationPointCasted != null))
                {
                    this._parent.OutputParameterUsage_SynchronisationPoint.Add(outputParameterUsage_SynchronisationPointCasted);
                }
                IForkedBehaviour synchronousForkedBehaviours_SynchronisationPointCasted = item.As<IForkedBehaviour>();
                if ((synchronousForkedBehaviours_SynchronisationPointCasted != null))
                {
                    this._parent.SynchronousForkedBehaviours_SynchronisationPoint.Add(synchronousForkedBehaviours_SynchronisationPointCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.OutputParameterUsage_SynchronisationPoint.Clear();
                this._parent.SynchronousForkedBehaviours_SynchronisationPoint.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.OutputParameterUsage_SynchronisationPoint.Contains(item))
                {
                    return true;
                }
                if (this._parent.SynchronousForkedBehaviours_SynchronisationPoint.Contains(item))
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
                IEnumerator<IModelElement> outputParameterUsage_SynchronisationPointEnumerator = this._parent.OutputParameterUsage_SynchronisationPoint.GetEnumerator();
                try
                {
                    for (
                    ; outputParameterUsage_SynchronisationPointEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = outputParameterUsage_SynchronisationPointEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    outputParameterUsage_SynchronisationPointEnumerator.Dispose();
                }
                IEnumerator<IModelElement> synchronousForkedBehaviours_SynchronisationPointEnumerator = this._parent.SynchronousForkedBehaviours_SynchronisationPoint.GetEnumerator();
                try
                {
                    for (
                    ; synchronousForkedBehaviours_SynchronisationPointEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = synchronousForkedBehaviours_SynchronisationPointEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    synchronousForkedBehaviours_SynchronisationPointEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IVariableUsage variableUsageItem = item.As<IVariableUsage>();
                if (((variableUsageItem != null) 
                            && this._parent.OutputParameterUsage_SynchronisationPoint.Remove(variableUsageItem)))
                {
                    return true;
                }
                IForkedBehaviour forkedBehaviourItem = item.As<IForkedBehaviour>();
                if (((forkedBehaviourItem != null) 
                            && this._parent.SynchronousForkedBehaviours_SynchronisationPoint.Remove(forkedBehaviourItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.OutputParameterUsage_SynchronisationPoint).Concat(this._parent.SynchronousForkedBehaviours_SynchronisationPoint).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SynchronisationPoint class
        /// </summary>
        public class SynchronisationPointReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SynchronisationPoint _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SynchronisationPointReferencedElementsCollection(SynchronisationPoint parent)
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
                    count = (count + this._parent.OutputParameterUsage_SynchronisationPoint.Count);
                    if ((this._parent.ForkAction_SynchronisationPoint != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.SynchronousForkedBehaviours_SynchronisationPoint.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.OutputParameterUsage_SynchronisationPoint.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ForkAction_SynchronisationPointChanged += this.PropagateValueChanges;
                this._parent.SynchronousForkedBehaviours_SynchronisationPoint.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.OutputParameterUsage_SynchronisationPoint.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ForkAction_SynchronisationPointChanged -= this.PropagateValueChanges;
                this._parent.SynchronousForkedBehaviours_SynchronisationPoint.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IVariableUsage outputParameterUsage_SynchronisationPointCasted = item.As<IVariableUsage>();
                if ((outputParameterUsage_SynchronisationPointCasted != null))
                {
                    this._parent.OutputParameterUsage_SynchronisationPoint.Add(outputParameterUsage_SynchronisationPointCasted);
                }
                if ((this._parent.ForkAction_SynchronisationPoint == null))
                {
                    IForkAction forkAction_SynchronisationPointCasted = item.As<IForkAction>();
                    if ((forkAction_SynchronisationPointCasted != null))
                    {
                        this._parent.ForkAction_SynchronisationPoint = forkAction_SynchronisationPointCasted;
                        return;
                    }
                }
                IForkedBehaviour synchronousForkedBehaviours_SynchronisationPointCasted = item.As<IForkedBehaviour>();
                if ((synchronousForkedBehaviours_SynchronisationPointCasted != null))
                {
                    this._parent.SynchronousForkedBehaviours_SynchronisationPoint.Add(synchronousForkedBehaviours_SynchronisationPointCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.OutputParameterUsage_SynchronisationPoint.Clear();
                this._parent.ForkAction_SynchronisationPoint = null;
                this._parent.SynchronousForkedBehaviours_SynchronisationPoint.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.OutputParameterUsage_SynchronisationPoint.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.ForkAction_SynchronisationPoint))
                {
                    return true;
                }
                if (this._parent.SynchronousForkedBehaviours_SynchronisationPoint.Contains(item))
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
                IEnumerator<IModelElement> outputParameterUsage_SynchronisationPointEnumerator = this._parent.OutputParameterUsage_SynchronisationPoint.GetEnumerator();
                try
                {
                    for (
                    ; outputParameterUsage_SynchronisationPointEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = outputParameterUsage_SynchronisationPointEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    outputParameterUsage_SynchronisationPointEnumerator.Dispose();
                }
                if ((this._parent.ForkAction_SynchronisationPoint != null))
                {
                    array[arrayIndex] = this._parent.ForkAction_SynchronisationPoint;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> synchronousForkedBehaviours_SynchronisationPointEnumerator = this._parent.SynchronousForkedBehaviours_SynchronisationPoint.GetEnumerator();
                try
                {
                    for (
                    ; synchronousForkedBehaviours_SynchronisationPointEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = synchronousForkedBehaviours_SynchronisationPointEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    synchronousForkedBehaviours_SynchronisationPointEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IVariableUsage variableUsageItem = item.As<IVariableUsage>();
                if (((variableUsageItem != null) 
                            && this._parent.OutputParameterUsage_SynchronisationPoint.Remove(variableUsageItem)))
                {
                    return true;
                }
                if ((this._parent.ForkAction_SynchronisationPoint == item))
                {
                    this._parent.ForkAction_SynchronisationPoint = null;
                    return true;
                }
                IForkedBehaviour forkedBehaviourItem = item.As<IForkedBehaviour>();
                if (((forkedBehaviourItem != null) 
                            && this._parent.SynchronousForkedBehaviours_SynchronisationPoint.Remove(forkedBehaviourItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.OutputParameterUsage_SynchronisationPoint).Concat(this._parent.ForkAction_SynchronisationPoint).Concat(this._parent.SynchronousForkedBehaviours_SynchronisationPoint).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the forkAction_SynchronisationPoint property
        /// </summary>
        private sealed class ForkAction_SynchronisationPointProxy : ModelPropertyChange<ISynchronisationPoint, IForkAction>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ForkAction_SynchronisationPointProxy(ISynchronisationPoint modelElement) : 
                    base(modelElement, "forkAction_SynchronisationPoint")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IForkAction Value
            {
                get
                {
                    return this.ModelElement.ForkAction_SynchronisationPoint;
                }
                set
                {
                    this.ModelElement.ForkAction_SynchronisationPoint = value;
                }
            }
        }
    }
}

