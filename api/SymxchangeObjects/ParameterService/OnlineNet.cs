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
    [XmlTypeAttribute("OnlineNet", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("OnlineNet", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class OnlineNet
    {
        
        [XmlElementAttribute("AcquirerProcessorId", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string AcquirerProcessorId { get; set; }
        
        [XmlElementAttribute("AcquirerProcessorValue", Order=1, Form=XmlSchemaForm.Unqualified)]
        public string AcquirerProcessorValue { get; set; }
        
        [XmlElementAttribute("AcquirerSecurityCode", Order=2, Form=XmlSchemaForm.Unqualified)]
        public string AcquirerSecurityCode { get; set; }
        
        [XmlElementAttribute("AcquirerSettlementTime", Order=3, Form=XmlSchemaForm.Unqualified)]
        public string AcquirerSettlementTime { get; set; }
        
        [XmlElementAttribute("ClientId", Order=4, Form=XmlSchemaForm.Unqualified)]
        public string ClientId { get; set; }
        
        [XmlElementAttribute("DataProcessingCenter", Order=5, Form=XmlSchemaForm.Unqualified)]
        public string DataProcessingCenter { get; set; }
        
        [XmlElementAttribute("FinancialInstitutionId", Order=6, Form=XmlSchemaForm.Unqualified)]
        public string FinancialInstitutionId { get; set; }
        
        [XmlElementAttribute("ForcePostFinTrnLimitUsage", Order=7, Form=XmlSchemaForm.Unqualified)]
        public string ForcePostFinTrnLimitUsage { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("GlCode", Order=8, Form=XmlSchemaForm.Unqualified)]
        public short GlCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the GlCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool GlCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> GlCode
        {
            get
            {
                if (this.GlCodeValueSpecified)
                {
                    return this.GlCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.GlCodeValue = value.GetValueOrDefault();
                this.GlCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("HoldMatchWeight", Order=9, Form=XmlSchemaForm.Unqualified)]
        public short HoldMatchWeightValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the HoldMatchWeight property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool HoldMatchWeightValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> HoldMatchWeight
        {
            get
            {
                if (this.HoldMatchWeightValueSpecified)
                {
                    return this.HoldMatchWeightValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HoldMatchWeightValue = value.GetValueOrDefault();
                this.HoldMatchWeightValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("HoldMatchWeightIncrementals", Order=10, Form=XmlSchemaForm.Unqualified)]
        public short HoldMatchWeightIncrementalsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the HoldMatchWeightIncrementals property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool HoldMatchWeightIncrementalsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> HoldMatchWeightIncrementals
        {
            get
            {
                if (this.HoldMatchWeightIncrementalsValueSpecified)
                {
                    return this.HoldMatchWeightIncrementalsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HoldMatchWeightIncrementalsValue = value.GetValueOrDefault();
                this.HoldMatchWeightIncrementalsValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("IssuerProcessorValue", Order=11, Form=XmlSchemaForm.Unqualified)]
        public string IssuerProcessorValue { get; set; }
        
        [XmlElementAttribute("IssuerSecurityCode", Order=12, Form=XmlSchemaForm.Unqualified)]
        public string IssuerSecurityCode { get; set; }
        
        [XmlElementAttribute("IssuerSettlementTime", Order=13, Form=XmlSchemaForm.Unqualified)]
        public string IssuerSettlementTime { get; set; }
        
        [XmlElementAttribute("LogicalNetwork", Order=14, Form=XmlSchemaForm.Unqualified)]
        public string LogicalNetwork { get; set; }
        
        [XmlElementAttribute("MasterCardCcaFeeComment", Order=15, Form=XmlSchemaForm.Unqualified)]
        public string MasterCardCcaFeeComment { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MasterCardCcaFeeGlCode", Order=16, Form=XmlSchemaForm.Unqualified)]
        public short MasterCardCcaFeeGlCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MasterCardCcaFeeGlCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MasterCardCcaFeeGlCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> MasterCardCcaFeeGlCode
        {
            get
            {
                if (this.MasterCardCcaFeeGlCodeValueSpecified)
                {
                    return this.MasterCardCcaFeeGlCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MasterCardCcaFeeGlCodeValue = value.GetValueOrDefault();
                this.MasterCardCcaFeeGlCodeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("MasterCardIcaFeeComment", Order=17, Form=XmlSchemaForm.Unqualified)]
        public string MasterCardIcaFeeComment { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MasterCardIcaFeeGlCode", Order=18, Form=XmlSchemaForm.Unqualified)]
        public short MasterCardIcaFeeGlCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MasterCardIcaFeeGlCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MasterCardIcaFeeGlCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> MasterCardIcaFeeGlCode
        {
            get
            {
                if (this.MasterCardIcaFeeGlCodeValueSpecified)
                {
                    return this.MasterCardIcaFeeGlCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MasterCardIcaFeeGlCodeValue = value.GetValueOrDefault();
                this.MasterCardIcaFeeGlCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NetworkManagesPreAuthHolds", Order=19, Form=XmlSchemaForm.Unqualified)]
        public bool NetworkManagesPreAuthHoldsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NetworkManagesPreAuthHolds property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NetworkManagesPreAuthHoldsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> NetworkManagesPreAuthHolds
        {
            get
            {
                if (this.NetworkManagesPreAuthHoldsValueSpecified)
                {
                    return this.NetworkManagesPreAuthHoldsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NetworkManagesPreAuthHoldsValue = value.GetValueOrDefault();
                this.NetworkManagesPreAuthHoldsValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NetworkMessageFormat", Order=20, Form=XmlSchemaForm.Unqualified)]
        public short NetworkMessageFormatValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NetworkMessageFormat property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NetworkMessageFormatValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> NetworkMessageFormat
        {
            get
            {
                if (this.NetworkMessageFormatValueSpecified)
                {
                    return this.NetworkMessageFormatValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NetworkMessageFormatValue = value.GetValueOrDefault();
                this.NetworkMessageFormatValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("OtherAccountMiscId", Order=21, Form=XmlSchemaForm.Unqualified)]
        public short OtherAccountMiscIdValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OtherAccountMiscId property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OtherAccountMiscIdValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> OtherAccountMiscId
        {
            get
            {
                if (this.OtherAccountMiscIdValueSpecified)
                {
                    return this.OtherAccountMiscIdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OtherAccountMiscIdValue = value.GetValueOrDefault();
                this.OtherAccountMiscIdValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("OtherAccountType", Order=22, Form=XmlSchemaForm.Unqualified)]
        public short OtherAccountTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OtherAccountType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OtherAccountTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> OtherAccountType
        {
            get
            {
                if (this.OtherAccountTypeValueSpecified)
                {
                    return this.OtherAccountTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OtherAccountTypeValue = value.GetValueOrDefault();
                this.OtherAccountTypeValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("PartialApprovalCardTypes", Order=23, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.BitMap PartialApprovalCardTypes { get; set; }
        
        [XmlElementAttribute("Password", Order=24, Form=XmlSchemaForm.Unqualified)]
        public string Password { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PinPartialApprovalOption", Order=25, Form=XmlSchemaForm.Unqualified)]
        public short PinPartialApprovalOptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PinPartialApprovalOption property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PinPartialApprovalOptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> PinPartialApprovalOption
        {
            get
            {
                if (this.PinPartialApprovalOptionValueSpecified)
                {
                    return this.PinPartialApprovalOptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PinPartialApprovalOptionValue = value.GetValueOrDefault();
                this.PinPartialApprovalOptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PostAdministrativeMessages", Order=26, Form=XmlSchemaForm.Unqualified)]
        public bool PostAdministrativeMessagesValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PostAdministrativeMessages property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PostAdministrativeMessagesValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PostAdministrativeMessages
        {
            get
            {
                if (this.PostAdministrativeMessagesValueSpecified)
                {
                    return this.PostAdministrativeMessagesValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PostAdministrativeMessagesValue = value.GetValueOrDefault();
                this.PostAdministrativeMessagesValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("PrincipalId", Order=27, Form=XmlSchemaForm.Unqualified)]
        public string PrincipalId { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RequestAdvicePairs", Order=28, Form=XmlSchemaForm.Unqualified)]
        public bool RequestAdvicePairsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RequestAdvicePairs property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RequestAdvicePairsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> RequestAdvicePairs
        {
            get
            {
                if (this.RequestAdvicePairsValueSpecified)
                {
                    return this.RequestAdvicePairsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RequestAdvicePairsValue = value.GetValueOrDefault();
                this.RequestAdvicePairsValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("ReturnBalOnNonAtmTrans", Order=29, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.BitMap ReturnBalOnNonAtmTrans { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ReturnedBalances", Order=30, Form=XmlSchemaForm.Unqualified)]
        public short ReturnedBalancesValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ReturnedBalances property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ReturnedBalancesValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> ReturnedBalances
        {
            get
            {
                if (this.ReturnedBalancesValueSpecified)
                {
                    return this.ReturnedBalancesValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ReturnedBalancesValue = value.GetValueOrDefault();
                this.ReturnedBalancesValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("RoutingTransitNumber", Order=31, Form=XmlSchemaForm.Unqualified)]
        public string RoutingTransitNumber { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SigPartialApprovalOption", Order=32, Form=XmlSchemaForm.Unqualified)]
        public short SigPartialApprovalOptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SigPartialApprovalOption property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SigPartialApprovalOptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> SigPartialApprovalOption
        {
            get
            {
                if (this.SigPartialApprovalOptionValueSpecified)
                {
                    return this.SigPartialApprovalOptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SigPartialApprovalOptionValue = value.GetValueOrDefault();
                this.SigPartialApprovalOptionValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("SystemId", Order=33, Form=XmlSchemaForm.Unqualified)]
        public string SystemId { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("TerminalIdOption", Order=34, Form=XmlSchemaForm.Unqualified)]
        public short TerminalIdOptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TerminalIdOption property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TerminalIdOptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> TerminalIdOption
        {
            get
            {
                if (this.TerminalIdOptionValueSpecified)
                {
                    return this.TerminalIdOptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TerminalIdOptionValue = value.GetValueOrDefault();
                this.TerminalIdOptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("TokenizationNoteCode", Order=35, Form=XmlSchemaForm.Unqualified)]
        public short TokenizationNoteCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TokenizationNoteCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TokenizationNoteCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> TokenizationNoteCode
        {
            get
            {
                if (this.TokenizationNoteCodeValueSpecified)
                {
                    return this.TokenizationNoteCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TokenizationNoteCodeValue = value.GetValueOrDefault();
                this.TokenizationNoteCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UpdateCardStatusReason", Order=36, Form=XmlSchemaForm.Unqualified)]
        public bool UpdateCardStatusReasonValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UpdateCardStatusReason property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UpdateCardStatusReasonValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> UpdateCardStatusReason
        {
            get
            {
                if (this.UpdateCardStatusReasonValueSpecified)
                {
                    return this.UpdateCardStatusReasonValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UpdateCardStatusReasonValue = value.GetValueOrDefault();
                this.UpdateCardStatusReasonValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UseAcctsinOnlineMessage", Order=37, Form=XmlSchemaForm.Unqualified)]
        public bool UseAcctsinOnlineMessageValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UseAcctsinOnlineMessage property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UseAcctsinOnlineMessageValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> UseAcctsinOnlineMessage
        {
            get
            {
                if (this.UseAcctsinOnlineMessageValueSpecified)
                {
                    return this.UseAcctsinOnlineMessageValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UseAcctsinOnlineMessageValue = value.GetValueOrDefault();
                this.UseAcctsinOnlineMessageValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ValidateOnlineMsgAcct", Order=38, Form=XmlSchemaForm.Unqualified)]
        public bool ValidateOnlineMsgAcctValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ValidateOnlineMsgAcct property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ValidateOnlineMsgAcctValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ValidateOnlineMsgAcct
        {
            get
            {
                if (this.ValidateOnlineMsgAcctValueSpecified)
                {
                    return this.ValidateOnlineMsgAcctValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ValidateOnlineMsgAcctValue = value.GetValueOrDefault();
                this.ValidateOnlineMsgAcctValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("VisaMultiCrrncyIsaFeeCmnt", Order=39, Form=XmlSchemaForm.Unqualified)]
        public string VisaMultiCrrncyIsaFeeCmnt { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("VisaMultiCrrncyIsaFeeGl", Order=40, Form=XmlSchemaForm.Unqualified)]
        public short VisaMultiCrrncyIsaFeeGlValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the VisaMultiCrrncyIsaFeeGl property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool VisaMultiCrrncyIsaFeeGlValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> VisaMultiCrrncyIsaFeeGl
        {
            get
            {
                if (this.VisaMultiCrrncyIsaFeeGlValueSpecified)
                {
                    return this.VisaMultiCrrncyIsaFeeGlValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.VisaMultiCrrncyIsaFeeGlValue = value.GetValueOrDefault();
                this.VisaMultiCrrncyIsaFeeGlValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("VisaSglCrrncyIsaFeeCmnt", Order=41, Form=XmlSchemaForm.Unqualified)]
        public string VisaSglCrrncyIsaFeeCmnt { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("VisaSglCrrncyIsaFeeGl", Order=42, Form=XmlSchemaForm.Unqualified)]
        public short VisaSglCrrncyIsaFeeGlValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the VisaSglCrrncyIsaFeeGl property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool VisaSglCrrncyIsaFeeGlValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> VisaSglCrrncyIsaFeeGl
        {
            get
            {
                if (this.VisaSglCrrncyIsaFeeGlValueSpecified)
                {
                    return this.VisaSglCrrncyIsaFeeGlValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.VisaSglCrrncyIsaFeeGlValue = value.GetValueOrDefault();
                this.VisaSglCrrncyIsaFeeGlValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("WarnonOverdraw", Order=43, Form=XmlSchemaForm.Unqualified)]
        public bool WarnonOverdrawValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the WarnonOverdraw property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool WarnonOverdrawValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> WarnonOverdraw
        {
            get
            {
                if (this.WarnonOverdrawValueSpecified)
                {
                    return this.WarnonOverdrawValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.WarnonOverdrawValue = value.GetValueOrDefault();
                this.WarnonOverdrawValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=44, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=45)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="OnlineNet" /> class.</para>
        /// </summary>
        public OnlineNet()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
