//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\MbrAddressService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\MbrAddressService\generated-output -n MbraddressService
namespace MbraddressService
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
    [XmlTypeAttribute("MbrAddress", Namespace="http://www.symxchange.generated.symitar.com/crud/mbraddress/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("MbrAddress", Namespace="http://www.symxchange.generated.symitar.com/crud/mbraddress/dto/retrieve")]
    public partial class MbrAddress
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AddrCreateDate", Order=0, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime AddrCreateDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AddrCreateDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AddrCreateDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> AddrCreateDate
        {
            get
            {
                if (this.AddrCreateDateValueSpecified)
                {
                    return this.AddrCreateDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AddrCreateDateValue = value.GetValueOrDefault();
                this.AddrCreateDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AddrDisconnectDate", Order=1, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime AddrDisconnectDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AddrDisconnectDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AddrDisconnectDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> AddrDisconnectDate
        {
            get
            {
                if (this.AddrDisconnectDateValueSpecified)
                {
                    return this.AddrDisconnectDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AddrDisconnectDateValue = value.GetValueOrDefault();
                this.AddrDisconnectDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AddrExpDate", Order=2, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime AddrExpDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AddrExpDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AddrExpDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> AddrExpDate
        {
            get
            {
                if (this.AddrExpDateValueSpecified)
                {
                    return this.AddrExpDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AddrExpDateValue = value.GetValueOrDefault();
                this.AddrExpDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AddrFmLastDate", Order=3, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime AddrFmLastDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AddrFmLastDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AddrFmLastDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> AddrFmLastDate
        {
            get
            {
                if (this.AddrFmLastDateValueSpecified)
                {
                    return this.AddrFmLastDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AddrFmLastDateValue = value.GetValueOrDefault();
                this.AddrFmLastDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AddrFmLastPurgeDate", Order=4, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime AddrFmLastPurgeDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AddrFmLastPurgeDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AddrFmLastPurgeDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> AddrFmLastPurgeDate
        {
            get
            {
                if (this.AddrFmLastPurgeDateValueSpecified)
                {
                    return this.AddrFmLastPurgeDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AddrFmLastPurgeDateValue = value.GetValueOrDefault();
                this.AddrFmLastPurgeDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AddrRecordChangeDate", Order=5, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime AddrRecordChangeDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AddrRecordChangeDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AddrRecordChangeDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> AddrRecordChangeDate
        {
            get
            {
                if (this.AddrRecordChangeDateValueSpecified)
                {
                    return this.AddrRecordChangeDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AddrRecordChangeDateValue = value.GetValueOrDefault();
                this.AddrRecordChangeDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AddressType", Order=6, Form=XmlSchemaForm.Unqualified)]
        public short AddressTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AddressType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AddressTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> AddressType
        {
            get
            {
                if (this.AddressTypeValueSpecified)
                {
                    return this.AddressTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AddressTypeValue = value.GetValueOrDefault();
                this.AddressTypeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("CarrierRoute", Order=7, Form=XmlSchemaForm.Unqualified)]
        public string CarrierRoute { get; set; }
        
        [XmlElementAttribute("City", Order=8, Form=XmlSchemaForm.Unqualified)]
        public string City { get; set; }
        
        [XmlElementAttribute("Country", Order=9, Form=XmlSchemaForm.Unqualified)]
        public string Country { get; set; }
        
        [XmlElementAttribute("CountryCode", Order=10, Form=XmlSchemaForm.Unqualified)]
        public string CountryCode { get; set; }
        
        [XmlElementAttribute("ExtraAddress", Order=11, Form=XmlSchemaForm.Unqualified)]
        public string ExtraAddress { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Headquarters", Order=12, Form=XmlSchemaForm.Unqualified)]
        public short HeadquartersValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Headquarters property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool HeadquartersValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> Headquarters
        {
            get
            {
                if (this.HeadquartersValueSpecified)
                {
                    return this.HeadquartersValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HeadquartersValue = value.GetValueOrDefault();
                this.HeadquartersValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MbrAddrFileType", Order=13, Form=XmlSchemaForm.Unqualified)]
        public short MbrAddrFileTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MbrAddrFileType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MbrAddrFileTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> MbrAddrFileType
        {
            get
            {
                if (this.MbrAddrFileTypeValueSpecified)
                {
                    return this.MbrAddrFileTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MbrAddrFileTypeValue = value.GetValueOrDefault();
                this.MbrAddrFileTypeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("MbrAddrNumber", Order=14, Form=XmlSchemaForm.Unqualified)]
        public string MbrAddrNumber { get; set; }
        
        [XmlElementAttribute("MbrAddressFmHistoryList", Order=15, Form=XmlSchemaForm.Unqualified)]
        public MbrAddressFmHistoryList MbrAddressFmHistoryList { get; set; }
        
        [XmlElementAttribute("State", Order=16, Form=XmlSchemaForm.Unqualified)]
        public string State { get; set; }
        
        [XmlElementAttribute("Street", Order=17, Form=XmlSchemaForm.Unqualified)]
        public string Street { get; set; }
        
        [XmlElementAttribute("ZipCode", Order=18, Form=XmlSchemaForm.Unqualified)]
        public string ZipCode { get; set; }
        
        [XmlElementAttribute("Version_1", Order=19, Form=XmlSchemaForm.Unqualified)]
        public MbraddressService.VersionType Version1 { get; set; }
        
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
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="MbrAddress" /> class.</para>
        /// </summary>
        public MbrAddress()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
