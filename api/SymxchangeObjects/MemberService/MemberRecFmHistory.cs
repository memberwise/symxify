//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\MemberService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\MemberService\generated-output -n MemberService
namespace MemberService
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
    [XmlTypeAttribute("MemberRecFmHistory", Namespace="http://www.symxchange.generated.symitar.com/crud/member/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class MemberRecFmHistory
    {
        
        [XmlElementAttribute("AccountNumber", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string AccountNumber { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BatchSequence", Order=1, Form=XmlSchemaForm.Unqualified)]
        public int BatchSequenceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BatchSequence property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BatchSequenceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> BatchSequence
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
        public short BranchValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Branch property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BranchValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> Branch
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
        
        [XmlElementAttribute("ConfirmationNumber", Order=3, Form=XmlSchemaForm.Unqualified)]
        public string ConfirmationNumber { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ConfirmationSeq", Order=4, Form=XmlSchemaForm.Unqualified)]
        public int ConfirmationSeqValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ConfirmationSeq property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ConfirmationSeqValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> ConfirmationSeq
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
        [XmlElementAttribute("ConsoleNumber", Order=5, Form=XmlSchemaForm.Unqualified)]
        public short ConsoleNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ConsoleNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ConsoleNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> ConsoleNumber
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
        [XmlElementAttribute("DataType", Order=6, Form=XmlSchemaForm.Unqualified)]
        public short DataTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DataType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DataTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> DataType
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
        
        [XmlElementAttribute("FieldName", Order=7, Form=XmlSchemaForm.Unqualified)]
        public string FieldName { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("FieldNumber", Order=8, Form=XmlSchemaForm.Unqualified)]
        public int FieldNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FieldNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FieldNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> FieldNumber
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
        [XmlElementAttribute("FmType", Order=9, Form=XmlSchemaForm.Unqualified)]
        public short FmTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FmType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FmTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> FmType
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
        
        [XmlElementAttribute("Id", Order=10, Form=XmlSchemaForm.Unqualified)]
        public string Id { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IdType", Order=11, Form=XmlSchemaForm.Unqualified)]
        public short IdTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IdType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IdTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> IdType
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
        [XmlElementAttribute("LastFmDate", Order=12, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime LastFmDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LastFmDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LastFmDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> LastFmDate
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
        
        [XmlElementAttribute("NewCharacter", Order=13, Form=XmlSchemaForm.Unqualified)]
        public string NewCharacter { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NewDate", Order=14, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime NewDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NewDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NewDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> NewDate
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
        [XmlElementAttribute("NewMoney", Order=15, Form=XmlSchemaForm.Unqualified)]
        public decimal NewMoneyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NewMoney property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NewMoneyValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> NewMoney
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
        [XmlElementAttribute("NewNumber", Order=16, Form=XmlSchemaForm.Unqualified)]
        public int NewNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NewNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NewNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> NewNumber
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
        [XmlElementAttribute("NewRate", Order=17, Form=XmlSchemaForm.Unqualified)]
        public decimal NewRateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NewRate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NewRateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> NewRate
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
        
        [XmlElementAttribute("OldCharacter", Order=18, Form=XmlSchemaForm.Unqualified)]
        public string OldCharacter { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("OldDate", Order=19, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime OldDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OldDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OldDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> OldDate
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
        [XmlElementAttribute("OldMoney", Order=20, Form=XmlSchemaForm.Unqualified)]
        public decimal OldMoneyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OldMoney property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OldMoneyValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> OldMoney
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
        [XmlElementAttribute("OldNumber", Order=21, Form=XmlSchemaForm.Unqualified)]
        public int OldNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OldNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OldNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> OldNumber
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
        [XmlElementAttribute("OldRate", Order=22, Form=XmlSchemaForm.Unqualified)]
        public decimal OldRateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OldRate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OldRateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> OldRate
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
        [XmlElementAttribute("PostDate", Order=23, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime PostDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PostDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PostDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> PostDate
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
        [XmlElementAttribute("PostTime", Order=24, Form=XmlSchemaForm.Unqualified)]
        public short PostTimeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PostTime property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PostTimeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> PostTime
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
        [XmlElementAttribute("ProcessorUser", Order=25, Form=XmlSchemaForm.Unqualified)]
        public short ProcessorUserValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ProcessorUser property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ProcessorUserValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> ProcessorUser
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
        
        [XmlElementAttribute("RecordName", Order=26, Form=XmlSchemaForm.Unqualified)]
        public string RecordName { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RecordType", Order=27, Form=XmlSchemaForm.Unqualified)]
        public int RecordTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RecordType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RecordTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> RecordType
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
        [XmlElementAttribute("SecurityLevels", Order=28, Form=XmlSchemaForm.Unqualified)]
        public short SecurityLevelsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SecurityLevels property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SecurityLevelsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> SecurityLevels
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
        [XmlElementAttribute("SequenceNumber", Order=29, Form=XmlSchemaForm.Unqualified)]
        public int SequenceNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SequenceNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SequenceNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> SequenceNumber
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
        [XmlElementAttribute("SubFieldNumber", Order=30, Form=XmlSchemaForm.Unqualified)]
        public short SubFieldNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SubFieldNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SubFieldNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> SubFieldNumber
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
        [XmlElementAttribute("UserNumber", Order=31, Form=XmlSchemaForm.Unqualified)]
        public short UserNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> UserNumber
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
        [XmlElementAttribute("UserOverride", Order=32, Form=XmlSchemaForm.Unqualified)]
        public short UserOverrideValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserOverride property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserOverrideValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> UserOverride
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
        
        [XmlElementAttribute("Version_1", Order=33, Form=XmlSchemaForm.Unqualified)]
        public MemberService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=34)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="MemberRecFmHistory" /> class.</para>
        /// </summary>
        public MemberRecFmHistory()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
