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
    [XmlTypeAttribute("InsTable", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("InsTable", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [XmlIncludeAttribute(typeof(InsTableFields_2))]
    public partial class InsTable_2
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BalloonPremium", Order=0, Form=XmlSchemaForm.Unqualified)]
        public decimal BalloonPremiumValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BalloonPremium property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BalloonPremiumValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> BalloonPremium
        {
            get
            {
                if (this.BalloonPremiumValueSpecified)
                {
                    return this.BalloonPremiumValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BalloonPremiumValue = value.GetValueOrDefault();
                this.BalloonPremiumValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BalloonPremiumBase", Order=1, Form=XmlSchemaForm.Unqualified)]
        public decimal BalloonPremiumBaseValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BalloonPremiumBase property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BalloonPremiumBaseValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> BalloonPremiumBase
        {
            get
            {
                if (this.BalloonPremiumBaseValueSpecified)
                {
                    return this.BalloonPremiumBaseValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BalloonPremiumBaseValue = value.GetValueOrDefault();
                this.BalloonPremiumBaseValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("DeviationFactor", Order=2, Form=XmlSchemaForm.Unqualified)]
        public decimal DeviationFactorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DeviationFactor property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DeviationFactorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> DeviationFactor
        {
            get
            {
                if (this.DeviationFactorValueSpecified)
                {
                    return this.DeviationFactorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DeviationFactorValue = value.GetValueOrDefault();
                this.DeviationFactorValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Formula", Order=3, Form=XmlSchemaForm.Unqualified)]
        public short FormulaValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Formula property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FormulaValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> Formula
        {
            get
            {
                if (this.FormulaValueSpecified)
                {
                    return this.FormulaValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FormulaValue = value.GetValueOrDefault();
                this.FormulaValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Frequency", Order=4, Form=XmlSchemaForm.Unqualified)]
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
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("FrequencyDay", Order=5, Form=XmlSchemaForm.Unqualified)]
        public short FrequencyDayValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FrequencyDay property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FrequencyDayValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> FrequencyDay
        {
            get
            {
                if (this.FrequencyDayValueSpecified)
                {
                    return this.FrequencyDayValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FrequencyDayValue = value.GetValueOrDefault();
                this.FrequencyDayValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("InsuranceCode", Order=6, Form=XmlSchemaForm.Unqualified)]
        public short InsuranceCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the InsuranceCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool InsuranceCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> InsuranceCode
        {
            get
            {
                if (this.InsuranceCodeValueSpecified)
                {
                    return this.InsuranceCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.InsuranceCodeValue = value.GetValueOrDefault();
                this.InsuranceCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("InsuranceTable", Order=7, Form=XmlSchemaForm.Unqualified)]
        public short InsuranceTableValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the InsuranceTable property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool InsuranceTableValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> InsuranceTable
        {
            get
            {
                if (this.InsuranceTableValueSpecified)
                {
                    return this.InsuranceTableValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.InsuranceTableValue = value.GetValueOrDefault();
                this.InsuranceTableValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("LongDescription", Order=8, Form=XmlSchemaForm.Unqualified)]
        public string LongDescription { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MaxAge", Order=9, Form=XmlSchemaForm.Unqualified)]
        public short MaxAgeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxAge property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MaxAgeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> MaxAge
        {
            get
            {
                if (this.MaxAgeValueSpecified)
                {
                    return this.MaxAgeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxAgeValue = value.GetValueOrDefault();
                this.MaxAgeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MaxInsurableAmount", Order=10, Form=XmlSchemaForm.Unqualified)]
        public decimal MaxInsurableAmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxInsurableAmount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MaxInsurableAmountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> MaxInsurableAmount
        {
            get
            {
                if (this.MaxInsurableAmountValueSpecified)
                {
                    return this.MaxInsurableAmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxInsurableAmountValue = value.GetValueOrDefault();
                this.MaxInsurableAmountValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MaxJointAge", Order=11, Form=XmlSchemaForm.Unqualified)]
        public short MaxJointAgeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxJointAge property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MaxJointAgeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> MaxJointAge
        {
            get
            {
                if (this.MaxJointAgeValueSpecified)
                {
                    return this.MaxJointAgeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxJointAgeValue = value.GetValueOrDefault();
                this.MaxJointAgeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MaxMonthlyBenefit", Order=12, Form=XmlSchemaForm.Unqualified)]
        public decimal MaxMonthlyBenefitValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxMonthlyBenefit property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MaxMonthlyBenefitValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> MaxMonthlyBenefit
        {
            get
            {
                if (this.MaxMonthlyBenefitValueSpecified)
                {
                    return this.MaxMonthlyBenefitValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxMonthlyBenefitValue = value.GetValueOrDefault();
                this.MaxMonthlyBenefitValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MaxTerminMonths", Order=13, Form=XmlSchemaForm.Unqualified)]
        public short MaxTerminMonthsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxTerminMonths property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MaxTerminMonthsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> MaxTerminMonths
        {
            get
            {
                if (this.MaxTerminMonthsValueSpecified)
                {
                    return this.MaxTerminMonthsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxTerminMonthsValue = value.GetValueOrDefault();
                this.MaxTerminMonthsValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Premium", Order=14, Form=XmlSchemaForm.Unqualified)]
        public decimal PremiumValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Premium property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PremiumValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> Premium
        {
            get
            {
                if (this.PremiumValueSpecified)
                {
                    return this.PremiumValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PremiumValue = value.GetValueOrDefault();
                this.PremiumValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PremiumBase", Order=15, Form=XmlSchemaForm.Unqualified)]
        public decimal PremiumBaseValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PremiumBase property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PremiumBaseValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> PremiumBase
        {
            get
            {
                if (this.PremiumBaseValueSpecified)
                {
                    return this.PremiumBaseValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PremiumBaseValue = value.GetValueOrDefault();
                this.PremiumBaseValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("ShortDescription", Order=16, Form=XmlSchemaForm.Unqualified)]
        public string ShortDescription { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SubFormula", Order=17, Form=XmlSchemaForm.Unqualified)]
        public short SubFormulaValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SubFormula property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SubFormulaValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> SubFormula
        {
            get
            {
                if (this.SubFormulaValueSpecified)
                {
                    return this.SubFormulaValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SubFormulaValue = value.GetValueOrDefault();
                this.SubFormulaValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<InsTableTermPremium_2> _termPremium;
        
        [XmlElementAttribute("TermPremium", Order=18, Form=XmlSchemaForm.Unqualified)]
        public Collection<InsTableTermPremium_2> TermPremium
        {
            get
            {
                return _termPremium;
            }
            set
            {
                _termPremium = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TermPremium collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TermPremiumSpecified
        {
            get
            {
                return ((this.TermPremium != null) 
                            && (this.TermPremium.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="InsTable_2" /> class.</para>
        /// </summary>
        public InsTable_2()
        {
            this._termPremium = new Collection<InsTableTermPremium_2>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlElementAttribute("Version_1", Order=19, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=20)]
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
