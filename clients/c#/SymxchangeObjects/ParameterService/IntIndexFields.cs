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
    [XmlTypeAttribute("IntIndexFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("IntIndexFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class IntIndexFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("DefinedCode", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool DefinedCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DefinedCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DefinedCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> DefinedCode
        {
            get
            {
                if (this.DefinedCodeValueSpecified)
                {
                    return this.DefinedCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DefinedCodeValue = value.GetValueOrDefault();
                this.DefinedCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Description", Order=1, Form=XmlSchemaForm.Unqualified)]
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
        
        [XmlIgnoreAttribute()]
        private Collection<short> _effectiveDate;
        
        [XmlElementAttribute("EffectiveDate", Order=2, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> EffectiveDate
        {
            get
            {
                return _effectiveDate;
            }
            set
            {
                _effectiveDate = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the EffectiveDate collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool EffectiveDateSpecified
        {
            get
            {
                return ((this.EffectiveDate != null) 
                            && (this.EffectiveDate.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="IntIndexFields" /> class.</para>
        /// </summary>
        public IntIndexFields()
        {
            this._effectiveDate = new Collection<short>();
            this._indexRate = new Collection<short>();
            this._any = new Collection<XmlElement>();
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IndexFrequency", Order=3, Form=XmlSchemaForm.Unqualified)]
        public bool IndexFrequencyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IndexFrequency property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IndexFrequencyValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IndexFrequency
        {
            get
            {
                if (this.IndexFrequencyValueSpecified)
                {
                    return this.IndexFrequencyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IndexFrequencyValue = value.GetValueOrDefault();
                this.IndexFrequencyValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _indexRate;
        
        [XmlElementAttribute("IndexRate", Order=4, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> IndexRate
        {
            get
            {
                return _indexRate;
            }
            set
            {
                _indexRate = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the IndexRate collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool IndexRateSpecified
        {
            get
            {
                return ((this.IndexRate != null) 
                            && (this.IndexRate.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IndexSource", Order=5, Form=XmlSchemaForm.Unqualified)]
        public bool IndexSourceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IndexSource property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IndexSourceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IndexSource
        {
            get
            {
                if (this.IndexSourceValueSpecified)
                {
                    return this.IndexSourceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IndexSourceValue = value.GetValueOrDefault();
                this.IndexSourceValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("InterestRateIndex", Order=6, Form=XmlSchemaForm.Unqualified)]
        public bool InterestRateIndexValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the InterestRateIndex property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool InterestRateIndexValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> InterestRateIndex
        {
            get
            {
                if (this.InterestRateIndexValueSpecified)
                {
                    return this.InterestRateIndexValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.InterestRateIndexValue = value.GetValueOrDefault();
                this.InterestRateIndexValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Type", Order=7, Form=XmlSchemaForm.Unqualified)]
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
        
        [XmlElementAttribute("Version_1", Order=8, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=9)]
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
