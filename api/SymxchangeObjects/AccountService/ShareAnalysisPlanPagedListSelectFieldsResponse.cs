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
    [XmlTypeAttribute("ShareAnalysisPlanPagedListSelectFieldsResponse", Namespace="http://www.symxchange.generated.symitar.com/crud/account")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class ShareAnalysisPlanPagedListSelectFieldsResponse
    {
        
        [XmlIgnoreAttribute()]
        private Collection<AccountService.ShareAnalysisPlan> _shareAnalysisPlan;
        
        [XmlElementAttribute("ShareAnalysisPlan", Order=0, Form=XmlSchemaForm.Unqualified)]
        public Collection<AccountService.ShareAnalysisPlan> ShareAnalysisPlan
        {
            get
            {
                return _shareAnalysisPlan;
            }
            set
            {
                _shareAnalysisPlan = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ShareAnalysisPlan collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ShareAnalysisPlanSpecified
        {
            get
            {
                return ((this.ShareAnalysisPlan != null) 
                            && (this.ShareAnalysisPlan.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ShareAnalysisPlanPagedListSelectFieldsResponse" /> class.</para>
        /// </summary>
        public ShareAnalysisPlanPagedListSelectFieldsResponse()
        {
            this._shareAnalysisPlan = new Collection<AccountService.ShareAnalysisPlan>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlElementAttribute("Token", Order=1, Form=XmlSchemaForm.Unqualified)]
        public string Token { get; set; }
        
        [XmlElementAttribute("Version_1", Order=2, Form=XmlSchemaForm.Unqualified)]
        public AccountService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=3)]
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
        
        [XmlAttributeAttribute("MessageId")]
        public string MessageId { get; set; }
    }
}
