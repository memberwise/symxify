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
    [XmlTypeAttribute("SecurityUpdateRequest", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class SecurityUpdateRequest
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SecuritySecurityCategory", Order=0, Form=XmlSchemaForm.Unqualified)]
        public short SecuritySecurityCategoryValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SecuritySecurityCategory property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SecuritySecurityCategoryValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> SecuritySecurityCategory
        {
            get
            {
                if (this.SecuritySecurityCategoryValueSpecified)
                {
                    return this.SecuritySecurityCategoryValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SecuritySecurityCategoryValue = value.GetValueOrDefault();
                this.SecuritySecurityCategoryValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SecurityRecordSelection", Order=1, Form=XmlSchemaForm.Unqualified)]
        public short SecurityRecordSelectionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SecurityRecordSelection property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SecurityRecordSelectionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> SecurityRecordSelection
        {
            get
            {
                if (this.SecurityRecordSelectionValueSpecified)
                {
                    return this.SecurityRecordSelectionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SecurityRecordSelectionValue = value.GetValueOrDefault();
                this.SecurityRecordSelectionValueSpecified = value.HasValue;
            }
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("SecurityFields", Order=2, Form=XmlSchemaForm.Unqualified)]
        public SecurityFields_2 SecurityFields { get; set; }
    }
}
