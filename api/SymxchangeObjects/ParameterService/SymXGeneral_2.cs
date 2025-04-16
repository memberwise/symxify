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
    [XmlTypeAttribute("SymXGeneral", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("SymXGeneral", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [XmlIncludeAttribute(typeof(SymXGeneralFields_2))]
    public partial class SymXGeneral_2
    {
        
        [XmlIgnoreAttribute()]
        private Collection<SymXGeneralCustomSpecfile_2> _customSpecfile;
        
        [XmlElementAttribute("CustomSpecfile", Order=0, Form=XmlSchemaForm.Unqualified)]
        public Collection<SymXGeneralCustomSpecfile_2> CustomSpecfile
        {
            get
            {
                return _customSpecfile;
            }
            set
            {
                _customSpecfile = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CustomSpecfile collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CustomSpecfileSpecified
        {
            get
            {
                return ((this.CustomSpecfile != null) 
                            && (this.CustomSpecfile.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="SymXGeneral_2" /> class.</para>
        /// </summary>
        public SymXGeneral_2()
        {
            this._customSpecfile = new Collection<SymXGeneralCustomSpecfile_2>();
            this._specfileLoadMethod = new Collection<SymXGeneralSpecfileLoadMethod_2>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlElementAttribute("FicsAppPassword", Order=1, Form=XmlSchemaForm.Unqualified)]
        public string FicsAppPassword { get; set; }
        
        [XmlElementAttribute("FicsAppUserId", Order=2, Form=XmlSchemaForm.Unqualified)]
        public string FicsAppUserId { get; set; }
        
        [XmlElementAttribute("FicsDataSourceName", Order=3, Form=XmlSchemaForm.Unqualified)]
        public string FicsDataSourceName { get; set; }
        
        [XmlElementAttribute("FicsDbPassword", Order=4, Form=XmlSchemaForm.Unqualified)]
        public string FicsDbPassword { get; set; }
        
        [XmlElementAttribute("FicsDbUserId", Order=5, Form=XmlSchemaForm.Unqualified)]
        public string FicsDbUserId { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("InstanceId", Order=6, Form=XmlSchemaForm.Unqualified)]
        public short InstanceIdValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the InstanceId property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool InstanceIdValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> InstanceId
        {
            get
            {
                if (this.InstanceIdValueSpecified)
                {
                    return this.InstanceIdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.InstanceIdValue = value.GetValueOrDefault();
                this.InstanceIdValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NoticesPrinterType", Order=7, Form=XmlSchemaForm.Unqualified)]
        public short NoticesPrinterTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NoticesPrinterType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NoticesPrinterTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> NoticesPrinterType
        {
            get
            {
                if (this.NoticesPrinterTypeValueSpecified)
                {
                    return this.NoticesPrinterTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NoticesPrinterTypeValue = value.GetValueOrDefault();
                this.NoticesPrinterTypeValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<SymXGeneralSpecfileLoadMethod_2> _specfileLoadMethod;
        
        [XmlElementAttribute("SpecfileLoadMethod", Order=8, Form=XmlSchemaForm.Unqualified)]
        public Collection<SymXGeneralSpecfileLoadMethod_2> SpecfileLoadMethod
        {
            get
            {
                return _specfileLoadMethod;
            }
            set
            {
                _specfileLoadMethod = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the SpecfileLoadMethod collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SpecfileLoadMethodSpecified
        {
            get
            {
                return ((this.SpecfileLoadMethod != null) 
                            && (this.SpecfileLoadMethod.Count != 0));
            }
        }
        
        [XmlElementAttribute("Version_1", Order=9, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=10)]
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
