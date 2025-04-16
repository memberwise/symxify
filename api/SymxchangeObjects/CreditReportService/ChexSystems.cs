//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\CreditreportService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\CreditreportService\generated-output -n CreditReportService
namespace CreditReportService
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
    [XmlTypeAttribute("ChexSystems", Namespace="http://www.symxchange.generated.symitar.com/noncrud/creditreport/dto", AnonymousType=true)]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("ChexSystems", Namespace="http://www.symxchange.generated.symitar.com/noncrud/creditreport/dto")]
    public partial class ChexSystems
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IncludeNewAccountChex", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool IncludeNewAccountChexValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IncludeNewAccountChex property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IncludeNewAccountChexValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IncludeNewAccountChex
        {
            get
            {
                if (this.IncludeNewAccountChexValueSpecified)
                {
                    return this.IncludeNewAccountChexValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IncludeNewAccountChexValue = value.GetValueOrDefault();
                this.IncludeNewAccountChexValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IncludeQualiFile", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool IncludeQualiFileValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IncludeQualiFile property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IncludeQualiFileValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IncludeQualiFile
        {
            get
            {
                if (this.IncludeQualiFileValueSpecified)
                {
                    return this.IncludeQualiFileValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IncludeQualiFileValue = value.GetValueOrDefault();
                this.IncludeQualiFileValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IncludeIDVerification", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool IncludeIdVerificationValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IncludeIdVerification property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IncludeIdVerificationValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IncludeIdVerification
        {
            get
            {
                if (this.IncludeIdVerificationValueSpecified)
                {
                    return this.IncludeIdVerificationValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IncludeIdVerificationValue = value.GetValueOrDefault();
                this.IncludeIdVerificationValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IncludeOFACWatch", Order=3, Form=XmlSchemaForm.Unqualified)]
        public bool IncludeOfacWatchValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IncludeOfacWatch property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IncludeOfacWatchValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IncludeOfacWatch
        {
            get
            {
                if (this.IncludeOfacWatchValueSpecified)
                {
                    return this.IncludeOfacWatchValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IncludeOfacWatchValue = value.GetValueOrDefault();
                this.IncludeOfacWatchValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=4, Form=XmlSchemaForm.Unqualified)]
        public CreditReportService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=5)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ChexSystems" /> class.</para>
        /// </summary>
        public ChexSystems()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
