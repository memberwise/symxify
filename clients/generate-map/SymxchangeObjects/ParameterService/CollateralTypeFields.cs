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
    [XmlTypeAttribute("CollateralTypeFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("CollateralTypeFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class CollateralTypeFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CollateralStatus", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool CollateralStatusValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CollateralStatus property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CollateralStatusValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CollateralStatus
        {
            get
            {
                if (this.CollateralStatusValueSpecified)
                {
                    return this.CollateralStatusValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CollateralStatusValue = value.GetValueOrDefault();
                this.CollateralStatusValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CollateralType", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool CollateralTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CollateralType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CollateralTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CollateralType
        {
            get
            {
                if (this.CollateralTypeValueSpecified)
                {
                    return this.CollateralTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CollateralTypeValue = value.GetValueOrDefault();
                this.CollateralTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Description", Order=2, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("RequiredDocTypes", Order=3, Form=XmlSchemaForm.Unqualified)]
        public bool RequiredDocTypesValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RequiredDocTypes property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RequiredDocTypesValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> RequiredDocTypes
        {
            get
            {
                if (this.RequiredDocTypesValueSpecified)
                {
                    return this.RequiredDocTypesValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RequiredDocTypesValue = value.GetValueOrDefault();
                this.RequiredDocTypesValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _userChar;
        
        [XmlElementAttribute("UserChar", Order=4, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> UserChar
        {
            get
            {
                return _userChar;
            }
            set
            {
                _userChar = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the UserChar collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool UserCharSpecified
        {
            get
            {
                return ((this.UserChar != null) 
                            && (this.UserChar.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CollateralTypeFields" /> class.</para>
        /// </summary>
        public CollateralTypeFields()
        {
            this._userChar = new Collection<short>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlElementAttribute("Version_1", Order=5, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=6)]
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
