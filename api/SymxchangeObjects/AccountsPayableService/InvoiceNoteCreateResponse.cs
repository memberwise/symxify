//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\AccountsPayableService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\AccountsPayableService\generated-output -n AccountsPayableService
namespace AccountsPayableService
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
    [XmlTypeAttribute("InvoiceNoteCreateResponse", Namespace="http://www.symxchange.generated.symitar.com/crud/accountspayable")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class InvoiceNoteCreateResponse
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("InvoiceNoteLocator", Order=0, Form=XmlSchemaForm.Unqualified)]
        public int InvoiceNoteLocatorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the InvoiceNoteLocator property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool InvoiceNoteLocatorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> InvoiceNoteLocator
        {
            get
            {
                if (this.InvoiceNoteLocatorValueSpecified)
                {
                    return this.InvoiceNoteLocatorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.InvoiceNoteLocatorValue = value.GetValueOrDefault();
                this.InvoiceNoteLocatorValueSpecified = value.HasValue;
            }
        }
        
        [XmlAttributeAttribute("MessageId")]
        public string MessageId { get; set; }
    }
}
