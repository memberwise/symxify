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
    [XmlTypeAttribute("updateExternalLoanTrackingByID", Namespace="http://www.symxchange.generated.symitar.com/crud/account", AnonymousType=true)]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("updateExternalLoanTrackingByID", Namespace="http://www.symxchange.generated.symitar.com/crud/account")]
    public partial class UpdateExternalLoanTrackingById
    {
        
        [XmlElementAttribute("Request", Order=0, Form=XmlSchemaForm.Unqualified)]
        public UpdateExternalLoanTrackingByIdRequest Request { get; set; }
    }
}
