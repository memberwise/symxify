//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\ContactEventMgmtService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\ContactEventMgmtService\generated-output -n ContactEventMgmtService
namespace ContactEventMgmtService
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
    [XmlTypeAttribute("ContactEventMgmtBaseRequest", Namespace="http://www.symxchange.generated.symitar.com/noncrud/contacteventmgmt/dto")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(GetEventSummariesByAccountRequest))]
    public partial class ContactEventMgmtBaseRequest
    {
        
        [XmlElementAttribute("Credentials", Order=0, Form=XmlSchemaForm.Unqualified)]
        public ContactEventMgmtService.AdminCredentialsChoice Credentials { get; set; }
        
        [XmlElementAttribute("DeviceInformation", Order=1, Form=XmlSchemaForm.Unqualified)]
        public ContactEventMgmtService.DeviceInformation DeviceInformation { get; set; }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlAttributeAttribute("MessageId", Namespace="http://www.symxchange.generated.symitar.com/symxcommon", Form=XmlSchemaForm.Qualified)]
        public string MessageId { get; set; }
    }
}
