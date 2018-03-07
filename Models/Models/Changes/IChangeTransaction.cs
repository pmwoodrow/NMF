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

namespace NMF.Models.Changes
{
    
    
    /// <summary>
    /// The public interface for ChangeTransaction
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ChangeTransaction))]
    [XmlDefaultImplementationTypeAttribute(typeof(ChangeTransaction))]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/changes#//ChangeTransaction")]
    public interface IChangeTransaction : NMF.Models.IModelElement, IModelChange
    {
        
        /// <summary>
        /// The sourceChange property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("sourceChange")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        IModelChange SourceChange
        {
            get;
            set;
        }
        
        /// <summary>
        /// The nestedChanges property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("nestedChanges")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        IOrderedSetExpression<IModelChange> NestedChanges
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the SourceChange property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SourceChangeChanging;
        
        /// <summary>
        /// Gets fired when the SourceChange property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SourceChangeChanged;
    }
}

