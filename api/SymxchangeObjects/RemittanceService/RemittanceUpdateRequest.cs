//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\RemittanceService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\RemittanceService\generated-output -n RemittanceService
namespace RemittanceService
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
    [XmlTypeAttribute("RemittanceUpdateRequest", Namespace="http://www.symxchange.generated.symitar.com/crud/remittance/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class RemittanceUpdateRequest
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RemittanceGlobalSequenceDate", Order=0, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime RemittanceGlobalSequenceDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RemittanceGlobalSequenceDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RemittanceGlobalSequenceDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> RemittanceGlobalSequenceDate
        {
            get
            {
                if (this.RemittanceGlobalSequenceDateValueSpecified)
                {
                    return this.RemittanceGlobalSequenceDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RemittanceGlobalSequenceDateValue = value.GetValueOrDefault();
                this.RemittanceGlobalSequenceDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RemittanceGlobalSequence", Order=1, Form=XmlSchemaForm.Unqualified)]
        public int RemittanceGlobalSequenceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RemittanceGlobalSequence property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RemittanceGlobalSequenceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> RemittanceGlobalSequence
        {
            get
            {
                if (this.RemittanceGlobalSequenceValueSpecified)
                {
                    return this.RemittanceGlobalSequenceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RemittanceGlobalSequenceValue = value.GetValueOrDefault();
                this.RemittanceGlobalSequenceValueSpecified = value.HasValue;
            }
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("RemittanceFields", Order=2, Form=XmlSchemaForm.Unqualified)]
        public RemittanceFields_2 RemittanceFields { get; set; }
    }
}
