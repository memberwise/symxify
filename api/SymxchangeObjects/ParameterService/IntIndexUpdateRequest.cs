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
    [XmlTypeAttribute("IntIndexUpdateRequest", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class IntIndexUpdateRequest
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IntIndexInterestRateIndex", Order=0, Form=XmlSchemaForm.Unqualified)]
        public short IntIndexInterestRateIndexValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IntIndexInterestRateIndex property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IntIndexInterestRateIndexValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> IntIndexInterestRateIndex
        {
            get
            {
                if (this.IntIndexInterestRateIndexValueSpecified)
                {
                    return this.IntIndexInterestRateIndexValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IntIndexInterestRateIndexValue = value.GetValueOrDefault();
                this.IntIndexInterestRateIndexValueSpecified = value.HasValue;
            }
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("IntIndexFields", Order=1, Form=XmlSchemaForm.Unqualified)]
        public IntIndexFields_2 IntIndexFields { get; set; }
    }
}
