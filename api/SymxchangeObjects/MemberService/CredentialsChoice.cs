//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\MemberService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\MemberService\generated-output -n MemberService
namespace MemberService
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
    [XmlTypeAttribute("CredentialsChoice", Namespace="http://www.symxchange.generated.symitar.com/symxcommon")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class CredentialsChoice
    {
        
        [XmlElementAttribute("AccountNumberCredentials", Order=0, Form=XmlSchemaForm.Unqualified)]
        public AccountNumberCredentials AccountNumberCredentials { get; set; }
        
        [XmlElementAttribute("HomeBankingCredentials", Order=1, Form=XmlSchemaForm.Unqualified)]
        public HomeBankingCredentials HomeBankingCredentials { get; set; }
        
        [XmlElementAttribute("CardCredentials", Order=2, Form=XmlSchemaForm.Unqualified)]
        public CardCredentials CardCredentials { get; set; }
        
        [XmlElementAttribute("MICRCredentials", Order=3, Form=XmlSchemaForm.Unqualified)]
        public MicrCredentials MicrCredentials { get; set; }
        
        [XmlElementAttribute("LookupCredentials", Order=4, Form=XmlSchemaForm.Unqualified)]
        public LookupCredentials LookupCredentials { get; set; }
        
        [XmlElementAttribute("UserNumberCredentials", Order=5, Form=XmlSchemaForm.Unqualified)]
        public UserNumberCredentials UserNumberCredentials { get; set; }
        
        [XmlElementAttribute("AdministrativeCredentials", Order=6, Form=XmlSchemaForm.Unqualified)]
        public AdministrativeCredentials AdministrativeCredentials { get; set; }
        
        [XmlElementAttribute("TokenCredentials", Order=7, Form=XmlSchemaForm.Unqualified)]
        public TokenCredentials TokenCredentials { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 9999.</para>
        /// </summary>
        [RangeAttribute(typeof(short), "0", "9999")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlAttributeAttribute("ProcessorUser", Namespace="http://www.symxchange.generated.symitar.com/symxcommon", Form=XmlSchemaForm.Qualified)]
        public short ProcessorUserValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ProcessorUser property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ProcessorUserValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 9999.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public Nullable<short> ProcessorUser
        {
            get
            {
                if (this.ProcessorUserValueSpecified)
                {
                    return this.ProcessorUserValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ProcessorUserValue = value.GetValueOrDefault();
                this.ProcessorUserValueSpecified = value.HasValue;
            }
        }
    }
}
