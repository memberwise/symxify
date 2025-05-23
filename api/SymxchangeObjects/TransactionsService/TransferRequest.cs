//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\TransactionsService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\TransactionsService\generated-output -n TransactionsService
namespace TransactionsService
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
    [XmlTypeAttribute("TransferRequest", Namespace="http://www.symxchange.generated.symitar.com/noncrud/transactions/dto")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class TransferRequest : TransactionsBaseRequest
    {
        
        /// <summary>
        /// <para xml:lang="en">Maximum length: 14.</para>
        /// </summary>
        [MaxLengthAttribute(14)]
        [XmlElementAttribute("DonorAccountNumber", Order=0)]
        public string DonorAccountNumber { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Maximum length: 20.</para>
        /// </summary>
        [MaxLengthAttribute(20)]
        [XmlElementAttribute("DonorId", Order=1)]
        public string DonorId { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("DonorType", Order=2)]
        public DonorIdType DonorTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DonorType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DonorTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DonorIdType> DonorType
        {
            get
            {
                if (this.DonorTypeValueSpecified)
                {
                    return this.DonorTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DonorTypeValue = value.GetValueOrDefault();
                this.DonorTypeValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Maximum length: 14.</para>
        /// </summary>
        [MaxLengthAttribute(14)]
        [XmlElementAttribute("RecipientAccountNumber", Order=3)]
        public string RecipientAccountNumber { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Maximum length: 20.</para>
        /// </summary>
        [MaxLengthAttribute(20)]
        [XmlElementAttribute("RecipientId", Order=4)]
        public string RecipientId { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RecipientType", Order=5)]
        public RecipientIdType RecipientTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RecipientType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RecipientTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<RecipientIdType> RecipientType
        {
            get
            {
                if (this.RecipientTypeValueSpecified)
                {
                    return this.RecipientTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RecipientTypeValue = value.GetValueOrDefault();
                this.RecipientTypeValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.01.</para>
        /// <para xml:lang="en">Maximum inclusive value: 90000000000000.00.</para>
        /// </summary>
        [RangeAttribute(typeof(decimal), "0.01", "90000000000000.00")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("TransferAmount", Order=6, Form=XmlSchemaForm.Unqualified)]
        public decimal TransferAmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TransferAmount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TransferAmountValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.01.</para>
        /// <para xml:lang="en">Maximum inclusive value: 90000000000000.00.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public Nullable<decimal> TransferAmount
        {
            get
            {
                if (this.TransferAmountValueSpecified)
                {
                    return this.TransferAmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TransferAmountValue = value.GetValueOrDefault();
                this.TransferAmountValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 132.</para>
        /// </summary>
        [MinLengthAttribute(1)]
        [MaxLengthAttribute(132)]
        [XmlElementAttribute("Comment", Order=7)]
        public string Comment { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AuthorizationType", Order=8)]
        public AuthorizationType AuthorizationTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AuthorizationType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AuthorizationTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<AuthorizationType> AuthorizationType
        {
            get
            {
                if (this.AuthorizationTypeValueSpecified)
                {
                    return this.AuthorizationTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AuthorizationTypeValue = value.GetValueOrDefault();
                this.AuthorizationTypeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("RemitInformation", Order=9)]
        public RemitInformation RemitInformation { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ForcePostRequested", Order=10)]
        public bool ForcePostRequestedValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ForcePostRequested property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ForcePostRequestedValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ForcePostRequested
        {
            get
            {
                if (this.ForcePostRequestedValueSpecified)
                {
                    return this.ForcePostRequestedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ForcePostRequestedValue = value.GetValueOrDefault();
                this.ForcePostRequestedValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.01.</para>
        /// <para xml:lang="en">Maximum inclusive value: 90000000000000.00.</para>
        /// </summary>
        [RangeAttribute(typeof(decimal), "0.01", "90000000000000.00")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PrincipalAmount", Order=11)]
        public decimal PrincipalAmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PrincipalAmount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PrincipalAmountValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.01.</para>
        /// <para xml:lang="en">Maximum inclusive value: 90000000000000.00.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public Nullable<decimal> PrincipalAmount
        {
            get
            {
                if (this.PrincipalAmountValueSpecified)
                {
                    return this.PrincipalAmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PrincipalAmountValue = value.GetValueOrDefault();
                this.PrincipalAmountValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Maximum length: 2.</para>
        /// </summary>
        [MaxLengthAttribute(2)]
        [XmlElementAttribute("SourceCode", Order=12)]
        public string SourceCode { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 1900-01-01.</para>
        /// <para xml:lang="en">Maximum inclusive value: 2078-12-31.</para>
        /// </summary>
        [RangeAttribute(typeof(DateTime), "1900-01-01", "2078-12-31")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EffectiveDate", Order=13, DataType="date")]
        public DateTime EffectiveDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EffectiveDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EffectiveDateValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 1900-01-01.</para>
        /// <para xml:lang="en">Maximum inclusive value: 2078-12-31.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> EffectiveDate
        {
            get
            {
                if (this.EffectiveDateValueSpecified)
                {
                    return this.EffectiveDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EffectiveDateValue = value.GetValueOrDefault();
                this.EffectiveDateValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 9999.</para>
        /// </summary>
        [RangeAttribute(typeof(short), "0", "9999")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CommentCode", Order=14)]
        public short CommentCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CommentCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CommentCodeValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 9999.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public Nullable<short> CommentCode
        {
            get
            {
                if (this.CommentCodeValueSpecified)
                {
                    return this.CommentCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CommentCodeValue = value.GetValueOrDefault();
                this.CommentCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LoanPaymentType", Order=15)]
        public LoanPaymentType LoanPaymentTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LoanPaymentType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LoanPaymentTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<LoanPaymentType> LoanPaymentType
        {
            get
            {
                if (this.LoanPaymentTypeValueSpecified)
                {
                    return this.LoanPaymentTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LoanPaymentTypeValue = value.GetValueOrDefault();
                this.LoanPaymentTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RegulationDLimited", Order=16, IsNullable=true)]
        public Nullable<bool> RegulationDLimitedValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RegulationDLimited property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RegulationDLimitedValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> RegulationDLimited
        {
            get
            {
                if (this.RegulationDLimitedValueSpecified)
                {
                    return this.RegulationDLimitedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RegulationDLimitedValue = value.GetValueOrDefault();
                this.RegulationDLimitedValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RecurrenceRequested", Order=17)]
        public bool RecurrenceRequestedValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RecurrenceRequested property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RecurrenceRequestedValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> RecurrenceRequested
        {
            get
            {
                if (this.RecurrenceRequestedValueSpecified)
                {
                    return this.RecurrenceRequestedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RecurrenceRequestedValue = value.GetValueOrDefault();
                this.RecurrenceRequestedValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 40.</para>
        /// </summary>
        [MinLengthAttribute(1)]
        [MaxLengthAttribute(40)]
        [XmlElementAttribute("GLComment", Order=18)]
        public string GlComment { get; set; }
    }
}
