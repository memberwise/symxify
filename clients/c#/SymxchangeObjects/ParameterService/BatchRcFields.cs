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
    [XmlTypeAttribute("BatchRcFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("BatchRcFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class BatchRcFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BatchReturnCode", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool BatchReturnCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BatchReturnCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BatchReturnCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> BatchReturnCode
        {
            get
            {
                if (this.BatchReturnCodeValueSpecified)
                {
                    return this.BatchReturnCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BatchReturnCodeValue = value.GetValueOrDefault();
                this.BatchReturnCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BatchReturnCodeDefinedType", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool BatchReturnCodeDefinedTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BatchReturnCodeDefinedType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BatchReturnCodeDefinedTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> BatchReturnCodeDefinedType
        {
            get
            {
                if (this.BatchReturnCodeDefinedTypeValueSpecified)
                {
                    return this.BatchReturnCodeDefinedTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BatchReturnCodeDefinedTypeValue = value.GetValueOrDefault();
                this.BatchReturnCodeDefinedTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BatchReturnCodeDescription", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool BatchReturnCodeDescriptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BatchReturnCodeDescription property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BatchReturnCodeDescriptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> BatchReturnCodeDescription
        {
            get
            {
                if (this.BatchReturnCodeDescriptionValueSpecified)
                {
                    return this.BatchReturnCodeDescriptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BatchReturnCodeDescriptionValue = value.GetValueOrDefault();
                this.BatchReturnCodeDescriptionValueSpecified = value.HasValue;
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
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="BatchRcFields" /> class.</para>
        /// </summary>
        public BatchRcFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
