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
    [XmlTypeAttribute("PlanDefault", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("PlanDefault", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class PlanDefault
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ChargeOffDays", Order=0, Form=XmlSchemaForm.Unqualified)]
        public short ChargeOffDaysValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ChargeOffDays property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ChargeOffDaysValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> ChargeOffDays
        {
            get
            {
                if (this.ChargeOffDaysValueSpecified)
                {
                    return this.ChargeOffDaysValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ChargeOffDaysValue = value.GetValueOrDefault();
                this.ChargeOffDaysValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ChargeOffPmts", Order=1, Form=XmlSchemaForm.Unqualified)]
        public short ChargeOffPmtsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ChargeOffPmts property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ChargeOffPmtsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> ChargeOffPmts
        {
            get
            {
                if (this.ChargeOffPmtsValueSpecified)
                {
                    return this.ChargeOffPmtsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ChargeOffPmtsValue = value.GetValueOrDefault();
                this.ChargeOffPmtsValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ChargebackCoOption", Order=2, Form=XmlSchemaForm.Unqualified)]
        public short ChargebackCoOptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ChargebackCoOption property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ChargebackCoOptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> ChargebackCoOption
        {
            get
            {
                if (this.ChargebackCoOptionValueSpecified)
                {
                    return this.ChargebackCoOptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ChargebackCoOptionValue = value.GetValueOrDefault();
                this.ChargebackCoOptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ChargebackPoOption", Order=3, Form=XmlSchemaForm.Unqualified)]
        public short ChargebackPoOptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ChargebackPoOption property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ChargebackPoOptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> ChargebackPoOption
        {
            get
            {
                if (this.ChargebackPoOptionValueSpecified)
                {
                    return this.ChargebackPoOptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ChargebackPoOptionValue = value.GetValueOrDefault();
                this.ChargebackPoOptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CloseDate", Order=4, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime CloseDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CloseDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CloseDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> CloseDate
        {
            get
            {
                if (this.CloseDateValueSpecified)
                {
                    return this.CloseDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CloseDateValue = value.GetValueOrDefault();
                this.CloseDateValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Description", Order=5, Form=XmlSchemaForm.Unqualified)]
        public string Description { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EarlyPayoffDays", Order=6, Form=XmlSchemaForm.Unqualified)]
        public short EarlyPayoffDaysValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EarlyPayoffDays property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EarlyPayoffDaysValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> EarlyPayoffDays
        {
            get
            {
                if (this.EarlyPayoffDaysValueSpecified)
                {
                    return this.EarlyPayoffDaysValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EarlyPayoffDaysValue = value.GetValueOrDefault();
                this.EarlyPayoffDaysValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EarlyPayoffPmts", Order=7, Form=XmlSchemaForm.Unqualified)]
        public short EarlyPayoffPmtsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EarlyPayoffPmts property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EarlyPayoffPmtsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> EarlyPayoffPmts
        {
            get
            {
                if (this.EarlyPayoffPmtsValueSpecified)
                {
                    return this.EarlyPayoffPmtsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EarlyPayoffPmtsValue = value.GetValueOrDefault();
                this.EarlyPayoffPmtsValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MbrFeeAmount", Order=8, Form=XmlSchemaForm.Unqualified)]
        public decimal MbrFeeAmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MbrFeeAmount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MbrFeeAmountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> MbrFeeAmount
        {
            get
            {
                if (this.MbrFeeAmountValueSpecified)
                {
                    return this.MbrFeeAmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MbrFeeAmountValue = value.GetValueOrDefault();
                this.MbrFeeAmountValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MemberFee", Order=9, Form=XmlSchemaForm.Unqualified)]
        public short MemberFeeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MemberFee property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MemberFeeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> MemberFee
        {
            get
            {
                if (this.MemberFeeValueSpecified)
                {
                    return this.MemberFeeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MemberFeeValue = value.GetValueOrDefault();
                this.MemberFeeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ReservePlanType", Order=10, Form=XmlSchemaForm.Unqualified)]
        public short ReservePlanTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ReservePlanType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ReservePlanTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> ReservePlanType
        {
            get
            {
                if (this.ReservePlanTypeValueSpecified)
                {
                    return this.ReservePlanTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ReservePlanTypeValue = value.GetValueOrDefault();
                this.ReservePlanTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Type", Order=11, Form=XmlSchemaForm.Unqualified)]
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
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UpFrontReserveAmt", Order=12, Form=XmlSchemaForm.Unqualified)]
        public decimal UpFrontReserveAmtValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UpFrontReserveAmt property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UpFrontReserveAmtValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> UpFrontReserveAmt
        {
            get
            {
                if (this.UpFrontReserveAmtValueSpecified)
                {
                    return this.UpFrontReserveAmtValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UpFrontReserveAmtValue = value.GetValueOrDefault();
                this.UpFrontReserveAmtValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UpFrontReservePercent", Order=13, Form=XmlSchemaForm.Unqualified)]
        public decimal UpFrontReservePercentValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UpFrontReservePercent property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UpFrontReservePercentValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> UpFrontReservePercent
        {
            get
            {
                if (this.UpFrontReservePercentValueSpecified)
                {
                    return this.UpFrontReservePercentValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UpFrontReservePercentValue = value.GetValueOrDefault();
                this.UpFrontReservePercentValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserAmount1", Order=14, Form=XmlSchemaForm.Unqualified)]
        public decimal UserAmount1Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserAmount1 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserAmount1ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> UserAmount1
        {
            get
            {
                if (this.UserAmount1ValueSpecified)
                {
                    return this.UserAmount1Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserAmount1Value = value.GetValueOrDefault();
                this.UserAmount1ValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserAmount2", Order=15, Form=XmlSchemaForm.Unqualified)]
        public decimal UserAmount2Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserAmount2 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserAmount2ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> UserAmount2
        {
            get
            {
                if (this.UserAmount2ValueSpecified)
                {
                    return this.UserAmount2Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserAmount2Value = value.GetValueOrDefault();
                this.UserAmount2ValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserAmount3", Order=16, Form=XmlSchemaForm.Unqualified)]
        public decimal UserAmount3Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserAmount3 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserAmount3ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> UserAmount3
        {
            get
            {
                if (this.UserAmount3ValueSpecified)
                {
                    return this.UserAmount3Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserAmount3Value = value.GetValueOrDefault();
                this.UserAmount3ValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("UserChar1", Order=17, Form=XmlSchemaForm.Unqualified)]
        public string UserChar1 { get; set; }
        
        [XmlElementAttribute("UserChar2", Order=18, Form=XmlSchemaForm.Unqualified)]
        public string UserChar2 { get; set; }
        
        [XmlElementAttribute("UserChar3", Order=19, Form=XmlSchemaForm.Unqualified)]
        public string UserChar3 { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserCode1", Order=20, Form=XmlSchemaForm.Unqualified)]
        public short UserCode1Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserCode1 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserCode1ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> UserCode1
        {
            get
            {
                if (this.UserCode1ValueSpecified)
                {
                    return this.UserCode1Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserCode1Value = value.GetValueOrDefault();
                this.UserCode1ValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserDate1", Order=21, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime UserDate1Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserDate1 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserDate1ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> UserDate1
        {
            get
            {
                if (this.UserDate1ValueSpecified)
                {
                    return this.UserDate1Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserDate1Value = value.GetValueOrDefault();
                this.UserDate1ValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserNumber1", Order=22, Form=XmlSchemaForm.Unqualified)]
        public int UserNumber1Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserNumber1 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserNumber1ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> UserNumber1
        {
            get
            {
                if (this.UserNumber1ValueSpecified)
                {
                    return this.UserNumber1Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserNumber1Value = value.GetValueOrDefault();
                this.UserNumber1ValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserNumber2", Order=23, Form=XmlSchemaForm.Unqualified)]
        public int UserNumber2Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserNumber2 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserNumber2ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> UserNumber2
        {
            get
            {
                if (this.UserNumber2ValueSpecified)
                {
                    return this.UserNumber2Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserNumber2Value = value.GetValueOrDefault();
                this.UserNumber2ValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserRate1", Order=24, Form=XmlSchemaForm.Unqualified)]
        public decimal UserRate1Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserRate1 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserRate1ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> UserRate1
        {
            get
            {
                if (this.UserRate1ValueSpecified)
                {
                    return this.UserRate1Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserRate1Value = value.GetValueOrDefault();
                this.UserRate1ValueSpecified = value.HasValue;
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
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="PlanDefault" /> class.</para>
        /// </summary>
        public PlanDefault()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
