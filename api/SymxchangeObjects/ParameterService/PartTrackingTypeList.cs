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
    [XmlTypeAttribute("PartTrackingTypeList", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class PartTrackingTypeList
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("hasReachedMaximumListSize", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool HasReachedMaximumListSizeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the HasReachedMaximumListSize property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool HasReachedMaximumListSizeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> HasReachedMaximumListSize
        {
            get
            {
                if (this.HasReachedMaximumListSizeValueSpecified)
                {
                    return this.HasReachedMaximumListSizeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HasReachedMaximumListSizeValue = value.GetValueOrDefault();
                this.HasReachedMaximumListSizeValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<PartTrackingType> _partTrackingType;
        
        [XmlElementAttribute("PartTrackingType", Order=1, Form=XmlSchemaForm.Unqualified)]
        public Collection<PartTrackingType> PartTrackingType
        {
            get
            {
                return _partTrackingType;
            }
            set
            {
                _partTrackingType = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the PartTrackingType collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PartTrackingTypeSpecified
        {
            get
            {
                return ((this.PartTrackingType != null) 
                            && (this.PartTrackingType.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="PartTrackingTypeList" /> class.</para>
        /// </summary>
        public PartTrackingTypeList()
        {
            this._partTrackingType = new Collection<PartTrackingType>();
        }
    }
}
