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
    [XmlTypeAttribute("Pledge", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("Pledge", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/update")]
    [XmlIncludeAttribute(typeof(PledgeFields_2))]
    public partial class Pledge_2
    {
        
        [XmlElementAttribute("AccountNumber", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string AccountNumber { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Amount", Order=1, Form=XmlSchemaForm.Unqualified)]
        public decimal AmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Amount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AmountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> Amount
        {
            get
            {
                if (this.AmountValueSpecified)
                {
                    return this.AmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AmountValue = value.GetValueOrDefault();
                this.AmountValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CollateralCode", Order=2, Form=XmlSchemaForm.Unqualified)]
        public short CollateralCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CollateralCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CollateralCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> CollateralCode
        {
            get
            {
                if (this.CollateralCodeValueSpecified)
                {
                    return this.CollateralCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CollateralCodeValue = value.GetValueOrDefault();
                this.CollateralCodeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("CollateralDescription", Order=3, Form=XmlSchemaForm.Unqualified)]
        public string CollateralDescription { get; set; }
        
        [XmlElementAttribute("CollateralNumber", Order=4, Form=XmlSchemaForm.Unqualified)]
        public string CollateralNumber { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EffectiveDate", Order=5, Form=XmlSchemaForm.Unqualified, IsNullable=true, DataType="date")]
        public Nullable<DateTime> EffectiveDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EffectiveDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EffectiveDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> EffectiveDate
        {
            get
            {
                if (this.EffectiveDateValueSpecified)
                {
                    return this.EffectiveDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EffectiveDateValue = value.GetValueOrDefault();
                this.EffectiveDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ExpirationDate", Order=6, Form=XmlSchemaForm.Unqualified, IsNullable=true, DataType="date")]
        public Nullable<DateTime> ExpirationDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ExpirationDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ExpirationDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> ExpirationDate
        {
            get
            {
                if (this.ExpirationDateValueSpecified)
                {
                    return this.ExpirationDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ExpirationDateValue = value.GetValueOrDefault();
                this.ExpirationDateValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Id", Order=7, Form=XmlSchemaForm.Unqualified)]
        public string Id { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Locator", Order=8, Form=XmlSchemaForm.Unqualified)]
        public int LocatorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Locator property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LocatorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> Locator
        {
            get
            {
                if (this.LocatorValueSpecified)
                {
                    return this.LocatorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LocatorValue = value.GetValueOrDefault();
                this.LocatorValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Percent", Order=9, Form=XmlSchemaForm.Unqualified)]
        public decimal PercentValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Percent property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PercentValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> Percent
        {
            get
            {
                if (this.PercentValueSpecified)
                {
                    return this.PercentValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PercentValue = value.GetValueOrDefault();
                this.PercentValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Priority", Order=10, Form=XmlSchemaForm.Unqualified)]
        public short PriorityValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Priority property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PriorityValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> Priority
        {
            get
            {
                if (this.PriorityValueSpecified)
                {
                    return this.PriorityValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PriorityValue = value.GetValueOrDefault();
                this.PriorityValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RecordChangeDate", Order=11, Form=XmlSchemaForm.Unqualified, IsNullable=true, DataType="date")]
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
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Type", Order=12, Form=XmlSchemaForm.Unqualified)]
        public short TypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Type property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> Type
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
        
        [XmlElementAttribute("Version_1", Order=13, Form=XmlSchemaForm.Unqualified)]
        public AccountService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=14)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Pledge_2" /> class.</para>
        /// </summary>
        public Pledge_2()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
