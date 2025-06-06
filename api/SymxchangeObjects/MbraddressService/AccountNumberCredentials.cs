//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\MbrAddressService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\MbrAddressService\generated-output -n MbraddressService
namespace MbraddressService
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
    [XmlTypeAttribute("AccountNumberCredentials", Namespace="http://www.symxchange.generated.symitar.com/symxcommon")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class AccountNumberCredentials
    {
        
        /// <summary>
        /// <para xml:lang="en">Maximum length: 10.</para>
        /// </summary>
        [MaxLengthAttribute(10)]
        [XmlElementAttribute("AccountNumber", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string AccountNumber { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 999.</para>
        /// </summary>
        [RangeAttribute(typeof(short), "1", "999")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("OptionalUserCode", Order=1, Form=XmlSchemaForm.Unqualified)]
        public short OptionalUserCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OptionalUserCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OptionalUserCodeValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 999.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public Nullable<short> OptionalUserCode
        {
            get
            {
                if (this.OptionalUserCodeValueSpecified)
                {
                    return this.OptionalUserCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OptionalUserCodeValue = value.GetValueOrDefault();
                this.OptionalUserCodeValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Maximum length: 20.</para>
        /// </summary>
        [MaxLengthAttribute(20)]
        [XmlElementAttribute("HomeBankingPassword", Order=2, Form=XmlSchemaForm.Unqualified)]
        public string HomeBankingPassword { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Maximum length: 15.</para>
        /// </summary>
        [MaxLengthAttribute(15)]
        [XmlElementAttribute("AudioAccessCode", Order=3, Form=XmlSchemaForm.Unqualified)]
        public string AudioAccessCode { get; set; }
        
        [XmlElementAttribute("SecondaryVerification", Order=4, Form=XmlSchemaForm.Unqualified)]
        public SecondaryVerification SecondaryVerification { get; set; }
        
        [XmlElementAttribute("Version_1", Order=5, Form=XmlSchemaForm.Unqualified)]
        public VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=6)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AccountNumberCredentials" /> class.</para>
        /// </summary>
        public AccountNumberCredentials()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
