//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\NonAccountNameService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\NonAccountNameService\generated-output -n NonAccountNameService
namespace NonAccountNameService
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
    [XmlTypeAttribute("NonAcctNameFmHistoryFields", Namespace="http://www.symxchange.generated.symitar.com/crud/nonaccountname/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class NonAcctNameFmHistoryFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AccountNumber", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool AccountNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AccountNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AccountNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> AccountNumber
        {
            get
            {
                if (this.AccountNumberValueSpecified)
                {
                    return this.AccountNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AccountNumberValue = value.GetValueOrDefault();
                this.AccountNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BatchSequence", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool BatchSequenceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BatchSequence property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BatchSequenceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> BatchSequence
        {
            get
            {
                if (this.BatchSequenceValueSpecified)
                {
                    return this.BatchSequenceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BatchSequenceValue = value.GetValueOrDefault();
                this.BatchSequenceValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Branch", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool BranchValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Branch property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BranchValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Branch
        {
            get
            {
                if (this.BranchValueSpecified)
                {
                    return this.BranchValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BranchValue = value.GetValueOrDefault();
                this.BranchValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ConfirmationSeq", Order=3, Form=XmlSchemaForm.Unqualified)]
        public bool ConfirmationSeqValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ConfirmationSeq property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ConfirmationSeqValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ConfirmationSeq
        {
            get
            {
                if (this.ConfirmationSeqValueSpecified)
                {
                    return this.ConfirmationSeqValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ConfirmationSeqValue = value.GetValueOrDefault();
                this.ConfirmationSeqValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ConsoleNumber", Order=4, Form=XmlSchemaForm.Unqualified)]
        public bool ConsoleNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ConsoleNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ConsoleNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ConsoleNumber
        {
            get
            {
                if (this.ConsoleNumberValueSpecified)
                {
                    return this.ConsoleNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ConsoleNumberValue = value.GetValueOrDefault();
                this.ConsoleNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("DataType", Order=5, Form=XmlSchemaForm.Unqualified)]
        public bool DataTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DataType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DataTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> DataType
        {
            get
            {
                if (this.DataTypeValueSpecified)
                {
                    return this.DataTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DataTypeValue = value.GetValueOrDefault();
                this.DataTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("FieldName", Order=6, Form=XmlSchemaForm.Unqualified)]
        public bool FieldNameValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FieldName property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FieldNameValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> FieldName
        {
            get
            {
                if (this.FieldNameValueSpecified)
                {
                    return this.FieldNameValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FieldNameValue = value.GetValueOrDefault();
                this.FieldNameValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("FieldNumber", Order=7, Form=XmlSchemaForm.Unqualified)]
        public bool FieldNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FieldNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FieldNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> FieldNumber
        {
            get
            {
                if (this.FieldNumberValueSpecified)
                {
                    return this.FieldNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FieldNumberValue = value.GetValueOrDefault();
                this.FieldNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("FmType", Order=8, Form=XmlSchemaForm.Unqualified)]
        public bool FmTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FmType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FmTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> FmType
        {
            get
            {
                if (this.FmTypeValueSpecified)
                {
                    return this.FmTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FmTypeValue = value.GetValueOrDefault();
                this.FmTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Id", Order=9, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("IdType", Order=10, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("LastFmDate", Order=11, Form=XmlSchemaForm.Unqualified)]
        public bool LastFmDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LastFmDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LastFmDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> LastFmDate
        {
            get
            {
                if (this.LastFmDateValueSpecified)
                {
                    return this.LastFmDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LastFmDateValue = value.GetValueOrDefault();
                this.LastFmDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NewCharacter", Order=12, Form=XmlSchemaForm.Unqualified)]
        public bool NewCharacterValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NewCharacter property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NewCharacterValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> NewCharacter
        {
            get
            {
                if (this.NewCharacterValueSpecified)
                {
                    return this.NewCharacterValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NewCharacterValue = value.GetValueOrDefault();
                this.NewCharacterValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NewDate", Order=13, Form=XmlSchemaForm.Unqualified)]
        public bool NewDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NewDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NewDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> NewDate
        {
            get
            {
                if (this.NewDateValueSpecified)
                {
                    return this.NewDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NewDateValue = value.GetValueOrDefault();
                this.NewDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NewMoney", Order=14, Form=XmlSchemaForm.Unqualified)]
        public bool NewMoneyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NewMoney property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NewMoneyValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> NewMoney
        {
            get
            {
                if (this.NewMoneyValueSpecified)
                {
                    return this.NewMoneyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NewMoneyValue = value.GetValueOrDefault();
                this.NewMoneyValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NewNumber", Order=15, Form=XmlSchemaForm.Unqualified)]
        public bool NewNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NewNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NewNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> NewNumber
        {
            get
            {
                if (this.NewNumberValueSpecified)
                {
                    return this.NewNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NewNumberValue = value.GetValueOrDefault();
                this.NewNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NewRate", Order=16, Form=XmlSchemaForm.Unqualified)]
        public bool NewRateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NewRate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NewRateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> NewRate
        {
            get
            {
                if (this.NewRateValueSpecified)
                {
                    return this.NewRateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NewRateValue = value.GetValueOrDefault();
                this.NewRateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("OldCharacter", Order=17, Form=XmlSchemaForm.Unqualified)]
        public bool OldCharacterValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OldCharacter property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OldCharacterValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> OldCharacter
        {
            get
            {
                if (this.OldCharacterValueSpecified)
                {
                    return this.OldCharacterValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OldCharacterValue = value.GetValueOrDefault();
                this.OldCharacterValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("OldDate", Order=18, Form=XmlSchemaForm.Unqualified)]
        public bool OldDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OldDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OldDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> OldDate
        {
            get
            {
                if (this.OldDateValueSpecified)
                {
                    return this.OldDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OldDateValue = value.GetValueOrDefault();
                this.OldDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("OldMoney", Order=19, Form=XmlSchemaForm.Unqualified)]
        public bool OldMoneyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OldMoney property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OldMoneyValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> OldMoney
        {
            get
            {
                if (this.OldMoneyValueSpecified)
                {
                    return this.OldMoneyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OldMoneyValue = value.GetValueOrDefault();
                this.OldMoneyValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("OldNumber", Order=20, Form=XmlSchemaForm.Unqualified)]
        public bool OldNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OldNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OldNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> OldNumber
        {
            get
            {
                if (this.OldNumberValueSpecified)
                {
                    return this.OldNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OldNumberValue = value.GetValueOrDefault();
                this.OldNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("OldRate", Order=21, Form=XmlSchemaForm.Unqualified)]
        public bool OldRateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OldRate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OldRateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> OldRate
        {
            get
            {
                if (this.OldRateValueSpecified)
                {
                    return this.OldRateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OldRateValue = value.GetValueOrDefault();
                this.OldRateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PostDate", Order=22, Form=XmlSchemaForm.Unqualified)]
        public bool PostDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PostDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PostDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PostDate
        {
            get
            {
                if (this.PostDateValueSpecified)
                {
                    return this.PostDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PostDateValue = value.GetValueOrDefault();
                this.PostDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PostTime", Order=23, Form=XmlSchemaForm.Unqualified)]
        public bool PostTimeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PostTime property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PostTimeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PostTime
        {
            get
            {
                if (this.PostTimeValueSpecified)
                {
                    return this.PostTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PostTimeValue = value.GetValueOrDefault();
                this.PostTimeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ProcessorUser", Order=24, Form=XmlSchemaForm.Unqualified)]
        public bool ProcessorUserValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ProcessorUser property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ProcessorUserValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ProcessorUser
        {
            get
            {
                if (this.ProcessorUserValueSpecified)
                {
                    return this.ProcessorUserValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ProcessorUserValue = value.GetValueOrDefault();
                this.ProcessorUserValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RecordName", Order=25, Form=XmlSchemaForm.Unqualified)]
        public bool RecordNameValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RecordName property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RecordNameValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> RecordName
        {
            get
            {
                if (this.RecordNameValueSpecified)
                {
                    return this.RecordNameValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RecordNameValue = value.GetValueOrDefault();
                this.RecordNameValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RecordType", Order=26, Form=XmlSchemaForm.Unqualified)]
        public bool RecordTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RecordType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RecordTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> RecordType
        {
            get
            {
                if (this.RecordTypeValueSpecified)
                {
                    return this.RecordTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RecordTypeValue = value.GetValueOrDefault();
                this.RecordTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SecurityLevels", Order=27, Form=XmlSchemaForm.Unqualified)]
        public bool SecurityLevelsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SecurityLevels property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SecurityLevelsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> SecurityLevels
        {
            get
            {
                if (this.SecurityLevelsValueSpecified)
                {
                    return this.SecurityLevelsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SecurityLevelsValue = value.GetValueOrDefault();
                this.SecurityLevelsValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SequenceNumber", Order=28, Form=XmlSchemaForm.Unqualified)]
        public bool SequenceNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SequenceNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SequenceNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> SequenceNumber
        {
            get
            {
                if (this.SequenceNumberValueSpecified)
                {
                    return this.SequenceNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SequenceNumberValue = value.GetValueOrDefault();
                this.SequenceNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SubFieldNumber", Order=29, Form=XmlSchemaForm.Unqualified)]
        public bool SubFieldNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SubFieldNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SubFieldNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> SubFieldNumber
        {
            get
            {
                if (this.SubFieldNumberValueSpecified)
                {
                    return this.SubFieldNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SubFieldNumberValue = value.GetValueOrDefault();
                this.SubFieldNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserNumber", Order=30, Form=XmlSchemaForm.Unqualified)]
        public bool UserNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> UserNumber
        {
            get
            {
                if (this.UserNumberValueSpecified)
                {
                    return this.UserNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserNumberValue = value.GetValueOrDefault();
                this.UserNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserOverride", Order=31, Form=XmlSchemaForm.Unqualified)]
        public bool UserOverrideValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserOverride property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserOverrideValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> UserOverride
        {
            get
            {
                if (this.UserOverrideValueSpecified)
                {
                    return this.UserOverrideValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserOverrideValue = value.GetValueOrDefault();
                this.UserOverrideValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=32, Form=XmlSchemaForm.Unqualified)]
        public NonAccountNameService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=33)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="NonAcctNameFmHistoryFields" /> class.</para>
        /// </summary>
        public NonAcctNameFmHistoryFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
