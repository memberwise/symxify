//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\ReceivedItemService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\ReceivedItemService\generated-output -n ReceivedItemService
namespace ReceivedItemService
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
    [XmlTypeAttribute("ReceivedItemCompositeKey", Namespace="http://www.symxchange.generated.symitar.com/crud/receiveditem")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class ReceivedItemCompositeKey
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ReceivedItemGlobalSequenceDate", Order=0, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime ReceivedItemGlobalSequenceDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ReceivedItemGlobalSequenceDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ReceivedItemGlobalSequenceDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> ReceivedItemGlobalSequenceDate
        {
            get
            {
                if (this.ReceivedItemGlobalSequenceDateValueSpecified)
                {
                    return this.ReceivedItemGlobalSequenceDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ReceivedItemGlobalSequenceDateValue = value.GetValueOrDefault();
                this.ReceivedItemGlobalSequenceDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ReceivedItemGlobalSequence", Order=1, Form=XmlSchemaForm.Unqualified)]
        public int ReceivedItemGlobalSequenceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ReceivedItemGlobalSequence property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ReceivedItemGlobalSequenceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> ReceivedItemGlobalSequence
        {
            get
            {
                if (this.ReceivedItemGlobalSequenceValueSpecified)
                {
                    return this.ReceivedItemGlobalSequenceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ReceivedItemGlobalSequenceValue = value.GetValueOrDefault();
                this.ReceivedItemGlobalSequenceValueSpecified = value.HasValue;
            }
        }
    }
}
