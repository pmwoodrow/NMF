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
    /// The public interface for Event
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Event))]
    [XmlDefaultImplementationTypeAttribute(typeof(Event))]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/nmeta/#//Event")]
    public interface IEvent : NMF.Models.IModelElement, IMetaElement
    {
        
        /// <summary>
        /// The Type property
        /// </summary>
        [CategoryAttribute("Event")]
        [XmlAttributeAttribute(true)]
        IDataType Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DeclaringType property
        /// </summary>
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Events")]
        IReferenceType DeclaringType
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Type property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanging;
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanged;
        
        /// <summary>
        /// Gets fired before the DeclaringType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DeclaringTypeChanging;
        
        /// <summary>
        /// Gets fired when the DeclaringType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DeclaringTypeChanged;
    }
}

