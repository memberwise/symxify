//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\AccountService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\AccountService\generated-output -n AccountService
namespace AccountService
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
    [XmlTypeAttribute("Portfolio", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("Portfolio", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/update")]
    [XmlIncludeAttribute(typeof(PortfolioFields_2))]
    public partial class Portfolio_2
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AvailableBalance", Order=0, Form=XmlSchemaForm.Unqualified)]
        public decimal AvailableBalanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AvailableBalance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AvailableBalanceValueSpecified { get; set; }
        
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
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Balance", Order=1, Form=XmlSchemaForm.Unqualified)]
        public decimal BalanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Balance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BalanceValueSpecified { get; set; }
        
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
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CloseDate", Order=2, Form=XmlSchemaForm.Unqualified, IsNullable=true, DataType="date")]
        public Nullable<DateTime> CloseDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CloseDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CloseDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> CloseDate
        {
            get
            {
                if (this.CloseDateValueSpecified)
                {
                    return this.CloseDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CloseDateValue = value.GetValueOrDefault();
                this.CloseDateValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Description", Order=3, Form=XmlSchemaForm.Unqualified)]
        public string Description { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("FmLastDate", Order=4, Form=XmlSchemaForm.Unqualified, IsNullable=true, DataType="date")]
        public Nullable<DateTime> FmLastDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FmLastDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FmLastDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> FmLastDate
        {
            get
            {
                if (this.FmLastDateValueSpecified)
                {
                    return this.FmLastDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FmLastDateValue = value.GetValueOrDefault();
                this.FmLastDateValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Id", Order=5, Form=XmlSchemaForm.Unqualified)]
        public string Id { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NotePurgeDate", Order=6, Form=XmlSchemaForm.Unqualified, IsNullable=true, DataType="date")]
        public Nullable<DateTime> NotePurgeDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NotePurgeDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NotePurgeDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> NotePurgeDate
        {
            get
            {
                if (this.NotePurgeDateValueSpecified)
                {
                    return this.NotePurgeDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NotePurgeDateValue = value.GetValueOrDefault();
                this.NotePurgeDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RecordChangeDate", Order=7, Form=XmlSchemaForm.Unqualified, IsNullable=true, DataType="date")]
        public Nullable<DateTime> RecordChangeDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RecordChangeDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RecordChangeDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> RecordChangeDate
        {
            get
            {
                if (this.RecordChangeDateValueSpecified)
                {
                    return this.RecordChangeDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RecordChangeDateValue = value.GetValueOrDefault();
                this.RecordChangeDateValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=8, Form=XmlSchemaForm.Unqualified)]
        public AccountService.VersionType Version1 { get; set; }
        
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Portfolio_2" /> class.</para>
        /// </summary>
        public Portfolio_2()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
