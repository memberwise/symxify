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
    [XmlTypeAttribute("WireCorpVer", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("WireCorpVer", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [XmlIncludeAttribute(typeof(WireCorpVerFields_2))]
    public partial class WireCorpVer_2
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CorpEnteredMbrVerifyMins", Order=0, Form=XmlSchemaForm.Unqualified)]
        public short CorpEnteredMbrVerifyMinsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CorpEnteredMbrVerifyMins property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CorpEnteredMbrVerifyMinsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> CorpEnteredMbrVerifyMins
        {
            get
            {
                if (this.CorpEnteredMbrVerifyMinsValueSpecified)
                {
                    return this.CorpEnteredMbrVerifyMinsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CorpEnteredMbrVerifyMinsValue = value.GetValueOrDefault();
                this.CorpEnteredMbrVerifyMinsValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NewWireMinVerifyAmt", Order=1, Form=XmlSchemaForm.Unqualified)]
        public decimal NewWireMinVerifyAmtValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NewWireMinVerifyAmt property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NewWireMinVerifyAmtValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> NewWireMinVerifyAmt
        {
            get
            {
                if (this.NewWireMinVerifyAmtValueSpecified)
                {
                    return this.NewWireMinVerifyAmtValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NewWireMinVerifyAmtValue = value.GetValueOrDefault();
                this.NewWireMinVerifyAmtValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PreAuthMinVerifyAmt", Order=2, Form=XmlSchemaForm.Unqualified)]
        public decimal PreAuthMinVerifyAmtValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PreAuthMinVerifyAmt property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PreAuthMinVerifyAmtValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> PreAuthMinVerifyAmt
        {
            get
            {
                if (this.PreAuthMinVerifyAmtValueSpecified)
                {
                    return this.PreAuthMinVerifyAmtValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PreAuthMinVerifyAmtValue = value.GetValueOrDefault();
                this.PreAuthMinVerifyAmtValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("VerifyPreAuthTemplateEdits", Order=3, Form=XmlSchemaForm.Unqualified)]
        public short VerifyPreAuthTemplateEditsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the VerifyPreAuthTemplateEdits property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool VerifyPreAuthTemplateEditsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> VerifyPreAuthTemplateEdits
        {
            get
            {
                if (this.VerifyPreAuthTemplateEditsValueSpecified)
                {
                    return this.VerifyPreAuthTemplateEditsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.VerifyPreAuthTemplateEditsValue = value.GetValueOrDefault();
                this.VerifyPreAuthTemplateEditsValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("WesternUnionMinVerifyAmt", Order=4, Form=XmlSchemaForm.Unqualified)]
        public decimal WesternUnionMinVerifyAmtValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the WesternUnionMinVerifyAmt property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool WesternUnionMinVerifyAmtValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> WesternUnionMinVerifyAmt
        {
            get
            {
                if (this.WesternUnionMinVerifyAmtValueSpecified)
                {
                    return this.WesternUnionMinVerifyAmtValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.WesternUnionMinVerifyAmtValue = value.GetValueOrDefault();
                this.WesternUnionMinVerifyAmtValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=5, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=6)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WireCorpVer_2" /> class.</para>
        /// </summary>
        public WireCorpVer_2()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
