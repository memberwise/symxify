//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\FindbyService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\FindbyService\generated-output -n FindByService
namespace FindByService
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
    [XmlTypeAttribute("LookupByShortNameRequest", Namespace="http://www.symxchange.generated.symitar.com/noncrud/findby/dto")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class LookupByShortNameRequest
    {
        
        [XmlElementAttribute("Credentials", Order=0, Form=XmlSchemaForm.Unqualified)]
        public FindByService.AdminCredentialsChoice Credentials { get; set; }
        
        [XmlElementAttribute("DeviceInformation", Order=1, Form=XmlSchemaForm.Unqualified)]
        public FindByService.DeviceInformation DeviceInformation { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 16.</para>
        /// </summary>
        [MinLengthAttribute(1)]
        [MaxLengthAttribute(16)]
        [XmlElementAttribute("ShortName", Order=2, Form=XmlSchemaForm.Unqualified)]
        public string ShortName { get; set; }
        
        [XmlElementAttribute("Version_1", Order=3, Form=XmlSchemaForm.Unqualified)]
        public FindByService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=4)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LookupByShortNameRequest" /> class.</para>
        /// </summary>
        public LookupByShortNameRequest()
        {
            this._any = new Collection<XmlElement>();
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlAttributeAttribute("MessageId", Namespace="http://www.symxchange.generated.symitar.com/symxcommon", Form=XmlSchemaForm.Qualified)]
        public string MessageId { get; set; }
    }
}
