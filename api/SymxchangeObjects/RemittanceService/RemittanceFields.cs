//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\RemittanceService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\RemittanceService\generated-output -n RemittanceService
namespace RemittanceService
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
    [XmlTypeAttribute("RemittanceFields", Namespace="http://www.symxchange.generated.symitar.com/crud/remittance/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("RemittanceFields", Namespace="http://www.symxchange.generated.symitar.com/crud/remittance/dto/retrieve")]
    public partial class RemittanceFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Amount", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool AmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Amount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AmountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Amount
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
        [XmlElementAttribute("ConfirmationNumber", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool ConfirmationNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ConfirmationNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ConfirmationNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ConfirmationNumber
        {
            get
            {
                if (this.ConfirmationNumberValueSpecified)
                {
                    return this.ConfirmationNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ConfirmationNumberValue = value.GetValueOrDefault();
                this.ConfirmationNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ConfirmationSeq", Order=2, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("ConsoleNumber", Order=3, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("Description", Order=4, Form=XmlSchemaForm.Unqualified)]
        public bool DescriptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Description property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DescriptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Description
        {
            get
            {
                if (this.DescriptionValueSpecified)
                {
                    return this.DescriptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DescriptionValue = value.GetValueOrDefault();
                this.DescriptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("FundType", Order=5, Form=XmlSchemaForm.Unqualified)]
        public bool FundTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FundType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FundTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> FundType
        {
            get
            {
                if (this.FundTypeValueSpecified)
                {
                    return this.FundTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FundTypeValue = value.GetValueOrDefault();
                this.FundTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("GlCode", Order=6, Form=XmlSchemaForm.Unqualified)]
        public bool GlCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the GlCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool GlCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> GlCode
        {
            get
            {
                if (this.GlCodeValueSpecified)
                {
                    return this.GlCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.GlCodeValue = value.GetValueOrDefault();
                this.GlCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("GlobalSequence", Order=7, Form=XmlSchemaForm.Unqualified)]
        public bool GlobalSequenceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the GlobalSequence property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool GlobalSequenceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> GlobalSequence
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
        [XmlElementAttribute("GlobalSequenceDate", Order=8, Form=XmlSchemaForm.Unqualified)]
        public bool GlobalSequenceDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the GlobalSequenceDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool GlobalSequenceDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> GlobalSequenceDate
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
        [XmlElementAttribute("MemberAccount", Order=9, Form=XmlSchemaForm.Unqualified)]
        public bool MemberAccountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MemberAccount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MemberAccountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> MemberAccount
        {
            get
            {
                if (this.MemberAccountValueSpecified)
                {
                    return this.MemberAccountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MemberAccountValue = value.GetValueOrDefault();
                this.MemberAccountValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Payer", Order=10, Form=XmlSchemaForm.Unqualified)]
        public bool PayerValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Payer property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PayerValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Payer
        {
            get
            {
                if (this.PayerValueSpecified)
                {
                    return this.PayerValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PayerValue = value.GetValueOrDefault();
                this.PayerValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PostDate", Order=11, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("PrevDueDate", Order=12, Form=XmlSchemaForm.Unqualified)]
        public bool PrevDueDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PrevDueDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PrevDueDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PrevDueDate
        {
            get
            {
                if (this.PrevDueDateValueSpecified)
                {
                    return this.PrevDueDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PrevDueDateValue = value.GetValueOrDefault();
                this.PrevDueDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ProcessorAcct", Order=13, Form=XmlSchemaForm.Unqualified)]
        public bool ProcessorAcctValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ProcessorAcct property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ProcessorAcctValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ProcessorAcct
        {
            get
            {
                if (this.ProcessorAcctValueSpecified)
                {
                    return this.ProcessorAcctValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ProcessorAcctValue = value.GetValueOrDefault();
                this.ProcessorAcctValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ProcessorCode", Order=14, Form=XmlSchemaForm.Unqualified)]
        public bool ProcessorCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ProcessorCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ProcessorCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ProcessorCode
        {
            get
            {
                if (this.ProcessorCodeValueSpecified)
                {
                    return this.ProcessorCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ProcessorCodeValue = value.GetValueOrDefault();
                this.ProcessorCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ReconDate", Order=15, Form=XmlSchemaForm.Unqualified)]
        public bool ReconDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ReconDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ReconDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ReconDate
        {
            get
            {
                if (this.ReconDateValueSpecified)
                {
                    return this.ReconDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ReconDateValue = value.GetValueOrDefault();
                this.ReconDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RecordChangeDate", Order=16, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("RemitDate", Order=17, Form=XmlSchemaForm.Unqualified)]
        public bool RemitDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RemitDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RemitDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> RemitDate
        {
            get
            {
                if (this.RemitDateValueSpecified)
                {
                    return this.RemitDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RemitDateValue = value.GetValueOrDefault();
                this.RemitDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Sequence", Order=18, Form=XmlSchemaForm.Unqualified)]
        public bool SequenceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Sequence property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SequenceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Sequence
        {
            get
            {
                if (this.SequenceValueSpecified)
                {
                    return this.SequenceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SequenceValue = value.GetValueOrDefault();
                this.SequenceValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Status", Order=19, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("TranCode", Order=20, Form=XmlSchemaForm.Unqualified)]
        public bool TranCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TranCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TranCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> TranCode
        {
            get
            {
                if (this.TranCodeValueSpecified)
                {
                    return this.TranCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TranCodeValue = value.GetValueOrDefault();
                this.TranCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("TranType", Order=21, Form=XmlSchemaForm.Unqualified)]
        public bool TranTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TranType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TranTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> TranType
        {
            get
            {
                if (this.TranTypeValueSpecified)
                {
                    return this.TranTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TranTypeValue = value.GetValueOrDefault();
                this.TranTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("User", Order=22, Form=XmlSchemaForm.Unqualified)]
        public bool UserValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the User property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> User
        {
            get
            {
                if (this.UserValueSpecified)
                {
                    return this.UserValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserValue = value.GetValueOrDefault();
                this.UserValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("VoidDate", Order=23, Form=XmlSchemaForm.Unqualified)]
        public bool VoidDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the VoidDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool VoidDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> VoidDate
        {
            get
            {
                if (this.VoidDateValueSpecified)
                {
                    return this.VoidDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.VoidDateValue = value.GetValueOrDefault();
                this.VoidDateValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=24, Form=XmlSchemaForm.Unqualified)]
        public RemittanceService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=25)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="RemittanceFields" /> class.</para>
        /// </summary>
        public RemittanceFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
