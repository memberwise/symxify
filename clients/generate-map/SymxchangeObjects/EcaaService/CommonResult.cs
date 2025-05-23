//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\EcaaService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\EcaaService\generated-output -n EcaaService
namespace EcaaService
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
    [XmlTypeAttribute("commonResult", Namespace="http://www.symxchange.generated.symitar.com/noncrud/ecaa/dto")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(AuthenticateMemberResult))]
    [XmlIncludeAttribute(typeof(AuthenticateResult))]
    [XmlIncludeAttribute(typeof(AuthenticateServiceResult))]
    [XmlIncludeAttribute(typeof(AuthenticateWithAuthorizationResult))]
    [XmlIncludeAttribute(typeof(AuthorizeSymResult))]
    [XmlIncludeAttribute(typeof(ChangeMemberHbPasswordResult))]
    [XmlIncludeAttribute(typeof(ChangeSymitarPasswordResult))]
    [XmlIncludeAttribute(typeof(ConvertToJwtResult))]
    [XmlIncludeAttribute(typeof(ConvertToSamlResult))]
    [XmlIncludeAttribute(typeof(GetPrincipalsResult))]
    [XmlIncludeAttribute(typeof(InitKerberosAuthenticationResult))]
    public partial class CommonResult
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ErrorCode", Order=0, Form=XmlSchemaForm.Unqualified)]
        public ErrorCode ErrorCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ErrorCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ErrorCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<ErrorCode> ErrorCode
        {
            get
            {
                if (this.ErrorCodeValueSpecified)
                {
                    return this.ErrorCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ErrorCodeValue = value.GetValueOrDefault();
                this.ErrorCodeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("ErrorMessage", Order=1, Form=XmlSchemaForm.Unqualified)]
        public string ErrorMessage { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Result", Order=2, Form=XmlSchemaForm.Unqualified)]
        public Result ResultValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Result property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ResultValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<Result> Result
        {
            get
            {
                if (this.ResultValueSpecified)
                {
                    return this.ResultValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ResultValue = value.GetValueOrDefault();
                this.ResultValueSpecified = value.HasValue;
            }
        }
    }
}
