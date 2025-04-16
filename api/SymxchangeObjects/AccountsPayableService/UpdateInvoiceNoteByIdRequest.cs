//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\AccountsPayableService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\AccountsPayableService\generated-output -n AccountsPayableService
namespace AccountsPayableService
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
    [XmlTypeAttribute("UpdateInvoiceNoteByIDRequest", Namespace="http://www.symxchange.generated.symitar.com/crud/accountspayable")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class UpdateInvoiceNoteByIdRequest
    {
        
        [XmlElementAttribute("VendorNumber", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string VendorNumber { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("InvoiceLocator", Order=1, Form=XmlSchemaForm.Unqualified)]
        public int InvoiceLocatorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the InvoiceLocator property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool InvoiceLocatorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> InvoiceLocator
        {
            get
            {
                if (this.InvoiceLocatorValueSpecified)
                {
                    return this.InvoiceLocatorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.InvoiceLocatorValue = value.GetValueOrDefault();
                this.InvoiceLocatorValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("InvoiceNoteLocator", Order=2, Form=XmlSchemaForm.Unqualified)]
        public int InvoiceNoteLocatorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the InvoiceNoteLocator property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool InvoiceNoteLocatorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> InvoiceNoteLocator
        {
            get
            {
                if (this.InvoiceNoteLocatorValueSpecified)
                {
                    return this.InvoiceNoteLocatorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.InvoiceNoteLocatorValue = value.GetValueOrDefault();
                this.InvoiceNoteLocatorValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Credentials", Order=3, Form=XmlSchemaForm.Unqualified)]
        public AccountsPayableService.AdminCredentialsChoice Credentials { get; set; }
        
        [XmlElementAttribute("DeviceInformation", Order=4, Form=XmlSchemaForm.Unqualified)]
        public AccountsPayableService.DeviceInformation DeviceInformation { get; set; }
        
        [XmlElementAttribute("InvoiceNoteFields", Order=5, Form=XmlSchemaForm.Unqualified)]
        public AccountsPayableService.InvoiceNoteFields_2 InvoiceNoteFields { get; set; }
        
        [XmlElementAttribute("Version_1", Order=6, Form=XmlSchemaForm.Unqualified)]
        public AccountsPayableService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=7)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="UpdateInvoiceNoteByIdRequest" /> class.</para>
        /// </summary>
        public UpdateInvoiceNoteByIdRequest()
        {
            this._any = new Collection<XmlElement>();
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlAttributeAttribute("MessageId")]
        public string MessageId { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlAttributeAttribute("BranchId", Namespace="http://www.symxchange.generated.symitar.com/crud/accountspayable", Form=XmlSchemaForm.Qualified)]
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
