//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\ParameterService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\ParameterService\generated-output -n ParameterService
namespace ParameterService
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
    [XmlTypeAttribute("LoanAppCopiedFlds", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("LoanAppCopiedFlds", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class LoanAppCopiedFlds
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ApplicationType", Order=0, Form=XmlSchemaForm.Unqualified)]
        public short ApplicationTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ApplicationType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ApplicationTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> ApplicationType
        {
            get
            {
                if (this.ApplicationTypeValueSpecified)
                {
                    return this.ApplicationTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ApplicationTypeValue = value.GetValueOrDefault();
                this.ApplicationTypeValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<LoanAppCopiedFldsCopiedField> _copiedField;
        
        [XmlElementAttribute("CopiedField", Order=1, Form=XmlSchemaForm.Unqualified)]
        public Collection<LoanAppCopiedFldsCopiedField> CopiedField
        {
            get
            {
                return _copiedField;
            }
            set
            {
                _copiedField = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CopiedField collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CopiedFieldSpecified
        {
            get
            {
                return ((this.CopiedField != null) 
                            && (this.CopiedField.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoanAppCopiedFlds" /> class.</para>
        /// </summary>
        public LoanAppCopiedFlds()
        {
            this._copiedField = new Collection<LoanAppCopiedFldsCopiedField>();
            this._subField = new Collection<LoanAppCopiedFldsSubField>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<LoanAppCopiedFldsSubField> _subField;
        
        [XmlElementAttribute("SubField", Order=2, Form=XmlSchemaForm.Unqualified)]
        public Collection<LoanAppCopiedFldsSubField> SubField
        {
            get
            {
                return _subField;
            }
            set
            {
                _subField = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the SubField collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SubFieldSpecified
        {
            get
            {
                return ((this.SubField != null) 
                            && (this.SubField.Count != 0));
            }
        }
        
        [XmlElementAttribute("Version_1", Order=3, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
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
    }
}
