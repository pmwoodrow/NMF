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
    /// The public interface for OperationCall
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(OperationCall))]
    [XmlDefaultImplementationTypeAttribute(typeof(OperationCall))]
    public interface IOperationCall : NMF.Models.IModelElement, IModelChange
    {
        
        /// <summary>
        /// The operation property
        /// </summary>
        [XmlElementNameAttribute("operation")]
        [XmlAttributeAttribute(true)]
        IOperation Operation
        {
            get;
            set;
        }
        
        /// <summary>
        /// The targetElement property
        /// </summary>
        [XmlElementNameAttribute("targetElement")]
        [XmlAttributeAttribute(true)]
        NMF.Models.IModelElement TargetElement
        {
            get;
            set;
        }
        
        /// <summary>
        /// The arguments property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("arguments")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        IListExpression<IOperationArgument> Arguments
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Operation property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OperationChanging;
        
        /// <summary>
        /// Gets fired when the Operation property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OperationChanged;
        
        /// <summary>
        /// Gets fired before the TargetElement property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TargetElementChanging;
        
        /// <summary>
        /// Gets fired when the TargetElement property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TargetElementChanged;
    }
}
