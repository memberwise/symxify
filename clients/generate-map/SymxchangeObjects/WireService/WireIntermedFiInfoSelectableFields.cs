//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\WireService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\WireService\generated-output -n WireService
namespace WireService
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
    [XmlTypeAttribute("WireIntermedFiInfoSelectableFields", Namespace="http://www.symxchange.generated.symitar.com/crud/wire/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class WireIntermedFiInfoSelectableFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IncludeAllWireIntermedFiInfoFields", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool IncludeAllWireIntermedFiInfoFieldsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IncludeAllWireIntermedFiInfoFields property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IncludeAllWireIntermedFiInfoFieldsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IncludeAllWireIntermedFiInfoFields
        {
            get
            {
                if (this.IncludeAllWireIntermedFiInfoFieldsValueSpecified)
                {
                    return this.IncludeAllWireIntermedFiInfoFieldsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IncludeAllWireIntermedFiInfoFieldsValue = value.GetValueOrDefault();
                this.IncludeAllWireIntermedFiInfoFieldsValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("WireIntermedFiInfoFields", Order=1, Form=XmlSchemaForm.Unqualified)]
        public WireIntermedFiInfoFields WireIntermedFiInfoFields { get; set; }
        
        [XmlElementAttribute("Version_1", Order=2, Form=XmlSchemaForm.Unqualified)]
        public WireService.VersionType Version1 { get; set; }
        
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WireIntermedFiInfoSelectableFields" /> class.</para>
        /// </summary>
        public WireIntermedFiInfoSelectableFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
