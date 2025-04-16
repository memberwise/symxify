//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\WireService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\WireService\generated-output -n WireService
namespace WireService
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
    [XmlTypeAttribute("UpdateWireBeneficiaryAdvByIDRequest", Namespace="http://www.symxchange.generated.symitar.com/crud/wire")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class UpdateWireBeneficiaryAdvByIdRequest
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("WireSequenceNumber", Order=0, Form=XmlSchemaForm.Unqualified)]
        public int WireSequenceNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the WireSequenceNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool WireSequenceNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> WireSequenceNumber
        {
            get
            {
                if (this.WireSequenceNumberValueSpecified)
                {
                    return this.WireSequenceNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.WireSequenceNumberValue = value.GetValueOrDefault();
                this.WireSequenceNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("WireBeneficiaryAdvLocator", Order=1, Form=XmlSchemaForm.Unqualified)]
        public int WireBeneficiaryAdvLocatorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the WireBeneficiaryAdvLocator property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool WireBeneficiaryAdvLocatorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> WireBeneficiaryAdvLocator
        {
            get
            {
                if (this.WireBeneficiaryAdvLocatorValueSpecified)
                {
                    return this.WireBeneficiaryAdvLocatorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.WireBeneficiaryAdvLocatorValue = value.GetValueOrDefault();
                this.WireBeneficiaryAdvLocatorValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Credentials", Order=2, Form=XmlSchemaForm.Unqualified)]
        public WireService.AdminCredentialsChoice Credentials { get; set; }
        
        [XmlElementAttribute("DeviceInformation", Order=3, Form=XmlSchemaForm.Unqualified)]
        public WireService.DeviceInformation DeviceInformation { get; set; }
        
        [XmlElementAttribute("WireBeneficiaryAdvFields", Order=4, Form=XmlSchemaForm.Unqualified)]
        public WireService.WireBeneficiaryAdvFields_2 WireBeneficiaryAdvFields { get; set; }
        
        [XmlElementAttribute("Version_1", Order=5, Form=XmlSchemaForm.Unqualified)]
        public WireService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=6)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="UpdateWireBeneficiaryAdvByIdRequest" /> class.</para>
        /// </summary>
        public UpdateWireBeneficiaryAdvByIdRequest()
        {
            this._any = new Collection<XmlElement>();
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlAttributeAttribute("MessageId")]
        public string MessageId { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlAttributeAttribute("BranchId", Namespace="http://www.symxchange.generated.symitar.com/crud/wire", Form=XmlSchemaForm.Qualified)]
        public short BranchIdValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BranchId property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BranchIdValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> BranchId
        {
            get
            {
                if (this.BranchIdValueSpecified)
                {
                    return this.BranchIdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BranchIdValue = value.GetValueOrDefault();
                this.BranchIdValueSpecified = value.HasValue;
            }
        }
    }
}
