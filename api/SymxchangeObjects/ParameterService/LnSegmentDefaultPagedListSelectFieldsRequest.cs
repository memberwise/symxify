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
    [XmlTypeAttribute("LnSegmentDefaultPagedListSelectFieldsRequest", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class LnSegmentDefaultPagedListSelectFieldsRequest
    {
        
        [XmlElementAttribute("Credentials", Order=0, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.AdminCredentialsChoice Credentials { get; set; }
        
        [XmlElementAttribute("DeviceInformation", Order=1, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.DeviceInformation DeviceInformation { get; set; }
        
        [XmlElementAttribute("PagingRequestContext", Order=2, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.PagingRequestContext PagingRequestContext { get; set; }
        
        [XmlElementAttribute("SelectableFields", Order=3, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.LnSegmentDefaultSingleSelectableFields SelectableFields { get; set; }
        
        [XmlElementAttribute("Version_1", Order=4, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=5)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LnSegmentDefaultPagedListSelectFieldsRequest" /> class.</para>
        /// </summary>
        public LnSegmentDefaultPagedListSelectFieldsRequest()
        {
            this._any = new Collection<XmlElement>();
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlAttributeAttribute("MessageId")]
        public string MessageId { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlAttributeAttribute("BranchId", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter", Form=XmlSchemaForm.Qualified)]
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
