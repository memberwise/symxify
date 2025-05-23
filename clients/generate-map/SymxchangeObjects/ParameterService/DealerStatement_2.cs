//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\ParameterService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\ParameterService\generated-output -n ParameterService
namespace ParameterService
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
    [XmlTypeAttribute("DealerStatement", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("DealerStatement", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [XmlIncludeAttribute(typeof(DealerStatementFields_2))]
    public partial class DealerStatement_2
    {
        
        [XmlElementAttribute("Adjustments", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string Adjustments { get; set; }
        
        [XmlElementAttribute("ChargebackAmount", Order=1, Form=XmlSchemaForm.Unqualified)]
        public string ChargebackAmount { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<DealerStatementClosedDealerMessage1_2> _closedDealerMessage1;
        
        [XmlElementAttribute("ClosedDealerMessage1", Order=2, Form=XmlSchemaForm.Unqualified)]
        public Collection<DealerStatementClosedDealerMessage1_2> ClosedDealerMessage1
        {
            get
            {
                return _closedDealerMessage1;
            }
            set
            {
                _closedDealerMessage1 = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ClosedDealerMessage1 collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ClosedDealerMessage1Specified
        {
            get
            {
                return ((this.ClosedDealerMessage1 != null) 
                            && (this.ClosedDealerMessage1.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DealerStatement_2" /> class.</para>
        /// </summary>
        public DealerStatement_2()
        {
            this._closedDealerMessage1 = new Collection<DealerStatementClosedDealerMessage1_2>();
            this._closedDealerMessage2 = new Collection<DealerStatementClosedDealerMessage2_2>();
            this._institutionAddressLine = new Collection<DealerStatementInstitutionAddressLine_2>();
            this._messageLine1 = new Collection<DealerStatementMessageLine1_2>();
            this._messageLine2 = new Collection<DealerStatementMessageLine2_2>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<DealerStatementClosedDealerMessage2_2> _closedDealerMessage2;
        
        [XmlElementAttribute("ClosedDealerMessage2", Order=3, Form=XmlSchemaForm.Unqualified)]
        public Collection<DealerStatementClosedDealerMessage2_2> ClosedDealerMessage2
        {
            get
            {
                return _closedDealerMessage2;
            }
            set
            {
                _closedDealerMessage2 = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ClosedDealerMessage2 collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ClosedDealerMessage2Specified
        {
            get
            {
                return ((this.ClosedDealerMessage2 != null) 
                            && (this.ClosedDealerMessage2.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("DealerDormant", Order=4, Form=XmlSchemaForm.Unqualified)]
        public short DealerDormantValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DealerDormant property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DealerDormantValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> DealerDormant
        {
            get
            {
                if (this.DealerDormantValueSpecified)
                {
                    return this.DealerDormantValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DealerDormantValue = value.GetValueOrDefault();
                this.DealerDormantValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Fees", Order=5, Form=XmlSchemaForm.Unqualified)]
        public string Fees { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Format", Order=6, Form=XmlSchemaForm.Unqualified)]
        public short FormatValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Format property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FormatValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> Format
        {
            get
            {
                if (this.FormatValueSpecified)
                {
                    return this.FormatValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FormatValue = value.GetValueOrDefault();
                this.FormatValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("HoldbackAmount", Order=7, Form=XmlSchemaForm.Unqualified)]
        public string HoldbackAmount { get; set; }
        
        [XmlElementAttribute("InquiryLine", Order=8, Form=XmlSchemaForm.Unqualified)]
        public string InquiryLine { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<DealerStatementInstitutionAddressLine_2> _institutionAddressLine;
        
        [XmlElementAttribute("InstitutionAddressLine", Order=9, Form=XmlSchemaForm.Unqualified)]
        public Collection<DealerStatementInstitutionAddressLine_2> InstitutionAddressLine
        {
            get
            {
                return _institutionAddressLine;
            }
            set
            {
                _institutionAddressLine = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the InstitutionAddressLine collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool InstitutionAddressLineSpecified
        {
            get
            {
                return ((this.InstitutionAddressLine != null) 
                            && (this.InstitutionAddressLine.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<DealerStatementMessageLine1_2> _messageLine1;
        
        [XmlElementAttribute("MessageLine1", Order=10, Form=XmlSchemaForm.Unqualified)]
        public Collection<DealerStatementMessageLine1_2> MessageLine1
        {
            get
            {
                return _messageLine1;
            }
            set
            {
                _messageLine1 = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the MessageLine1 collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool MessageLine1Specified
        {
            get
            {
                return ((this.MessageLine1 != null) 
                            && (this.MessageLine1.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<DealerStatementMessageLine2_2> _messageLine2;
        
        [XmlElementAttribute("MessageLine2", Order=11, Form=XmlSchemaForm.Unqualified)]
        public Collection<DealerStatementMessageLine2_2> MessageLine2
        {
            get
            {
                return _messageLine2;
            }
            set
            {
                _messageLine2 = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the MessageLine2 collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool MessageLine2Specified
        {
            get
            {
                return ((this.MessageLine2 != null) 
                            && (this.MessageLine2.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NegativeSignOption", Order=12, Form=XmlSchemaForm.Unqualified)]
        public short NegativeSignOptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NegativeSignOption property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NegativeSignOptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> NegativeSignOption
        {
            get
            {
                if (this.NegativeSignOptionValueSpecified)
                {
                    return this.NegativeSignOptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NegativeSignOptionValue = value.GetValueOrDefault();
                this.NegativeSignOptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NumberoftimesGenerated", Order=13, Form=XmlSchemaForm.Unqualified)]
        public int NumberoftimesGeneratedValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NumberoftimesGenerated property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NumberoftimesGeneratedValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> NumberoftimesGenerated
        {
            get
            {
                if (this.NumberoftimesGeneratedValueSpecified)
                {
                    return this.NumberoftimesGeneratedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NumberoftimesGeneratedValue = value.GetValueOrDefault();
                this.NumberoftimesGeneratedValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PrintDatesinHeader", Order=14, Form=XmlSchemaForm.Unqualified)]
        public bool PrintDatesinHeaderValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PrintDatesinHeader property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PrintDatesinHeaderValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PrintDatesinHeader
        {
            get
            {
                if (this.PrintDatesinHeaderValueSpecified)
                {
                    return this.PrintDatesinHeaderValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PrintDatesinHeaderValue = value.GetValueOrDefault();
                this.PrintDatesinHeaderValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PrintTransactionDates", Order=15, Form=XmlSchemaForm.Unqualified)]
        public bool PrintTransactionDatesValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PrintTransactionDates property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PrintTransactionDatesValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PrintTransactionDates
        {
            get
            {
                if (this.PrintTransactionDatesValueSpecified)
                {
                    return this.PrintTransactionDatesValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PrintTransactionDatesValue = value.GetValueOrDefault();
                this.PrintTransactionDatesValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PrintTransactionDetail", Order=16, Form=XmlSchemaForm.Unqualified)]
        public bool PrintTransactionDetailValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PrintTransactionDetail property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PrintTransactionDetailValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PrintTransactionDetail
        {
            get
            {
                if (this.PrintTransactionDetailValueSpecified)
                {
                    return this.PrintTransactionDetailValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PrintTransactionDetailValue = value.GetValueOrDefault();
                this.PrintTransactionDetailValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SeparateClosedDealer", Order=17, Form=XmlSchemaForm.Unqualified)]
        public bool SeparateClosedDealerValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SeparateClosedDealer property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SeparateClosedDealerValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> SeparateClosedDealer
        {
            get
            {
                if (this.SeparateClosedDealerValueSpecified)
                {
                    return this.SeparateClosedDealerValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SeparateClosedDealerValue = value.GetValueOrDefault();
                this.SeparateClosedDealerValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("StatementCutoffDate", Order=18, Form=XmlSchemaForm.Unqualified, IsNullable=true, DataType="date")]
        public Nullable<DateTime> StatementCutoffDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the StatementCutoffDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool StatementCutoffDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> StatementCutoffDate
        {
            get
            {
                if (this.StatementCutoffDateValueSpecified)
                {
                    return this.StatementCutoffDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StatementCutoffDateValue = value.GetValueOrDefault();
                this.StatementCutoffDateValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("StatementDates", Order=19, Form=XmlSchemaForm.Unqualified)]
        public string StatementDates { get; set; }
        
        [XmlElementAttribute("StatementGroupList", Order=20, Form=XmlSchemaForm.Unqualified)]
        public string StatementGroupList { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SuppressDealerNumberZeros", Order=21, Form=XmlSchemaForm.Unqualified)]
        public bool SuppressDealerNumberZerosValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SuppressDealerNumberZeros property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SuppressDealerNumberZerosValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> SuppressDealerNumberZeros
        {
            get
            {
                if (this.SuppressDealerNumberZerosValueSpecified)
                {
                    return this.SuppressDealerNumberZerosValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SuppressDealerNumberZerosValue = value.GetValueOrDefault();
                this.SuppressDealerNumberZerosValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("TotalDealerReserve", Order=22, Form=XmlSchemaForm.Unqualified)]
        public string TotalDealerReserve { get; set; }
        
        [XmlElementAttribute("UpfrontReserve", Order=23, Form=XmlSchemaForm.Unqualified)]
        public string UpfrontReserve { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UseCommas", Order=24, Form=XmlSchemaForm.Unqualified)]
        public bool UseCommasValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UseCommas property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UseCommasValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> UseCommas
        {
            get
            {
                if (this.UseCommasValueSpecified)
                {
                    return this.UseCommasValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UseCommasValue = value.GetValueOrDefault();
                this.UseCommasValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UseContactName", Order=25, Form=XmlSchemaForm.Unqualified)]
        public bool UseContactNameValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UseContactName property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UseContactNameValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> UseContactName
        {
            get
            {
                if (this.UseContactNameValueSpecified)
                {
                    return this.UseContactNameValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UseContactNameValue = value.GetValueOrDefault();
                this.UseContactNameValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("YtdTotalPrinting", Order=26, Form=XmlSchemaForm.Unqualified)]
        public bool YtdTotalPrintingValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the YtdTotalPrinting property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool YtdTotalPrintingValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> YtdTotalPrinting
        {
            get
            {
                if (this.YtdTotalPrintingValueSpecified)
                {
                    return this.YtdTotalPrintingValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.YtdTotalPrintingValue = value.GetValueOrDefault();
                this.YtdTotalPrintingValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=27, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=28)]
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
