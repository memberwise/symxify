//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\GeneralLedgerService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\GeneralLedgerService\generated-output -n GeneralLedgerService
namespace GeneralLedgerService
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
    [XmlTypeAttribute("Identification", Namespace="http://www.symxchange.generated.symitar.com/symxcommon")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class Identification
    {
        
        /// <summary>
        /// <para xml:lang="en">Maximum length: 20.</para>
        /// </summary>
        [MaxLengthAttribute(20)]
        [XmlElementAttribute("HomeBankingUserName", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string HomeBankingUserName { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 999.</para>
        /// </summary>
        [RangeAttribute(typeof(short), "1", "999")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserCode", Order=1, Form=XmlSchemaForm.Unqualified)]
        public short UserCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserCodeValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 999.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public Nullable<short> UserCode
        {
            get
            {
                if (this.UserCodeValueSpecified)
                {
                    return this.UserCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserCodeValue = value.GetValueOrDefault();
                this.UserCodeValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Maximum length: 10.</para>
        /// </summary>
        [MaxLengthAttribute(10)]
        [XmlElementAttribute("LoginAccountNumber", Order=2, Form=XmlSchemaForm.Unqualified)]
        public string LoginAccountNumber { get; set; }
        
        [XmlElementAttribute("Version_1", Order=3, Form=XmlSchemaForm.Unqualified)]
        public VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=4)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Identification" /> class.</para>
        /// </summary>
        public Identification()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
