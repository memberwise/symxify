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
    [XmlTypeAttribute("ShareCheckOrderImprintLineSize", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/update", AnonymousType=true)]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("ShareCheckOrderImprintLineSize", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/update")]
    public partial class ShareCheckOrderImprintLineSize_2
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
        [XmlElementAttribute("ImprintLineSize", Order=1, Form=XmlSchemaForm.Unqualified)]
        public short ImprintLineSizeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ImprintLineSize property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ImprintLineSizeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> ImprintLineSize
        {
            get
            {
                if (this.ImprintLineSizeValueSpecified)
                {
                    return this.ImprintLineSizeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ImprintLineSizeValue = value.GetValueOrDefault();
                this.ImprintLineSizeValueSpecified = value.HasValue;
            }
        }
    }
}
