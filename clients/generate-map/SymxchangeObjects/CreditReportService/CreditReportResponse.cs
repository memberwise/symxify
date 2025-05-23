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
    [XmlTypeAttribute("CreditReportResponse", Namespace="http://www.symxchange.generated.symitar.com/noncrud/creditreport/dto")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class CreditReportResponse : CreditReportBaseResponse
    {
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: -2147483647.</para>
        /// <para xml:lang="en">Maximum inclusive value: 2147483647.</para>
        /// </summary>
        [RangeAttribute(typeof(int), "-2147483647", "2147483647")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CredRepLocator", Order=0, Form=XmlSchemaForm.Unqualified)]
        public int CredRepLocatorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CredRepLocator property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CredRepLocatorValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: -2147483647.</para>
        /// <para xml:lang="en">Maximum inclusive value: 2147483647.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public Nullable<int> CredRepLocator
        {
            get
            {
                if (this.CredRepLocatorValueSpecified)
                {
                    return this.CredRepLocatorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CredRepLocatorValue = value.GetValueOrDefault();
                this.CredRepLocatorValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=1, Form=XmlSchemaForm.Unqualified)]
        public CreditReportService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=2)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CreditReportResponse" /> class.</para>
        /// </summary>
        public CreditReportResponse()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
