//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\EcaaService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\EcaaService\generated-output -n EcaaService
namespace EcaaService
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
    [XmlTypeAttribute("authenticateResult", Namespace="http://www.symxchange.generated.symitar.com/noncrud/ecaa/dto")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(AuthenticateWithAuthorizationResult))]
    public partial class AuthenticateResult : CommonResult
    {
        
        [XmlElementAttribute("SAMLAssertion", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string SamlAssertion { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<string> _authorizedSym;
        
        [XmlElementAttribute("AuthorizedSym", Order=1, Form=XmlSchemaForm.Unqualified)]
        public Collection<string> AuthorizedSym
        {
            get
            {
                return _authorizedSym;
            }
            set
            {
                _authorizedSym = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the AuthorizedSym collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AuthorizedSymSpecified
        {
            get
            {
                return ((this.AuthorizedSym != null) 
                            && (this.AuthorizedSym.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AuthenticateResult" /> class.</para>
        /// </summary>
        public AuthenticateResult()
        {
            this._authorizedSym = new Collection<string>();
        }
    }
}
