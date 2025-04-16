//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\TransactionsService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\TransactionsService\generated-output -n TransactionsService
namespace TransactionsService
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
    [XmlTypeAttribute("CashDeviceType", Namespace="http://www.symxchange.generated.symitar.com/noncrud/transactions/dto")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class CashDeviceType
    {
        
        [XmlElementAttribute("Denominations", Order=0, Form=XmlSchemaForm.Unqualified)]
        public CashDeviceTypeDenominations Denominations { get; set; }
        
        [XmlElementAttribute("Coin", Order=1, Form=XmlSchemaForm.Unqualified)]
        public CoinType Coin { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Orientation", Order=2, Form=XmlSchemaForm.Unqualified)]
        public CashDeviceTypeOrientation OrientationValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Orientation property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OrientationValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<CashDeviceTypeOrientation> Orientation
        {
            get
            {
                if (this.OrientationValueSpecified)
                {
                    return this.OrientationValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OrientationValue = value.GetValueOrDefault();
                this.OrientationValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=3, Form=XmlSchemaForm.Unqualified)]
        public TransactionsService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=4)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CashDeviceType" /> class.</para>
        /// </summary>
        public CashDeviceType()
        {
            this._any = new Collection<XmlElement>();
        }
        
        [XmlAttributeAttribute("name")]
        public string Name { get; set; }
    }
}
