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
    [XmlTypeAttribute("InstitutionFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("InstitutionFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class InstitutionFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Branch", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool BranchValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Branch property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BranchValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Branch
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
        [XmlElementAttribute("CfpbWebAddress1", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool CfpbWebAddress1Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CfpbWebAddress1 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CfpbWebAddress1ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CfpbWebAddress1
        {
            get
            {
                if (this.CfpbWebAddress1ValueSpecified)
                {
                    return this.CfpbWebAddress1Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CfpbWebAddress1Value = value.GetValueOrDefault();
                this.CfpbWebAddress1ValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CfpbWebAddress2", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool CfpbWebAddress2Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CfpbWebAddress2 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CfpbWebAddress2ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CfpbWebAddress2
        {
            get
            {
                if (this.CfpbWebAddress2ValueSpecified)
                {
                    return this.CfpbWebAddress2Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CfpbWebAddress2Value = value.GetValueOrDefault();
                this.CfpbWebAddress2ValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("City", Order=3, Form=XmlSchemaForm.Unqualified)]
        public bool CityValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the City property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CityValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> City
        {
            get
            {
                if (this.CityValueSpecified)
                {
                    return this.CityValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CityValue = value.GetValueOrDefault();
                this.CityValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CountryCode", Order=4, Form=XmlSchemaForm.Unqualified)]
        public bool CountryCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CountryCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CountryCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CountryCode
        {
            get
            {
                if (this.CountryCodeValueSpecified)
                {
                    return this.CountryCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CountryCodeValue = value.GetValueOrDefault();
                this.CountryCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CtrApprover", Order=5, Form=XmlSchemaForm.Unqualified)]
        public bool CtrApproverValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CtrApprover property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CtrApproverValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CtrApprover
        {
            get
            {
                if (this.CtrApproverValueSpecified)
                {
                    return this.CtrApproverValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CtrApproverValue = value.GetValueOrDefault();
                this.CtrApproverValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CtrApproverTitle", Order=6, Form=XmlSchemaForm.Unqualified)]
        public bool CtrApproverTitleValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CtrApproverTitle property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CtrApproverTitleValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CtrApproverTitle
        {
            get
            {
                if (this.CtrApproverTitleValueSpecified)
                {
                    return this.CtrApproverTitleValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CtrApproverTitleValue = value.GetValueOrDefault();
                this.CtrApproverTitleValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CtrContact", Order=7, Form=XmlSchemaForm.Unqualified)]
        public bool CtrContactValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CtrContact property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CtrContactValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CtrContact
        {
            get
            {
                if (this.CtrContactValueSpecified)
                {
                    return this.CtrContactValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CtrContactValue = value.GetValueOrDefault();
                this.CtrContactValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CtrContactPhone", Order=8, Form=XmlSchemaForm.Unqualified)]
        public bool CtrContactPhoneValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CtrContactPhone property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CtrContactPhoneValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CtrContactPhone
        {
            get
            {
                if (this.CtrContactPhoneValueSpecified)
                {
                    return this.CtrContactPhoneValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CtrContactPhoneValue = value.GetValueOrDefault();
                this.CtrContactPhoneValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CtrContactPhoneExt", Order=9, Form=XmlSchemaForm.Unqualified)]
        public bool CtrContactPhoneExtValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CtrContactPhoneExt property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CtrContactPhoneExtValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CtrContactPhoneExt
        {
            get
            {
                if (this.CtrContactPhoneExtValueSpecified)
                {
                    return this.CtrContactPhoneExtValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CtrContactPhoneExtValue = value.GetValueOrDefault();
                this.CtrContactPhoneExtValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CtrPreparer", Order=10, Form=XmlSchemaForm.Unqualified)]
        public bool CtrPreparerValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CtrPreparer property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CtrPreparerValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CtrPreparer
        {
            get
            {
                if (this.CtrPreparerValueSpecified)
                {
                    return this.CtrPreparerValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CtrPreparerValue = value.GetValueOrDefault();
                this.CtrPreparerValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Ein", Order=11, Form=XmlSchemaForm.Unqualified)]
        public bool EinValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Ein property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EinValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Ein
        {
            get
            {
                if (this.EinValueSpecified)
                {
                    return this.EinValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EinValue = value.GetValueOrDefault();
                this.EinValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ExtraAddress", Order=12, Form=XmlSchemaForm.Unqualified)]
        public bool ExtraAddressValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ExtraAddress property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ExtraAddressValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ExtraAddress
        {
            get
            {
                if (this.ExtraAddressValueSpecified)
                {
                    return this.ExtraAddressValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ExtraAddressValue = value.GetValueOrDefault();
                this.ExtraAddressValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("FiEmail", Order=13, Form=XmlSchemaForm.Unqualified)]
        public bool FiEmailValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FiEmail property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FiEmailValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> FiEmail
        {
            get
            {
                if (this.FiEmailValueSpecified)
                {
                    return this.FiEmailValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FiEmailValue = value.GetValueOrDefault();
                this.FiEmailValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("FiPhone", Order=14, Form=XmlSchemaForm.Unqualified)]
        public bool FiPhoneValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FiPhone property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FiPhoneValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> FiPhone
        {
            get
            {
                if (this.FiPhoneValueSpecified)
                {
                    return this.FiPhoneValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FiPhoneValue = value.GetValueOrDefault();
                this.FiPhoneValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("HudPhone", Order=15, Form=XmlSchemaForm.Unqualified)]
        public bool HudPhoneValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the HudPhone property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool HudPhoneValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> HudPhone
        {
            get
            {
                if (this.HudPhoneValueSpecified)
                {
                    return this.HudPhoneValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HudPhoneValue = value.GetValueOrDefault();
                this.HudPhoneValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("HudWebAddress1", Order=16, Form=XmlSchemaForm.Unqualified)]
        public bool HudWebAddress1Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the HudWebAddress1 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool HudWebAddress1ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> HudWebAddress1
        {
            get
            {
                if (this.HudWebAddress1ValueSpecified)
                {
                    return this.HudWebAddress1Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HudWebAddress1Value = value.GetValueOrDefault();
                this.HudWebAddress1ValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("HudWebAddress2", Order=17, Form=XmlSchemaForm.Unqualified)]
        public bool HudWebAddress2Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the HudWebAddress2 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool HudWebAddress2ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> HudWebAddress2
        {
            get
            {
                if (this.HudWebAddress2ValueSpecified)
                {
                    return this.HudWebAddress2Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HudWebAddress2Value = value.GetValueOrDefault();
                this.HudWebAddress2ValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Name", Order=18, Form=XmlSchemaForm.Unqualified)]
        public bool NameValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Name property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NameValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Name
        {
            get
            {
                if (this.NameValueSpecified)
                {
                    return this.NameValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NameValue = value.GetValueOrDefault();
                this.NameValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RoutingNumber", Order=19, Form=XmlSchemaForm.Unqualified)]
        public bool RoutingNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RoutingNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RoutingNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> RoutingNumber
        {
            get
            {
                if (this.RoutingNumberValueSpecified)
                {
                    return this.RoutingNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RoutingNumberValue = value.GetValueOrDefault();
                this.RoutingNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("State", Order=20, Form=XmlSchemaForm.Unqualified)]
        public bool StateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the State property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool StateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> State
        {
            get
            {
                if (this.StateValueSpecified)
                {
                    return this.StateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StateValue = value.GetValueOrDefault();
                this.StateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Street", Order=21, Form=XmlSchemaForm.Unqualified)]
        public bool StreetValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Street property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool StreetValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Street
        {
            get
            {
                if (this.StreetValueSpecified)
                {
                    return this.StreetValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StreetValue = value.GetValueOrDefault();
                this.StreetValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Telephone", Order=22, Form=XmlSchemaForm.Unqualified)]
        public bool TelephoneValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Telephone property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TelephoneValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Telephone
        {
            get
            {
                if (this.TelephoneValueSpecified)
                {
                    return this.TelephoneValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TelephoneValue = value.GetValueOrDefault();
                this.TelephoneValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("WebsiteAddr", Order=23, Form=XmlSchemaForm.Unqualified)]
        public bool WebsiteAddrValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the WebsiteAddr property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool WebsiteAddrValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> WebsiteAddr
        {
            get
            {
                if (this.WebsiteAddrValueSpecified)
                {
                    return this.WebsiteAddrValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.WebsiteAddrValue = value.GetValueOrDefault();
                this.WebsiteAddrValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ZipCode", Order=24, Form=XmlSchemaForm.Unqualified)]
        public bool ZipCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ZipCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ZipCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ZipCode
        {
            get
            {
                if (this.ZipCodeValueSpecified)
                {
                    return this.ZipCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ZipCodeValue = value.GetValueOrDefault();
                this.ZipCodeValueSpecified = value.HasValue;
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="InstitutionFields" /> class.</para>
        /// </summary>
        public InstitutionFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
