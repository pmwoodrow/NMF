//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PortV3Namespace.TypeB
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Linq;
    using NMF.Expressions;
    using NMF.Expressions.Linq;
    using NMF.Models;
    using NMF.Models.Collections;
    using NMF.Models.Expressions;
    using NMF.Collections.Generic;
    using NMF.Collections.ObjectModel;
    using NMF.Serialization;
    using NMF.Utilities;
    using NMF.Models.Meta;
    using NMF.Models.Repository;
    
    
    /// <summary>
    /// The default implementation of the BlockB class
    /// </summary>
    [XmlNamespaceAttribute("http://www.eclipse.org/atl/atlTransformations/TypeB")]
    [XmlNamespacePrefixAttribute("TypeB")]
    [ModelRepresentationClassAttribute("http://www.eclipse.org/atl/atlTransformations/TypeB#//BlockB/")]
    public class BlockB : ModelElement, IBlockB, IModelElement
    {
        
        /// <summary>
        /// The backing field for the InputPorts property
        /// </summary>
        private ObservableCompositionOrderedSet<IInPortB> _inputPorts;
        
        /// <summary>
        /// The backing field for the OutputPorts property
        /// </summary>
        private ObservableCompositionOrderedSet<IOutPortB> _outputPorts;
        
        private static IClass _classInstance;
        
        public BlockB()
        {
            this._inputPorts = new ObservableCompositionOrderedSet<IInPortB>(this);
            this._inputPorts.CollectionChanging += this.InputPortsCollectionChanging;
            this._inputPorts.CollectionChanged += this.InputPortsCollectionChanged;
            this._outputPorts = new ObservableCompositionOrderedSet<IOutPortB>(this);
            this._outputPorts.CollectionChanging += this.OutputPortsCollectionChanging;
            this._outputPorts.CollectionChanged += this.OutputPortsCollectionChanged;
        }
        
        /// <summary>
        /// The inputPorts property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("inputPorts")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IInPortB> InputPorts
        {
            get
            {
                return this._inputPorts;
            }
        }
        
        /// <summary>
        /// The outputPorts property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("outputPorts")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IOutPortB> OutputPorts
        {
            get
            {
                return this._outputPorts;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new BlockBChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new BlockBReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/atl/atlTransformations/TypeB#//BlockB/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the InputPorts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void InputPortsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("InputPorts", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the InputPorts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void InputPortsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("InputPorts", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the OutputPorts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OutputPortsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("OutputPorts", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the OutputPorts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OutputPortsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("OutputPorts", e);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int inputPortsIndex = ModelHelper.IndexOfReference(this.InputPorts, element);
            if ((inputPortsIndex != -1))
            {
                return ModelHelper.CreatePath("inputPorts", inputPortsIndex);
            }
            int outputPortsIndex = ModelHelper.IndexOfReference(this.OutputPorts, element);
            if ((outputPortsIndex != -1))
            {
                return ModelHelper.CreatePath("outputPorts", outputPortsIndex);
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
            if ((reference == "INPUTPORTS"))
            {
                if ((index < this.InputPorts.Count))
                {
                    return this.InputPorts[index];
                }
                else
                {
                    return null;
                }
            }
            if ((reference == "OUTPUTPORTS"))
            {
                if ((index < this.OutputPorts.Count))
                {
                    return this.OutputPorts[index];
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
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "INPUTPORTS"))
            {
                return this._inputPorts;
            }
            if ((feature == "OUTPUTPORTS"))
            {
                return this._outputPorts;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/atl/atlTransformations/TypeB#//BlockB/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the BlockB class
        /// </summary>
        public class BlockBChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private BlockB _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public BlockBChildrenCollection(BlockB parent)
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
                    count = (count + this._parent.InputPorts.Count);
                    count = (count + this._parent.OutputPorts.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.InputPorts.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.OutputPorts.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.InputPorts.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.OutputPorts.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IInPortB inputPortsCasted = item.As<IInPortB>();
                if ((inputPortsCasted != null))
                {
                    this._parent.InputPorts.Add(inputPortsCasted);
                }
                IOutPortB outputPortsCasted = item.As<IOutPortB>();
                if ((outputPortsCasted != null))
                {
                    this._parent.OutputPorts.Add(outputPortsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.InputPorts.Clear();
                this._parent.OutputPorts.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.InputPorts.Contains(item))
                {
                    return true;
                }
                if (this._parent.OutputPorts.Contains(item))
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
                IEnumerator<IModelElement> inputPortsEnumerator = this._parent.InputPorts.GetEnumerator();
                try
                {
                    for (
                    ; inputPortsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = inputPortsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    inputPortsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> outputPortsEnumerator = this._parent.OutputPorts.GetEnumerator();
                try
                {
                    for (
                    ; outputPortsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = outputPortsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    outputPortsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IInPortB inPortBItem = item.As<IInPortB>();
                if (((inPortBItem != null) 
                            && this._parent.InputPorts.Remove(inPortBItem)))
                {
                    return true;
                }
                IOutPortB outPortBItem = item.As<IOutPortB>();
                if (((outPortBItem != null) 
                            && this._parent.OutputPorts.Remove(outPortBItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.InputPorts).Concat(this._parent.OutputPorts).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the BlockB class
        /// </summary>
        public class BlockBReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private BlockB _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public BlockBReferencedElementsCollection(BlockB parent)
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
                    count = (count + this._parent.InputPorts.Count);
                    count = (count + this._parent.OutputPorts.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.InputPorts.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.OutputPorts.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.InputPorts.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.OutputPorts.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IInPortB inputPortsCasted = item.As<IInPortB>();
                if ((inputPortsCasted != null))
                {
                    this._parent.InputPorts.Add(inputPortsCasted);
                }
                IOutPortB outputPortsCasted = item.As<IOutPortB>();
                if ((outputPortsCasted != null))
                {
                    this._parent.OutputPorts.Add(outputPortsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.InputPorts.Clear();
                this._parent.OutputPorts.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.InputPorts.Contains(item))
                {
                    return true;
                }
                if (this._parent.OutputPorts.Contains(item))
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
                IEnumerator<IModelElement> inputPortsEnumerator = this._parent.InputPorts.GetEnumerator();
                try
                {
                    for (
                    ; inputPortsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = inputPortsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    inputPortsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> outputPortsEnumerator = this._parent.OutputPorts.GetEnumerator();
                try
                {
                    for (
                    ; outputPortsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = outputPortsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    outputPortsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IInPortB inPortBItem = item.As<IInPortB>();
                if (((inPortBItem != null) 
                            && this._parent.InputPorts.Remove(inPortBItem)))
                {
                    return true;
                }
                IOutPortB outPortBItem = item.As<IOutPortB>();
                if (((outPortBItem != null) 
                            && this._parent.OutputPorts.Remove(outPortBItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.InputPorts).Concat(this._parent.OutputPorts).GetEnumerator();
            }
        }
    }
    
    /// <summary>
    /// The default implementation of the PortB class
    /// </summary>
    [XmlIdentifierAttribute("name")]
    [XmlNamespaceAttribute("http://www.eclipse.org/atl/atlTransformations/TypeB")]
    [XmlNamespacePrefixAttribute("TypeB")]
    [ModelRepresentationClassAttribute("http://www.eclipse.org/atl/atlTransformations/TypeB#//PortB/")]
    [DebuggerDisplayAttribute("PortB {Name}")]
    public abstract class PortB : ModelElement, IPortB, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Name property
        /// </summary>
        private string _name;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The name property
        /// </summary>
        [XmlElementNameAttribute("name")]
        [IdAttribute()]
        [XmlAttributeAttribute(true)]
        public virtual string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    string old = this._name;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnNameChanging(e);
                    this.OnPropertyChanging("Name", e);
                    this._name = value;
                    this.OnNameChanged(e);
                    this.OnPropertyChanged("Name", e);
                }
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/atl/atlTransformations/TypeB#//PortB/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the current model element can be identified by an attribute value
        /// </summary>
        public override bool IsIdentified
        {
            get
            {
                return true;
            }
        }
        
        /// <summary>
        /// Gets fired before the Name property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NameChanging;
        
        /// <summary>
        /// Gets fired when the Name property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NameChanged;
        
        /// <summary>
        /// Raises the NameChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNameChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NameChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the NameChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNameChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NameChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "NAME"))
            {
                return this.Name;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "NAME"))
            {
                this.Name = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/atl/atlTransformations/TypeB#//PortB/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Gets the identifier string for this model element
        /// </summary>
        /// <returns>The identifier string</returns>
        public override string ToIdentifierString()
        {
            if ((this.Name == null))
            {
                return null;
            }
            return this.Name.ToString();
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the name property
        /// </summary>
        private sealed class NameProxy : ModelPropertyChange<IPortB, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public NameProxy(IPortB modelElement) : 
                    base(modelElement, "Name")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Name;
                }
                set
                {
                    this.ModelElement.Name = value;
                }
            }
        }
    }
    
    /// <summary>
    /// The default implementation of the InPortB class
    /// </summary>
    [XmlNamespaceAttribute("http://www.eclipse.org/atl/atlTransformations/TypeB")]
    [XmlNamespacePrefixAttribute("TypeB")]
    [ModelRepresentationClassAttribute("http://www.eclipse.org/atl/atlTransformations/TypeB#//InPortB/")]
    [DebuggerDisplayAttribute("InPortB {Name}")]
    public class InPortB : PortB, IInPortB, IModelElement
    {
        
        private static IClass _classInstance;
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/atl/atlTransformations/TypeB#//InPortB/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/atl/atlTransformations/TypeB#//InPortB/")));
            }
            return _classInstance;
        }
    }
    
    /// <summary>
    /// The default implementation of the OutPortB class
    /// </summary>
    [XmlNamespaceAttribute("http://www.eclipse.org/atl/atlTransformations/TypeB")]
    [XmlNamespacePrefixAttribute("TypeB")]
    [ModelRepresentationClassAttribute("http://www.eclipse.org/atl/atlTransformations/TypeB#//OutPortB/")]
    [DebuggerDisplayAttribute("OutPortB {Name}")]
    public class OutPortB : PortB, IOutPortB, IModelElement
    {
        
        private static IClass _classInstance;
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/atl/atlTransformations/TypeB#//OutPortB/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/atl/atlTransformations/TypeB#//OutPortB/")));
            }
            return _classInstance;
        }
    }
    
    /// <summary>
    /// The public interface for OutPortB
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(OutPortB))]
    [XmlDefaultImplementationTypeAttribute(typeof(OutPortB))]
    public interface IOutPortB : IModelElement, IPortB
    {
    }
    
    /// <summary>
    /// The public interface for InPortB
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(InPortB))]
    [XmlDefaultImplementationTypeAttribute(typeof(InPortB))]
    public interface IInPortB : IModelElement, IPortB
    {
    }
    
    /// <summary>
    /// The public interface for PortB
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(PortB))]
    [XmlDefaultImplementationTypeAttribute(typeof(PortB))]
    public interface IPortB : IModelElement
    {
        
        /// <summary>
        /// The name property
        /// </summary>
        string Name
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Name property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NameChanging;
        
        /// <summary>
        /// Gets fired when the Name property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NameChanged;
    }
    
    /// <summary>
    /// The public interface for BlockB
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(BlockB))]
    [XmlDefaultImplementationTypeAttribute(typeof(BlockB))]
    public interface IBlockB : IModelElement
    {
        
        /// <summary>
        /// The inputPorts property
        /// </summary>
        IOrderedSetExpression<IInPortB> InputPorts
        {
            get;
        }
        
        /// <summary>
        /// The outputPorts property
        /// </summary>
        IOrderedSetExpression<IOutPortB> OutputPorts
        {
            get;
        }
    }
}
