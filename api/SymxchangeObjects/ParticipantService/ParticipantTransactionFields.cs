//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\ParticipantService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\ParticipantService\generated-output -n ParticipantService
namespace ParticipantService
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
    [XmlTypeAttribute("ParticipantTransactionFields", Namespace="http://www.symxchange.generated.symitar.com/crud/participant/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class ParticipantTransactionFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ActionCode", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool ActionCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ActionCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ActionCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ActionCode
        {
            get
            {
                if (this.ActionCodeValueSpecified)
                {
                    return this.ActionCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ActionCodeValue = value.GetValueOrDefault();
                this.ActionCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ActivityDate", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool ActivityDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ActivityDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ActivityDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ActivityDate
        {
            get
            {
                if (this.ActivityDateValueSpecified)
                {
                    return this.ActivityDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ActivityDateValue = value.GetValueOrDefault();
                this.ActivityDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AdjustmentFlag", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool AdjustmentFlagValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AdjustmentFlag property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AdjustmentFlagValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> AdjustmentFlag
        {
            get
            {
                if (this.AdjustmentFlagValueSpecified)
                {
                    return this.AdjustmentFlagValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AdjustmentFlagValue = value.GetValueOrDefault();
                this.AdjustmentFlagValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AgId", Order=3, Form=XmlSchemaForm.Unqualified)]
        public bool AgIdValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AgId property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AgIdValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> AgId
        {
            get
            {
                if (this.AgIdValueSpecified)
                {
                    return this.AgIdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AgIdValue = value.GetValueOrDefault();
                this.AgIdValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BalanceChange", Order=4, Form=XmlSchemaForm.Unqualified)]
        public bool BalanceChangeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BalanceChange property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BalanceChangeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> BalanceChange
        {
            get
            {
                if (this.BalanceChangeValueSpecified)
                {
                    return this.BalanceChangeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BalanceChangeValue = value.GetValueOrDefault();
                this.BalanceChangeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BatchSequence", Order=5, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("Branch", Order=6, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("Comment", Order=7, Form=XmlSchemaForm.Unqualified)]
        public bool CommentValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Comment property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CommentValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Comment
        {
            get
            {
                if (this.CommentValueSpecified)
                {
                    return this.CommentValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CommentValue = value.GetValueOrDefault();
                this.CommentValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CommentFlag", Order=8, Form=XmlSchemaForm.Unqualified)]
        public bool CommentFlagValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CommentFlag property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CommentFlagValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CommentFlag
        {
            get
            {
                if (this.CommentFlagValueSpecified)
                {
                    return this.CommentFlagValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CommentFlagValue = value.GetValueOrDefault();
                this.CommentFlagValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ConsoleNumber", Order=9, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("Description", Order=10, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("EffectiveDate", Order=11, Form=XmlSchemaForm.Unqualified)]
        public bool EffectiveDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EffectiveDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EffectiveDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> EffectiveDate
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
        [XmlElementAttribute("LoanId", Order=12, Form=XmlSchemaForm.Unqualified)]
        public bool LoanIdValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LoanId property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LoanIdValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> LoanId
        {
            get
            {
                if (this.LoanIdValueSpecified)
                {
                    return this.LoanIdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LoanIdValue = value.GetValueOrDefault();
                this.LoanIdValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MemberBranch", Order=13, Form=XmlSchemaForm.Unqualified)]
        public bool MemberBranchValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MemberBranch property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MemberBranchValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> MemberBranch
        {
            get
            {
                if (this.MemberBranchValueSpecified)
                {
                    return this.MemberBranchValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MemberBranchValue = value.GetValueOrDefault();
                this.MemberBranchValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NewBalance", Order=14, Form=XmlSchemaForm.Unqualified)]
        public bool NewBalanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NewBalance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NewBalanceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> NewBalance
        {
            get
            {
                if (this.NewBalanceValueSpecified)
                {
                    return this.NewBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NewBalanceValue = value.GetValueOrDefault();
                this.NewBalanceValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ParticipantNumber", Order=15, Form=XmlSchemaForm.Unqualified)]
        public bool ParticipantNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ParticipantNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ParticipantNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ParticipantNumber
        {
            get
            {
                if (this.ParticipantNumberValueSpecified)
                {
                    return this.ParticipantNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ParticipantNumberValue = value.GetValueOrDefault();
                this.ParticipantNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ParticipantType", Order=16, Form=XmlSchemaForm.Unqualified)]
        public bool ParticipantTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ParticipantType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ParticipantTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ParticipantType
        {
            get
            {
                if (this.ParticipantTypeValueSpecified)
                {
                    return this.ParticipantTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ParticipantTypeValue = value.GetValueOrDefault();
                this.ParticipantTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PoolNumber", Order=17, Form=XmlSchemaForm.Unqualified)]
        public bool PoolNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PoolNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PoolNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PoolNumber
        {
            get
            {
                if (this.PoolNumberValueSpecified)
                {
                    return this.PoolNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PoolNumberValue = value.GetValueOrDefault();
                this.PoolNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PostDate", Order=18, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("PostTime", Order=19, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("SequenceNumber", Order=20, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("SourceCode", Order=21, Form=XmlSchemaForm.Unqualified)]
        public bool SourceCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SourceCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SourceCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> SourceCode
        {
            get
            {
                if (this.SourceCodeValueSpecified)
                {
                    return this.SourceCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SourceCodeValue = value.GetValueOrDefault();
                this.SourceCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SubActionCode", Order=22, Form=XmlSchemaForm.Unqualified)]
        public bool SubActionCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SubActionCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SubActionCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> SubActionCode
        {
            get
            {
                if (this.SubActionCodeValueSpecified)
                {
                    return this.SubActionCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SubActionCodeValue = value.GetValueOrDefault();
                this.SubActionCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserNumber", Order=23, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("UserOverride", Order=24, Form=XmlSchemaForm.Unqualified)]
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
        
        [XmlElementAttribute("Version_1", Order=25, Form=XmlSchemaForm.Unqualified)]
        public ParticipantService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=26)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ParticipantTransactionFields" /> class.</para>
        /// </summary>
        public ParticipantTransactionFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
