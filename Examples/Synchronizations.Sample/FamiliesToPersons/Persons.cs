//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NMF.Synchronizations.Example.Persons
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
    /// The default implementation of the Person class
    /// </summary>
    [XmlNamespaceAttribute("http://www.eclipse.org/atl/atlTransformations/Persons")]
    [XmlNamespacePrefixAttribute("Persons")]
    [ModelRepresentationClassAttribute("http://www.eclipse.org/atl/atlTransformations/Persons#//Person/")]
    public abstract class Person : ModelElement, IPerson, IModelElement
    {
        
        /// <summary>
        /// The backing field for the FullName property
        /// </summary>
        private string _fullName;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The fullName property
        /// </summary>
        [XmlElementNameAttribute("fullName")]
        [XmlAttributeAttribute(true)]
        public virtual string FullName
        {
            get
            {
                return this._fullName;
            }
            set
            {
                if ((this._fullName != value))
                {
                    string old = this._fullName;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnFullNameChanging(e);
                    this.OnPropertyChanging("FullName", e);
                    this._fullName = value;
                    this.OnFullNameChanged(e);
                    this.OnPropertyChanged("FullName", e);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/atl/atlTransformations/Persons#//Person/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the FullName property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FullNameChanging;
        
        /// <summary>
        /// Gets fired when the FullName property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FullNameChanged;
        
        /// <summary>
        /// Raises the FullNameChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFullNameChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FullNameChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the FullNameChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFullNameChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FullNameChanged;
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
            if ((attribute == "FULLNAME"))
            {
                return this.FullName;
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
            if ((feature == "FULLNAME"))
            {
                this.FullName = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/atl/atlTransformations/Persons#//Person/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the fullName property
        /// </summary>
        private sealed class FullNameProxy : ModelPropertyChange<IPerson, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public FullNameProxy(IPerson modelElement) : 
                    base(modelElement, "fullName")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.FullName;
                }
                set
                {
                    this.ModelElement.FullName = value;
                }
            }
        }
    }
    
    /// <summary>
    /// The default implementation of the Male class
    /// </summary>
    [XmlNamespaceAttribute("http://www.eclipse.org/atl/atlTransformations/Persons")]
    [XmlNamespacePrefixAttribute("Persons")]
    [ModelRepresentationClassAttribute("http://www.eclipse.org/atl/atlTransformations/Persons#//Male/")]
    public class Male : Person, IMale, IModelElement
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/atl/atlTransformations/Persons#//Male/")));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/atl/atlTransformations/Persons#//Male/")));
            }
            return _classInstance;
        }
    }
    
    /// <summary>
    /// The default implementation of the Female class
    /// </summary>
    [XmlNamespaceAttribute("http://www.eclipse.org/atl/atlTransformations/Persons")]
    [XmlNamespacePrefixAttribute("Persons")]
    [ModelRepresentationClassAttribute("http://www.eclipse.org/atl/atlTransformations/Persons#//Female/")]
    public class Female : Person, IFemale, IModelElement
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/atl/atlTransformations/Persons#//Female/")));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/atl/atlTransformations/Persons#//Female/")));
            }
            return _classInstance;
        }
    }
    
    /// <summary>
    /// The public interface for Female
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Female))]
    [XmlDefaultImplementationTypeAttribute(typeof(Female))]
    [ModelRepresentationClassAttribute("http://www.eclipse.org/atl/atlTransformations/Persons#//Female/")]
    public interface IFemale : IModelElement, IPerson
    {
    }
    
    /// <summary>
    /// The public interface for Male
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Male))]
    [XmlDefaultImplementationTypeAttribute(typeof(Male))]
    [ModelRepresentationClassAttribute("http://www.eclipse.org/atl/atlTransformations/Persons#//Male/")]
    public interface IMale : IModelElement, IPerson
    {
    }
    
    /// <summary>
    /// The public interface for Person
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Person))]
    [XmlDefaultImplementationTypeAttribute(typeof(Person))]
    [ModelRepresentationClassAttribute("http://www.eclipse.org/atl/atlTransformations/Persons#//Person/")]
    public interface IPerson : IModelElement
    {
        
        /// <summary>
        /// The fullName property
        /// </summary>
        string FullName
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the FullName property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FullNameChanging;
        
        /// <summary>
        /// Gets fired when the FullName property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FullNameChanged;
    }
}
