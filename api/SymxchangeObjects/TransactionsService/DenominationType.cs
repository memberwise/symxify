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
    [XmlTypeAttribute("DenominationType", Namespace="http://www.symxchange.generated.symitar.com/noncrud/transactions/dto")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class DenominationType
    {
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Unit", Order=0, Form=XmlSchemaForm.Unqualified)]
        public int UnitValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Unit property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UnitValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public Nullable<int> Unit
        {
            get
            {
                if (this.UnitValueSpecified)
                {
                    return this.UnitValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UnitValue = value.GetValueOrDefault();
                this.UnitValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Count", Order=1, Form=XmlSchemaForm.Unqualified)]
        public int CountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Count property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CountValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public Nullable<int> Count
        {
            get
            {
                if (this.CountValueSpecified)
                {
                    return this.CountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CountValue = value.GetValueOrDefault();
                this.CountValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Status", Order=2, Form=XmlSchemaForm.Unqualified)]
        public StatusType StatusValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Status property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool StatusValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<StatusType> Status
        {
            get
            {
                if (this.StatusValueSpecified)
                {
                    return this.StatusValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StatusValue = value.GetValueOrDefault();
                this.StatusValueSpecified = value.HasValue;
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DenominationType" /> class.</para>
        /// </summary>
        public DenominationType()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
