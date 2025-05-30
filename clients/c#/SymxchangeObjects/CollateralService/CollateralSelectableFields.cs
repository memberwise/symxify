//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\CollateralService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\CollateralService\generated-output -n CollateralService
namespace CollateralService
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
    [XmlTypeAttribute("CollateralSelectableFields", Namespace="http://www.symxchange.generated.symitar.com/crud/collateral/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class CollateralSelectableFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IncludeAllCollateralFields", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool IncludeAllCollateralFieldsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IncludeAllCollateralFields property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IncludeAllCollateralFieldsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IncludeAllCollateralFields
        {
            get
            {
                if (this.IncludeAllCollateralFieldsValueSpecified)
                {
                    return this.IncludeAllCollateralFieldsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IncludeAllCollateralFieldsValue = value.GetValueOrDefault();
                this.IncludeAllCollateralFieldsValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("CollateralFields", Order=1, Form=XmlSchemaForm.Unqualified)]
        public CollateralFields CollateralFields { get; set; }
        
        [XmlElementAttribute("CollateralCollHoldSelectableFields", Order=2, Form=XmlSchemaForm.Unqualified)]
        public CollateralCollHoldSelectableFields CollateralCollHoldSelectableFields { get; set; }
        
        [XmlElementAttribute("CollateralDocumentSelectableFields", Order=3, Form=XmlSchemaForm.Unqualified)]
        public CollateralDocumentSelectableFields CollateralDocumentSelectableFields { get; set; }
        
        [XmlElementAttribute("CollateralFmHistorySelectableFields", Order=4, Form=XmlSchemaForm.Unqualified)]
        public CollateralFmHistorySelectableFields CollateralFmHistorySelectableFields { get; set; }
        
        [XmlElementAttribute("CollateralTrackingSelectableFields", Order=5, Form=XmlSchemaForm.Unqualified)]
        public CollateralTrackingSelectableFields CollateralTrackingSelectableFields { get; set; }
        
        [XmlElementAttribute("Version_1", Order=6, Form=XmlSchemaForm.Unqualified)]
        public CollateralService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=7)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CollateralSelectableFields" /> class.</para>
        /// </summary>
        public CollateralSelectableFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
