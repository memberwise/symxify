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
    [XmlTypeAttribute("ExcpItemSelectableFields", Namespace="http://www.symxchange.generated.symitar.com/crud/exceptionitem/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class ExcpItemSelectableFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IncludeAllExcpItemFields", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool IncludeAllExcpItemFieldsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IncludeAllExcpItemFields property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IncludeAllExcpItemFieldsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IncludeAllExcpItemFields
        {
            get
            {
                if (this.IncludeAllExcpItemFieldsValueSpecified)
                {
                    return this.IncludeAllExcpItemFieldsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IncludeAllExcpItemFieldsValue = value.GetValueOrDefault();
                this.IncludeAllExcpItemFieldsValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("ExcpItemFields", Order=1, Form=XmlSchemaForm.Unqualified)]
        public ExcpItemFields ExcpItemFields { get; set; }
        
        [XmlElementAttribute("ExcpAddInfoSelectableFields", Order=2, Form=XmlSchemaForm.Unqualified)]
        public ExcpAddInfoSelectableFields ExcpAddInfoSelectableFields { get; set; }
        
        [XmlElementAttribute("ExcpAddendaSelectableFields", Order=3, Form=XmlSchemaForm.Unqualified)]
        public ExcpAddendaSelectableFields ExcpAddendaSelectableFields { get; set; }
        
        [XmlElementAttribute("Version_1", Order=4, Form=XmlSchemaForm.Unqualified)]
        public ExceptionItemService.VersionType Version1 { get; set; }
        
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
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ExcpItemSelectableFields" /> class.</para>
        /// </summary>
        public ExcpItemSelectableFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
