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
    [XmlTypeAttribute("InsTableSingleSelectableFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class InsTableSingleSelectableFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IncludeAllInsTableFields", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool IncludeAllInsTableFieldsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IncludeAllInsTableFields property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IncludeAllInsTableFieldsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IncludeAllInsTableFields
        {
            get
            {
                if (this.IncludeAllInsTableFieldsValueSpecified)
                {
                    return this.IncludeAllInsTableFieldsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IncludeAllInsTableFieldsValue = value.GetValueOrDefault();
                this.IncludeAllInsTableFieldsValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("InsTableFields", Order=1, Form=XmlSchemaForm.Unqualified)]
        public InsTableFields InsTableFields { get; set; }
        
        [XmlElementAttribute("Version_1", Order=2, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="InsTableSingleSelectableFields" /> class.</para>
        /// </summary>
        public InsTableSingleSelectableFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
