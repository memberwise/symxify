//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\DealerService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\DealerService\generated-output -n DealerService
namespace DealerService
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
    [XmlTypeAttribute("ReservePlanTransactionSelectableFields", Namespace="http://www.symxchange.generated.symitar.com/crud/dealer/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class ReservePlanTransactionSelectableFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IncludeAllReservePlanTransactionFields", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool IncludeAllReservePlanTransactionFieldsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IncludeAllReservePlanTransactionFields property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IncludeAllReservePlanTransactionFieldsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IncludeAllReservePlanTransactionFields
        {
            get
            {
                if (this.IncludeAllReservePlanTransactionFieldsValueSpecified)
                {
                    return this.IncludeAllReservePlanTransactionFieldsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IncludeAllReservePlanTransactionFieldsValue = value.GetValueOrDefault();
                this.IncludeAllReservePlanTransactionFieldsValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("ReservePlanTransactionFields", Order=1, Form=XmlSchemaForm.Unqualified)]
        public ReservePlanTransactionFields ReservePlanTransactionFields { get; set; }
        
        [XmlElementAttribute("Version_1", Order=2, Form=XmlSchemaForm.Unqualified)]
        public DealerService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=3)]
        public Collection<XmlElement> Any
        {
            get
            {
                return _any;
            }
            set
            {
                _any = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get
            {
                return ((this.Any != null) 
                            && (this.Any.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ReservePlanTransactionSelectableFields" /> class.</para>
        /// </summary>
        public ReservePlanTransactionSelectableFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
