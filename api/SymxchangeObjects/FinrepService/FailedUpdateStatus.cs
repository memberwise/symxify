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
    [XmlTypeAttribute("FailedUpdateStatus", Namespace="http://www.symxchange.generated.symitar.com/symxcommon")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class FailedUpdateStatus
    {
        
        [XmlElementAttribute("Record", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string Record { get; set; }
        
        [XmlElementAttribute("ErrorCode", Order=1, Form=XmlSchemaForm.Unqualified)]
        public string ErrorCode { get; set; }
        
        [XmlElementAttribute("ErrorMessage", Order=2, Form=XmlSchemaForm.Unqualified)]
        public string ErrorMessage { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<PrimaryKeyField> _primaryKeyField;
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("PrimaryKeyField", Order=3, Form=XmlSchemaForm.Unqualified)]
        public Collection<PrimaryKeyField> PrimaryKeyField
        {
            get
            {
                return _primaryKeyField;
            }
            set
            {
                _primaryKeyField = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="FailedUpdateStatus" /> class.</para>
        /// </summary>
        public FailedUpdateStatus()
        {
            this._primaryKeyField = new Collection<PrimaryKeyField>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlElementAttribute("Version_1", Order=4, Form=XmlSchemaForm.Unqualified)]
        public VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=5)]
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
    }
}
