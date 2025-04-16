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
    [XmlTypeAttribute("ShareSelectableFields", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class ShareSelectableFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IncludeAllShareFields", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool IncludeAllShareFieldsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IncludeAllShareFields property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IncludeAllShareFieldsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IncludeAllShareFields
        {
            get
            {
                if (this.IncludeAllShareFieldsValueSpecified)
                {
                    return this.IncludeAllShareFieldsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IncludeAllShareFieldsValue = value.GetValueOrDefault();
                this.IncludeAllShareFieldsValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("ShareFields", Order=1, Form=XmlSchemaForm.Unqualified)]
        public ShareFields ShareFields { get; set; }
        
        [XmlElementAttribute("ShareAnalysisSelectableFields", Order=2, Form=XmlSchemaForm.Unqualified)]
        public ShareAnalysisSelectableFields ShareAnalysisSelectableFields { get; set; }
        
        [XmlElementAttribute("ShareAnalysisGroupSelectableFields", Order=3, Form=XmlSchemaForm.Unqualified)]
        public ShareAnalysisGroupSelectableFields ShareAnalysisGroupSelectableFields { get; set; }
        
        [XmlElementAttribute("ShareAnalysisPlanSelectableFields", Order=4, Form=XmlSchemaForm.Unqualified)]
        public ShareAnalysisPlanSelectableFields ShareAnalysisPlanSelectableFields { get; set; }
        
        [XmlElementAttribute("ShareCheckOrderSelectableFields", Order=5, Form=XmlSchemaForm.Unqualified)]
        public ShareCheckOrderSelectableFields ShareCheckOrderSelectableFields { get; set; }
        
        [XmlElementAttribute("ShareHoldSelectableFields", Order=6, Form=XmlSchemaForm.Unqualified)]
        public ShareHoldSelectableFields ShareHoldSelectableFields { get; set; }
        
        [XmlElementAttribute("ShareNameSelectableFields", Order=7, Form=XmlSchemaForm.Unqualified)]
        public ShareNameSelectableFields ShareNameSelectableFields { get; set; }
        
        [XmlElementAttribute("ShareNoteSelectableFields", Order=8, Form=XmlSchemaForm.Unqualified)]
        public ShareNoteSelectableFields ShareNoteSelectableFields { get; set; }
        
        [XmlElementAttribute("ShareTrackingSelectableFields", Order=9, Form=XmlSchemaForm.Unqualified)]
        public ShareTrackingSelectableFields ShareTrackingSelectableFields { get; set; }
        
        [XmlElementAttribute("ShareTransactionSelectableFields", Order=10, Form=XmlSchemaForm.Unqualified)]
        public ShareTransactionSelectableFields ShareTransactionSelectableFields { get; set; }
        
        [XmlElementAttribute("ShareTransferSelectableFields", Order=11, Form=XmlSchemaForm.Unqualified)]
        public ShareTransferSelectableFields ShareTransferSelectableFields { get; set; }
        
        [XmlElementAttribute("Version_1", Order=12, Form=XmlSchemaForm.Unqualified)]
        public AccountService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=13)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ShareSelectableFields" /> class.</para>
        /// </summary>
        public ShareSelectableFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
