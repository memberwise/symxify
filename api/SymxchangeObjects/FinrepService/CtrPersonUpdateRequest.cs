//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\FinrepService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\FinrepService\generated-output -n FinrepService
namespace FinrepService
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
    [XmlTypeAttribute("CtrPersonUpdateRequest", Namespace="http://www.symxchange.generated.symitar.com/crud/finrep/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class CtrPersonUpdateRequest
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CtrPersonLocator", Order=0, Form=XmlSchemaForm.Unqualified)]
        public int CtrPersonLocatorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CtrPersonLocator property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CtrPersonLocatorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> CtrPersonLocator
        {
            get
            {
                if (this.CtrPersonLocatorValueSpecified)
                {
                    return this.CtrPersonLocatorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CtrPersonLocatorValue = value.GetValueOrDefault();
                this.CtrPersonLocatorValueSpecified = value.HasValue;
            }
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("CtrPersonFields", Order=1, Form=XmlSchemaForm.Unqualified)]
        public CtrPersonFields_2 CtrPersonFields { get; set; }
    }
}
