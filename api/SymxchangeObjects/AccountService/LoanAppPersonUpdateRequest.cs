//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\AccountService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\AccountService\generated-output -n AccountService
namespace AccountService
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
    [XmlTypeAttribute("LoanAppPersonUpdateRequest", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class LoanAppPersonUpdateRequest
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LoanAppPersonLocator", Order=0, Form=XmlSchemaForm.Unqualified)]
        public int LoanAppPersonLocatorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LoanAppPersonLocator property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LoanAppPersonLocatorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> LoanAppPersonLocator
        {
            get
            {
                if (this.LoanAppPersonLocatorValueSpecified)
                {
                    return this.LoanAppPersonLocatorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LoanAppPersonLocatorValue = value.GetValueOrDefault();
                this.LoanAppPersonLocatorValueSpecified = value.HasValue;
            }
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("LoanAppPersonFields", Order=1, Form=XmlSchemaForm.Unqualified)]
        public LoanAppPersonFields_2 LoanAppPersonFields { get; set; }
    }
}
