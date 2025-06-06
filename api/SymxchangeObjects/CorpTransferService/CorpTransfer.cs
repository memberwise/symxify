//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\CorpTransferService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\CorpTransferService\generated-output -n CorpTransferService
namespace CorpTransferService
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
    [XmlTypeAttribute("CorpTransfer", Namespace="http://www.symxchange.generated.symitar.com/crud/corptransfer/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class CorpTransfer
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Amount", Order=0, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("CompletedByUser", Order=1, Form=XmlSchemaForm.Unqualified)]
        public int CompletedByUserValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CompletedByUser property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CompletedByUserValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> CompletedByUser
        {
            get
            {
                if (this.CompletedByUserValueSpecified)
                {
                    return this.CompletedByUserValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CompletedByUserValue = value.GetValueOrDefault();
                this.CompletedByUserValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CompletedDate", Order=2, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime CompletedDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CompletedDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CompletedDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> CompletedDate
        {
            get
            {
                if (this.CompletedDateValueSpecified)
                {
                    return this.CompletedDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CompletedDateValue = value.GetValueOrDefault();
                this.CompletedDateValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("CompletedReason", Order=3, Form=XmlSchemaForm.Unqualified)]
        public string CompletedReason { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CompletedTime", Order=4, Form=XmlSchemaForm.Unqualified)]
        public short CompletedTimeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CompletedTime property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CompletedTimeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> CompletedTime
        {
            get
            {
                if (this.CompletedTimeValueSpecified)
                {
                    return this.CompletedTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CompletedTimeValue = value.GetValueOrDefault();
                this.CompletedTimeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EffectiveDate", Order=5, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime EffectiveDateValue { get; set; }
        
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
        [XmlElementAttribute("EnteredByCorporateUser", Order=6, Form=XmlSchemaForm.Unqualified)]
        public int EnteredByCorporateUserValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EnteredByCorporateUser property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EnteredByCorporateUserValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> EnteredByCorporateUser
        {
            get
            {
                if (this.EnteredByCorporateUserValueSpecified)
                {
                    return this.EnteredByCorporateUserValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EnteredByCorporateUserValue = value.GetValueOrDefault();
                this.EnteredByCorporateUserValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EnteredByMemberUser", Order=7, Form=XmlSchemaForm.Unqualified)]
        public int EnteredByMemberUserValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EnteredByMemberUser property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EnteredByMemberUserValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> EnteredByMemberUser
        {
            get
            {
                if (this.EnteredByMemberUserValueSpecified)
                {
                    return this.EnteredByMemberUserValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EnteredByMemberUserValue = value.GetValueOrDefault();
                this.EnteredByMemberUserValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EnteredDate", Order=8, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime EnteredDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EnteredDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EnteredDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> EnteredDate
        {
            get
            {
                if (this.EnteredDateValueSpecified)
                {
                    return this.EnteredDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EnteredDateValue = value.GetValueOrDefault();
                this.EnteredDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EnteredTime", Order=9, Form=XmlSchemaForm.Unqualified)]
        public short EnteredTimeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EnteredTime property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EnteredTimeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> EnteredTime
        {
            get
            {
                if (this.EnteredTimeValueSpecified)
                {
                    return this.EnteredTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EnteredTimeValue = value.GetValueOrDefault();
                this.EnteredTimeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("EnteredValidationMethod", Order=10, Form=XmlSchemaForm.Unqualified)]
        public string EnteredValidationMethod { get; set; }
        
        [XmlElementAttribute("FromAccount", Order=11, Form=XmlSchemaForm.Unqualified)]
        public string FromAccount { get; set; }
        
        [XmlElementAttribute("FromGlAccount", Order=12, Form=XmlSchemaForm.Unqualified)]
        public string FromGlAccount { get; set; }
        
        [XmlElementAttribute("FromId", Order=13, Form=XmlSchemaForm.Unqualified)]
        public string FromId { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("FromIdType", Order=14, Form=XmlSchemaForm.Unqualified)]
        public short FromIdTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FromIdType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FromIdTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> FromIdType
        {
            get
            {
                if (this.FromIdTypeValueSpecified)
                {
                    return this.FromIdTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FromIdTypeValue = value.GetValueOrDefault();
                this.FromIdTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("GlobalSequence", Order=15, Form=XmlSchemaForm.Unqualified)]
        public int GlobalSequenceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the GlobalSequence property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool GlobalSequenceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> GlobalSequence
        {
            get
            {
                if (this.GlobalSequenceValueSpecified)
                {
                    return this.GlobalSequenceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.GlobalSequenceValue = value.GetValueOrDefault();
                this.GlobalSequenceValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("GlobalSequenceDate", Order=16, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime GlobalSequenceDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the GlobalSequenceDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool GlobalSequenceDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> GlobalSequenceDate
        {
            get
            {
                if (this.GlobalSequenceDateValueSpecified)
                {
                    return this.GlobalSequenceDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.GlobalSequenceDateValue = value.GetValueOrDefault();
                this.GlobalSequenceDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("InterestAmount", Order=17, Form=XmlSchemaForm.Unqualified)]
        public decimal InterestAmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the InterestAmount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool InterestAmountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> InterestAmount
        {
            get
            {
                if (this.InterestAmountValueSpecified)
                {
                    return this.InterestAmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.InterestAmountValue = value.GetValueOrDefault();
                this.InterestAmountValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<CorpTransferMemo> _memo;
        
        [XmlElementAttribute("Memo", Order=18, Form=XmlSchemaForm.Unqualified)]
        public Collection<CorpTransferMemo> Memo
        {
            get
            {
                return _memo;
            }
            set
            {
                _memo = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Memo collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool MemoSpecified
        {
            get
            {
                return ((this.Memo != null) 
                            && (this.Memo.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CorpTransfer" /> class.</para>
        /// </summary>
        public CorpTransfer()
        {
            this._memo = new Collection<CorpTransferMemo>();
            this._any = new Collection<XmlElement>();
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NoticeDate", Order=19, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime NoticeDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NoticeDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NoticeDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> NoticeDate
        {
            get
            {
                if (this.NoticeDateValueSpecified)
                {
                    return this.NoticeDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NoticeDateValue = value.GetValueOrDefault();
                this.NoticeDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NotificationDate", Order=20, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime NotificationDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NotificationDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NotificationDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> NotificationDate
        {
            get
            {
                if (this.NotificationDateValueSpecified)
                {
                    return this.NotificationDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NotificationDateValue = value.GetValueOrDefault();
                this.NotificationDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NotificationMethod", Order=21, Form=XmlSchemaForm.Unqualified)]
        public short NotificationMethodValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NotificationMethod property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NotificationMethodValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> NotificationMethod
        {
            get
            {
                if (this.NotificationMethodValueSpecified)
                {
                    return this.NotificationMethodValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NotificationMethodValue = value.GetValueOrDefault();
                this.NotificationMethodValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NotificationStatus", Order=22, Form=XmlSchemaForm.Unqualified)]
        public short NotificationStatusValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NotificationStatus property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NotificationStatusValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> NotificationStatus
        {
            get
            {
                if (this.NotificationStatusValueSpecified)
                {
                    return this.NotificationStatusValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NotificationStatusValue = value.GetValueOrDefault();
                this.NotificationStatusValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NotificationTime", Order=23, Form=XmlSchemaForm.Unqualified)]
        public short NotificationTimeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NotificationTime property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NotificationTimeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> NotificationTime
        {
            get
            {
                if (this.NotificationTimeValueSpecified)
                {
                    return this.NotificationTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NotificationTimeValue = value.GetValueOrDefault();
                this.NotificationTimeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("NotificationUser", Order=24, Form=XmlSchemaForm.Unqualified)]
        public string NotificationUser { get; set; }
        
        [XmlElementAttribute("OriginatorStatementDesc", Order=25, Form=XmlSchemaForm.Unqualified)]
        public string OriginatorStatementDesc { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("OriginatorTransactionSeq", Order=26, Form=XmlSchemaForm.Unqualified)]
        public int OriginatorTransactionSeqValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OriginatorTransactionSeq property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OriginatorTransactionSeqValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> OriginatorTransactionSeq
        {
            get
            {
                if (this.OriginatorTransactionSeqValueSpecified)
                {
                    return this.OriginatorTransactionSeqValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OriginatorTransactionSeqValue = value.GetValueOrDefault();
                this.OriginatorTransactionSeqValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PostDate", Order=27, Form=XmlSchemaForm.Unqualified, DataType="date")]
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
        [XmlElementAttribute("PrincipalAmount", Order=28, Form=XmlSchemaForm.Unqualified)]
        public decimal PrincipalAmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PrincipalAmount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PrincipalAmountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> PrincipalAmount
        {
            get
            {
                if (this.PrincipalAmountValueSpecified)
                {
                    return this.PrincipalAmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PrincipalAmountValue = value.GetValueOrDefault();
                this.PrincipalAmountValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("ReceiverStatementDesc", Order=29, Form=XmlSchemaForm.Unqualified)]
        public string ReceiverStatementDesc { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ReceiverTransactionSeq", Order=30, Form=XmlSchemaForm.Unqualified)]
        public int ReceiverTransactionSeqValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ReceiverTransactionSeq property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ReceiverTransactionSeqValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> ReceiverTransactionSeq
        {
            get
            {
                if (this.ReceiverTransactionSeqValueSpecified)
                {
                    return this.ReceiverTransactionSeqValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ReceiverTransactionSeqValue = value.GetValueOrDefault();
                this.ReceiverTransactionSeqValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Status", Order=31, Form=XmlSchemaForm.Unqualified)]
        public short StatusValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Status property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool StatusValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> Status
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
        
        [XmlElementAttribute("ToAccount", Order=32, Form=XmlSchemaForm.Unqualified)]
        public string ToAccount { get; set; }
        
        [XmlElementAttribute("ToGlAccount", Order=33, Form=XmlSchemaForm.Unqualified)]
        public string ToGlAccount { get; set; }
        
        [XmlElementAttribute("ToId", Order=34, Form=XmlSchemaForm.Unqualified)]
        public string ToId { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ToIdType", Order=35, Form=XmlSchemaForm.Unqualified)]
        public short ToIdTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ToIdType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ToIdTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> ToIdType
        {
            get
            {
                if (this.ToIdTypeValueSpecified)
                {
                    return this.ToIdTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ToIdTypeValue = value.GetValueOrDefault();
                this.ToIdTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Type", Order=36, Form=XmlSchemaForm.Unqualified)]
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
        
        [XmlElementAttribute("Version_1", Order=37, Form=XmlSchemaForm.Unqualified)]
        public CorpTransferService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=38)]
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
