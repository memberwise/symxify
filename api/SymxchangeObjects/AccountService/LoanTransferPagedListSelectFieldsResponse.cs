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
    [XmlTypeAttribute("LoanTransferPagedListSelectFieldsResponse", Namespace="http://www.symxchange.generated.symitar.com/crud/account")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class LoanTransferPagedListSelectFieldsResponse
    {
        
        [XmlIgnoreAttribute()]
        private Collection<AccountService.LoanTransfer> _loanTransfer;
        
        [XmlElementAttribute("LoanTransfer", Order=0, Form=XmlSchemaForm.Unqualified)]
        public Collection<AccountService.LoanTransfer> LoanTransfer
        {
            get
            {
                return _loanTransfer;
            }
            set
            {
                _loanTransfer = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the LoanTransfer collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool LoanTransferSpecified
        {
            get
            {
                return ((this.LoanTransfer != null) 
                            && (this.LoanTransfer.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoanTransferPagedListSelectFieldsResponse" /> class.</para>
        /// </summary>
        public LoanTransferPagedListSelectFieldsResponse()
        {
            this._loanTransfer = new Collection<AccountService.LoanTransfer>();
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
