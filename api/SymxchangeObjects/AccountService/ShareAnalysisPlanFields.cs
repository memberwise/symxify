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
    [XmlTypeAttribute("ShareAnalysisPlanFields", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("ShareAnalysisPlanFields", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve")]
    public partial class ShareAnalysisPlanFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CashAmountFree", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool CashAmountFreeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CashAmountFree property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CashAmountFreeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CashAmountFree
        {
            get
            {
                if (this.CashAmountFreeValueSpecified)
                {
                    return this.CashAmountFreeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CashAmountFreeValue = value.GetValueOrDefault();
                this.CashAmountFreeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CashAtmTotals", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool CashAtmTotalsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CashAtmTotals property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CashAtmTotalsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CashAtmTotals
        {
            get
            {
                if (this.CashAtmTotalsValueSpecified)
                {
                    return this.CashAtmTotalsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CashAtmTotalsValue = value.GetValueOrDefault();
                this.CashAtmTotalsValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CashRate", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool CashRateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CashRate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CashRateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CashRate
        {
            get
            {
                if (this.CashRateValueSpecified)
                {
                    return this.CashRateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CashRateValue = value.GetValueOrDefault();
                this.CashRateValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _charge;
        
        [XmlElementAttribute("Charge", Order=3, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> Charge
        {
            get
            {
                return _charge;
            }
            set
            {
                _charge = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Charge collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ChargeSpecified
        {
            get
            {
                return ((this.Charge != null) 
                            && (this.Charge.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ShareAnalysisPlanFields" /> class.</para>
        /// </summary>
        public ShareAnalysisPlanFields()
        {
            this._charge = new Collection<short>();
            this._chargeType = new Collection<short>();
            this._free = new Collection<short>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _chargeType;
        
        [XmlElementAttribute("ChargeType", Order=4, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> ChargeType
        {
            get
            {
                return _chargeType;
            }
            set
            {
                _chargeType = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ChargeType collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ChargeTypeSpecified
        {
            get
            {
                return ((this.ChargeType != null) 
                            && (this.ChargeType.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("DefinedCode", Order=5, Form=XmlSchemaForm.Unqualified)]
        public bool DefinedCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DefinedCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DefinedCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> DefinedCode
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
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Description", Order=6, Form=XmlSchemaForm.Unqualified)]
        public bool DescriptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Description property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DescriptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Description
        {
            get
            {
                if (this.DescriptionValueSpecified)
                {
                    return this.DescriptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DescriptionValue = value.GetValueOrDefault();
                this.DescriptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EarnRateMethod", Order=7, Form=XmlSchemaForm.Unqualified)]
        public bool EarnRateMethodValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EarnRateMethod property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EarnRateMethodValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> EarnRateMethod
        {
            get
            {
                if (this.EarnRateMethodValueSpecified)
                {
                    return this.EarnRateMethodValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EarnRateMethodValue = value.GetValueOrDefault();
                this.EarnRateMethodValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EffectiveDate", Order=8, Form=XmlSchemaForm.Unqualified)]
        public bool EffectiveDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EffectiveDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EffectiveDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> EffectiveDate
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
        [XmlElementAttribute("ExpirationDate", Order=9, Form=XmlSchemaForm.Unqualified)]
        public bool ExpirationDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ExpirationDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ExpirationDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ExpirationDate
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
        
        [XmlIgnoreAttribute()]
        private Collection<short> _free;
        
        [XmlElementAttribute("Free", Order=10, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> Free
        {
            get
            {
                return _free;
            }
            set
            {
                _free = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Free collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool FreeSpecified
        {
            get
            {
                return ((this.Free != null) 
                            && (this.Free.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Locator", Order=11, Form=XmlSchemaForm.Unqualified)]
        public bool LocatorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Locator property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LocatorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Locator
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
        [XmlElementAttribute("MaintenanceCharge", Order=12, Form=XmlSchemaForm.Unqualified)]
        public bool MaintenanceChargeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaintenanceCharge property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MaintenanceChargeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> MaintenanceCharge
        {
            get
            {
                if (this.MaintenanceChargeValueSpecified)
                {
                    return this.MaintenanceChargeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaintenanceChargeValue = value.GetValueOrDefault();
                this.MaintenanceChargeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MaximumCharge", Order=13, Form=XmlSchemaForm.Unqualified)]
        public bool MaximumChargeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaximumCharge property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MaximumChargeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> MaximumCharge
        {
            get
            {
                if (this.MaximumChargeValueSpecified)
                {
                    return this.MaximumChargeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaximumChargeValue = value.GetValueOrDefault();
                this.MaximumChargeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MinimumCharge", Order=14, Form=XmlSchemaForm.Unqualified)]
        public bool MinimumChargeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MinimumCharge property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MinimumChargeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> MinimumCharge
        {
            get
            {
                if (this.MinimumChargeValueSpecified)
                {
                    return this.MinimumChargeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MinimumChargeValue = value.GetValueOrDefault();
                this.MinimumChargeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Plan", Order=15, Form=XmlSchemaForm.Unqualified)]
        public bool PlanValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Plan property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PlanValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Plan
        {
            get
            {
                if (this.PlanValueSpecified)
                {
                    return this.PlanValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PlanValue = value.GetValueOrDefault();
                this.PlanValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RecordChangeDate", Order=16, Form=XmlSchemaForm.Unqualified)]
        public bool RecordChangeDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RecordChangeDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RecordChangeDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> RecordChangeDate
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
        [XmlElementAttribute("Tier1Balance", Order=17, Form=XmlSchemaForm.Unqualified)]
        public bool Tier1BalanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Tier1Balance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool Tier1BalanceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Tier1Balance
        {
            get
            {
                if (this.Tier1BalanceValueSpecified)
                {
                    return this.Tier1BalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.Tier1BalanceValue = value.GetValueOrDefault();
                this.Tier1BalanceValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Tier1EarnRate", Order=18, Form=XmlSchemaForm.Unqualified)]
        public bool Tier1EarnRateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Tier1EarnRate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool Tier1EarnRateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Tier1EarnRate
        {
            get
            {
                if (this.Tier1EarnRateValueSpecified)
                {
                    return this.Tier1EarnRateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.Tier1EarnRateValue = value.GetValueOrDefault();
                this.Tier1EarnRateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Tier2Balance", Order=19, Form=XmlSchemaForm.Unqualified)]
        public bool Tier2BalanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Tier2Balance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool Tier2BalanceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Tier2Balance
        {
            get
            {
                if (this.Tier2BalanceValueSpecified)
                {
                    return this.Tier2BalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.Tier2BalanceValue = value.GetValueOrDefault();
                this.Tier2BalanceValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Tier2EarnRate", Order=20, Form=XmlSchemaForm.Unqualified)]
        public bool Tier2EarnRateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Tier2EarnRate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool Tier2EarnRateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Tier2EarnRate
        {
            get
            {
                if (this.Tier2EarnRateValueSpecified)
                {
                    return this.Tier2EarnRateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.Tier2EarnRateValue = value.GetValueOrDefault();
                this.Tier2EarnRateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Tier3Balance", Order=21, Form=XmlSchemaForm.Unqualified)]
        public bool Tier3BalanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Tier3Balance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool Tier3BalanceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Tier3Balance
        {
            get
            {
                if (this.Tier3BalanceValueSpecified)
                {
                    return this.Tier3BalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.Tier3BalanceValue = value.GetValueOrDefault();
                this.Tier3BalanceValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Tier3EarnRate", Order=22, Form=XmlSchemaForm.Unqualified)]
        public bool Tier3EarnRateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Tier3EarnRate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool Tier3EarnRateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Tier3EarnRate
        {
            get
            {
                if (this.Tier3EarnRateValueSpecified)
                {
                    return this.Tier3EarnRateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.Tier3EarnRateValue = value.GetValueOrDefault();
                this.Tier3EarnRateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Tier4Balance", Order=23, Form=XmlSchemaForm.Unqualified)]
        public bool Tier4BalanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Tier4Balance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool Tier4BalanceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Tier4Balance
        {
            get
            {
                if (this.Tier4BalanceValueSpecified)
                {
                    return this.Tier4BalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.Tier4BalanceValue = value.GetValueOrDefault();
                this.Tier4BalanceValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Tier4EarnRate", Order=24, Form=XmlSchemaForm.Unqualified)]
        public bool Tier4EarnRateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Tier4EarnRate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool Tier4EarnRateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Tier4EarnRate
        {
            get
            {
                if (this.Tier4EarnRateValueSpecified)
                {
                    return this.Tier4EarnRateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.Tier4EarnRateValue = value.GetValueOrDefault();
                this.Tier4EarnRateValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=25, Form=XmlSchemaForm.Unqualified)]
        public AccountService.VersionType Version1 { get; set; }
        
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
