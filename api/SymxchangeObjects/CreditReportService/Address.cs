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
    [XmlTypeAttribute("Address", Namespace="http://www.symxchange.generated.symitar.com/noncrud/creditreport/dto", AnonymousType=true)]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("Address", Namespace="http://www.symxchange.generated.symitar.com/noncrud/creditreport/dto")]
    public partial class Address
    {
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 10.</para>
        /// </summary>
        [MinLengthAttribute(1)]
        [MaxLengthAttribute(10)]
        [XmlElementAttribute("HouseNumber", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string HouseNumber { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 2.</para>
        /// </summary>
        [MinLengthAttribute(1)]
        [MaxLengthAttribute(2)]
        [XmlElementAttribute("Directional", Order=1, Form=XmlSchemaForm.Unqualified)]
        public string Directional { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 40.</para>
        /// </summary>
        [MinLengthAttribute(1)]
        [MaxLengthAttribute(40)]
        [XmlElementAttribute("StreetName", Order=2, Form=XmlSchemaForm.Unqualified)]
        public string StreetName { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 2.</para>
        /// </summary>
        [MinLengthAttribute(1)]
        [MaxLengthAttribute(2)]
        [XmlElementAttribute("StreetType", Order=3, Form=XmlSchemaForm.Unqualified)]
        public string StreetType { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 20.</para>
        /// </summary>
        [MinLengthAttribute(1)]
        [MaxLengthAttribute(20)]
        [XmlElementAttribute("City", Order=4, Form=XmlSchemaForm.Unqualified)]
        public string City { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 10.</para>
        /// </summary>
        [MinLengthAttribute(1)]
        [MaxLengthAttribute(10)]
        [XmlElementAttribute("State", Order=5, Form=XmlSchemaForm.Unqualified)]
        public string State { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 10.</para>
        /// </summary>
        [MinLengthAttribute(1)]
        [MaxLengthAttribute(10)]
        [XmlElementAttribute("ZipCode", Order=6, Form=XmlSchemaForm.Unqualified)]
        public string ZipCode { get; set; }
        
        [XmlElementAttribute("Version_1", Order=7, Form=XmlSchemaForm.Unqualified)]
        public CreditReportService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=8)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Address" /> class.</para>
        /// </summary>
        public Address()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
