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
    [XmlTypeAttribute("ShareDefaultUpdateRequest", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class ShareDefaultUpdateRequest
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ShareDefaultShareType", Order=0, Form=XmlSchemaForm.Unqualified)]
        public short ShareDefaultShareTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ShareDefaultShareType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ShareDefaultShareTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> ShareDefaultShareType
        {
            get
            {
                if (this.ShareDefaultShareTypeValueSpecified)
                {
                    return this.ShareDefaultShareTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ShareDefaultShareTypeValue = value.GetValueOrDefault();
                this.ShareDefaultShareTypeValueSpecified = value.HasValue;
            }
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ShareDefaultFields", Order=1, Form=XmlSchemaForm.Unqualified)]
        public ShareDefaultFields_2 ShareDefaultFields { get; set; }
    }
}
