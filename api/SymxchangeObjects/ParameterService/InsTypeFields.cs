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
    [XmlTypeAttribute("InsTypeFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("InsTypeFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class InsTypeFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ConsolidationCode", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool ConsolidationCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ConsolidationCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ConsolidationCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ConsolidationCode
        {
            get
            {
                if (this.ConsolidationCodeValueSpecified)
                {
                    return this.ConsolidationCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ConsolidationCodeValue = value.GetValueOrDefault();
                this.ConsolidationCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("DefinedCode", Order=1, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("DisabilityInsuranceTable", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool DisabilityInsuranceTableValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DisabilityInsuranceTable property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DisabilityInsuranceTableValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> DisabilityInsuranceTable
        {
            get
            {
                if (this.DisabilityInsuranceTableValueSpecified)
                {
                    return this.DisabilityInsuranceTableValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DisabilityInsuranceTableValue = value.GetValueOrDefault();
                this.DisabilityInsuranceTableValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("InsuranceType", Order=3, Form=XmlSchemaForm.Unqualified)]
        public bool InsuranceTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the InsuranceType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool InsuranceTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> InsuranceType
        {
            get
            {
                if (this.InsuranceTypeValueSpecified)
                {
                    return this.InsuranceTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.InsuranceTypeValue = value.GetValueOrDefault();
                this.InsuranceTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LifeInsuranceTable", Order=4, Form=XmlSchemaForm.Unqualified)]
        public bool LifeInsuranceTableValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LifeInsuranceTable property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LifeInsuranceTableValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> LifeInsuranceTable
        {
            get
            {
                if (this.LifeInsuranceTableValueSpecified)
                {
                    return this.LifeInsuranceTableValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LifeInsuranceTableValue = value.GetValueOrDefault();
                this.LifeInsuranceTableValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LongDescription", Order=5, Form=XmlSchemaForm.Unqualified)]
        public bool LongDescriptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LongDescription property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LongDescriptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> LongDescription
        {
            get
            {
                if (this.LongDescriptionValueSpecified)
                {
                    return this.LongDescriptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LongDescriptionValue = value.GetValueOrDefault();
                this.LongDescriptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MaxDisDirectInsType", Order=6, Form=XmlSchemaForm.Unqualified)]
        public bool MaxDisDirectInsTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxDisDirectInsType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MaxDisDirectInsTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> MaxDisDirectInsType
        {
            get
            {
                if (this.MaxDisDirectInsTypeValueSpecified)
                {
                    return this.MaxDisDirectInsTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxDisDirectInsTypeValue = value.GetValueOrDefault();
                this.MaxDisDirectInsTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MaxLifeDirectInsType", Order=7, Form=XmlSchemaForm.Unqualified)]
        public bool MaxLifeDirectInsTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxLifeDirectInsType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MaxLifeDirectInsTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> MaxLifeDirectInsType
        {
            get
            {
                if (this.MaxLifeDirectInsTypeValueSpecified)
                {
                    return this.MaxLifeDirectInsTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxLifeDirectInsTypeValue = value.GetValueOrDefault();
                this.MaxLifeDirectInsTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SecondInsuredAsPrimeDis", Order=8, Form=XmlSchemaForm.Unqualified)]
        public bool SecondInsuredAsPrimeDisValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SecondInsuredAsPrimeDis property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SecondInsuredAsPrimeDisValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> SecondInsuredAsPrimeDis
        {
            get
            {
                if (this.SecondInsuredAsPrimeDisValueSpecified)
                {
                    return this.SecondInsuredAsPrimeDisValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SecondInsuredAsPrimeDisValue = value.GetValueOrDefault();
                this.SecondInsuredAsPrimeDisValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SecondInsuredAsPrimeLife", Order=9, Form=XmlSchemaForm.Unqualified)]
        public bool SecondInsuredAsPrimeLifeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SecondInsuredAsPrimeLife property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SecondInsuredAsPrimeLifeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> SecondInsuredAsPrimeLife
        {
            get
            {
                if (this.SecondInsuredAsPrimeLifeValueSpecified)
                {
                    return this.SecondInsuredAsPrimeLifeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SecondInsuredAsPrimeLifeValue = value.GetValueOrDefault();
                this.SecondInsuredAsPrimeLifeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ShortDescription", Order=10, Form=XmlSchemaForm.Unqualified)]
        public bool ShortDescriptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ShortDescription property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ShortDescriptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ShortDescription
        {
            get
            {
                if (this.ShortDescriptionValueSpecified)
                {
                    return this.ShortDescriptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ShortDescriptionValue = value.GetValueOrDefault();
                this.ShortDescriptionValueSpecified = value.HasValue;
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="InsTypeFields" /> class.</para>
        /// </summary>
        public InsTypeFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
