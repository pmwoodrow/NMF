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
using global::System.Collections;
using global::System.Collections.Generic;
using global::System.Collections.ObjectModel;
using global::System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMFExamples.Units
{
    
    
    /// <summary>
    /// The default implementation of the UnitRepository class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/Units/1.0")]
    [XmlNamespacePrefixAttribute("units")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/Units/1.0#//UnitRepository")]
    public partial class UnitRepository : ModelElement, IUnitRepository, IModelElement
    {
        
        private static Lazy<ITypedElement> _unitsReference = new Lazy<ITypedElement>(RetrieveUnitsReference);
        
        /// <summary>
        /// The backing field for the Units property
        /// </summary>
        private ObservableCompositionList<IBaseUnit> _units;
        
        private static IClass _classInstance;
        
        public UnitRepository()
        {
            this._units = new ObservableCompositionList<IBaseUnit>(this);
            this._units.CollectionChanging += this.UnitsCollectionChanging;
            this._units.CollectionChanged += this.UnitsCollectionChanged;
        }
        
        /// <summary>
        /// The units property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("units")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public ICollectionExpression<IBaseUnit> Units
        {
            get
            {
                return this._units;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new UnitRepositoryChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new UnitRepositoryReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/Units/1.0#//UnitRepository")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveUnitsReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Units.UnitRepository.ClassInstance)).Resolve("units")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Units property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void UnitsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Units", e, _unitsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Units property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void UnitsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Units", e, _unitsReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override global::System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "UNITS"))
            {
                return this._units;
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
            if ((container == this._units))
            {
                return "units";
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/Units/1.0#//UnitRepository")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the UnitRepository class
        /// </summary>
        public class UnitRepositoryChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private UnitRepository _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public UnitRepositoryChildrenCollection(UnitRepository parent)
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
                    count = (count + this._parent.Units.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Units.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Units.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IBaseUnit unitsCasted = item.As<IBaseUnit>();
                if ((unitsCasted != null))
                {
                    this._parent.Units.Add(unitsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Units.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Units.Contains(item))
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
                IEnumerator<IModelElement> unitsEnumerator = this._parent.Units.GetEnumerator();
                try
                {
                    for (
                    ; unitsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = unitsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    unitsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IBaseUnit baseUnitItem = item.As<IBaseUnit>();
                if (((baseUnitItem != null) 
                            && this._parent.Units.Remove(baseUnitItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Units).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the UnitRepository class
        /// </summary>
        public class UnitRepositoryReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private UnitRepository _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public UnitRepositoryReferencedElementsCollection(UnitRepository parent)
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
                    count = (count + this._parent.Units.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Units.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Units.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IBaseUnit unitsCasted = item.As<IBaseUnit>();
                if ((unitsCasted != null))
                {
                    this._parent.Units.Add(unitsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Units.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Units.Contains(item))
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
                IEnumerator<IModelElement> unitsEnumerator = this._parent.Units.GetEnumerator();
                try
                {
                    for (
                    ; unitsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = unitsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    unitsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IBaseUnit baseUnitItem = item.As<IBaseUnit>();
                if (((baseUnitItem != null) 
                            && this._parent.Units.Remove(baseUnitItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Units).GetEnumerator();
            }
        }
    }
}

