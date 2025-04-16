//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\GeneralLedgerService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\GeneralLedgerService\generated-output -n GeneralLedgerService
namespace GeneralLedgerService
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
    [XmlTypeAttribute("GlAccountFmHistoryPagedListSelectFieldsRequest", Namespace="http://www.symxchange.generated.symitar.com/crud/generalledger")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class GlAccountFmHistoryPagedListSelectFieldsRequest
    {
        
        [XmlElementAttribute("GlAccountNumber", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string GlAccountNumber { get; set; }
        
        [XmlElementAttribute("GlAccountSuffix", Order=1, Form=XmlSchemaForm.Unqualified)]
        public string GlAccountSuffix { get; set; }
        
        [XmlElementAttribute("GlAccountBranch", Order=2, Form=XmlSchemaForm.Unqualified)]
        public string GlAccountBranch { get; set; }
        
        [XmlElementAttribute("Credentials", Order=3, Form=XmlSchemaForm.Unqualified)]
        public GeneralLedgerService.AdminCredentialsChoice Credentials { get; set; }
        
        [XmlElementAttribute("DeviceInformation", Order=4, Form=XmlSchemaForm.Unqualified)]
        public GeneralLedgerService.DeviceInformation DeviceInformation { get; set; }
        
        [XmlElementAttribute("PagingRequestContext", Order=5, Form=XmlSchemaForm.Unqualified)]
        public GeneralLedgerService.PagingRequestContext PagingRequestContext { get; set; }
        
        [XmlElementAttribute("SelectableFields", Order=6, Form=XmlSchemaForm.Unqualified)]
        public GeneralLedgerService.GlAccountFmHistorySingleSelectableFields SelectableFields { get; set; }
        
        [XmlElementAttribute("Version_1", Order=7, Form=XmlSchemaForm.Unqualified)]
        public GeneralLedgerService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=8)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="GlAccountFmHistoryPagedListSelectFieldsRequest" /> class.</para>
        /// </summary>
        public GlAccountFmHistoryPagedListSelectFieldsRequest()
        {
            this._any = new Collection<XmlElement>();
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlAttributeAttribute("MessageId")]
        public string MessageId { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlAttributeAttribute("BranchId", Namespace="http://www.symxchange.generated.symitar.com/crud/generalledger", Form=XmlSchemaForm.Qualified)]
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
