//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\GeneralLedgerService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\GeneralLedgerService\generated-output -n GeneralLedgerService
namespace GeneralLedgerService
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
    [XmlTypeAttribute("GlSubaccount", Namespace="http://www.symxchange.generated.symitar.com/crud/generalledger/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("GlSubaccount", Namespace="http://www.symxchange.generated.symitar.com/crud/generalledger/dto/retrieve")]
    public partial class GlSubaccount
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AccrualAmount", Order=0, Form=XmlSchemaForm.Unqualified)]
        public decimal AccrualAmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AccrualAmount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AccrualAmountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> AccrualAmount
        {
            get
            {
                if (this.AccrualAmountValueSpecified)
                {
                    return this.AccrualAmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AccrualAmountValue = value.GetValueOrDefault();
                this.AccrualAmountValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AccrualEffectDate", Order=1, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime AccrualEffectDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AccrualEffectDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AccrualEffectDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> AccrualEffectDate
        {
            get
            {
                if (this.AccrualEffectDateValueSpecified)
                {
                    return this.AccrualEffectDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AccrualEffectDateValue = value.GetValueOrDefault();
                this.AccrualEffectDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AccrualPostDate", Order=2, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime AccrualPostDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AccrualPostDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AccrualPostDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> AccrualPostDate
        {
            get
            {
                if (this.AccrualPostDateValueSpecified)
                {
                    return this.AccrualPostDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AccrualPostDateValue = value.GetValueOrDefault();
                this.AccrualPostDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AccrualPostThruDate", Order=3, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime AccrualPostThruDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AccrualPostThruDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AccrualPostThruDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> AccrualPostThruDate
        {
            get
            {
                if (this.AccrualPostThruDateValueSpecified)
                {
                    return this.AccrualPostThruDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AccrualPostThruDateValue = value.GetValueOrDefault();
                this.AccrualPostThruDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AccrualStartDate", Order=4, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime AccrualStartDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AccrualStartDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AccrualStartDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> AccrualStartDate
        {
            get
            {
                if (this.AccrualStartDateValueSpecified)
                {
                    return this.AccrualStartDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AccrualStartDateValue = value.GetValueOrDefault();
                this.AccrualStartDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AccruedAmount", Order=5, Form=XmlSchemaForm.Unqualified)]
        public decimal AccruedAmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AccruedAmount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AccruedAmountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> AccruedAmount
        {
            get
            {
                if (this.AccruedAmountValueSpecified)
                {
                    return this.AccruedAmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AccruedAmountValue = value.GetValueOrDefault();
                this.AccruedAmountValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AccruedCount", Order=6, Form=XmlSchemaForm.Unqualified)]
        public short AccruedCountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AccruedCount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AccruedCountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> AccruedCount
        {
            get
            {
                if (this.AccruedCountValueSpecified)
                {
                    return this.AccruedCountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AccruedCountValue = value.GetValueOrDefault();
                this.AccruedCountValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AcquisitionDate", Order=7, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime AcquisitionDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AcquisitionDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AcquisitionDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> AcquisitionDate
        {
            get
            {
                if (this.AcquisitionDateValueSpecified)
                {
                    return this.AcquisitionDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AcquisitionDateValue = value.GetValueOrDefault();
                this.AcquisitionDateValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("CommentOne", Order=8, Form=XmlSchemaForm.Unqualified)]
        public string CommentOne { get; set; }
        
        [XmlElementAttribute("CommentTwo", Order=9, Form=XmlSchemaForm.Unqualified)]
        public string CommentTwo { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CurrentValue", Order=10, Form=XmlSchemaForm.Unqualified)]
        public decimal CurrentValueValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CurrentValue property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CurrentValueValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> CurrentValue
        {
            get
            {
                if (this.CurrentValueValueSpecified)
                {
                    return this.CurrentValueValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CurrentValueValue = value.GetValueOrDefault();
                this.CurrentValueValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Disposition", Order=11, Form=XmlSchemaForm.Unqualified)]
        public short DispositionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Disposition property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DispositionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> Disposition
        {
            get
            {
                if (this.DispositionValueSpecified)
                {
                    return this.DispositionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DispositionValue = value.GetValueOrDefault();
                this.DispositionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("FirstMonthMethod", Order=12, Form=XmlSchemaForm.Unqualified)]
        public short FirstMonthMethodValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FirstMonthMethod property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FirstMonthMethodValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> FirstMonthMethod
        {
            get
            {
                if (this.FirstMonthMethodValueSpecified)
                {
                    return this.FirstMonthMethodValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FirstMonthMethodValue = value.GetValueOrDefault();
                this.FirstMonthMethodValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("GlOffset", Order=13, Form=XmlSchemaForm.Unqualified)]
        public string GlOffset { get; set; }
        
        [XmlElementAttribute("Id", Order=14, Form=XmlSchemaForm.Unqualified)]
        public string Id { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("InsMaturityDate", Order=15, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime InsMaturityDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the InsMaturityDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool InsMaturityDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> InsMaturityDate
        {
            get
            {
                if (this.InsMaturityDateValueSpecified)
                {
                    return this.InsMaturityDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.InsMaturityDateValue = value.GetValueOrDefault();
                this.InsMaturityDateValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("InsTypeDescription", Order=16, Form=XmlSchemaForm.Unqualified)]
        public string InsTypeDescription { get; set; }
        
        [XmlElementAttribute("InsuranceType", Order=17, Form=XmlSchemaForm.Unqualified)]
        public string InsuranceType { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LastFmDate", Order=18, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime LastFmDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LastFmDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LastFmDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> LastFmDate
        {
            get
            {
                if (this.LastFmDateValueSpecified)
                {
                    return this.LastFmDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LastFmDateValue = value.GetValueOrDefault();
                this.LastFmDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LimitValue", Order=19, Form=XmlSchemaForm.Unqualified)]
        public decimal LimitValueValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LimitValue property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LimitValueValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> LimitValue
        {
            get
            {
                if (this.LimitValueValueSpecified)
                {
                    return this.LimitValueValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LimitValueValue = value.GetValueOrDefault();
                this.LimitValueValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MaturityDate", Order=20, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime MaturityDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaturityDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MaturityDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> MaturityDate
        {
            get
            {
                if (this.MaturityDateValueSpecified)
                {
                    return this.MaturityDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaturityDateValue = value.GetValueOrDefault();
                this.MaturityDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Method", Order=21, Form=XmlSchemaForm.Unqualified)]
        public short MethodValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Method property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MethodValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> Method
        {
            get
            {
                if (this.MethodValueSpecified)
                {
                    return this.MethodValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MethodValue = value.GetValueOrDefault();
                this.MethodValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Name", Order=22, Form=XmlSchemaForm.Unqualified)]
        public string Name { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("OriginalValue", Order=23, Form=XmlSchemaForm.Unqualified)]
        public decimal OriginalValueValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OriginalValue property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OriginalValueValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> OriginalValue
        {
            get
            {
                if (this.OriginalValueValueSpecified)
                {
                    return this.OriginalValueValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OriginalValueValue = value.GetValueOrDefault();
                this.OriginalValueValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Process", Order=24, Form=XmlSchemaForm.Unqualified)]
        public short ProcessValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Process property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ProcessValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> Process
        {
            get
            {
                if (this.ProcessValueSpecified)
                {
                    return this.ProcessValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ProcessValue = value.GetValueOrDefault();
                this.ProcessValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Rate", Order=25, Form=XmlSchemaForm.Unqualified)]
        public decimal RateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Rate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> Rate
        {
            get
            {
                if (this.RateValueSpecified)
                {
                    return this.RateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RateValue = value.GetValueOrDefault();
                this.RateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RateBase", Order=26, Form=XmlSchemaForm.Unqualified)]
        public short RateBaseValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RateBase property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RateBaseValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> RateBase
        {
            get
            {
                if (this.RateBaseValueSpecified)
                {
                    return this.RateBaseValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RateBaseValue = value.GetValueOrDefault();
                this.RateBaseValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RecordChangeDate", Order=27, Form=XmlSchemaForm.Unqualified, DataType="date")]
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
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SaleAmount", Order=28, Form=XmlSchemaForm.Unqualified)]
        public decimal SaleAmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SaleAmount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SaleAmountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> SaleAmount
        {
            get
            {
                if (this.SaleAmountValueSpecified)
                {
                    return this.SaleAmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SaleAmountValue = value.GetValueOrDefault();
                this.SaleAmountValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SaleDate", Order=29, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime SaleDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SaleDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SaleDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> SaleDate
        {
            get
            {
                if (this.SaleDateValueSpecified)
                {
                    return this.SaleDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SaleDateValue = value.GetValueOrDefault();
                this.SaleDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("TaxAmount", Order=30, Form=XmlSchemaForm.Unqualified)]
        public decimal TaxAmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TaxAmount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TaxAmountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> TaxAmount
        {
            get
            {
                if (this.TaxAmountValueSpecified)
                {
                    return this.TaxAmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TaxAmountValue = value.GetValueOrDefault();
                this.TaxAmountValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("TaxCategory", Order=31, Form=XmlSchemaForm.Unqualified)]
        public string TaxCategory { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("TaxDate", Order=32, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime TaxDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TaxDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TaxDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> TaxDate
        {
            get
            {
                if (this.TaxDateValueSpecified)
                {
                    return this.TaxDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TaxDateValue = value.GetValueOrDefault();
                this.TaxDateValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("TaxDescription", Order=33, Form=XmlSchemaForm.Unqualified)]
        public string TaxDescription { get; set; }
        
        [XmlElementAttribute("TaxLocation", Order=34, Form=XmlSchemaForm.Unqualified)]
        public string TaxLocation { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("TermFrequency", Order=35, Form=XmlSchemaForm.Unqualified)]
        public short TermFrequencyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TermFrequency property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TermFrequencyValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> TermFrequency
        {
            get
            {
                if (this.TermFrequencyValueSpecified)
                {
                    return this.TermFrequencyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TermFrequencyValue = value.GetValueOrDefault();
                this.TermFrequencyValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("TermPeriod", Order=36, Form=XmlSchemaForm.Unqualified)]
        public short TermPeriodValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TermPeriod property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TermPeriodValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> TermPeriod
        {
            get
            {
                if (this.TermPeriodValueSpecified)
                {
                    return this.TermPeriodValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TermPeriodValue = value.GetValueOrDefault();
                this.TermPeriodValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Type", Order=37, Form=XmlSchemaForm.Unqualified)]
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
        
        [XmlElementAttribute("Version_1", Order=38, Form=XmlSchemaForm.Unqualified)]
        public GeneralLedgerService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=39)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="GlSubaccount" /> class.</para>
        /// </summary>
        public GlSubaccount()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
