//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\PoweronService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\PoweronService\generated-output -n PowerOnService
namespace PowerOnService
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
    [XmlTypeAttribute("PromptRgDataType", Namespace="http://www.symxchange.generated.symitar.com/noncrud/poweron/dto", AnonymousType=true)]
    public enum PromptRgDataType
    {
        
        [XmlEnumAttribute("NO_INPUT_REQUIRED")]
        NoInputRequired,
        
        [XmlEnumAttribute("STRING")]
        String,
        
        [XmlEnumAttribute("RATE")]
        Rate,
        
        [XmlEnumAttribute("DATE")]
        Date,
        
        [XmlEnumAttribute("NUMBER")]
        Number,
        
        [XmlEnumAttribute("CODE")]
        Code,
        
        [XmlEnumAttribute("YES_NO")]
        YesNo,
        
        [XmlEnumAttribute("MONEY")]
        Money,
        
        [XmlEnumAttribute("BIG_MONEY")]
        BigMoney,
        
        [XmlEnumAttribute("END")]
        End,
    }
}
