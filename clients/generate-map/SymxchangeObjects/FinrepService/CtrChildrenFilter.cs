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
    [XmlTypeAttribute("CtrChildrenFilter", Namespace="http://www.symxchange.generated.symitar.com/crud/finrep/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class CtrChildrenFilter
    {
        
        [XmlElementAttribute("CtrAccountFilter", Order=0, Form=XmlSchemaForm.Unqualified)]
        public CtrAccountFilter CtrAccountFilter { get; set; }
        
        [XmlElementAttribute("CtrBranchFilter", Order=1, Form=XmlSchemaForm.Unqualified)]
        public CtrBranchFilter CtrBranchFilter { get; set; }
        
        [XmlElementAttribute("CtrFmHistoryFilter", Order=2, Form=XmlSchemaForm.Unqualified)]
        public CtrFmHistoryFilter CtrFmHistoryFilter { get; set; }
        
        [XmlElementAttribute("CtrForeignFilter", Order=3, Form=XmlSchemaForm.Unqualified)]
        public CtrForeignFilter CtrForeignFilter { get; set; }
        
        [XmlElementAttribute("CtrNoteFilter", Order=4, Form=XmlSchemaForm.Unqualified)]
        public CtrNoteFilter CtrNoteFilter { get; set; }
        
        [XmlElementAttribute("CtrPersonFilter", Order=5, Form=XmlSchemaForm.Unqualified)]
        public CtrPersonFilter CtrPersonFilter { get; set; }
        
        [XmlElementAttribute("Version_1", Order=6, Form=XmlSchemaForm.Unqualified)]
        public FinrepService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=7)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CtrChildrenFilter" /> class.</para>
        /// </summary>
        public CtrChildrenFilter()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
