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
    [XmlTypeAttribute("MoProductFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("MoProductFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class MoProductFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CreateCheckRecord", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool CreateCheckRecordValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CreateCheckRecord property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CreateCheckRecordValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CreateCheckRecord
        {
            get
            {
                if (this.CreateCheckRecordValueSpecified)
                {
                    return this.CreateCheckRecordValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CreateCheckRecordValue = value.GetValueOrDefault();
                this.CreateCheckRecordValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NumberofProducts", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool NumberofProductsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NumberofProducts property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NumberofProductsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> NumberofProducts
        {
            get
            {
                if (this.NumberofProductsValueSpecified)
                {
                    return this.NumberofProductsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NumberofProductsValue = value.GetValueOrDefault();
                this.NumberofProductsValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _productDescription;
        
        [XmlElementAttribute("ProductDescription", Order=2, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> ProductDescription
        {
            get
            {
                return _productDescription;
            }
            set
            {
                _productDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ProductDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ProductDescriptionSpecified
        {
            get
            {
                return ((this.ProductDescription != null) 
                            && (this.ProductDescription.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="MoProductFields" /> class.</para>
        /// </summary>
        public MoProductFields()
        {
            this._productDescription = new Collection<short>();
            this._any = new Collection<XmlElement>();
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
