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
    [XmlTypeAttribute("LoanAppFormPkt", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("LoanAppFormPkt", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [XmlIncludeAttribute(typeof(LoanAppFormPktFields_2))]
    public partial class LoanAppFormPkt_2
    {
        
        [XmlIgnoreAttribute()]
        private Collection<LoanAppFormPktDefaultPrinter_2> _defaultPrinter;
        
        [XmlElementAttribute("DefaultPrinter", Order=0, Form=XmlSchemaForm.Unqualified)]
        public Collection<LoanAppFormPktDefaultPrinter_2> DefaultPrinter
        {
            get
            {
                return _defaultPrinter;
            }
            set
            {
                _defaultPrinter = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DefaultPrinter collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DefaultPrinterSpecified
        {
            get
            {
                return ((this.DefaultPrinter != null) 
                            && (this.DefaultPrinter.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoanAppFormPkt_2" /> class.</para>
        /// </summary>
        public LoanAppFormPkt_2()
        {
            this._defaultPrinter = new Collection<LoanAppFormPktDefaultPrinter_2>();
            this._forcePrinting = new Collection<LoanAppFormPktForcePrinting_2>();
            this._specfileName = new Collection<LoanAppFormPktSpecfileName_2>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlElementAttribute("Description", Order=1, Form=XmlSchemaForm.Unqualified)]
        public string Description { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<LoanAppFormPktForcePrinting_2> _forcePrinting;
        
        [XmlElementAttribute("ForcePrinting", Order=2, Form=XmlSchemaForm.Unqualified)]
        public Collection<LoanAppFormPktForcePrinting_2> ForcePrinting
        {
            get
            {
                return _forcePrinting;
            }
            set
            {
                _forcePrinting = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ForcePrinting collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ForcePrintingSpecified
        {
            get
            {
                return ((this.ForcePrinting != null) 
                            && (this.ForcePrinting.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("FormPacketType", Order=3, Form=XmlSchemaForm.Unqualified)]
        public short FormPacketTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FormPacketType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FormPacketTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> FormPacketType
        {
            get
            {
                if (this.FormPacketTypeValueSpecified)
                {
                    return this.FormPacketTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FormPacketTypeValue = value.GetValueOrDefault();
                this.FormPacketTypeValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<LoanAppFormPktSpecfileName_2> _specfileName;
        
        [XmlElementAttribute("SpecfileName", Order=4, Form=XmlSchemaForm.Unqualified)]
        public Collection<LoanAppFormPktSpecfileName_2> SpecfileName
        {
            get
            {
                return _specfileName;
            }
            set
            {
                _specfileName = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the SpecfileName collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SpecfileNameSpecified
        {
            get
            {
                return ((this.SpecfileName != null) 
                            && (this.SpecfileName.Count != 0));
            }
        }
        
        [XmlElementAttribute("Version_1", Order=5, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=6)]
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
