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
    [XmlTypeAttribute("LoanTypeIdRangeFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("LoanTypeIdRangeFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class LoanTypeIdRangeFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IdRange", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool IdRangeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IdRange property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IdRangeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IdRange
        {
            get
            {
                if (this.IdRangeValueSpecified)
                {
                    return this.IdRangeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IdRangeValue = value.GetValueOrDefault();
                this.IdRangeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IdRangeHigh", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool IdRangeHighValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IdRangeHigh property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IdRangeHighValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IdRangeHigh
        {
            get
            {
                if (this.IdRangeHighValueSpecified)
                {
                    return this.IdRangeHighValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IdRangeHighValue = value.GetValueOrDefault();
                this.IdRangeHighValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IdRangeLow", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool IdRangeLowValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IdRangeLow property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IdRangeLowValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IdRangeLow
        {
            get
            {
                if (this.IdRangeLowValueSpecified)
                {
                    return this.IdRangeLowValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IdRangeLowValue = value.GetValueOrDefault();
                this.IdRangeLowValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LoanType", Order=3, Form=XmlSchemaForm.Unqualified)]
        public bool LoanTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LoanType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LoanTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> LoanType
        {
            get
            {
                if (this.LoanTypeValueSpecified)
                {
                    return this.LoanTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LoanTypeValue = value.GetValueOrDefault();
                this.LoanTypeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=4, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoanTypeIdRangeFields" /> class.</para>
        /// </summary>
        public LoanTypeIdRangeFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
