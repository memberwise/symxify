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
    [XmlTypeAttribute("PartTrackingTypeUpdateRequest", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class PartTrackingTypeUpdateRequest
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PartTrackingTypeRecordSelection", Order=0, Form=XmlSchemaForm.Unqualified)]
        public short PartTrackingTypeRecordSelectionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PartTrackingTypeRecordSelection property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PartTrackingTypeRecordSelectionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> PartTrackingTypeRecordSelection
        {
            get
            {
                if (this.PartTrackingTypeRecordSelectionValueSpecified)
                {
                    return this.PartTrackingTypeRecordSelectionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PartTrackingTypeRecordSelectionValue = value.GetValueOrDefault();
                this.PartTrackingTypeRecordSelectionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PartTrackingTypeTrackingType", Order=1, Form=XmlSchemaForm.Unqualified)]
        public short PartTrackingTypeTrackingTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PartTrackingTypeTrackingType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PartTrackingTypeTrackingTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> PartTrackingTypeTrackingType
        {
            get
            {
                if (this.PartTrackingTypeTrackingTypeValueSpecified)
                {
                    return this.PartTrackingTypeTrackingTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PartTrackingTypeTrackingTypeValue = value.GetValueOrDefault();
                this.PartTrackingTypeTrackingTypeValueSpecified = value.HasValue;
            }
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("PartTrackingTypeFields", Order=2, Form=XmlSchemaForm.Unqualified)]
        public PartTrackingTypeFields_2 PartTrackingTypeFields { get; set; }
    }
}
