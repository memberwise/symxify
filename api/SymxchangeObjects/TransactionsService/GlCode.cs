//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\TransactionsService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\TransactionsService\generated-output -n TransactionsService
namespace TransactionsService
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
    [XmlTypeAttribute("GLCode", Namespace="http://www.symxchange.generated.symitar.com/noncrud/transactions/dto")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(DonorGlCode))]
    [XmlIncludeAttribute(typeof(RecipientGlCode))]
    public partial class GlCode
    {
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// <para xml:lang="en">Maximum length: 13.</para>
        /// </summary>
        [MaxLengthAttribute(13)]
        [XmlTextAttribute()]
        public string Value { get; set; }
        
        [XmlIgnoreAttribute()]
        private GlCodeTypeItem _type = TransactionsService.GlCodeTypeItem.User;
        
        [DefaultValueAttribute(TransactionsService.GlCodeTypeItem.User)]
        [XmlAttributeAttribute("type")]
        public GlCodeTypeItem Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
    }
}
