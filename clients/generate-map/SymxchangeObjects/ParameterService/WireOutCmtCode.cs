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
    [XmlTypeAttribute("WireOutCmtCode", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("WireOutCmtCode", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class WireOutCmtCode
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CorporateCommCode", Order=0, Form=XmlSchemaForm.Unqualified)]
        public short CorporateCommCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CorporateCommCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CorporateCommCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> CorporateCommCode
        {
            get
            {
                if (this.CorporateCommCodeValueSpecified)
                {
                    return this.CorporateCommCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CorporateCommCodeValue = value.GetValueOrDefault();
                this.CorporateCommCodeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("MatchBusFunctionCode", Order=1, Form=XmlSchemaForm.Unqualified)]
        public string MatchBusFunctionCode { get; set; }
        
        [XmlElementAttribute("MatchTypeCode", Order=2, Form=XmlSchemaForm.Unqualified)]
        public string MatchTypeCode { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MatchWireType", Order=3, Form=XmlSchemaForm.Unqualified)]
        public short MatchWireTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MatchWireType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MatchWireTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> MatchWireType
        {
            get
            {
                if (this.MatchWireTypeValueSpecified)
                {
                    return this.MatchWireTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MatchWireTypeValue = value.GetValueOrDefault();
                this.MatchWireTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MemberCommentCode", Order=4, Form=XmlSchemaForm.Unqualified)]
        public short MemberCommentCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MemberCommentCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MemberCommentCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> MemberCommentCode
        {
            get
            {
                if (this.MemberCommentCodeValueSpecified)
                {
                    return this.MemberCommentCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MemberCommentCodeValue = value.GetValueOrDefault();
                this.MemberCommentCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Selection", Order=5, Form=XmlSchemaForm.Unqualified)]
        public short SelectionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Selection property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SelectionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> Selection
        {
            get
            {
                if (this.SelectionValueSpecified)
                {
                    return this.SelectionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SelectionValue = value.GetValueOrDefault();
                this.SelectionValueSpecified = value.HasValue;
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WireOutCmtCode" /> class.</para>
        /// </summary>
        public WireOutCmtCode()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
