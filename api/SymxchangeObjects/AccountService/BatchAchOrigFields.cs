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
    [XmlTypeAttribute("BatchAchOrigFields", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("BatchAchOrigFields", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve")]
    public partial class BatchAchOrigFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CompanyDiscretionaryData", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool CompanyDiscretionaryDataValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CompanyDiscretionaryData property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CompanyDiscretionaryDataValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CompanyDiscretionaryData
        {
            get
            {
                if (this.CompanyDiscretionaryDataValueSpecified)
                {
                    return this.CompanyDiscretionaryDataValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CompanyDiscretionaryDataValue = value.GetValueOrDefault();
                this.CompanyDiscretionaryDataValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CompanyEntryDescription", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool CompanyEntryDescriptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CompanyEntryDescription property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CompanyEntryDescriptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CompanyEntryDescription
        {
            get
            {
                if (this.CompanyEntryDescriptionValueSpecified)
                {
                    return this.CompanyEntryDescriptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CompanyEntryDescriptionValue = value.GetValueOrDefault();
                this.CompanyEntryDescriptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CompanyId", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool CompanyIdValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CompanyId property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CompanyIdValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CompanyId
        {
            get
            {
                if (this.CompanyIdValueSpecified)
                {
                    return this.CompanyIdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CompanyIdValue = value.GetValueOrDefault();
                this.CompanyIdValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CompanyName", Order=3, Form=XmlSchemaForm.Unqualified)]
        public bool CompanyNameValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CompanyName property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CompanyNameValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CompanyName
        {
            get
            {
                if (this.CompanyNameValueSpecified)
                {
                    return this.CompanyNameValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CompanyNameValue = value.GetValueOrDefault();
                this.CompanyNameValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("DepositSettlementDate", Order=4, Form=XmlSchemaForm.Unqualified)]
        public bool DepositSettlementDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DepositSettlementDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DepositSettlementDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> DepositSettlementDate
        {
            get
            {
                if (this.DepositSettlementDateValueSpecified)
                {
                    return this.DepositSettlementDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DepositSettlementDateValue = value.GetValueOrDefault();
                this.DepositSettlementDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EffectiveEntryDate", Order=5, Form=XmlSchemaForm.Unqualified)]
        public bool EffectiveEntryDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EffectiveEntryDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EffectiveEntryDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> EffectiveEntryDate
        {
            get
            {
                if (this.EffectiveEntryDateValueSpecified)
                {
                    return this.EffectiveEntryDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EffectiveEntryDateValue = value.GetValueOrDefault();
                this.EffectiveEntryDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Expiration", Order=6, Form=XmlSchemaForm.Unqualified)]
        public bool ExpirationValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Expiration property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ExpirationValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Expiration
        {
            get
            {
                if (this.ExpirationValueSpecified)
                {
                    return this.ExpirationValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ExpirationValue = value.GetValueOrDefault();
                this.ExpirationValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("GroupNumber", Order=7, Form=XmlSchemaForm.Unqualified)]
        public bool GroupNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the GroupNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool GroupNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> GroupNumber
        {
            get
            {
                if (this.GroupNumberValueSpecified)
                {
                    return this.GroupNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.GroupNumberValue = value.GetValueOrDefault();
                this.GroupNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Id", Order=8, Form=XmlSchemaForm.Unqualified)]
        public bool IdValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Id property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IdValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Id
        {
            get
            {
                if (this.IdValueSpecified)
                {
                    return this.IdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IdValue = value.GetValueOrDefault();
                this.IdValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IdType", Order=9, Form=XmlSchemaForm.Unqualified)]
        public bool IdTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IdType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IdTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IdType
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
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Locator", Order=10, Form=XmlSchemaForm.Unqualified)]
        public bool LocatorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Locator property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LocatorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Locator
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
        [XmlElementAttribute("OrigAmount", Order=11, Form=XmlSchemaForm.Unqualified)]
        public bool OrigAmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OrigAmount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OrigAmountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> OrigAmount
        {
            get
            {
                if (this.OrigAmountValueSpecified)
                {
                    return this.OrigAmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OrigAmountValue = value.GetValueOrDefault();
                this.OrigAmountValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PaySettlementDate", Order=12, Form=XmlSchemaForm.Unqualified)]
        public bool PaySettlementDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PaySettlementDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PaySettlementDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PaySettlementDate
        {
            get
            {
                if (this.PaySettlementDateValueSpecified)
                {
                    return this.PaySettlementDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PaySettlementDateValue = value.GetValueOrDefault();
                this.PaySettlementDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PostMethod", Order=13, Form=XmlSchemaForm.Unqualified)]
        public bool PostMethodValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PostMethod property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PostMethodValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PostMethod
        {
            get
            {
                if (this.PostMethodValueSpecified)
                {
                    return this.PostMethodValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PostMethodValue = value.GetValueOrDefault();
                this.PostMethodValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RecordChangeDate", Order=14, Form=XmlSchemaForm.Unqualified)]
        public bool RecordChangeDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RecordChangeDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RecordChangeDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> RecordChangeDate
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
        [XmlElementAttribute("StandardEntryClassCode", Order=15, Form=XmlSchemaForm.Unqualified)]
        public bool StandardEntryClassCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the StandardEntryClassCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool StandardEntryClassCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> StandardEntryClassCode
        {
            get
            {
                if (this.StandardEntryClassCodeValueSpecified)
                {
                    return this.StandardEntryClassCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StandardEntryClassCodeValue = value.GetValueOrDefault();
                this.StandardEntryClassCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Status", Order=16, Form=XmlSchemaForm.Unqualified)]
        public bool StatusValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Status property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool StatusValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Status
        {
            get
            {
                if (this.StatusValueSpecified)
                {
                    return this.StatusValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StatusValue = value.GetValueOrDefault();
                this.StatusValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("TotalOriginationCount", Order=17, Form=XmlSchemaForm.Unqualified)]
        public bool TotalOriginationCountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TotalOriginationCount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TotalOriginationCountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> TotalOriginationCount
        {
            get
            {
                if (this.TotalOriginationCountValueSpecified)
                {
                    return this.TotalOriginationCountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TotalOriginationCountValue = value.GetValueOrDefault();
                this.TotalOriginationCountValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("TotalPostedCount", Order=18, Form=XmlSchemaForm.Unqualified)]
        public bool TotalPostedCountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TotalPostedCount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TotalPostedCountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> TotalPostedCount
        {
            get
            {
                if (this.TotalPostedCountValueSpecified)
                {
                    return this.TotalPostedCountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TotalPostedCountValue = value.GetValueOrDefault();
                this.TotalPostedCountValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=19, Form=XmlSchemaForm.Unqualified)]
        public AccountService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=20)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="BatchAchOrigFields" /> class.</para>
        /// </summary>
        public BatchAchOrigFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
