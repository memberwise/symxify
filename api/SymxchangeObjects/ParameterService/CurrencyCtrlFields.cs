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
    [XmlTypeAttribute("CurrencyCtrlFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("CurrencyCtrlFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class CurrencyCtrlFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BuyRate", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool BuyRateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BuyRate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BuyRateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> BuyRate
        {
            get
            {
                if (this.BuyRateValueSpecified)
                {
                    return this.BuyRateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BuyRateValue = value.GetValueOrDefault();
                this.BuyRateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BuyRateDescription", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool BuyRateDescriptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BuyRateDescription property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BuyRateDescriptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> BuyRateDescription
        {
            get
            {
                if (this.BuyRateDescriptionValueSpecified)
                {
                    return this.BuyRateDescriptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BuyRateDescriptionValue = value.GetValueOrDefault();
                this.BuyRateDescriptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CurrencyDecimalPlaces", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool CurrencyDecimalPlacesValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CurrencyDecimalPlaces property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CurrencyDecimalPlacesValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CurrencyDecimalPlaces
        {
            get
            {
                if (this.CurrencyDecimalPlacesValueSpecified)
                {
                    return this.CurrencyDecimalPlacesValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CurrencyDecimalPlacesValue = value.GetValueOrDefault();
                this.CurrencyDecimalPlacesValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CurrencyMinimumUnits", Order=3, Form=XmlSchemaForm.Unqualified)]
        public bool CurrencyMinimumUnitsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CurrencyMinimumUnits property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CurrencyMinimumUnitsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CurrencyMinimumUnits
        {
            get
            {
                if (this.CurrencyMinimumUnitsValueSpecified)
                {
                    return this.CurrencyMinimumUnitsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CurrencyMinimumUnitsValue = value.GetValueOrDefault();
                this.CurrencyMinimumUnitsValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CurrencyName", Order=4, Form=XmlSchemaForm.Unqualified)]
        public bool CurrencyNameValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CurrencyName property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CurrencyNameValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CurrencyName
        {
            get
            {
                if (this.CurrencyNameValueSpecified)
                {
                    return this.CurrencyNameValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CurrencyNameValue = value.GetValueOrDefault();
                this.CurrencyNameValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CurrencyShortName", Order=5, Form=XmlSchemaForm.Unqualified)]
        public bool CurrencyShortNameValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CurrencyShortName property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CurrencyShortNameValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CurrencyShortName
        {
            get
            {
                if (this.CurrencyShortNameValueSpecified)
                {
                    return this.CurrencyShortNameValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CurrencyShortNameValue = value.GetValueOrDefault();
                this.CurrencyShortNameValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("FipsCountryCode", Order=6, Form=XmlSchemaForm.Unqualified)]
        public bool FipsCountryCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FipsCountryCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FipsCountryCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> FipsCountryCode
        {
            get
            {
                if (this.FipsCountryCodeValueSpecified)
                {
                    return this.FipsCountryCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FipsCountryCodeValue = value.GetValueOrDefault();
                this.FipsCountryCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PrimeRate", Order=7, Form=XmlSchemaForm.Unqualified)]
        public bool PrimeRateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PrimeRate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PrimeRateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PrimeRate
        {
            get
            {
                if (this.PrimeRateValueSpecified)
                {
                    return this.PrimeRateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PrimeRateValue = value.GetValueOrDefault();
                this.PrimeRateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PrimeRateDescription", Order=8, Form=XmlSchemaForm.Unqualified)]
        public bool PrimeRateDescriptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PrimeRateDescription property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PrimeRateDescriptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PrimeRateDescription
        {
            get
            {
                if (this.PrimeRateDescriptionValueSpecified)
                {
                    return this.PrimeRateDescriptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PrimeRateDescriptionValue = value.GetValueOrDefault();
                this.PrimeRateDescriptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SellRate", Order=9, Form=XmlSchemaForm.Unqualified)]
        public bool SellRateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SellRate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SellRateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> SellRate
        {
            get
            {
                if (this.SellRateValueSpecified)
                {
                    return this.SellRateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SellRateValue = value.GetValueOrDefault();
                this.SellRateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SellRateDescription", Order=10, Form=XmlSchemaForm.Unqualified)]
        public bool SellRateDescriptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SellRateDescription property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SellRateDescriptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> SellRateDescription
        {
            get
            {
                if (this.SellRateDescriptionValueSpecified)
                {
                    return this.SellRateDescriptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SellRateDescriptionValue = value.GetValueOrDefault();
                this.SellRateDescriptionValueSpecified = value.HasValue;
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
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CurrencyCtrlFields" /> class.</para>
        /// </summary>
        public CurrencyCtrlFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
