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
    [XmlTypeAttribute("CollatrlTrackingType", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("CollatrlTrackingType", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [XmlIncludeAttribute(typeof(CollatrlTrackingTypeFields_2))]
    public partial class CollatrlTrackingType_2
    {
        
        [XmlElementAttribute("Description", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string Description { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ParentClosingOption", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool ParentClosingOptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ParentClosingOption property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ParentClosingOptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ParentClosingOption
        {
            get
            {
                if (this.ParentClosingOptionValueSpecified)
                {
                    return this.ParentClosingOptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ParentClosingOptionValue = value.GetValueOrDefault();
                this.ParentClosingOptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RecordSelection", Order=2, Form=XmlSchemaForm.Unqualified)]
        public short RecordSelectionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RecordSelection property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RecordSelectionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> RecordSelection
        {
            get
            {
                if (this.RecordSelectionValueSpecified)
                {
                    return this.RecordSelectionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RecordSelectionValue = value.GetValueOrDefault();
                this.RecordSelectionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("TrackingType", Order=3, Form=XmlSchemaForm.Unqualified)]
        public short TrackingTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TrackingType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TrackingTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> TrackingType
        {
            get
            {
                if (this.TrackingTypeValueSpecified)
                {
                    return this.TrackingTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TrackingTypeValue = value.GetValueOrDefault();
                this.TrackingTypeValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<CollatrlTrackingTypeUserRate20_2> _userRate20;
        
        [XmlElementAttribute("UserRate20", Order=4, Form=XmlSchemaForm.Unqualified)]
        public Collection<CollatrlTrackingTypeUserRate20_2> UserRate20
        {
            get
            {
                return _userRate20;
            }
            set
            {
                _userRate20 = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the UserRate20 collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool UserRate20Specified
        {
            get
            {
                return ((this.UserRate20 != null) 
                            && (this.UserRate20.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CollatrlTrackingType_2" /> class.</para>
        /// </summary>
        public CollatrlTrackingType_2()
        {
            this._userRate20 = new Collection<CollatrlTrackingTypeUserRate20_2>();
            this._any = new Collection<XmlElement>();
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
