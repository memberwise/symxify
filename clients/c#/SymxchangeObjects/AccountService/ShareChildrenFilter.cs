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
    [XmlTypeAttribute("ShareChildrenFilter", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class ShareChildrenFilter
    {
        
        [XmlElementAttribute("ShareAnalysisFilter", Order=0, Form=XmlSchemaForm.Unqualified)]
        public ShareAnalysisFilter ShareAnalysisFilter { get; set; }
        
        [XmlElementAttribute("ShareAnalysisGroupFilter", Order=1, Form=XmlSchemaForm.Unqualified)]
        public ShareAnalysisGroupFilter ShareAnalysisGroupFilter { get; set; }
        
        [XmlElementAttribute("ShareAnalysisPlanFilter", Order=2, Form=XmlSchemaForm.Unqualified)]
        public ShareAnalysisPlanFilter ShareAnalysisPlanFilter { get; set; }
        
        [XmlElementAttribute("ShareCheckOrderFilter", Order=3, Form=XmlSchemaForm.Unqualified)]
        public ShareCheckOrderFilter ShareCheckOrderFilter { get; set; }
        
        [XmlElementAttribute("ShareHoldFilter", Order=4, Form=XmlSchemaForm.Unqualified)]
        public ShareHoldFilter ShareHoldFilter { get; set; }
        
        [XmlElementAttribute("ShareNameFilter", Order=5, Form=XmlSchemaForm.Unqualified)]
        public ShareNameFilter ShareNameFilter { get; set; }
        
        [XmlElementAttribute("ShareNoteFilter", Order=6, Form=XmlSchemaForm.Unqualified)]
        public ShareNoteFilter ShareNoteFilter { get; set; }
        
        [XmlElementAttribute("ShareTrackingFilter", Order=7, Form=XmlSchemaForm.Unqualified)]
        public ShareTrackingFilter ShareTrackingFilter { get; set; }
        
        [XmlElementAttribute("ShareTransactionFilter", Order=8, Form=XmlSchemaForm.Unqualified)]
        public ShareTransactionFilter ShareTransactionFilter { get; set; }
        
        [XmlElementAttribute("ShareTransferFilter", Order=9, Form=XmlSchemaForm.Unqualified)]
        public ShareTransferFilter ShareTransferFilter { get; set; }
        
        [XmlElementAttribute("Version_1", Order=10, Form=XmlSchemaForm.Unqualified)]
        public AccountService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=11)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ShareChildrenFilter" /> class.</para>
        /// </summary>
        public ShareChildrenFilter()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
