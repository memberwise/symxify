//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\GeneralLedgerService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\GeneralLedgerService\generated-output -n GeneralLedgerService
namespace GeneralLedgerService
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
    [XmlTypeAttribute("GlAccountTrackingUpdateRequest", Namespace="http://www.symxchange.generated.symitar.com/crud/generalledger/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class GlAccountTrackingUpdateRequest
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("GlAccountTrackingLocator", Order=0, Form=XmlSchemaForm.Unqualified)]
        public int GlAccountTrackingLocatorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the GlAccountTrackingLocator property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool GlAccountTrackingLocatorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> GlAccountTrackingLocator
        {
            get
            {
                if (this.GlAccountTrackingLocatorValueSpecified)
                {
                    return this.GlAccountTrackingLocatorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.GlAccountTrackingLocatorValue = value.GetValueOrDefault();
                this.GlAccountTrackingLocatorValueSpecified = value.HasValue;
            }
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("GlAccountTrackingFields", Order=1, Form=XmlSchemaForm.Unqualified)]
        public GlAccountTrackingFields_2 GlAccountTrackingFields { get; set; }
    }
}
