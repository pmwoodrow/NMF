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
    /// The default implementation of the ForkedBehaviour class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/SEFF/5.0")]
    [XmlNamespacePrefixAttribute("seff")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/ForkedBehaviour")]
    [DebuggerDisplayAttribute("ForkedBehaviour {Id}")]
    public partial class ForkedBehaviour : ResourceDemandingBehaviour, IForkedBehaviour, IModelElement
    {
        
        private static Lazy<ITypedElement> _synchronisationPoint_ForkedBehaviourReference = new Lazy<ITypedElement>(RetrieveSynchronisationPoint_ForkedBehaviourReference);
        
        /// <summary>
        /// The backing field for the SynchronisationPoint_ForkedBehaviour property
        /// </summary>
        private ISynchronisationPoint _synchronisationPoint_ForkedBehaviour;
        
        private static Lazy<ITypedElement> _forkAction_ForkedBehaivourReference = new Lazy<ITypedElement>(RetrieveForkAction_ForkedBehaivourReference);
        
        /// <summary>
        /// The backing field for the ForkAction_ForkedBehaivour property
        /// </summary>
        private IForkAction _forkAction_ForkedBehaivour;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The synchronisationPoint_ForkedBehaviour property
        /// </summary>
        [XmlElementNameAttribute("synchronisationPoint_ForkedBehaviour")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("synchronousForkedBehaviours_SynchronisationPoint")]
        public ISynchronisationPoint SynchronisationPoint_ForkedBehaviour
        {
            get
            {
                return this._synchronisationPoint_ForkedBehaviour;
            }
            set
            {
                if ((this._synchronisationPoint_ForkedBehaviour != value))
                {
                    ISynchronisationPoint old = this._synchronisationPoint_ForkedBehaviour;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSynchronisationPoint_ForkedBehaviourChanging(e);
                    this.OnPropertyChanging("SynchronisationPoint_ForkedBehaviour", e, _synchronisationPoint_ForkedBehaviourReference);
                    this._synchronisationPoint_ForkedBehaviour = value;
                    this.Parent = value;
                    if ((old != null))
                    {
                        old.SynchronousForkedBehaviours_SynchronisationPoint.Remove(this);
                        old.Deleted -= this.OnResetSynchronisationPoint_ForkedBehaviour;
                    }
                    if ((value != null))
                    {
                        if ((value.SynchronousForkedBehaviours_SynchronisationPoint.Contains(this) != true))
                        {
                            value.SynchronousForkedBehaviours_SynchronisationPoint.Add(this);
                        }
                        value.Deleted += this.OnResetSynchronisationPoint_ForkedBehaviour;
                    }
                    this.OnSynchronisationPoint_ForkedBehaviourChanged(e);
                    this.OnPropertyChanged("SynchronisationPoint_ForkedBehaviour", e, _synchronisationPoint_ForkedBehaviourReference);
                }
            }
        }
        
        /// <summary>
        /// The forkAction_ForkedBehaivour property
        /// </summary>
        [XmlElementNameAttribute("forkAction_ForkedBehaivour")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("asynchronousForkedBehaviours_ForkAction")]
        public IForkAction ForkAction_ForkedBehaivour
        {
            get
            {
                return this._forkAction_ForkedBehaivour;
            }
            set
            {
                if ((this._forkAction_ForkedBehaivour != value))
                {
                    IForkAction old = this._forkAction_ForkedBehaivour;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnForkAction_ForkedBehaivourChanging(e);
                    this.OnPropertyChanging("ForkAction_ForkedBehaivour", e, _forkAction_ForkedBehaivourReference);
                    this._forkAction_ForkedBehaivour = value;
                    this.Parent = value;
                    if ((old != null))
                    {
                        old.AsynchronousForkedBehaviours_ForkAction.Remove(this);
                        old.Deleted -= this.OnResetForkAction_ForkedBehaivour;
                    }
                    if ((value != null))
                    {
                        if ((value.AsynchronousForkedBehaviours_ForkAction.Contains(this) != true))
                        {
                            value.AsynchronousForkedBehaviours_ForkAction.Add(this);
                        }
                        value.Deleted += this.OnResetForkAction_ForkedBehaivour;
                    }
                    this.OnForkAction_ForkedBehaivourChanged(e);
                    this.OnPropertyChanged("ForkAction_ForkedBehaivour", e, _forkAction_ForkedBehaivourReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ForkedBehaviourReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/ForkedBehaviour")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the SynchronisationPoint_ForkedBehaviour property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> SynchronisationPoint_ForkedBehaviourChanging;
        
        /// <summary>
        /// Gets fired when the SynchronisationPoint_ForkedBehaviour property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> SynchronisationPoint_ForkedBehaviourChanged;
        
        /// <summary>
        /// Gets fired before the ForkAction_ForkedBehaivour property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ForkAction_ForkedBehaivourChanging;
        
        /// <summary>
        /// Gets fired when the ForkAction_ForkedBehaivour property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ForkAction_ForkedBehaivourChanged;
        
        private static ITypedElement RetrieveSynchronisationPoint_ForkedBehaviourReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Seff.ForkedBehaviour.ClassInstance)).Resolve("synchronisationPoint_ForkedBehaviour")));
        }
        
        /// <summary>
        /// Raises the SynchronisationPoint_ForkedBehaviourChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSynchronisationPoint_ForkedBehaviourChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.SynchronisationPoint_ForkedBehaviourChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SynchronisationPoint_ForkedBehaviourChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSynchronisationPoint_ForkedBehaviourChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.SynchronisationPoint_ForkedBehaviourChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the SynchronisationPoint_ForkedBehaviour property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetSynchronisationPoint_ForkedBehaviour(object sender, global::System.EventArgs eventArgs)
        {
            this.SynchronisationPoint_ForkedBehaviour = null;
        }
        
        private static ITypedElement RetrieveForkAction_ForkedBehaivourReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Seff.ForkedBehaviour.ClassInstance)).Resolve("forkAction_ForkedBehaivour")));
        }
        
        /// <summary>
        /// Raises the ForkAction_ForkedBehaivourChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnForkAction_ForkedBehaivourChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ForkAction_ForkedBehaivourChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ForkAction_ForkedBehaivourChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnForkAction_ForkedBehaivourChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ForkAction_ForkedBehaivourChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ForkAction_ForkedBehaivour property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetForkAction_ForkedBehaivour(object sender, global::System.EventArgs eventArgs)
        {
            this.ForkAction_ForkedBehaivour = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "SYNCHRONISATIONPOINT_FORKEDBEHAVIOUR"))
            {
                this.SynchronisationPoint_ForkedBehaviour = ((ISynchronisationPoint)(value));
                return;
            }
            if ((feature == "FORKACTION_FORKEDBEHAIVOUR"))
            {
                this.ForkAction_ForkedBehaivour = ((IForkAction)(value));
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
            if ((attribute == "SynchronisationPoint_ForkedBehaviour"))
            {
                return new SynchronisationPoint_ForkedBehaviourProxy(this);
            }
            if ((attribute == "ForkAction_ForkedBehaivour"))
            {
                return new ForkAction_ForkedBehaivourProxy(this);
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
            if ((reference == "SynchronisationPoint_ForkedBehaviour"))
            {
                return new SynchronisationPoint_ForkedBehaviourProxy(this);
            }
            if ((reference == "ForkAction_ForkedBehaivour"))
            {
                return new ForkAction_ForkedBehaivourProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/ForkedBehaviour")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ForkedBehaviour class
        /// </summary>
        public class ForkedBehaviourReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ForkedBehaviour _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ForkedBehaviourReferencedElementsCollection(ForkedBehaviour parent)
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
                    if ((this._parent.SynchronisationPoint_ForkedBehaviour != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ForkAction_ForkedBehaivour != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.SynchronisationPoint_ForkedBehaviourChanged += this.PropagateValueChanges;
                this._parent.ForkAction_ForkedBehaivourChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.SynchronisationPoint_ForkedBehaviourChanged -= this.PropagateValueChanges;
                this._parent.ForkAction_ForkedBehaivourChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.SynchronisationPoint_ForkedBehaviour == null))
                {
                    ISynchronisationPoint synchronisationPoint_ForkedBehaviourCasted = item.As<ISynchronisationPoint>();
                    if ((synchronisationPoint_ForkedBehaviourCasted != null))
                    {
                        this._parent.SynchronisationPoint_ForkedBehaviour = synchronisationPoint_ForkedBehaviourCasted;
                        return;
                    }
                }
                if ((this._parent.ForkAction_ForkedBehaivour == null))
                {
                    IForkAction forkAction_ForkedBehaivourCasted = item.As<IForkAction>();
                    if ((forkAction_ForkedBehaivourCasted != null))
                    {
                        this._parent.ForkAction_ForkedBehaivour = forkAction_ForkedBehaivourCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.SynchronisationPoint_ForkedBehaviour = null;
                this._parent.ForkAction_ForkedBehaivour = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.SynchronisationPoint_ForkedBehaviour))
                {
                    return true;
                }
                if ((item == this._parent.ForkAction_ForkedBehaivour))
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
                if ((this._parent.SynchronisationPoint_ForkedBehaviour != null))
                {
                    array[arrayIndex] = this._parent.SynchronisationPoint_ForkedBehaviour;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ForkAction_ForkedBehaivour != null))
                {
                    array[arrayIndex] = this._parent.ForkAction_ForkedBehaivour;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.SynchronisationPoint_ForkedBehaviour == item))
                {
                    this._parent.SynchronisationPoint_ForkedBehaviour = null;
                    return true;
                }
                if ((this._parent.ForkAction_ForkedBehaivour == item))
                {
                    this._parent.ForkAction_ForkedBehaivour = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.SynchronisationPoint_ForkedBehaviour).Concat(this._parent.ForkAction_ForkedBehaivour).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the synchronisationPoint_ForkedBehaviour property
        /// </summary>
        private sealed class SynchronisationPoint_ForkedBehaviourProxy : ModelPropertyChange<IForkedBehaviour, ISynchronisationPoint>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SynchronisationPoint_ForkedBehaviourProxy(IForkedBehaviour modelElement) : 
                    base(modelElement, "synchronisationPoint_ForkedBehaviour")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISynchronisationPoint Value
            {
                get
                {
                    return this.ModelElement.SynchronisationPoint_ForkedBehaviour;
                }
                set
                {
                    this.ModelElement.SynchronisationPoint_ForkedBehaviour = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the forkAction_ForkedBehaivour property
        /// </summary>
        private sealed class ForkAction_ForkedBehaivourProxy : ModelPropertyChange<IForkedBehaviour, IForkAction>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ForkAction_ForkedBehaivourProxy(IForkedBehaviour modelElement) : 
                    base(modelElement, "forkAction_ForkedBehaivour")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IForkAction Value
            {
                get
                {
                    return this.ModelElement.ForkAction_ForkedBehaivour;
                }
                set
                {
                    this.ModelElement.ForkAction_ForkedBehaivour = value;
                }
            }
        }
    }
}

