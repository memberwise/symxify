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
    [XmlTypeAttribute("ShareTransfer", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("ShareTransfer", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/update")]
    [XmlIncludeAttribute(typeof(ShareTransferFields_2))]
    public partial class ShareTransfer_2
    {
        
        [XmlElementAttribute("AccountNumber", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string AccountNumber { get; set; }
        
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
        [XmlElementAttribute("AmountOption", Order=2, Form=XmlSchemaForm.Unqualified)]
        public short AmountOptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AmountOption property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AmountOptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> AmountOption
        {
            get
            {
                if (this.AmountOptionValueSpecified)
                {
                    return this.AmountOptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AmountOptionValue = value.GetValueOrDefault();
                this.AmountOptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Day1", Order=3, Form=XmlSchemaForm.Unqualified)]
        public short Day1Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Day1 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool Day1ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> Day1
        {
            get
            {
                if (this.Day1ValueSpecified)
                {
                    return this.Day1Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.Day1Value = value.GetValueOrDefault();
                this.Day1ValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Day2", Order=4, Form=XmlSchemaForm.Unqualified)]
        public short Day2Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Day2 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool Day2ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> Day2
        {
            get
            {
                if (this.Day2ValueSpecified)
                {
                    return this.Day2Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.Day2Value = value.GetValueOrDefault();
                this.Day2ValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EffectiveDate", Order=5, Form=XmlSchemaForm.Unqualified, IsNullable=true, DataType="date")]
        public Nullable<DateTime> EffectiveDateValue { get; set; }
        
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
        [XmlElementAttribute("ExpirationDate", Order=6, Form=XmlSchemaForm.Unqualified, IsNullable=true, DataType="date")]
        public Nullable<DateTime> ExpirationDateValue { get; set; }
        
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
        
        [XmlElementAttribute("ExtLoanAccount", Order=7, Form=XmlSchemaForm.Unqualified)]
        public string ExtLoanAccount { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Frequency", Order=8, Form=XmlSchemaForm.Unqualified)]
        public short FrequencyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Frequency property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FrequencyValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> Frequency
        {
            get
            {
                if (this.FrequencyValueSpecified)
                {
                    return this.FrequencyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FrequencyValue = value.GetValueOrDefault();
                this.FrequencyValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Id", Order=9, Form=XmlSchemaForm.Unqualified)]
        public string Id { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IdType", Order=10, Form=XmlSchemaForm.Unqualified)]
        public short IdTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IdType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IdTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> IdType
        {
            get
            {
                if (this.IdTypeValueSpecified)
                {
                    return this.IdTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IdTypeValue = value.GetValueOrDefault();
                this.IdTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LastDate", Order=11, Form=XmlSchemaForm.Unqualified, IsNullable=true, DataType="date")]
        public Nullable<DateTime> LastDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LastDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LastDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> LastDate
        {
            get
            {
                if (this.LastDateValueSpecified)
                {
                    return this.LastDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LastDateValue = value.GetValueOrDefault();
                this.LastDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Locator", Order=12, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("MaturityCheck", Order=13, Form=XmlSchemaForm.Unqualified)]
        public short MaturityCheckValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaturityCheck property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MaturityCheckValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> MaturityCheck
        {
            get
            {
                if (this.MaturityCheckValueSpecified)
                {
                    return this.MaturityCheckValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaturityCheckValue = value.GetValueOrDefault();
                this.MaturityCheckValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MaximumBalance", Order=14, Form=XmlSchemaForm.Unqualified)]
        public decimal MaximumBalanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaximumBalance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MaximumBalanceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> MaximumBalance
        {
            get
            {
                if (this.MaximumBalanceValueSpecified)
                {
                    return this.MaximumBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaximumBalanceValue = value.GetValueOrDefault();
                this.MaximumBalanceValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MinimumBalance", Order=15, Form=XmlSchemaForm.Unqualified)]
        public decimal MinimumBalanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MinimumBalance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MinimumBalanceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> MinimumBalance
        {
            get
            {
                if (this.MinimumBalanceValueSpecified)
                {
                    return this.MinimumBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MinimumBalanceValue = value.GetValueOrDefault();
                this.MinimumBalanceValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NextDate", Order=16, Form=XmlSchemaForm.Unqualified, IsNullable=true, DataType="date")]
        public Nullable<DateTime> NextDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NextDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NextDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> NextDate
        {
            get
            {
                if (this.NextDateValueSpecified)
                {
                    return this.NextDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NextDateValue = value.GetValueOrDefault();
                this.NextDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PaymentType", Order=17, Form=XmlSchemaForm.Unqualified)]
        public short PaymentTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PaymentType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PaymentTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> PaymentType
        {
            get
            {
                if (this.PaymentTypeValueSpecified)
                {
                    return this.PaymentTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PaymentTypeValue = value.GetValueOrDefault();
                this.PaymentTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Percent", Order=18, Form=XmlSchemaForm.Unqualified)]
        public decimal PercentValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Percent property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PercentValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> Percent
        {
            get
            {
                if (this.PercentValueSpecified)
                {
                    return this.PercentValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PercentValue = value.GetValueOrDefault();
                this.PercentValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RecordChangeDate", Order=19, Form=XmlSchemaForm.Unqualified, IsNullable=true, DataType="date")]
        public Nullable<DateTime> RecordChangeDateValue { get; set; }
        
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
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RegE", Order=20, Form=XmlSchemaForm.Unqualified)]
        public short RegEValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RegE property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RegEValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> RegE
        {
            get
            {
                if (this.RegEValueSpecified)
                {
                    return this.RegEValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RegEValue = value.GetValueOrDefault();
                this.RegEValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SweepFee", Order=21, Form=XmlSchemaForm.Unqualified)]
        public decimal SweepFeeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SweepFee property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SweepFeeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> SweepFee
        {
            get
            {
                if (this.SweepFeeValueSpecified)
                {
                    return this.SweepFeeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SweepFeeValue = value.GetValueOrDefault();
                this.SweepFeeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("SweepFeeId", Order=22, Form=XmlSchemaForm.Unqualified)]
        public string SweepFeeId { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SweepFeeIdType", Order=23, Form=XmlSchemaForm.Unqualified)]
        public short SweepFeeIdTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SweepFeeIdType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SweepFeeIdTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> SweepFeeIdType
        {
            get
            {
                if (this.SweepFeeIdTypeValueSpecified)
                {
                    return this.SweepFeeIdTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SweepFeeIdTypeValue = value.GetValueOrDefault();
                this.SweepFeeIdTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SweepMinimum", Order=24, Form=XmlSchemaForm.Unqualified)]
        public decimal SweepMinimumValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SweepMinimum property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SweepMinimumValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> SweepMinimum
        {
            get
            {
                if (this.SweepMinimumValueSpecified)
                {
                    return this.SweepMinimumValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SweepMinimumValue = value.GetValueOrDefault();
                this.SweepMinimumValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Type", Order=25, Form=XmlSchemaForm.Unqualified)]
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
        
        [XmlElementAttribute("Version_1", Order=26, Form=XmlSchemaForm.Unqualified)]
        public AccountService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=27)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ShareTransfer_2" /> class.</para>
        /// </summary>
        public ShareTransfer_2()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
