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
    [XmlTypeAttribute("TptFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class TptFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BlankLines", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool BlankLinesValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BlankLines property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BlankLinesValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> BlankLines
        {
            get
            {
                if (this.BlankLinesValueSpecified)
                {
                    return this.BlankLinesValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BlankLinesValue = value.GetValueOrDefault();
                this.BlankLinesValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CheckDetailLines", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool CheckDetailLinesValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CheckDetailLines property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CheckDetailLinesValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CheckDetailLines
        {
            get
            {
                if (this.CheckDetailLinesValueSpecified)
                {
                    return this.CheckDetailLinesValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CheckDetailLinesValue = value.GetValueOrDefault();
                this.CheckDetailLinesValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Compression", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool CompressionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Compression property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CompressionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Compression
        {
            get
            {
                if (this.CompressionValueSpecified)
                {
                    return this.CompressionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CompressionValue = value.GetValueOrDefault();
                this.CompressionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CustomFormat", Order=3, Form=XmlSchemaForm.Unqualified)]
        public bool CustomFormatValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CustomFormat property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CustomFormatValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CustomFormat
        {
            get
            {
                if (this.CustomFormatValueSpecified)
                {
                    return this.CustomFormatValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CustomFormatValue = value.GetValueOrDefault();
                this.CustomFormatValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("DocumentAccountCode", Order=4, Form=XmlSchemaForm.Unqualified)]
        public bool DocumentAccountCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DocumentAccountCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DocumentAccountCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> DocumentAccountCode
        {
            get
            {
                if (this.DocumentAccountCodeValueSpecified)
                {
                    return this.DocumentAccountCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DocumentAccountCodeValue = value.GetValueOrDefault();
                this.DocumentAccountCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("DocumentNumber", Order=5, Form=XmlSchemaForm.Unqualified)]
        public bool DocumentNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DocumentNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DocumentNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> DocumentNumber
        {
            get
            {
                if (this.DocumentNumberValueSpecified)
                {
                    return this.DocumentNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DocumentNumberValue = value.GetValueOrDefault();
                this.DocumentNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Forms", Order=6, Form=XmlSchemaForm.Unqualified)]
        public bool FormsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Forms property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FormsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Forms
        {
            get
            {
                if (this.FormsValueSpecified)
                {
                    return this.FormsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FormsValue = value.GetValueOrDefault();
                this.FormsValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LinesPerPage", Order=7, Form=XmlSchemaForm.Unqualified)]
        public bool LinesPerPageValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LinesPerPage property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LinesPerPageValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> LinesPerPage
        {
            get
            {
                if (this.LinesPerPageValueSpecified)
                {
                    return this.LinesPerPageValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LinesPerPageValue = value.GetValueOrDefault();
                this.LinesPerPageValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Printer", Order=8, Form=XmlSchemaForm.Unqualified)]
        public bool PrinterValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Printer property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PrinterValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Printer
        {
            get
            {
                if (this.PrinterValueSpecified)
                {
                    return this.PrinterValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PrinterValue = value.GetValueOrDefault();
                this.PrinterValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PrinterType", Order=9, Form=XmlSchemaForm.Unqualified)]
        public bool PrinterTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PrinterType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PrinterTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PrinterType
        {
            get
            {
                if (this.PrinterTypeValueSpecified)
                {
                    return this.PrinterTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PrinterTypeValue = value.GetValueOrDefault();
                this.PrinterTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("QueueNumber", Order=10, Form=XmlSchemaForm.Unqualified)]
        public bool QueueNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the QueueNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool QueueNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> QueueNumber
        {
            get
            {
                if (this.QueueNumberValueSpecified)
                {
                    return this.QueueNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.QueueNumberValue = value.GetValueOrDefault();
                this.QueueNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("QueueSubNumber", Order=11, Form=XmlSchemaForm.Unqualified)]
        public bool QueueSubNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the QueueSubNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool QueueSubNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> QueueSubNumber
        {
            get
            {
                if (this.QueueSubNumberValueSpecified)
                {
                    return this.QueueSubNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.QueueSubNumberValue = value.GetValueOrDefault();
                this.QueueSubNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("QueueSubType", Order=12, Form=XmlSchemaForm.Unqualified)]
        public bool QueueSubTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the QueueSubType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool QueueSubTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> QueueSubType
        {
            get
            {
                if (this.QueueSubTypeValueSpecified)
                {
                    return this.QueueSubTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.QueueSubTypeValue = value.GetValueOrDefault();
                this.QueueSubTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("QueueTypes", Order=13, Form=XmlSchemaForm.Unqualified)]
        public bool QueueTypesValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the QueueTypes property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool QueueTypesValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> QueueTypes
        {
            get
            {
                if (this.QueueTypesValueSpecified)
                {
                    return this.QueueTypesValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.QueueTypesValue = value.GetValueOrDefault();
                this.QueueTypesValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=14, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=15)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TptFields" /> class.</para>
        /// </summary>
        public TptFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
