//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\FilemanagementService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\FilemanagementService\generated-output -n FileManagementService
namespace FileManagementService
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
    [XmlTypeAttribute("uploadDataFile", Namespace="http://www.symxchange.generated.symitar.com/noncrud/filemanagement", AnonymousType=true)]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("uploadDataFile", Namespace="http://www.symxchange.generated.symitar.com/noncrud/filemanagement")]
    public partial class UploadDataFile
    {
        
        [XmlElementAttribute("Request", Order=0, Form=XmlSchemaForm.Unqualified)]
        public FileManagementService.UploadRequest Request { get; set; }
    }
}
