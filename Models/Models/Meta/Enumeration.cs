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
    /// The default implementation of the Enumeration class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/nmeta/")]
    [XmlNamespacePrefixAttribute("nmeta")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/nmeta/#//Enumeration")]
    [DebuggerDisplayAttribute("Enumeration {Name}")]
    public partial class Enumeration : Type, IEnumeration, NMF.Models.IModelElement
    {
        
        /// <summary>
        /// The backing field for the IsFlagged property
        /// </summary>
        private bool _isFlagged;
        
        private static Lazy<ITypedElement> _isFlaggedAttribute = new Lazy<ITypedElement>(RetrieveIsFlaggedAttribute);
        
        private static Lazy<ITypedElement> _literalsReference = new Lazy<ITypedElement>(RetrieveLiteralsReference);
        
        /// <summary>
        /// The backing field for the Literals property
        /// </summary>
        private EnumerationLiteralsCollection _literals;
        
        private static IClass _classInstance;
        
        public Enumeration()
        {
            this._literals = new EnumerationLiteralsCollection(this);
            this._literals.CollectionChanging += this.LiteralsCollectionChanging;
            this._literals.CollectionChanged += this.LiteralsCollectionChanged;
        }
        
        /// <summary>
        /// The IsFlagged property
        /// </summary>
        [CategoryAttribute("Enumeration")]
        [XmlAttributeAttribute(true)]
        public bool IsFlagged
        {
            get
            {
                return this._isFlagged;
            }
            set
            {
                if ((this._isFlagged != value))
                {
                    bool old = this._isFlagged;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIsFlaggedChanging(e);
                    this.OnPropertyChanging("IsFlagged", e, _isFlaggedAttribute);
                    this._isFlagged = value;
                    this.OnIsFlaggedChanged(e);
                    this.OnPropertyChanged("IsFlagged", e, _isFlaggedAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Literals property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [BrowsableAttribute(false)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("Enumeration")]
        [ConstantAttribute()]
        public ICollectionExpression<ILiteral> Literals
        {
            get
            {
                return this._literals;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new EnumerationChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new EnumerationReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//Enumeration")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the IsFlagged property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IsFlaggedChanging;
        
        /// <summary>
        /// Gets fired when the IsFlagged property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IsFlaggedChanged;
        
        private static ITypedElement RetrieveIsFlaggedAttribute()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(Enumeration.ClassInstance)).Resolve("IsFlagged")));
        }
        
        /// <summary>
        /// Raises the IsFlaggedChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIsFlaggedChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IsFlaggedChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IsFlaggedChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIsFlaggedChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IsFlaggedChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveLiteralsReference()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(Enumeration.ClassInstance)).Resolve("Literals")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Literals property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LiteralsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Literals", e, _literalsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Literals property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LiteralsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Literals", e, _literalsReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "ISFLAGGED"))
            {
                return this.IsFlagged;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "LITERALS"))
            {
                return this._literals;
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
            if ((feature == "ISFLAGGED"))
            {
                this.IsFlagged = ((bool)(value));
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
            if ((attribute == "ISFLAGGED"))
            {
                return Observable.Box(new IsFlaggedProxy(this));
            }
            return base.GetExpressionForAttribute(attribute);
        }

        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected internal override string GetCompositionName(object container)
        {
            if ((container == this._literals))
            {
                return "Literals";
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//Enumeration")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Enumeration class
        /// </summary>
        public class EnumerationChildrenCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private Enumeration _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EnumerationChildrenCollection(Enumeration parent)
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
                    count = (count + this._parent.Literals.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Literals.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Literals.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                ILiteral literalsCasted = item.As<ILiteral>();
                if ((literalsCasted != null))
                {
                    this._parent.Literals.Add(literalsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Literals.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if (this._parent.Literals.Contains(item))
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
                IEnumerator<NMF.Models.IModelElement> literalsEnumerator = this._parent.Literals.GetEnumerator();
                try
                {
                    for (
                    ; literalsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = literalsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    literalsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(NMF.Models.IModelElement item)
            {
                ILiteral literalItem = item.As<ILiteral>();
                if (((literalItem != null) 
                            && this._parent.Literals.Remove(literalItem)))
                {
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
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.Literals).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Enumeration class
        /// </summary>
        public class EnumerationReferencedElementsCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private Enumeration _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EnumerationReferencedElementsCollection(Enumeration parent)
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
                    count = (count + this._parent.Literals.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Literals.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Literals.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                ILiteral literalsCasted = item.As<ILiteral>();
                if ((literalsCasted != null))
                {
                    this._parent.Literals.Add(literalsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Literals.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if (this._parent.Literals.Contains(item))
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
                IEnumerator<NMF.Models.IModelElement> literalsEnumerator = this._parent.Literals.GetEnumerator();
                try
                {
                    for (
                    ; literalsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = literalsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    literalsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(NMF.Models.IModelElement item)
            {
                ILiteral literalItem = item.As<ILiteral>();
                if (((literalItem != null) 
                            && this._parent.Literals.Remove(literalItem)))
                {
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
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.Literals).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the IsFlagged property
        /// </summary>
        private sealed class IsFlaggedProxy : ModelPropertyChange<IEnumeration, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IsFlaggedProxy(IEnumeration modelElement) : 
                    base(modelElement, "IsFlagged")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.IsFlagged;
                }
                set
                {
                    this.ModelElement.IsFlagged = value;
                }
            }
        }
    }
}

