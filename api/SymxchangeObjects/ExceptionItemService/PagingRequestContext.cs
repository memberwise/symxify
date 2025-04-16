//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\ExceptionItemService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\ExceptionItemService\generated-output -n ExceptionItemService
namespace ExceptionItemService
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
    [XmlTypeAttribute("PagingRequestContext", Namespace="http://www.symxchange.generated.symitar.com/symxcommon")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class PagingRequestContext
    {
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NumberOfRecordsToReturn", Order=0, Form=XmlSchemaForm.Unqualified)]
        public int NumberOfRecordsToReturnValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NumberOfRecordsToReturn property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NumberOfRecordsToReturnValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public Nullable<int> NumberOfRecordsToReturn
        {
            get
            {
                if (this.NumberOfRecordsToReturnValueSpecified)
                {
                    return this.NumberOfRecordsToReturnValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NumberOfRecordsToReturnValue = value.GetValueOrDefault();
                this.NumberOfRecordsToReturnValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NumberOfRecordsToSkip", Order=1, Form=XmlSchemaForm.Unqualified)]
        public int NumberOfRecordsToSkipValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NumberOfRecordsToSkip property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NumberOfRecordsToSkipValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public Nullable<int> NumberOfRecordsToSkip
        {
            get
            {
                if (this.NumberOfRecordsToSkipValueSpecified)
                {
                    return this.NumberOfRecordsToSkipValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NumberOfRecordsToSkipValue = value.GetValueOrDefault();
                this.NumberOfRecordsToSkipValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Token", Order=2, Form=XmlSchemaForm.Unqualified)]
        public string Token { get; set; }
        
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="PagingRequestContext" /> class.</para>
        /// </summary>
        public PagingRequestContext()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
