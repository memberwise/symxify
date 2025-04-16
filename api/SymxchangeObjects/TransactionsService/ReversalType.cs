//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\TransactionsService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\TransactionsService\generated-output -n TransactionsService
namespace TransactionsService
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
    [XmlTypeAttribute("ReversalType", Namespace="http://www.symxchange.generated.symitar.com/noncrud/transactions/dto")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class ReversalType
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ReversalCode", Order=0)]
        public ReversalCode ReversalCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ReversalCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ReversalCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<ReversalCode> ReversalCode
        {
            get
            {
                if (this.ReversalCodeValueSpecified)
                {
                    return this.ReversalCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ReversalCodeValue = value.GetValueOrDefault();
                this.ReversalCodeValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Maximum length: 14.</para>
        /// </summary>
        [MaxLengthAttribute(14)]
        [XmlElementAttribute("OriginalConfirmation", Order=1)]
        public string OriginalConfirmation { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.01.</para>
        /// <para xml:lang="en">Maximum inclusive value: 90000000000000.00.</para>
        /// </summary>
        [RangeAttribute(typeof(decimal), "0.01", "90000000000000.00")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PartialReversalOriginalTotalAmount", Order=2)]
        public decimal PartialReversalOriginalTotalAmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PartialReversalOriginalTotalAmount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PartialReversalOriginalTotalAmountValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.01.</para>
        /// <para xml:lang="en">Maximum inclusive value: 90000000000000.00.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public Nullable<decimal> PartialReversalOriginalTotalAmount
        {
            get
            {
                if (this.PartialReversalOriginalTotalAmountValueSpecified)
                {
                    return this.PartialReversalOriginalTotalAmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PartialReversalOriginalTotalAmountValue = value.GetValueOrDefault();
                this.PartialReversalOriginalTotalAmountValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=3, Form=XmlSchemaForm.Unqualified)]
        public TransactionsService.VersionType Version1 { get; set; }
        
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ReversalType" /> class.</para>
        /// </summary>
        public ReversalType()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
