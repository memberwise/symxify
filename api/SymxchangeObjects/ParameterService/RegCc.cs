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
    [XmlTypeAttribute("RegCc", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("RegCc", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class RegCc
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AggregateException", Order=0, Form=XmlSchemaForm.Unqualified)]
        public decimal AggregateExceptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AggregateException property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AggregateExceptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> AggregateException
        {
            get
            {
                if (this.AggregateExceptionValueSpecified)
                {
                    return this.AggregateExceptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AggregateExceptionValue = value.GetValueOrDefault();
                this.AggregateExceptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BankingDay", Order=1, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime BankingDayValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BankingDay property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BankingDayValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> BankingDay
        {
            get
            {
                if (this.BankingDayValueSpecified)
                {
                    return this.BankingDayValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BankingDayValue = value.GetValueOrDefault();
                this.BankingDayValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BankingDaysOption", Order=2, Form=XmlSchemaForm.Unqualified)]
        public short BankingDaysOptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BankingDaysOption property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BankingDaysOptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> BankingDaysOption
        {
            get
            {
                if (this.BankingDaysOptionValueSpecified)
                {
                    return this.BankingDaysOptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BankingDaysOptionValue = value.GetValueOrDefault();
                this.BankingDaysOptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Branch", Order=3, Form=XmlSchemaForm.Unqualified)]
        public short BranchValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Branch property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BranchValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> Branch
        {
            get
            {
                if (this.BranchValueSpecified)
                {
                    return this.BranchValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BranchValue = value.GetValueOrDefault();
                this.BranchValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BranchReference", Order=4, Form=XmlSchemaForm.Unqualified)]
        public short BranchReferenceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BranchReference property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BranchReferenceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> BranchReference
        {
            get
            {
                if (this.BranchReferenceValueSpecified)
                {
                    return this.BranchReferenceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BranchReferenceValue = value.GetValueOrDefault();
                this.BranchReferenceValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BranchValidCode", Order=5, Form=XmlSchemaForm.Unqualified)]
        public short BranchValidCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BranchValidCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BranchValidCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> BranchValidCode
        {
            get
            {
                if (this.BranchValidCodeValueSpecified)
                {
                    return this.BranchValidCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BranchValidCodeValue = value.GetValueOrDefault();
                this.BranchValidCodeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("BusinessDays", Order=6, Form=XmlSchemaForm.Unqualified)]
        public string BusinessDays { get; set; }
        
        [XmlElementAttribute("ExcpWarningCodeList", Order=7, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.BitMap ExcpWarningCodeList { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<RegCcFederalReserveHoliday> _federalReserveHoliday;
        
        [XmlElementAttribute("FederalReserveHoliday", Order=8, Form=XmlSchemaForm.Unqualified)]
        public Collection<RegCcFederalReserveHoliday> FederalReserveHoliday
        {
            get
            {
                return _federalReserveHoliday;
            }
            set
            {
                _federalReserveHoliday = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the FederalReserveHoliday collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool FederalReserveHolidaySpecified
        {
            get
            {
                return ((this.FederalReserveHoliday != null) 
                            && (this.FederalReserveHoliday.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="RegCc" /> class.</para>
        /// </summary>
        public RegCc()
        {
            this._federalReserveHoliday = new Collection<RegCcFederalReserveHoliday>();
            this._routingNumberHoldDays = new Collection<RegCcRoutingNumberHoldDays>();
            this._routingNumberPrefix = new Collection<RegCcRoutingNumberPrefix>();
            this._any = new Collection<XmlElement>();
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ForeignItemHoldDays", Order=9, Form=XmlSchemaForm.Unqualified)]
        public short ForeignItemHoldDaysValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ForeignItemHoldDays property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ForeignItemHoldDaysValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> ForeignItemHoldDays
        {
            get
            {
                if (this.ForeignItemHoldDaysValueSpecified)
                {
                    return this.ForeignItemHoldDaysValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ForeignItemHoldDaysValue = value.GetValueOrDefault();
                this.ForeignItemHoldDaysValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("HoldPolicy", Order=10, Form=XmlSchemaForm.Unqualified)]
        public short HoldPolicyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the HoldPolicy property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool HoldPolicyValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> HoldPolicy
        {
            get
            {
                if (this.HoldPolicyValueSpecified)
                {
                    return this.HoldPolicyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HoldPolicyValue = value.GetValueOrDefault();
                this.HoldPolicyValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("HoldWarningCodeList", Order=11, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.BitMap HoldWarningCodeList { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("KrHoldBaseAmtOption", Order=12, Form=XmlSchemaForm.Unqualified)]
        public short KrHoldBaseAmtOptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the KrHoldBaseAmtOption property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool KrHoldBaseAmtOptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> KrHoldBaseAmtOption
        {
            get
            {
                if (this.KrHoldBaseAmtOptionValueSpecified)
                {
                    return this.KrHoldBaseAmtOptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.KrHoldBaseAmtOptionValue = value.GetValueOrDefault();
                this.KrHoldBaseAmtOptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("KrHoldBaseOption", Order=13, Form=XmlSchemaForm.Unqualified)]
        public short KrHoldBaseOptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the KrHoldBaseOption property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool KrHoldBaseOptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> KrHoldBaseOption
        {
            get
            {
                if (this.KrHoldBaseOptionValueSpecified)
                {
                    return this.KrHoldBaseOptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.KrHoldBaseOptionValue = value.GetValueOrDefault();
                this.KrHoldBaseOptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LargeDepositExceptionHold", Order=14, Form=XmlSchemaForm.Unqualified)]
        public short LargeDepositExceptionHoldValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LargeDepositExceptionHold property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LargeDepositExceptionHoldValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> LargeDepositExceptionHold
        {
            get
            {
                if (this.LargeDepositExceptionHoldValueSpecified)
                {
                    return this.LargeDepositExceptionHoldValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LargeDepositExceptionHoldValue = value.GetValueOrDefault();
                this.LargeDepositExceptionHoldValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LastDayAvailable", Order=15, Form=XmlSchemaForm.Unqualified)]
        public decimal LastDayAvailableValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LastDayAvailable property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LastDayAvailableValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> LastDayAvailable
        {
            get
            {
                if (this.LastDayAvailableValueSpecified)
                {
                    return this.LastDayAvailableValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LastDayAvailableValue = value.GetValueOrDefault();
                this.LastDayAvailableValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LocalAggrgtExcpHoldDays", Order=16, Form=XmlSchemaForm.Unqualified)]
        public short LocalAggrgtExcpHoldDaysValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LocalAggrgtExcpHoldDays property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LocalAggrgtExcpHoldDaysValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> LocalAggrgtExcpHoldDays
        {
            get
            {
                if (this.LocalAggrgtExcpHoldDaysValueSpecified)
                {
                    return this.LocalAggrgtExcpHoldDaysValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LocalAggrgtExcpHoldDaysValue = value.GetValueOrDefault();
                this.LocalAggrgtExcpHoldDaysValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LocalExceptionHoldDays", Order=17, Form=XmlSchemaForm.Unqualified)]
        public short LocalExceptionHoldDaysValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LocalExceptionHoldDays property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LocalExceptionHoldDaysValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> LocalExceptionHoldDays
        {
            get
            {
                if (this.LocalExceptionHoldDaysValueSpecified)
                {
                    return this.LocalExceptionHoldDaysValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LocalExceptionHoldDaysValue = value.GetValueOrDefault();
                this.LocalExceptionHoldDaysValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LocalHoldDays", Order=18, Form=XmlSchemaForm.Unqualified)]
        public short LocalHoldDaysValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LocalHoldDays property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LocalHoldDaysValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> LocalHoldDays
        {
            get
            {
                if (this.LocalHoldDaysValueSpecified)
                {
                    return this.LocalHoldDaysValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LocalHoldDaysValue = value.GetValueOrDefault();
                this.LocalHoldDaysValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MaxHoldCalendarDays", Order=19, Form=XmlSchemaForm.Unqualified)]
        public short MaxHoldCalendarDaysValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxHoldCalendarDays property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MaxHoldCalendarDaysValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> MaxHoldCalendarDays
        {
            get
            {
                if (this.MaxHoldCalendarDaysValueSpecified)
                {
                    return this.MaxHoldCalendarDaysValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxHoldCalendarDaysValue = value.GetValueOrDefault();
                this.MaxHoldCalendarDaysValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NewAccountHoldDays", Order=20, Form=XmlSchemaForm.Unqualified)]
        public short NewAccountHoldDaysValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NewAccountHoldDays property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NewAccountHoldDaysValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> NewAccountHoldDays
        {
            get
            {
                if (this.NewAccountHoldDaysValueSpecified)
                {
                    return this.NewAccountHoldDaysValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NewAccountHoldDaysValue = value.GetValueOrDefault();
                this.NewAccountHoldDaysValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NewAccountWarningCode", Order=21, Form=XmlSchemaForm.Unqualified)]
        public short NewAccountWarningCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NewAccountWarningCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NewAccountWarningCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> NewAccountWarningCode
        {
            get
            {
                if (this.NewAccountWarningCodeValueSpecified)
                {
                    return this.NewAccountWarningCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NewAccountWarningCodeValue = value.GetValueOrDefault();
                this.NewAccountWarningCodeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("NextDayAvailExcpRsnList", Order=22, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.BitMap NextDayAvailExcpRsnList { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NextDayAvailable", Order=23, Form=XmlSchemaForm.Unqualified)]
        public decimal NextDayAvailableValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NextDayAvailable property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NextDayAvailableValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> NextDayAvailable
        {
            get
            {
                if (this.NextDayAvailableValueSpecified)
                {
                    return this.NextDayAvailableValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NextDayAvailableValue = value.GetValueOrDefault();
                this.NextDayAvailableValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NextDayDays", Order=24, Form=XmlSchemaForm.Unqualified)]
        public short NextDayDaysValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NextDayDays property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NextDayDaysValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> NextDayDays
        {
            get
            {
                if (this.NextDayDaysValueSpecified)
                {
                    return this.NextDayDaysValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NextDayDaysValue = value.GetValueOrDefault();
                this.NextDayDaysValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NonLocalAggrgtExcpHoldDay", Order=25, Form=XmlSchemaForm.Unqualified)]
        public short NonLocalAggrgtExcpHoldDayValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NonLocalAggrgtExcpHoldDay property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NonLocalAggrgtExcpHoldDayValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> NonLocalAggrgtExcpHoldDay
        {
            get
            {
                if (this.NonLocalAggrgtExcpHoldDayValueSpecified)
                {
                    return this.NonLocalAggrgtExcpHoldDayValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NonLocalAggrgtExcpHoldDayValue = value.GetValueOrDefault();
                this.NonLocalAggrgtExcpHoldDayValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NonLocalExceptionHoldDays", Order=26, Form=XmlSchemaForm.Unqualified)]
        public short NonLocalExceptionHoldDaysValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NonLocalExceptionHoldDays property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NonLocalExceptionHoldDaysValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> NonLocalExceptionHoldDays
        {
            get
            {
                if (this.NonLocalExceptionHoldDaysValueSpecified)
                {
                    return this.NonLocalExceptionHoldDaysValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NonLocalExceptionHoldDaysValue = value.GetValueOrDefault();
                this.NonLocalExceptionHoldDaysValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NonlocalHoldDays", Order=27, Form=XmlSchemaForm.Unqualified)]
        public short NonlocalHoldDaysValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NonlocalHoldDays property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NonlocalHoldDaysValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> NonlocalHoldDays
        {
            get
            {
                if (this.NonlocalHoldDaysValueSpecified)
                {
                    return this.NonlocalHoldDaysValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NonlocalHoldDaysValue = value.GetValueOrDefault();
                this.NonlocalHoldDaysValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RepeatedNsfWarningCode", Order=28, Form=XmlSchemaForm.Unqualified)]
        public short RepeatedNsfWarningCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RepeatedNsfWarningCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RepeatedNsfWarningCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> RepeatedNsfWarningCode
        {
            get
            {
                if (this.RepeatedNsfWarningCodeValueSpecified)
                {
                    return this.RepeatedNsfWarningCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RepeatedNsfWarningCodeValue = value.GetValueOrDefault();
                this.RepeatedNsfWarningCodeValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<RegCcRoutingNumberHoldDays> _routingNumberHoldDays;
        
        [XmlElementAttribute("RoutingNumberHoldDays", Order=29, Form=XmlSchemaForm.Unqualified)]
        public Collection<RegCcRoutingNumberHoldDays> RoutingNumberHoldDays
        {
            get
            {
                return _routingNumberHoldDays;
            }
            set
            {
                _routingNumberHoldDays = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the RoutingNumberHoldDays collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RoutingNumberHoldDaysSpecified
        {
            get
            {
                return ((this.RoutingNumberHoldDays != null) 
                            && (this.RoutingNumberHoldDays.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<RegCcRoutingNumberPrefix> _routingNumberPrefix;
        
        [XmlElementAttribute("RoutingNumberPrefix", Order=30, Form=XmlSchemaForm.Unqualified)]
        public Collection<RegCcRoutingNumberPrefix> RoutingNumberPrefix
        {
            get
            {
                return _routingNumberPrefix;
            }
            set
            {
                _routingNumberPrefix = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the RoutingNumberPrefix collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RoutingNumberPrefixSpecified
        {
            get
            {
                return ((this.RoutingNumberPrefix != null) 
                            && (this.RoutingNumberPrefix.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SavingsPolicy", Order=31, Form=XmlSchemaForm.Unqualified)]
        public short SavingsPolicyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SavingsPolicy property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SavingsPolicyValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> SavingsPolicy
        {
            get
            {
                if (this.SavingsPolicyValueSpecified)
                {
                    return this.SavingsPolicyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SavingsPolicyValue = value.GetValueOrDefault();
                this.SavingsPolicyValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UseMicrRtPrefix", Order=32, Form=XmlSchemaForm.Unqualified)]
        public bool UseMicrRtPrefixValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UseMicrRtPrefix property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UseMicrRtPrefixValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> UseMicrRtPrefix
        {
            get
            {
                if (this.UseMicrRtPrefixValueSpecified)
                {
                    return this.UseMicrRtPrefixValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UseMicrRtPrefixValue = value.GetValueOrDefault();
                this.UseMicrRtPrefixValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=33, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=34)]
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
