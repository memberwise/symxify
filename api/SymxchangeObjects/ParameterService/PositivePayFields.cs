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
    [XmlTypeAttribute("PositivePayFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("PositivePayFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class PositivePayFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Description", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool DescriptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Description property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DescriptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Description
        {
            get
            {
                if (this.DescriptionValueSpecified)
                {
                    return this.DescriptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DescriptionValue = value.GetValueOrDefault();
                this.DescriptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Type", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool TypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Type property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Type
        {
            get
            {
                if (this.TypeValueSpecified)
                {
                    return this.TypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TypeValue = value.GetValueOrDefault();
                this.TypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("VendorId", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool VendorIdValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the VendorId property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool VendorIdValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> VendorId
        {
            get
            {
                if (this.VendorIdValueSpecified)
                {
                    return this.VendorIdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.VendorIdValue = value.GetValueOrDefault();
                this.VendorIdValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("VendorIndex", Order=3, Form=XmlSchemaForm.Unqualified)]
        public bool VendorIndexValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the VendorIndex property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool VendorIndexValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> VendorIndex
        {
            get
            {
                if (this.VendorIndexValueSpecified)
                {
                    return this.VendorIndexValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.VendorIndexValue = value.GetValueOrDefault();
                this.VendorIndexValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("VendorToken", Order=4, Form=XmlSchemaForm.Unqualified)]
        public bool VendorTokenValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the VendorToken property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool VendorTokenValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> VendorToken
        {
            get
            {
                if (this.VendorTokenValueSpecified)
                {
                    return this.VendorTokenValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.VendorTokenValue = value.GetValueOrDefault();
                this.VendorTokenValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("VendorUrl", Order=5, Form=XmlSchemaForm.Unqualified)]
        public bool VendorUrlValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the VendorUrl property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool VendorUrlValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> VendorUrl
        {
            get
            {
                if (this.VendorUrlValueSpecified)
                {
                    return this.VendorUrlValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.VendorUrlValue = value.GetValueOrDefault();
                this.VendorUrlValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=6, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="PositivePayFields" /> class.</para>
        /// </summary>
        public PositivePayFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
