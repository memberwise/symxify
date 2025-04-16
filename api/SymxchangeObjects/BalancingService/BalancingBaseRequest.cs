//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\BalancingService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\BalancingService\generated-output -n BalancingService
namespace BalancingService
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
    [XmlTypeAttribute("BalancingBaseRequest", Namespace="http://www.symxchange.generated.symitar.com/noncrud/balancing/dto")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(CashValueAdjustRequest))]
    [XmlIncludeAttribute(typeof(CashValueReportRequest))]
    [XmlIncludeAttribute(typeof(CheckDisbursedReportRequest))]
    [XmlIncludeAttribute(typeof(ResetCashValueBalancesRequest))]
    [XmlIncludeAttribute(typeof(ResetDepositBalancesRequest))]
    [XmlIncludeAttribute(typeof(ResetSecondPartyCheckBalancesRequest))]
    [XmlIncludeAttribute(typeof(SecondPartyCheckAdjustRequest))]
    [XmlIncludeAttribute(typeof(VerifyDepositReportRequest))]
    public partial class BalancingBaseRequest
    {
        
        [XmlElementAttribute("Credentials", Order=0, Form=XmlSchemaForm.Unqualified)]
        public BalancingService.CredentialsChoice Credentials { get; set; }
        
        [XmlElementAttribute("DeviceInformation", Order=1, Form=XmlSchemaForm.Unqualified)]
        public BalancingService.DeviceInformation DeviceInformation { get; set; }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlAttributeAttribute("MessageId", Namespace="http://www.symxchange.generated.symitar.com/symxcommon", Form=XmlSchemaForm.Qualified)]
        public string MessageId { get; set; }
    }
}
