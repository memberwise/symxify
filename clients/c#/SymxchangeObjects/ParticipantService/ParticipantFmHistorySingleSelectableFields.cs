//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\ParticipantService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\ParticipantService\generated-output -n ParticipantService
namespace ParticipantService
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
    [XmlTypeAttribute("ParticipantFmHistorySingleSelectableFields", Namespace="http://www.symxchange.generated.symitar.com/crud/participant/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class ParticipantFmHistorySingleSelectableFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IncludeAllParticipantFmHistoryFields", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool IncludeAllParticipantFmHistoryFieldsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IncludeAllParticipantFmHistoryFields property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IncludeAllParticipantFmHistoryFieldsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IncludeAllParticipantFmHistoryFields
        {
            get
            {
                if (this.IncludeAllParticipantFmHistoryFieldsValueSpecified)
                {
                    return this.IncludeAllParticipantFmHistoryFieldsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IncludeAllParticipantFmHistoryFieldsValue = value.GetValueOrDefault();
                this.IncludeAllParticipantFmHistoryFieldsValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("ParticipantFmHistoryFields", Order=1, Form=XmlSchemaForm.Unqualified)]
        public ParticipantFmHistoryFields ParticipantFmHistoryFields { get; set; }
        
        [XmlElementAttribute("Version_1", Order=2, Form=XmlSchemaForm.Unqualified)]
        public ParticipantService.VersionType Version1 { get; set; }
        
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ParticipantFmHistorySingleSelectableFields" /> class.</para>
        /// </summary>
        public ParticipantFmHistorySingleSelectableFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
