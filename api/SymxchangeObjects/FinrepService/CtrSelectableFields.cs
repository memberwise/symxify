//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\FinrepService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\FinrepService\generated-output -n FinrepService
namespace FinrepService
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
    [XmlTypeAttribute("CtrSelectableFields", Namespace="http://www.symxchange.generated.symitar.com/crud/finrep/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class CtrSelectableFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IncludeAllCtrFields", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool IncludeAllCtrFieldsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IncludeAllCtrFields property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IncludeAllCtrFieldsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IncludeAllCtrFields
        {
            get
            {
                if (this.IncludeAllCtrFieldsValueSpecified)
                {
                    return this.IncludeAllCtrFieldsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IncludeAllCtrFieldsValue = value.GetValueOrDefault();
                this.IncludeAllCtrFieldsValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("CtrFields", Order=1, Form=XmlSchemaForm.Unqualified)]
        public CtrFields CtrFields { get; set; }
        
        [XmlElementAttribute("CtrAccountSelectableFields", Order=2, Form=XmlSchemaForm.Unqualified)]
        public CtrAccountSelectableFields CtrAccountSelectableFields { get; set; }
        
        [XmlElementAttribute("CtrBranchSelectableFields", Order=3, Form=XmlSchemaForm.Unqualified)]
        public CtrBranchSelectableFields CtrBranchSelectableFields { get; set; }
        
        [XmlElementAttribute("CtrFmHistorySelectableFields", Order=4, Form=XmlSchemaForm.Unqualified)]
        public CtrFmHistorySelectableFields CtrFmHistorySelectableFields { get; set; }
        
        [XmlElementAttribute("CtrForeignSelectableFields", Order=5, Form=XmlSchemaForm.Unqualified)]
        public CtrForeignSelectableFields CtrForeignSelectableFields { get; set; }
        
        [XmlElementAttribute("CtrNoteSelectableFields", Order=6, Form=XmlSchemaForm.Unqualified)]
        public CtrNoteSelectableFields CtrNoteSelectableFields { get; set; }
        
        [XmlElementAttribute("CtrPersonSelectableFields", Order=7, Form=XmlSchemaForm.Unqualified)]
        public CtrPersonSelectableFields CtrPersonSelectableFields { get; set; }
        
        [XmlElementAttribute("Version_1", Order=8, Form=XmlSchemaForm.Unqualified)]
        public FinrepService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=9)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CtrSelectableFields" /> class.</para>
        /// </summary>
        public CtrSelectableFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
