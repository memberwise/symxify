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
    [XmlTypeAttribute("AcctLimitFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("AcctLimitFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class AcctLimitFields
    {
        
        [XmlIgnoreAttribute()]
        private Collection<short> _limitDescription;
        
        [XmlElementAttribute("LimitDescription", Order=0, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> LimitDescription
        {
            get
            {
                return _limitDescription;
            }
            set
            {
                _limitDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the LimitDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool LimitDescriptionSpecified
        {
            get
            {
                return ((this.LimitDescription != null) 
                            && (this.LimitDescription.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AcctLimitFields" /> class.</para>
        /// </summary>
        public AcctLimitFields()
        {
            this._limitDescription = new Collection<short>();
            this._limitSourceCodes = new Collection<short>();
            this._limitTransactionSubType = new Collection<short>();
            this._limitTransactionType = new Collection<short>();
            this._warningCodeList = new Collection<short>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _limitSourceCodes;
        
        [XmlElementAttribute("LimitSourceCodes", Order=1, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> LimitSourceCodes
        {
            get
            {
                return _limitSourceCodes;
            }
            set
            {
                _limitSourceCodes = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the LimitSourceCodes collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool LimitSourceCodesSpecified
        {
            get
            {
                return ((this.LimitSourceCodes != null) 
                            && (this.LimitSourceCodes.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _limitTransactionSubType;
        
        [XmlElementAttribute("LimitTransactionSubType", Order=2, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> LimitTransactionSubType
        {
            get
            {
                return _limitTransactionSubType;
            }
            set
            {
                _limitTransactionSubType = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the LimitTransactionSubType collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool LimitTransactionSubTypeSpecified
        {
            get
            {
                return ((this.LimitTransactionSubType != null) 
                            && (this.LimitTransactionSubType.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _limitTransactionType;
        
        [XmlElementAttribute("LimitTransactionType", Order=3, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> LimitTransactionType
        {
            get
            {
                return _limitTransactionType;
            }
            set
            {
                _limitTransactionType = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the LimitTransactionType collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool LimitTransactionTypeSpecified
        {
            get
            {
                return ((this.LimitTransactionType != null) 
                            && (this.LimitTransactionType.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _warningCodeList;
        
        [XmlElementAttribute("WarningCodeList", Order=4, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> WarningCodeList
        {
            get
            {
                return _warningCodeList;
            }
            set
            {
                _warningCodeList = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WarningCodeList collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool WarningCodeListSpecified
        {
            get
            {
                return ((this.WarningCodeList != null) 
                            && (this.WarningCodeList.Count != 0));
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
    }
}
