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
    [XmlTypeAttribute("GlHistorySingleSelectableFields", Namespace="http://www.symxchange.generated.symitar.com/crud/generalledger/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class GlHistorySingleSelectableFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IncludeAllGlHistoryFields", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool IncludeAllGlHistoryFieldsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IncludeAllGlHistoryFields property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IncludeAllGlHistoryFieldsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IncludeAllGlHistoryFields
        {
            get
            {
                if (this.IncludeAllGlHistoryFieldsValueSpecified)
                {
                    return this.IncludeAllGlHistoryFieldsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IncludeAllGlHistoryFieldsValue = value.GetValueOrDefault();
                this.IncludeAllGlHistoryFieldsValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("GlHistoryFields", Order=1, Form=XmlSchemaForm.Unqualified)]
        public GlHistoryFields GlHistoryFields { get; set; }
        
        [XmlElementAttribute("Version_1", Order=2, Form=XmlSchemaForm.Unqualified)]
        public GeneralLedgerService.VersionType Version1 { get; set; }
        
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
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="GlHistorySingleSelectableFields" /> class.</para>
        /// </summary>
        public GlHistorySingleSelectableFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
