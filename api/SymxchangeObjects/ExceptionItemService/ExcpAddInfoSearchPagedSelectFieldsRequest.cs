//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\ExceptionItemService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\ExceptionItemService\generated-output -n ExceptionItemService
namespace ExceptionItemService
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
    [XmlTypeAttribute("ExcpAddInfoSearchPagedSelectFieldsRequest", Namespace="http://www.symxchange.generated.symitar.com/crud/exceptionitem")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class ExcpAddInfoSearchPagedSelectFieldsRequest
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ExcpItemGlobalSequenceDate", Order=0, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime ExcpItemGlobalSequenceDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ExcpItemGlobalSequenceDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ExcpItemGlobalSequenceDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> ExcpItemGlobalSequenceDate
        {
            get
            {
                if (this.ExcpItemGlobalSequenceDateValueSpecified)
                {
                    return this.ExcpItemGlobalSequenceDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ExcpItemGlobalSequenceDateValue = value.GetValueOrDefault();
                this.ExcpItemGlobalSequenceDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ExcpItemGlobalSequence", Order=1, Form=XmlSchemaForm.Unqualified)]
        public int ExcpItemGlobalSequenceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ExcpItemGlobalSequence property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ExcpItemGlobalSequenceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> ExcpItemGlobalSequence
        {
            get
            {
                if (this.ExcpItemGlobalSequenceValueSpecified)
                {
                    return this.ExcpItemGlobalSequenceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ExcpItemGlobalSequenceValue = value.GetValueOrDefault();
                this.ExcpItemGlobalSequenceValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Credentials", Order=2, Form=XmlSchemaForm.Unqualified)]
        public ExceptionItemService.AdminCredentialsChoice Credentials { get; set; }
        
        [XmlElementAttribute("DeviceInformation", Order=3, Form=XmlSchemaForm.Unqualified)]
        public ExceptionItemService.DeviceInformation DeviceInformation { get; set; }
        
        [XmlElementAttribute("PagingRequestContext", Order=4, Form=XmlSchemaForm.Unqualified)]
        public ExceptionItemService.PagingRequestContext PagingRequestContext { get; set; }
        
        [XmlElementAttribute("SelectableFields", Order=5, Form=XmlSchemaForm.Unqualified)]
        public ExceptionItemService.ExcpAddInfoSingleSelectableFields SelectableFields { get; set; }
        
        [XmlElementAttribute("SearchFilter", Order=6, Form=XmlSchemaForm.Unqualified)]
        public ExceptionItemService.ExcpAddInfoSearchFilter SearchFilter { get; set; }
        
        [XmlElementAttribute("Version_1", Order=7, Form=XmlSchemaForm.Unqualified)]
        public ExceptionItemService.VersionType Version1 { get; set; }
        
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ExcpAddInfoSearchPagedSelectFieldsRequest" /> class.</para>
        /// </summary>
        public ExcpAddInfoSearchPagedSelectFieldsRequest()
        {
            this._any = new Collection<XmlElement>();
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlAttributeAttribute("MessageId")]
        public string MessageId { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlAttributeAttribute("BranchId", Namespace="http://www.symxchange.generated.symitar.com/crud/exceptionitem", Form=XmlSchemaForm.Qualified)]
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
