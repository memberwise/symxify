//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\AccountService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\AccountService\generated-output -n AccountService
namespace AccountService
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
    [XmlTypeAttribute("LoanHold", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("LoanHold", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve")]
    public partial class LoanHold
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AchRecurringStop", Order=0, Form=XmlSchemaForm.Unqualified)]
        public short AchRecurringStopValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AchRecurringStop property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AchRecurringStopValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> AchRecurringStop
        {
            get
            {
                if (this.AchRecurringStopValueSpecified)
                {
                    return this.AchRecurringStopValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AchRecurringStopValue = value.GetValueOrDefault();
                this.AchRecurringStopValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Amount", Order=1, Form=XmlSchemaForm.Unqualified)]
        public decimal AmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Amount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AmountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> Amount
        {
            get
            {
                if (this.AmountValueSpecified)
                {
                    return this.AmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AmountValue = value.GetValueOrDefault();
                this.AmountValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AvailableBalance", Order=2, Form=XmlSchemaForm.Unqualified)]
        public decimal AvailableBalanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AvailableBalance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AvailableBalanceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> AvailableBalance
        {
            get
            {
                if (this.AvailableBalanceValueSpecified)
                {
                    return this.AvailableBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AvailableBalanceValue = value.GetValueOrDefault();
                this.AvailableBalanceValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EffectiveDate", Order=3, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime EffectiveDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EffectiveDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EffectiveDateValueSpecified { get; set; }
        
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
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ExpirationDate", Order=4, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime ExpirationDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ExpirationDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ExpirationDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> ExpirationDate
        {
            get
            {
                if (this.ExpirationDateValueSpecified)
                {
                    return this.ExpirationDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ExpirationDateValue = value.GetValueOrDefault();
                this.ExpirationDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ExpirationTime", Order=5, Form=XmlSchemaForm.Unqualified)]
        public short ExpirationTimeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ExpirationTime property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ExpirationTimeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> ExpirationTime
        {
            get
            {
                if (this.ExpirationTimeValueSpecified)
                {
                    return this.ExpirationTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ExpirationTimeValue = value.GetValueOrDefault();
                this.ExpirationTimeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("FeeCode", Order=6, Form=XmlSchemaForm.Unqualified)]
        public short FeeCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FeeCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FeeCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> FeeCode
        {
            get
            {
                if (this.FeeCodeValueSpecified)
                {
                    return this.FeeCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FeeCodeValue = value.GetValueOrDefault();
                this.FeeCodeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("FeeDescription", Order=7, Form=XmlSchemaForm.Unqualified)]
        public string FeeDescription { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("HoldCreationDate", Order=8, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime HoldCreationDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the HoldCreationDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool HoldCreationDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> HoldCreationDate
        {
            get
            {
                if (this.HoldCreationDateValueSpecified)
                {
                    return this.HoldCreationDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HoldCreationDateValue = value.GetValueOrDefault();
                this.HoldCreationDateValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("HoldCreationTime", Order=9, Form=XmlSchemaForm.Unqualified)]
        public string HoldCreationTime { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LedgerBalance", Order=10, Form=XmlSchemaForm.Unqualified)]
        public decimal LedgerBalanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LedgerBalance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LedgerBalanceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> LedgerBalance
        {
            get
            {
                if (this.LedgerBalanceValueSpecified)
                {
                    return this.LedgerBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LedgerBalanceValue = value.GetValueOrDefault();
                this.LedgerBalanceValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Locator", Order=11, Form=XmlSchemaForm.Unqualified)]
        public int LocatorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Locator property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LocatorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> Locator
        {
            get
            {
                if (this.LocatorValueSpecified)
                {
                    return this.LocatorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LocatorValue = value.GetValueOrDefault();
                this.LocatorValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MatchDate", Order=12, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime MatchDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MatchDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MatchDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> MatchDate
        {
            get
            {
                if (this.MatchDateValueSpecified)
                {
                    return this.MatchDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MatchDateValue = value.GetValueOrDefault();
                this.MatchDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MatchTime", Order=13, Form=XmlSchemaForm.Unqualified)]
        public short MatchTimeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MatchTime property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MatchTimeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> MatchTime
        {
            get
            {
                if (this.MatchTimeValueSpecified)
                {
                    return this.MatchTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MatchTimeValue = value.GetValueOrDefault();
                this.MatchTimeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("MemberBranch", Order=14, Form=XmlSchemaForm.Unqualified)]
        public string MemberBranch { get; set; }
        
        [XmlElementAttribute("PayeeName", Order=15, Form=XmlSchemaForm.Unqualified)]
        public string PayeeName { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RecordChangeDate", Order=16, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime RecordChangeDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RecordChangeDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RecordChangeDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> RecordChangeDate
        {
            get
            {
                if (this.RecordChangeDateValueSpecified)
                {
                    return this.RecordChangeDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RecordChangeDateValue = value.GetValueOrDefault();
                this.RecordChangeDateValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Reference1", Order=17, Form=XmlSchemaForm.Unqualified)]
        public string Reference1 { get; set; }
        
        [XmlElementAttribute("Reference2", Order=18, Form=XmlSchemaForm.Unqualified)]
        public string Reference2 { get; set; }
        
        [XmlElementAttribute("Reference3", Order=19, Form=XmlSchemaForm.Unqualified)]
        public string Reference3 { get; set; }
        
        [XmlElementAttribute("Reference4", Order=20, Form=XmlSchemaForm.Unqualified)]
        public string Reference4 { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("StopPayCode", Order=21, Form=XmlSchemaForm.Unqualified)]
        public short StopPayCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the StopPayCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool StopPayCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> StopPayCode
        {
            get
            {
                if (this.StopPayCodeValueSpecified)
                {
                    return this.StopPayCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StopPayCodeValue = value.GetValueOrDefault();
                this.StopPayCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("TransactionType", Order=22, Form=XmlSchemaForm.Unqualified)]
        public short TransactionTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TransactionType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TransactionTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> TransactionType
        {
            get
            {
                if (this.TransactionTypeValueSpecified)
                {
                    return this.TransactionTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TransactionTypeValue = value.GetValueOrDefault();
                this.TransactionTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Type", Order=23, Form=XmlSchemaForm.Unqualified)]
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
        
        [XmlElementAttribute("Version_1", Order=24, Form=XmlSchemaForm.Unqualified)]
        public AccountService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=25)]
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
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoanHold" /> class.</para>
        /// </summary>
        public LoanHold()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
