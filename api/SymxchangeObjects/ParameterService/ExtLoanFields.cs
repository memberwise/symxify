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
    [XmlTypeAttribute("ExtLoanFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("ExtLoanFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class ExtLoanFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AccountMask", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool AccountMaskValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AccountMask property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AccountMaskValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> AccountMask
        {
            get
            {
                if (this.AccountMaskValueSpecified)
                {
                    return this.AccountMaskValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AccountMaskValue = value.GetValueOrDefault();
                this.AccountMaskValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ActivityDateUpdate", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool ActivityDateUpdateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ActivityDateUpdate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ActivityDateUpdateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ActivityDateUpdate
        {
            get
            {
                if (this.ActivityDateUpdateValueSpecified)
                {
                    return this.ActivityDateUpdateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ActivityDateUpdateValue = value.GetValueOrDefault();
                this.ActivityDateUpdateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AdvanceTransactionGlCode", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool AdvanceTransactionGlCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AdvanceTransactionGlCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AdvanceTransactionGlCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> AdvanceTransactionGlCode
        {
            get
            {
                if (this.AdvanceTransactionGlCodeValueSpecified)
                {
                    return this.AdvanceTransactionGlCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AdvanceTransactionGlCodeValue = value.GetValueOrDefault();
                this.AdvanceTransactionGlCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AllowAdvances", Order=3, Form=XmlSchemaForm.Unqualified)]
        public bool AllowAdvancesValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AllowAdvances property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AllowAdvancesValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> AllowAdvances
        {
            get
            {
                if (this.AllowAdvancesValueSpecified)
                {
                    return this.AllowAdvancesValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AllowAdvancesValue = value.GetValueOrDefault();
                this.AllowAdvancesValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AllowFreezeUnfreezeofCard", Order=4, Form=XmlSchemaForm.Unqualified)]
        public bool AllowFreezeUnfreezeofCardValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AllowFreezeUnfreezeofCard property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AllowFreezeUnfreezeofCardValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> AllowFreezeUnfreezeofCard
        {
            get
            {
                if (this.AllowFreezeUnfreezeofCardValueSpecified)
                {
                    return this.AllowFreezeUnfreezeofCardValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AllowFreezeUnfreezeofCardValue = value.GetValueOrDefault();
                this.AllowFreezeUnfreezeofCardValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AllowPartialPayments", Order=5, Form=XmlSchemaForm.Unqualified)]
        public bool AllowPartialPaymentsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AllowPartialPayments property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AllowPartialPaymentsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> AllowPartialPayments
        {
            get
            {
                if (this.AllowPartialPaymentsValueSpecified)
                {
                    return this.AllowPartialPaymentsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AllowPartialPaymentsValue = value.GetValueOrDefault();
                this.AllowPartialPaymentsValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ExternalDataSourceName", Order=6, Form=XmlSchemaForm.Unqualified)]
        public bool ExternalDataSourceNameValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ExternalDataSourceName property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ExternalDataSourceNameValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ExternalDataSourceName
        {
            get
            {
                if (this.ExternalDataSourceNameValueSpecified)
                {
                    return this.ExternalDataSourceNameValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ExternalDataSourceNameValue = value.GetValueOrDefault();
                this.ExternalDataSourceNameValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ExternalLoanTrackingType", Order=7, Form=XmlSchemaForm.Unqualified)]
        public bool ExternalLoanTrackingTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ExternalLoanTrackingType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ExternalLoanTrackingTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ExternalLoanTrackingType
        {
            get
            {
                if (this.ExternalLoanTrackingTypeValueSpecified)
                {
                    return this.ExternalLoanTrackingTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ExternalLoanTrackingTypeValue = value.GetValueOrDefault();
                this.ExternalLoanTrackingTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NearRealTimeRecordUpdate", Order=8, Form=XmlSchemaForm.Unqualified)]
        public bool NearRealTimeRecordUpdateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NearRealTimeRecordUpdate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NearRealTimeRecordUpdateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> NearRealTimeRecordUpdate
        {
            get
            {
                if (this.NearRealTimeRecordUpdateValueSpecified)
                {
                    return this.NearRealTimeRecordUpdateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NearRealTimeRecordUpdateValue = value.GetValueOrDefault();
                this.NearRealTimeRecordUpdateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("OnlineDbPassword", Order=9, Form=XmlSchemaForm.Unqualified)]
        public bool OnlineDbPasswordValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OnlineDbPassword property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OnlineDbPasswordValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> OnlineDbPassword
        {
            get
            {
                if (this.OnlineDbPasswordValueSpecified)
                {
                    return this.OnlineDbPasswordValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnlineDbPasswordValue = value.GetValueOrDefault();
                this.OnlineDbPasswordValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("OnlineDbUserId", Order=10, Form=XmlSchemaForm.Unqualified)]
        public bool OnlineDbUserIdValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OnlineDbUserId property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OnlineDbUserIdValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> OnlineDbUserId
        {
            get
            {
                if (this.OnlineDbUserIdValueSpecified)
                {
                    return this.OnlineDbUserIdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnlineDbUserIdValue = value.GetValueOrDefault();
                this.OnlineDbUserIdValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("OnlineGlobalAppPasswd", Order=11, Form=XmlSchemaForm.Unqualified)]
        public bool OnlineGlobalAppPasswdValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OnlineGlobalAppPasswd property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OnlineGlobalAppPasswdValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> OnlineGlobalAppPasswd
        {
            get
            {
                if (this.OnlineGlobalAppPasswdValueSpecified)
                {
                    return this.OnlineGlobalAppPasswdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnlineGlobalAppPasswdValue = value.GetValueOrDefault();
                this.OnlineGlobalAppPasswdValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("OnlineGlobalAppUserId", Order=12, Form=XmlSchemaForm.Unqualified)]
        public bool OnlineGlobalAppUserIdValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OnlineGlobalAppUserId property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OnlineGlobalAppUserIdValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> OnlineGlobalAppUserId
        {
            get
            {
                if (this.OnlineGlobalAppUserIdValueSpecified)
                {
                    return this.OnlineGlobalAppUserIdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnlineGlobalAppUserIdValue = value.GetValueOrDefault();
                this.OnlineGlobalAppUserIdValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PartialPaymentTranCode", Order=13, Form=XmlSchemaForm.Unqualified)]
        public bool PartialPaymentTranCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PartialPaymentTranCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PartialPaymentTranCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PartialPaymentTranCode
        {
            get
            {
                if (this.PartialPaymentTranCodeValueSpecified)
                {
                    return this.PartialPaymentTranCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PartialPaymentTranCodeValue = value.GetValueOrDefault();
                this.PartialPaymentTranCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PaymentTransactionGlCode", Order=14, Form=XmlSchemaForm.Unqualified)]
        public bool PaymentTransactionGlCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PaymentTransactionGlCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PaymentTransactionGlCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PaymentTransactionGlCode
        {
            get
            {
                if (this.PaymentTransactionGlCodeValueSpecified)
                {
                    return this.PaymentTransactionGlCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PaymentTransactionGlCodeValue = value.GetValueOrDefault();
                this.PaymentTransactionGlCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Processor", Order=15, Form=XmlSchemaForm.Unqualified)]
        public bool ProcessorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Processor property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ProcessorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Processor
        {
            get
            {
                if (this.ProcessorValueSpecified)
                {
                    return this.ProcessorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ProcessorValue = value.GetValueOrDefault();
                this.ProcessorValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ProcessorAbbreviation", Order=16, Form=XmlSchemaForm.Unqualified)]
        public bool ProcessorAbbreviationValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ProcessorAbbreviation property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ProcessorAbbreviationValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ProcessorAbbreviation
        {
            get
            {
                if (this.ProcessorAbbreviationValueSpecified)
                {
                    return this.ProcessorAbbreviationValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ProcessorAbbreviationValue = value.GetValueOrDefault();
                this.ProcessorAbbreviationValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ProcessorAcctVerCode", Order=17, Form=XmlSchemaForm.Unqualified)]
        public bool ProcessorAcctVerCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ProcessorAcctVerCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ProcessorAcctVerCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ProcessorAcctVerCode
        {
            get
            {
                if (this.ProcessorAcctVerCodeValueSpecified)
                {
                    return this.ProcessorAcctVerCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ProcessorAcctVerCodeValue = value.GetValueOrDefault();
                this.ProcessorAcctVerCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ProcessorCode", Order=18, Form=XmlSchemaForm.Unqualified)]
        public bool ProcessorCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ProcessorCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ProcessorCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ProcessorCode
        {
            get
            {
                if (this.ProcessorCodeValueSpecified)
                {
                    return this.ProcessorCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ProcessorCodeValue = value.GetValueOrDefault();
                this.ProcessorCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ProcessorName", Order=19, Form=XmlSchemaForm.Unqualified)]
        public bool ProcessorNameValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ProcessorName property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ProcessorNameValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ProcessorName
        {
            get
            {
                if (this.ProcessorNameValueSpecified)
                {
                    return this.ProcessorNameValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ProcessorNameValue = value.GetValueOrDefault();
                this.ProcessorNameValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ReportLostorStolenCards", Order=20, Form=XmlSchemaForm.Unqualified)]
        public bool ReportLostorStolenCardsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ReportLostorStolenCards property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ReportLostorStolenCardsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ReportLostorStolenCards
        {
            get
            {
                if (this.ReportLostorStolenCardsValueSpecified)
                {
                    return this.ReportLostorStolenCardsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ReportLostorStolenCardsValue = value.GetValueOrDefault();
                this.ReportLostorStolenCardsValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _tranCodeAdvDesc;
        
        [XmlElementAttribute("TranCodeAdvDesc", Order=21, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> TranCodeAdvDesc
        {
            get
            {
                return _tranCodeAdvDesc;
            }
            set
            {
                _tranCodeAdvDesc = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TranCodeAdvDesc collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TranCodeAdvDescSpecified
        {
            get
            {
                return ((this.TranCodeAdvDesc != null) 
                            && (this.TranCodeAdvDesc.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ExtLoanFields" /> class.</para>
        /// </summary>
        public ExtLoanFields()
        {
            this._tranCodeAdvDesc = new Collection<short>();
            this._tranCodeAdvance = new Collection<short>();
            this._tranCodePayment = new Collection<short>();
            this._tranCodePmtDesc = new Collection<short>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _tranCodeAdvance;
        
        [XmlElementAttribute("TranCodeAdvance", Order=22, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> TranCodeAdvance
        {
            get
            {
                return _tranCodeAdvance;
            }
            set
            {
                _tranCodeAdvance = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TranCodeAdvance collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TranCodeAdvanceSpecified
        {
            get
            {
                return ((this.TranCodeAdvance != null) 
                            && (this.TranCodeAdvance.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _tranCodePayment;
        
        [XmlElementAttribute("TranCodePayment", Order=23, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> TranCodePayment
        {
            get
            {
                return _tranCodePayment;
            }
            set
            {
                _tranCodePayment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TranCodePayment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TranCodePaymentSpecified
        {
            get
            {
                return ((this.TranCodePayment != null) 
                            && (this.TranCodePayment.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _tranCodePmtDesc;
        
        [XmlElementAttribute("TranCodePmtDesc", Order=24, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> TranCodePmtDesc
        {
            get
            {
                return _tranCodePmtDesc;
            }
            set
            {
                _tranCodePmtDesc = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TranCodePmtDesc collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TranCodePmtDescSpecified
        {
            get
            {
                return ((this.TranCodePmtDesc != null) 
                            && (this.TranCodePmtDesc.Count != 0));
            }
        }
        
        [XmlElementAttribute("Version_1", Order=25, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=26)]
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
