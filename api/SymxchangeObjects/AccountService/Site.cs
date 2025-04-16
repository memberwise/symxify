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
    [XmlTypeAttribute("Site", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("Site", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve")]
    public partial class Site
    {
        
        [XmlElementAttribute("City", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string City { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CloseDate", Order=1, Form=XmlSchemaForm.Unqualified, DataType="date")]
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
        
        [XmlElementAttribute("ContactPhone", Order=2, Form=XmlSchemaForm.Unqualified)]
        public string ContactPhone { get; set; }
        
        [XmlElementAttribute("ExtraAddress", Order=3, Form=XmlSchemaForm.Unqualified)]
        public string ExtraAddress { get; set; }
        
        [XmlElementAttribute("FaxPhone", Order=4, Form=XmlSchemaForm.Unqualified)]
        public string FaxPhone { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Locator", Order=5, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("RecordChangeDate", Order=6, Form=XmlSchemaForm.Unqualified, DataType="date")]
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
        
        [XmlElementAttribute("SiteCashOrderTypeList", Order=7, Form=XmlSchemaForm.Unqualified)]
        public SiteCashOrderTypeList SiteCashOrderTypeList { get; set; }
        
        [XmlElementAttribute("SiteContactName", Order=8, Form=XmlSchemaForm.Unqualified)]
        public string SiteContactName { get; set; }
        
        [XmlElementAttribute("SiteId", Order=9, Form=XmlSchemaForm.Unqualified)]
        public string SiteId { get; set; }
        
        [XmlElementAttribute("SiteName", Order=10, Form=XmlSchemaForm.Unqualified)]
        public string SiteName { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SiteNumber", Order=11, Form=XmlSchemaForm.Unqualified)]
        public short SiteNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SiteNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SiteNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> SiteNumber
        {
            get
            {
                if (this.SiteNumberValueSpecified)
                {
                    return this.SiteNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SiteNumberValue = value.GetValueOrDefault();
                this.SiteNumberValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("SiteSettleShareId", Order=12, Form=XmlSchemaForm.Unqualified)]
        public string SiteSettleShareId { get; set; }
        
        [XmlElementAttribute("State", Order=13, Form=XmlSchemaForm.Unqualified)]
        public string State { get; set; }
        
        [XmlElementAttribute("Street", Order=14, Form=XmlSchemaForm.Unqualified)]
        public string Street { get; set; }
        
        [XmlElementAttribute("ZipCode", Order=15, Form=XmlSchemaForm.Unqualified)]
        public string ZipCode { get; set; }
        
        [XmlElementAttribute("Version_1", Order=16, Form=XmlSchemaForm.Unqualified)]
        public AccountService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=17)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Site" /> class.</para>
        /// </summary>
        public Site()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
