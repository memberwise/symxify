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
    [XmlTypeAttribute("LoanPromoRateOffset", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve", AnonymousType=true)]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("LoanPromoRateOffset", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve")]
    public partial class LoanPromoRateOffset
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
        [XmlElementAttribute("PromoRateOffset", Order=1, Form=XmlSchemaForm.Unqualified)]
        public decimal PromoRateOffsetValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PromoRateOffset property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PromoRateOffsetValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> PromoRateOffset
        {
            get
            {
                if (this.PromoRateOffsetValueSpecified)
                {
                    return this.PromoRateOffsetValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PromoRateOffsetValue = value.GetValueOrDefault();
                this.PromoRateOffsetValueSpecified = value.HasValue;
            }
        }
    }
}
