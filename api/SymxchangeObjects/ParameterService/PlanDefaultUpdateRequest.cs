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
    [XmlTypeAttribute("PlanDefaultUpdateRequest", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class PlanDefaultUpdateRequest
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PlanDefaultReservePlanType", Order=0, Form=XmlSchemaForm.Unqualified)]
        public short PlanDefaultReservePlanTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PlanDefaultReservePlanType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PlanDefaultReservePlanTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> PlanDefaultReservePlanType
        {
            get
            {
                if (this.PlanDefaultReservePlanTypeValueSpecified)
                {
                    return this.PlanDefaultReservePlanTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PlanDefaultReservePlanTypeValue = value.GetValueOrDefault();
                this.PlanDefaultReservePlanTypeValueSpecified = value.HasValue;
            }
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("PlanDefaultFields", Order=1, Form=XmlSchemaForm.Unqualified)]
        public PlanDefaultFields_2 PlanDefaultFields { get; set; }
    }
}
