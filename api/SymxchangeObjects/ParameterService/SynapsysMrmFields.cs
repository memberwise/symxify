//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\ParameterService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\ParameterService\generated-output -n ParameterService
namespace ParameterService
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
    [XmlTypeAttribute("SynapsysMrmFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("SynapsysMrmFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class SynapsysMrmFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EnableSynapsysMrmDevice", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool EnableSynapsysMrmDeviceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EnableSynapsysMrmDevice property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EnableSynapsysMrmDeviceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> EnableSynapsysMrmDevice
        {
            get
            {
                if (this.EnableSynapsysMrmDeviceValueSpecified)
                {
                    return this.EnableSynapsysMrmDeviceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EnableSynapsysMrmDeviceValue = value.GetValueOrDefault();
                this.EnableSynapsysMrmDeviceValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EnableTellerTranMrmDisplay", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool EnableTellerTranMrmDisplayValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EnableTellerTranMrmDisplay property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EnableTellerTranMrmDisplayValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> EnableTellerTranMrmDisplay
        {
            get
            {
                if (this.EnableTellerTranMrmDisplayValueSpecified)
                {
                    return this.EnableTellerTranMrmDisplayValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EnableTellerTranMrmDisplayValue = value.GetValueOrDefault();
                this.EnableTellerTranMrmDisplayValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IpAddress", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool IpAddressValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IpAddress property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IpAddressValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IpAddress
        {
            get
            {
                if (this.IpAddressValueSpecified)
                {
                    return this.IpAddressValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IpAddressValue = value.GetValueOrDefault();
                this.IpAddressValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PortNumber", Order=3, Form=XmlSchemaForm.Unqualified)]
        public bool PortNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PortNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PortNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PortNumber
        {
            get
            {
                if (this.PortNumberValueSpecified)
                {
                    return this.PortNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PortNumberValue = value.GetValueOrDefault();
                this.PortNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SynapsysCuNumber", Order=4, Form=XmlSchemaForm.Unqualified)]
        public bool SynapsysCuNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SynapsysCuNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SynapsysCuNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> SynapsysCuNumber
        {
            get
            {
                if (this.SynapsysCuNumberValueSpecified)
                {
                    return this.SynapsysCuNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SynapsysCuNumberValue = value.GetValueOrDefault();
                this.SynapsysCuNumberValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Timeout", Order=5, Form=XmlSchemaForm.Unqualified)]
        public bool TimeoutValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Timeout property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TimeoutValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Timeout
        {
            get
            {
                if (this.TimeoutValueSpecified)
                {
                    return this.TimeoutValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TimeoutValue = value.GetValueOrDefault();
                this.TimeoutValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=6, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="SynapsysMrmFields" /> class.</para>
        /// </summary>
        public SynapsysMrmFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
