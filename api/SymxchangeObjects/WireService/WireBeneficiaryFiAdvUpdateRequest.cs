//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\WireService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\WireService\generated-output -n WireService
namespace WireService
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
    [XmlTypeAttribute("WireBeneficiaryFiAdvUpdateRequest", Namespace="http://www.symxchange.generated.symitar.com/crud/wire/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class WireBeneficiaryFiAdvUpdateRequest
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("WireBeneficiaryFiAdvLocator", Order=0, Form=XmlSchemaForm.Unqualified)]
        public int WireBeneficiaryFiAdvLocatorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the WireBeneficiaryFiAdvLocator property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool WireBeneficiaryFiAdvLocatorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> WireBeneficiaryFiAdvLocator
        {
            get
            {
                if (this.WireBeneficiaryFiAdvLocatorValueSpecified)
                {
                    return this.WireBeneficiaryFiAdvLocatorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.WireBeneficiaryFiAdvLocatorValue = value.GetValueOrDefault();
                this.WireBeneficiaryFiAdvLocatorValueSpecified = value.HasValue;
            }
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("WireBeneficiaryFiAdvFields", Order=1, Form=XmlSchemaForm.Unqualified)]
        public WireBeneficiaryFiAdvFields_2 WireBeneficiaryFiAdvFields { get; set; }
    }
}
