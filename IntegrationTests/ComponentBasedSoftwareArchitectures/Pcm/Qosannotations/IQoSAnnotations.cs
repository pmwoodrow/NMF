//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Parameter;
using NMFExamples.Pcm.Repository;
using NMFExamples.Pcm.System;
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

namespace NMFExamples.Pcm.Qosannotations
{
    
    
    /// <summary>
    /// The public interface for QoSAnnotations
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(QoSAnnotations))]
    [XmlDefaultImplementationTypeAttribute(typeof(QoSAnnotations))]
    public interface IQoSAnnotations : IModelElement, IEntity
    {
        
        /// <summary>
        /// The specifiedOutputParameterAbstractions_QoSAnnotations property
        /// </summary>
        IListExpression<ISpecifiedOutputParameterAbstraction> SpecifiedOutputParameterAbstractions_QoSAnnotations
        {
            get;
        }
        
        /// <summary>
        /// The system_QoSAnnotations property
        /// </summary>
        ISystem0 System_QoSAnnotations
        {
            get;
            set;
        }
        
        /// <summary>
        /// The specifiedQoSAnnotations_QoSAnnotations property
        /// </summary>
        IListExpression<ISpecifiedQoSAnnotation> SpecifiedQoSAnnotations_QoSAnnotations
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the System_QoSAnnotations property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> System_QoSAnnotationsChanging;
        
        /// <summary>
        /// Gets fired when the System_QoSAnnotations property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> System_QoSAnnotationsChanged;
    }
}

