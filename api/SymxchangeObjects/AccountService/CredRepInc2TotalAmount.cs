//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\AccountService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\AccountService\generated-output -n AccountService
namespace AccountService
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
    [XmlTypeAttribute("CredRepInc2TotalAmount", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve", AnonymousType=true)]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class CredRepInc2TotalAmount
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EntryId", Order=0, Form=XmlSchemaForm.Unqualified)]
        public short EntryIdValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EntryId property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EntryIdValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> EntryId
        {
            get
            {
                if (this.EntryIdValueSpecified)
                {
                    return this.EntryIdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EntryIdValue = value.GetValueOrDefault();
                this.EntryIdValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Inc2TotalAmount", Order=1, Form=XmlSchemaForm.Unqualified)]
        public decimal Inc2TotalAmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Inc2TotalAmount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool Inc2TotalAmountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> Inc2TotalAmount
        {
            get
            {
                if (this.Inc2TotalAmountValueSpecified)
                {
                    return this.Inc2TotalAmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.Inc2TotalAmountValue = value.GetValueOrDefault();
                this.Inc2TotalAmountValueSpecified = value.HasValue;
            }
        }
    }
}
