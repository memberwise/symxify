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
    [XmlTypeAttribute("EscrowTypeFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("EscrowTypeFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class EscrowTypeFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AdjustPaymentPortion", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool AdjustPaymentPortionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AdjustPaymentPortion property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AdjustPaymentPortionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> AdjustPaymentPortion
        {
            get
            {
                if (this.AdjustPaymentPortionValueSpecified)
                {
                    return this.AdjustPaymentPortionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AdjustPaymentPortionValue = value.GetValueOrDefault();
                this.AdjustPaymentPortionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CrEscDividendinPayoff", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool CrEscDividendinPayoffValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CrEscDividendinPayoff property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CrEscDividendinPayoffValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CrEscDividendinPayoff
        {
            get
            {
                if (this.CrEscDividendinPayoffValueSpecified)
                {
                    return this.CrEscDividendinPayoffValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CrEscDividendinPayoffValue = value.GetValueOrDefault();
                this.CrEscDividendinPayoffValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("DaysinAdvancetoPrintRpt", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool DaysinAdvancetoPrintRptValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DaysinAdvancetoPrintRpt property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DaysinAdvancetoPrintRptValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> DaysinAdvancetoPrintRpt
        {
            get
            {
                if (this.DaysinAdvancetoPrintRptValueSpecified)
                {
                    return this.DaysinAdvancetoPrintRptValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DaysinAdvancetoPrintRptValue = value.GetValueOrDefault();
                this.DaysinAdvancetoPrintRptValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("DefinedCode", Order=3, Form=XmlSchemaForm.Unqualified)]
        public bool DefinedCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DefinedCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DefinedCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> DefinedCode
        {
            get
            {
                if (this.DefinedCodeValueSpecified)
                {
                    return this.DefinedCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DefinedCodeValue = value.GetValueOrDefault();
                this.DefinedCodeValueSpecified = value.HasValue;
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
        [XmlElementAttribute("EscrowType", Order=5, Form=XmlSchemaForm.Unqualified)]
        public bool EscrowTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EscrowType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EscrowTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> EscrowType
        {
            get
            {
                if (this.EscrowTypeValueSpecified)
                {
                    return this.EscrowTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EscrowTypeValue = value.GetValueOrDefault();
                this.EscrowTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IncludeEscrowBalinPayoff", Order=6, Form=XmlSchemaForm.Unqualified)]
        public bool IncludeEscrowBalinPayoffValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IncludeEscrowBalinPayoff property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IncludeEscrowBalinPayoffValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IncludeEscrowBalinPayoff
        {
            get
            {
                if (this.IncludeEscrowBalinPayoffValueSpecified)
                {
                    return this.IncludeEscrowBalinPayoffValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IncludeEscrowBalinPayoffValue = value.GetValueOrDefault();
                this.IncludeEscrowBalinPayoffValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IncludeinEscrowAnalysis", Order=7, Form=XmlSchemaForm.Unqualified)]
        public bool IncludeinEscrowAnalysisValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IncludeinEscrowAnalysis property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IncludeinEscrowAnalysisValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IncludeinEscrowAnalysis
        {
            get
            {
                if (this.IncludeinEscrowAnalysisValueSpecified)
                {
                    return this.IncludeinEscrowAnalysisValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IncludeinEscrowAnalysisValue = value.GetValueOrDefault();
                this.IncludeinEscrowAnalysisValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("InvoiceType", Order=8, Form=XmlSchemaForm.Unqualified)]
        public bool InvoiceTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the InvoiceType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool InvoiceTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> InvoiceType
        {
            get
            {
                if (this.InvoiceTypeValueSpecified)
                {
                    return this.InvoiceTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.InvoiceTypeValue = value.GetValueOrDefault();
                this.InvoiceTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NumberofCushionMonths", Order=9, Form=XmlSchemaForm.Unqualified)]
        public bool NumberofCushionMonthsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NumberofCushionMonths property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NumberofCushionMonthsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> NumberofCushionMonths
        {
            get
            {
                if (this.NumberofCushionMonthsValueSpecified)
                {
                    return this.NumberofCushionMonthsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NumberofCushionMonthsValue = value.GetValueOrDefault();
                this.NumberofCushionMonthsValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PaymentType", Order=10, Form=XmlSchemaForm.Unqualified)]
        public bool PaymentTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PaymentType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PaymentTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PaymentType
        {
            get
            {
                if (this.PaymentTypeValueSpecified)
                {
                    return this.PaymentTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PaymentTypeValue = value.GetValueOrDefault();
                this.PaymentTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("StatementDescription", Order=11, Form=XmlSchemaForm.Unqualified)]
        public bool StatementDescriptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the StatementDescription property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool StatementDescriptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> StatementDescription
        {
            get
            {
                if (this.StatementDescriptionValueSpecified)
                {
                    return this.StatementDescriptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StatementDescriptionValue = value.GetValueOrDefault();
                this.StatementDescriptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("TransactionDescription", Order=12, Form=XmlSchemaForm.Unqualified)]
        public bool TransactionDescriptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TransactionDescription property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TransactionDescriptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> TransactionDescription
        {
            get
            {
                if (this.TransactionDescriptionValueSpecified)
                {
                    return this.TransactionDescriptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TransactionDescriptionValue = value.GetValueOrDefault();
                this.TransactionDescriptionValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=13, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EscrowTypeFields" /> class.</para>
        /// </summary>
        public EscrowTypeFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
