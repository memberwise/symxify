//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\ProjectionService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\ProjectionService\generated-output -n ProjectionService
namespace ProjectionService
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
    [XmlTypeAttribute("CalculatePaymentAmountRequest", Namespace="http://www.symxchange.generated.symitar.com/noncrud/projection/dto")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class CalculatePaymentAmountRequest : LoanProjectionBaseRequest
    {
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: -999999999999.99.</para>
        /// <para xml:lang="en">Maximum inclusive value: 999999999999.99.</para>
        /// </summary>
        [RangeAttribute(typeof(decimal), "-999999999999.99", "999999999999.99")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LoanAmount", Order=0, Form=XmlSchemaForm.Unqualified)]
        public decimal LoanAmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LoanAmount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LoanAmountValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: -999999999999.99.</para>
        /// <para xml:lang="en">Maximum inclusive value: 999999999999.99.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public Nullable<decimal> LoanAmount
        {
            get
            {
                if (this.LoanAmountValueSpecified)
                {
                    return this.LoanAmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LoanAmountValue = value.GetValueOrDefault();
                this.LoanAmountValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MaturityDate", Order=1, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime MaturityDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaturityDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MaturityDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> MaturityDate
        {
            get
            {
                if (this.MaturityDateValueSpecified)
                {
                    return this.MaturityDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaturityDateValue = value.GetValueOrDefault();
                this.MaturityDateValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=2, Form=XmlSchemaForm.Unqualified)]
        public ProjectionService.VersionType Version1 { get; set; }
        
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CalculatePaymentAmountRequest" /> class.</para>
        /// </summary>
        public CalculatePaymentAmountRequest()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
