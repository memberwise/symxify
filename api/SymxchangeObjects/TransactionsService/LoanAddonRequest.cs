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
    [XmlTypeAttribute("LoanAddonRequest", Namespace="http://www.symxchange.generated.symitar.com/noncrud/transactions/dto")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class LoanAddonRequest : TransactionsBaseRequest
    {
        
        /// <summary>
        /// <para xml:lang="en">Maximum length: 10.</para>
        /// </summary>
        [MaxLengthAttribute(10)]
        [XmlElementAttribute("AccountNumber", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string AccountNumber { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IdType", Order=1, Form=XmlSchemaForm.Unqualified)]
        public LoanIdType IdTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IdType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IdTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<LoanIdType> IdType
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
        /// <para xml:lang="en">Maximum length: 20.</para>
        /// </summary>
        [MaxLengthAttribute(20)]
        [XmlElementAttribute("LoanId", Order=2)]
        public string LoanId { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 10.</para>
        /// <para xml:lang="en">Pattern: [0-9]+.</para>
        /// </summary>
        [MinLengthAttribute(1)]
        [MaxLengthAttribute(10)]
        [RegularExpressionAttribute("[0-9]+")]
        [XmlElementAttribute("CheckNumber", Order=3)]
        public string CheckNumber { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CheckIssuer", Order=4)]
        public CheckIssuerType CheckIssuerValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CheckIssuer property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CheckIssuerValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<CheckIssuerType> CheckIssuer
        {
            get
            {
                if (this.CheckIssuerValueSpecified)
                {
                    return this.CheckIssuerValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CheckIssuerValue = value.GetValueOrDefault();
                this.CheckIssuerValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Amounts", Order=5)]
        public AmountInformation Amounts { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 132.</para>
        /// </summary>
        [MinLengthAttribute(1)]
        [MaxLengthAttribute(132)]
        [XmlElementAttribute("Comment", Order=6)]
        public string Comment { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 9999.</para>
        /// </summary>
        [RangeAttribute(typeof(short), "0", "9999")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CommentCode", Order=7)]
        public short CommentCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CommentCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CommentCodeValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 9999.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public Nullable<short> CommentCode
        {
            get
            {
                if (this.CommentCodeValueSpecified)
                {
                    return this.CommentCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CommentCodeValue = value.GetValueOrDefault();
                this.CommentCodeValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 1900-01-01.</para>
        /// <para xml:lang="en">Maximum inclusive value: 2078-12-31.</para>
        /// </summary>
        [RangeAttribute(typeof(DateTime), "1900-01-01", "2078-12-31")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EffectiveDate", Order=8, DataType="date")]
        public DateTime EffectiveDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EffectiveDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EffectiveDateValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 1900-01-01.</para>
        /// <para xml:lang="en">Maximum inclusive value: 2078-12-31.</para>
        /// </summary>
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
        
        [XmlElementAttribute("GLAccounts", Order=9)]
        public GlAccounts GlAccounts { get; set; }
        
        [XmlElementAttribute("GLCodes", Order=10)]
        public GlCodes GlCodes { get; set; }
        
        [XmlElementAttribute("Payee", Order=11)]
        public PayeeInformation Payee { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AuthorizationType", Order=12)]
        public AuthorizationType AuthorizationTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AuthorizationType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AuthorizationTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<AuthorizationType> AuthorizationType
        {
            get
            {
                if (this.AuthorizationTypeValueSpecified)
                {
                    return this.AuthorizationTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AuthorizationTypeValue = value.GetValueOrDefault();
                this.AuthorizationTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ForcePostRequested", Order=13)]
        public bool ForcePostRequestedValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ForcePostRequested property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ForcePostRequestedValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ForcePostRequested
        {
            get
            {
                if (this.ForcePostRequestedValueSpecified)
                {
                    return this.ForcePostRequestedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ForcePostRequestedValue = value.GetValueOrDefault();
                this.ForcePostRequestedValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Maximum length: 2.</para>
        /// </summary>
        [MaxLengthAttribute(2)]
        [XmlElementAttribute("SourceCode", Order=14)]
        public string SourceCode { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RecurrenceRequested", Order=15)]
        public bool RecurrenceRequestedValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RecurrenceRequested property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RecurrenceRequestedValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> RecurrenceRequested
        {
            get
            {
                if (this.RecurrenceRequestedValueSpecified)
                {
                    return this.RecurrenceRequestedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RecurrenceRequestedValue = value.GetValueOrDefault();
                this.RecurrenceRequestedValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Maximum length: 15.</para>
        /// </summary>
        [MaxLengthAttribute(15)]
        [XmlElementAttribute("TracerNumber", Order=16)]
        public string TracerNumber { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Maximum length: 10.</para>
        /// </summary>
        [MaxLengthAttribute(10)]
        [XmlElementAttribute("DraftNumber", Order=17)]
        public string DraftNumber { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<Printer> _printer;
        
        [XmlElementAttribute("Printer", Order=18)]
        public Collection<Printer> Printer
        {
            get
            {
                return _printer;
            }
            set
            {
                _printer = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Printer collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PrinterSpecified
        {
            get
            {
                return ((this.Printer != null) 
                            && (this.Printer.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoanAddonRequest" /> class.</para>
        /// </summary>
        public LoanAddonRequest()
        {
            this._printer = new Collection<Printer>();
            this._dispenser = new Collection<Dispenser>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<Dispenser> _dispenser;
        
        [XmlElementAttribute("Dispenser", Order=19)]
        public Collection<Dispenser> Dispenser
        {
            get
            {
                return _dispenser;
            }
            set
            {
                _dispenser = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Dispenser collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DispenserSpecified
        {
            get
            {
                return ((this.Dispenser != null) 
                            && (this.Dispenser.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CalculateCheck", Order=20)]
        public bool CalculateCheckValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CalculateCheck property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CalculateCheckValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CalculateCheck
        {
            get
            {
                if (this.CalculateCheckValueSpecified)
                {
                    return this.CalculateCheckValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CalculateCheckValue = value.GetValueOrDefault();
                this.CalculateCheckValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 40.</para>
        /// </summary>
        [MinLengthAttribute(1)]
        [MaxLengthAttribute(40)]
        [XmlElementAttribute("GLComment", Order=21)]
        public string GlComment { get; set; }
    }
}
