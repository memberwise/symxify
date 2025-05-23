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
    [XmlTypeAttribute("ProductDetails", Namespace="http://www.symxchange.generated.symitar.com/noncrud/transactions/dto")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(Donor))]
    [XmlIncludeAttribute(typeof(Recipient))]
    public partial class ProductDetails
    {
        
        [XmlElementAttribute("Id", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string Id { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IdType", Order=1, Form=XmlSchemaForm.Unqualified)]
        public IdType IdTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IdType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IdTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<IdType> IdType
        {
            get
            {
                if (this.IdTypeValueSpecified)
                {
                    return this.IdTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IdTypeValue = value.GetValueOrDefault();
                this.IdTypeValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Balance", Order=2, Form=XmlSchemaForm.Unqualified)]
        public decimal BalanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Balance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BalanceValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public Nullable<decimal> Balance
        {
            get
            {
                if (this.BalanceValueSpecified)
                {
                    return this.BalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BalanceValue = value.GetValueOrDefault();
                this.BalanceValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AvailableBalance", Order=3, Form=XmlSchemaForm.Unqualified)]
        public decimal AvailableBalanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AvailableBalance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AvailableBalanceValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public Nullable<decimal> AvailableBalance
        {
            get
            {
                if (this.AvailableBalanceValueSpecified)
                {
                    return this.AvailableBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AvailableBalanceValue = value.GetValueOrDefault();
                this.AvailableBalanceValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Description", Order=4, Form=XmlSchemaForm.Unqualified)]
        public string Description { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Maximum length: 14.</para>
        /// </summary>
        [MaxLengthAttribute(14)]
        [XmlElementAttribute("AccountNumber", Order=5, Form=XmlSchemaForm.Unqualified)]
        public string AccountNumber { get; set; }
        
        [XmlElementAttribute("Name", Order=6, Form=XmlSchemaForm.Unqualified)]
        public string Name { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AccountTrackingType", Order=7, Form=XmlSchemaForm.Unqualified)]
        public int AccountTrackingTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AccountTrackingType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AccountTrackingTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> AccountTrackingType
        {
            get
            {
                if (this.AccountTrackingTypeValueSpecified)
                {
                    return this.AccountTrackingTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AccountTrackingTypeValue = value.GetValueOrDefault();
                this.AccountTrackingTypeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=8, Form=XmlSchemaForm.Unqualified)]
        public TransactionsService.VersionType Version1 { get; set; }
        
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
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ProductDetails" /> class.</para>
        /// </summary>
        public ProductDetails()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
