//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\ParameterService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\ParameterService\generated-output -n ParameterService
namespace ParameterService
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    
    
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1182.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("PmtAppMethod", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("PmtAppMethod", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class PmtAppMethod
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CreateAddlPrincipalComment", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool CreateAddlPrincipalCommentValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CreateAddlPrincipalComment property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CreateAddlPrincipalCommentValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CreateAddlPrincipalComment
        {
            get
            {
                if (this.CreateAddlPrincipalCommentValueSpecified)
                {
                    return this.CreateAddlPrincipalCommentValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CreateAddlPrincipalCommentValue = value.GetValueOrDefault();
                this.CreateAddlPrincipalCommentValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<PmtAppMethodCurrentExcessOrder> _currentExcessOrder;
        
        [XmlElementAttribute("CurrentExcessOrder", Order=1, Form=XmlSchemaForm.Unqualified)]
        public Collection<PmtAppMethodCurrentExcessOrder> CurrentExcessOrder
        {
            get
            {
                return _currentExcessOrder;
            }
            set
            {
                _currentExcessOrder = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CurrentExcessOrder collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CurrentExcessOrderSpecified
        {
            get
            {
                return ((this.CurrentExcessOrder != null) 
                            && (this.CurrentExcessOrder.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="PmtAppMethod" /> class.</para>
        /// </summary>
        public PmtAppMethod()
        {
            this._currentExcessOrder = new Collection<PmtAppMethodCurrentExcessOrder>();
            this._dqExcessOrder = new Collection<PmtAppMethodDqExcessOrder>();
            this._gracePmtExcessOrder = new Collection<PmtAppMethodGracePmtExcessOrder>();
            this._paymentOrder = new Collection<PmtAppMethodPaymentOrder>();
            this._prepaidExcessOrder = new Collection<PmtAppMethodPrepaidExcessOrder>();
            this._any = new Collection<XmlElement>();
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("DefinedCode", Order=2, Form=XmlSchemaForm.Unqualified)]
        public short DefinedCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DefinedCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DefinedCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> DefinedCode
        {
            get
            {
                if (this.DefinedCodeValueSpecified)
                {
                    return this.DefinedCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DefinedCodeValue = value.GetValueOrDefault();
                this.DefinedCodeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Description", Order=3, Form=XmlSchemaForm.Unqualified)]
        public string Description { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<PmtAppMethodDqExcessOrder> _dqExcessOrder;
        
        [XmlElementAttribute("DqExcessOrder", Order=4, Form=XmlSchemaForm.Unqualified)]
        public Collection<PmtAppMethodDqExcessOrder> DqExcessOrder
        {
            get
            {
                return _dqExcessOrder;
            }
            set
            {
                _dqExcessOrder = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DqExcessOrder collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DqExcessOrderSpecified
        {
            get
            {
                return ((this.DqExcessOrder != null) 
                            && (this.DqExcessOrder.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<PmtAppMethodGracePmtExcessOrder> _gracePmtExcessOrder;
        
        [XmlElementAttribute("GracePmtExcessOrder", Order=5, Form=XmlSchemaForm.Unqualified)]
        public Collection<PmtAppMethodGracePmtExcessOrder> GracePmtExcessOrder
        {
            get
            {
                return _gracePmtExcessOrder;
            }
            set
            {
                _gracePmtExcessOrder = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the GracePmtExcessOrder collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool GracePmtExcessOrderSpecified
        {
            get
            {
                return ((this.GracePmtExcessOrder != null) 
                            && (this.GracePmtExcessOrder.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IncludeEscrowUnpdinPmtDue", Order=6, Form=XmlSchemaForm.Unqualified)]
        public bool IncludeEscrowUnpdinPmtDueValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IncludeEscrowUnpdinPmtDue property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IncludeEscrowUnpdinPmtDueValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IncludeEscrowUnpdinPmtDue
        {
            get
            {
                if (this.IncludeEscrowUnpdinPmtDueValueSpecified)
                {
                    return this.IncludeEscrowUnpdinPmtDueValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IncludeEscrowUnpdinPmtDueValue = value.GetValueOrDefault();
                this.IncludeEscrowUnpdinPmtDueValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<PmtAppMethodPaymentOrder> _paymentOrder;
        
        [XmlElementAttribute("PaymentOrder", Order=7, Form=XmlSchemaForm.Unqualified)]
        public Collection<PmtAppMethodPaymentOrder> PaymentOrder
        {
            get
            {
                return _paymentOrder;
            }
            set
            {
                _paymentOrder = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the PaymentOrder collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PaymentOrderSpecified
        {
            get
            {
                return ((this.PaymentOrder != null) 
                            && (this.PaymentOrder.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<PmtAppMethodPrepaidExcessOrder> _prepaidExcessOrder;
        
        [XmlElementAttribute("PrepaidExcessOrder", Order=8, Form=XmlSchemaForm.Unqualified)]
        public Collection<PmtAppMethodPrepaidExcessOrder> PrepaidExcessOrder
        {
            get
            {
                return _prepaidExcessOrder;
            }
            set
            {
                _prepaidExcessOrder = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the PrepaidExcessOrder collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PrepaidExcessOrderSpecified
        {
            get
            {
                return ((this.PrepaidExcessOrder != null) 
                            && (this.PrepaidExcessOrder.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ThresholdPaymentIndicator", Order=9, Form=XmlSchemaForm.Unqualified)]
        public short ThresholdPaymentIndicatorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ThresholdPaymentIndicator property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ThresholdPaymentIndicatorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> ThresholdPaymentIndicator
        {
            get
            {
                if (this.ThresholdPaymentIndicatorValueSpecified)
                {
                    return this.ThresholdPaymentIndicatorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ThresholdPaymentIndicatorValue = value.GetValueOrDefault();
                this.ThresholdPaymentIndicatorValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Type", Order=10, Form=XmlSchemaForm.Unqualified)]
        public short TypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Type property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> Type
        {
            get
            {
                if (this.TypeValueSpecified)
                {
                    return this.TypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TypeValue = value.GetValueOrDefault();
                this.TypeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=11, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=12)]
        public Collection<XmlElement> Any
        {
            get
            {
                return _any;
            }
            set
            {
                _any = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get
            {
                return ((this.Any != null) 
                            && (this.Any.Count != 0));
            }
        }
    }
}
