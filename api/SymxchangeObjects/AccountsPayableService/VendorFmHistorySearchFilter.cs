//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\AccountsPayableService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\AccountsPayableService\generated-output -n AccountsPayableService
namespace AccountsPayableService
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
    [XmlTypeAttribute("VendorFmHistorySearchFilter", Namespace="http://www.symxchange.generated.symitar.com/crud/accountspayable/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class VendorFmHistorySearchFilter
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("StartPostDate", Order=0, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime StartPostDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the StartPostDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool StartPostDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> StartPostDate
        {
            get
            {
                if (this.StartPostDateValueSpecified)
                {
                    return this.StartPostDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StartPostDateValue = value.GetValueOrDefault();
                this.StartPostDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EndPostDate", Order=1, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime EndPostDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EndPostDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EndPostDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> EndPostDate
        {
            get
            {
                if (this.EndPostDateValueSpecified)
                {
                    return this.EndPostDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EndPostDateValue = value.GetValueOrDefault();
                this.EndPostDateValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Query", Order=2, Form=XmlSchemaForm.Unqualified)]
        public string Query { get; set; }
        
        [XmlElementAttribute("Version_1", Order=3, Form=XmlSchemaForm.Unqualified)]
        public AccountsPayableService.VersionType Version1 { get; set; }
        
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="VendorFmHistorySearchFilter" /> class.</para>
        /// </summary>
        public VendorFmHistorySearchFilter()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
