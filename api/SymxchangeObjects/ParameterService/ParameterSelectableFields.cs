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
    [XmlTypeAttribute("ParameterSelectableFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class ParameterSelectableFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IncludeAllParameterFields", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool IncludeAllParameterFieldsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IncludeAllParameterFields property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IncludeAllParameterFieldsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IncludeAllParameterFields
        {
            get
            {
                if (this.IncludeAllParameterFieldsValueSpecified)
                {
                    return this.IncludeAllParameterFieldsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IncludeAllParameterFieldsValue = value.GetValueOrDefault();
                this.IncludeAllParameterFieldsValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("ParameterFields", Order=1, Form=XmlSchemaForm.Unqualified)]
        public ParameterFields ParameterFields { get; set; }
        
        [XmlElementAttribute("AccountDefaultSelectableFields", Order=2, Form=XmlSchemaForm.Unqualified)]
        public AccountDefaultSelectableFields AccountDefaultSelectableFields { get; set; }
        
        [XmlElementAttribute("AccountFieldNameSelectableFields", Order=3, Form=XmlSchemaForm.Unqualified)]
        public AccountFieldNameSelectableFields AccountFieldNameSelectableFields { get; set; }
        
        [XmlElementAttribute("AcctLimitSelectableFields", Order=4, Form=XmlSchemaForm.Unqualified)]
        public AcctLimitSelectableFields AcctLimitSelectableFields { get; set; }
        
        [XmlElementAttribute("AcctMembGrpDescSelectableFields", Order=5, Form=XmlSchemaForm.Unqualified)]
        public AcctMembGrpDescSelectableFields AcctMembGrpDescSelectableFields { get; set; }
        
        [XmlElementAttribute("AcctRelCodeDescSelectableFields", Order=6, Form=XmlSchemaForm.Unqualified)]
        public AcctRelCodeDescSelectableFields AcctRelCodeDescSelectableFields { get; set; }
        
        [XmlElementAttribute("AcctTrackingTypeSelectableFields", Order=7, Form=XmlSchemaForm.Unqualified)]
        public AcctTrackingTypeSelectableFields AcctTrackingTypeSelectableFields { get; set; }
        
        [XmlElementAttribute("AcctTypeNameSelectableFields", Order=8, Form=XmlSchemaForm.Unqualified)]
        public AcctTypeNameSelectableFields AcctTypeNameSelectableFields { get; set; }
        
        [XmlElementAttribute("AcsGlobalSelectableFields", Order=9, Form=XmlSchemaForm.Unqualified)]
        public AcsGlobalSelectableFields AcsGlobalSelectableFields { get; set; }
        
        [XmlElementAttribute("AcsServiceSelectableFields", Order=10, Form=XmlSchemaForm.Unqualified)]
        public AcsServiceSelectableFields AcsServiceSelectableFields { get; set; }
        
        [XmlElementAttribute("ActivityFmSelectableFields", Order=11, Form=XmlSchemaForm.Unqualified)]
        public ActivityFmSelectableFields ActivityFmSelectableFields { get; set; }
        
        [XmlElementAttribute("AnalysisFloatSelectableFields", Order=12, Form=XmlSchemaForm.Unqualified)]
        public AnalysisFloatSelectableFields AnalysisFloatSelectableFields { get; set; }
        
        [XmlElementAttribute("AnalysisGlobalSelectableFields", Order=13, Form=XmlSchemaForm.Unqualified)]
        public AnalysisGlobalSelectableFields AnalysisGlobalSelectableFields { get; set; }
        
        [XmlElementAttribute("AnalysisPlanSelectableFields", Order=14, Form=XmlSchemaForm.Unqualified)]
        public AnalysisPlanSelectableFields AnalysisPlanSelectableFields { get; set; }
        
        [XmlElementAttribute("ApMiscSelectableFields", Order=15, Form=XmlSchemaForm.Unqualified)]
        public ApMiscSelectableFields ApMiscSelectableFields { get; set; }
        
        [XmlElementAttribute("ApPmtTermsTableSelectableFields", Order=16, Form=XmlSchemaForm.Unqualified)]
        public ApPmtTermsTableSelectableFields ApPmtTermsTableSelectableFields { get; set; }
        
        [XmlElementAttribute("ApWorkFlowSelectableFields", Order=17, Form=XmlSchemaForm.Unqualified)]
        public ApWorkFlowSelectableFields ApWorkFlowSelectableFields { get; set; }
        
        [XmlElementAttribute("AtmSelectableFields", Order=18, Form=XmlSchemaForm.Unqualified)]
        public AtmSelectableFields AtmSelectableFields { get; set; }
        
        [XmlElementAttribute("AudioSelectableFields", Order=19, Form=XmlSchemaForm.Unqualified)]
        public AudioSelectableFields AudioSelectableFields { get; set; }
        
        [XmlElementAttribute("BatchRcSelectableFields", Order=20, Form=XmlSchemaForm.Unqualified)]
        public BatchRcSelectableFields BatchRcSelectableFields { get; set; }
        
        [XmlElementAttribute("CardDefaultSelectableFields", Order=21, Form=XmlSchemaForm.Unqualified)]
        public CardDefaultSelectableFields CardDefaultSelectableFields { get; set; }
        
        [XmlElementAttribute("CardWizSelectableFields", Order=22, Form=XmlSchemaForm.Unqualified)]
        public CardWizSelectableFields CardWizSelectableFields { get; set; }
        
        [XmlElementAttribute("CashOrderVendorSelectableFields", Order=23, Form=XmlSchemaForm.Unqualified)]
        public CashOrderVendorSelectableFields CashOrderVendorSelectableFields { get; set; }
        
        [XmlElementAttribute("CdmSelectableFields", Order=24, Form=XmlSchemaForm.Unqualified)]
        public CdmSelectableFields CdmSelectableFields { get; set; }
        
        [XmlElementAttribute("CdmCommonSelectableFields", Order=25, Form=XmlSchemaForm.Unqualified)]
        public CdmCommonSelectableFields CdmCommonSelectableFields { get; set; }
        
        [XmlElementAttribute("CheckOrderDefaultSelectableFields", Order=26, Form=XmlSchemaForm.Unqualified)]
        public CheckOrderDefaultSelectableFields CheckOrderDefaultSelectableFields { get; set; }
        
        [XmlElementAttribute("CollateralTypeSelectableFields", Order=27, Form=XmlSchemaForm.Unqualified)]
        public CollateralTypeSelectableFields CollateralTypeSelectableFields { get; set; }
        
        [XmlElementAttribute("CollatrlTrackingTypeSelectableFields", Order=28, Form=XmlSchemaForm.Unqualified)]
        public CollatrlTrackingTypeSelectableFields CollatrlTrackingTypeSelectableFields { get; set; }
        
        [XmlElementAttribute("CommentSelectableFields", Order=29, Form=XmlSchemaForm.Unqualified)]
        public CommentSelectableFields CommentSelectableFields { get; set; }
        
        [XmlElementAttribute("ConsoleFmSelectableFields", Order=30, Form=XmlSchemaForm.Unqualified)]
        public ConsoleFmSelectableFields ConsoleFmSelectableFields { get; set; }
        
        [XmlElementAttribute("CorpTransferSelectableFields", Order=31, Form=XmlSchemaForm.Unqualified)]
        public CorpTransferSelectableFields CorpTransferSelectableFields { get; set; }
        
        [XmlElementAttribute("CpLetterSelectableFields", Order=32, Form=XmlSchemaForm.Unqualified)]
        public CpLetterSelectableFields CpLetterSelectableFields { get; set; }
        
        [XmlElementAttribute("CpWorkCardSelectableFields", Order=33, Form=XmlSchemaForm.Unqualified)]
        public CpWorkCardSelectableFields CpWorkCardSelectableFields { get; set; }
        
        [XmlElementAttribute("CreditReportSelectableFields", Order=34, Form=XmlSchemaForm.Unqualified)]
        public CreditReportSelectableFields CreditReportSelectableFields { get; set; }
        
        [XmlElementAttribute("CrsSelectableFields", Order=35, Form=XmlSchemaForm.Unqualified)]
        public CrsSelectableFields CrsSelectableFields { get; set; }
        
        [XmlElementAttribute("CurrencyCtrlSelectableFields", Order=36, Form=XmlSchemaForm.Unqualified)]
        public CurrencyCtrlSelectableFields CurrencyCtrlSelectableFields { get; set; }
        
        [XmlElementAttribute("DailyPostSelectableFields", Order=37, Form=XmlSchemaForm.Unqualified)]
        public DailyPostSelectableFields DailyPostSelectableFields { get; set; }
        
        [XmlElementAttribute("DealerStatementSelectableFields", Order=38, Form=XmlSchemaForm.Unqualified)]
        public DealerStatementSelectableFields DealerStatementSelectableFields { get; set; }
        
        [XmlElementAttribute("DebtRatioSelectableFields", Order=39, Form=XmlSchemaForm.Unqualified)]
        public DebtRatioSelectableFields DebtRatioSelectableFields { get; set; }
        
        [XmlElementAttribute("DisclosureSelectableFields", Order=40, Form=XmlSchemaForm.Unqualified)]
        public DisclosureSelectableFields DisclosureSelectableFields { get; set; }
        
        [XmlElementAttribute("DivIndexGlobalSelectableFields", Order=41, Form=XmlSchemaForm.Unqualified)]
        public DivIndexGlobalSelectableFields DivIndexGlobalSelectableFields { get; set; }
        
        [XmlElementAttribute("DivIndexLocalSelectableFields", Order=42, Form=XmlSchemaForm.Unqualified)]
        public DivIndexLocalSelectableFields DivIndexLocalSelectableFields { get; set; }
        
        [XmlElementAttribute("DivTableSelectableFields", Order=43, Form=XmlSchemaForm.Unqualified)]
        public DivTableSelectableFields DivTableSelectableFields { get; set; }
        
        [XmlElementAttribute("DocExcpNoticeSelectableFields", Order=44, Form=XmlSchemaForm.Unqualified)]
        public DocExcpNoticeSelectableFields DocExcpNoticeSelectableFields { get; set; }
        
        [XmlElementAttribute("DocTypeDefaultSelectableFields", Order=45, Form=XmlSchemaForm.Unqualified)]
        public DocTypeDefaultSelectableFields DocTypeDefaultSelectableFields { get; set; }
        
        [XmlElementAttribute("DocumentNumberSelectableFields", Order=46, Form=XmlSchemaForm.Unqualified)]
        public DocumentNumberSelectableFields DocumentNumberSelectableFields { get; set; }
        
        [XmlElementAttribute("EpisysDbExtractSelectableFields", Order=47, Form=XmlSchemaForm.Unqualified)]
        public EpisysDbExtractSelectableFields EpisysDbExtractSelectableFields { get; set; }
        
        [XmlElementAttribute("EscrowAnalysisSelectableFields", Order=48, Form=XmlSchemaForm.Unqualified)]
        public EscrowAnalysisSelectableFields EscrowAnalysisSelectableFields { get; set; }
        
        [XmlElementAttribute("EscrowTypeSelectableFields", Order=49, Form=XmlSchemaForm.Unqualified)]
        public EscrowTypeSelectableFields EscrowTypeSelectableFields { get; set; }
        
        [XmlElementAttribute("ExtLoanSelectableFields", Order=50, Form=XmlSchemaForm.Unqualified)]
        public ExtLoanSelectableFields ExtLoanSelectableFields { get; set; }
        
        [XmlElementAttribute("GlCategorySelectableFields", Order=51, Form=XmlSchemaForm.Unqualified)]
        public GlCategorySelectableFields GlCategorySelectableFields { get; set; }
        
        [XmlElementAttribute("GlCodeSelectableFields", Order=52, Form=XmlSchemaForm.Unqualified)]
        public GlCodeSelectableFields GlCodeSelectableFields { get; set; }
        
        [XmlElementAttribute("GlTableSelectableFields", Order=53, Form=XmlSchemaForm.Unqualified)]
        public GlTableSelectableFields GlTableSelectableFields { get; set; }
        
        [XmlElementAttribute("GlTrackingTypeSelectableFields", Order=54, Form=XmlSchemaForm.Unqualified)]
        public GlTrackingTypeSelectableFields GlTrackingTypeSelectableFields { get; set; }
        
        [XmlElementAttribute("GlxLateSelectableFields", Order=55, Form=XmlSchemaForm.Unqualified)]
        public GlxLateSelectableFields GlxLateSelectableFields { get; set; }
        
        [XmlElementAttribute("IdentIdTypeDescSelectableFields", Order=56, Form=XmlSchemaForm.Unqualified)]
        public IdentIdTypeDescSelectableFields IdentIdTypeDescSelectableFields { get; set; }
        
        [XmlElementAttribute("ImagingSelectableFields", Order=57, Form=XmlSchemaForm.Unqualified)]
        public ImagingSelectableFields ImagingSelectableFields { get; set; }
        
        [XmlElementAttribute("InqDefinitionSelectableFields", Order=58, Form=XmlSchemaForm.Unqualified)]
        public InqDefinitionSelectableFields InqDefinitionSelectableFields { get; set; }
        
        [XmlElementAttribute("InsTableSelectableFields", Order=59, Form=XmlSchemaForm.Unqualified)]
        public InsTableSelectableFields InsTableSelectableFields { get; set; }
        
        [XmlElementAttribute("InsTypeSelectableFields", Order=60, Form=XmlSchemaForm.Unqualified)]
        public InsTypeSelectableFields InsTypeSelectableFields { get; set; }
        
        [XmlElementAttribute("InstitutionSelectableFields", Order=61, Form=XmlSchemaForm.Unqualified)]
        public InstitutionSelectableFields InstitutionSelectableFields { get; set; }
        
        [XmlElementAttribute("IntIndexSelectableFields", Order=62, Form=XmlSchemaForm.Unqualified)]
        public IntIndexSelectableFields IntIndexSelectableFields { get; set; }
        
        [XmlElementAttribute("IntTypeSelectableFields", Order=63, Form=XmlSchemaForm.Unqualified)]
        public IntTypeSelectableFields IntTypeSelectableFields { get; set; }
        
        [XmlElementAttribute("InventoryCopiedFldsSelectableFields", Order=64, Form=XmlSchemaForm.Unqualified)]
        public InventoryCopiedFldsSelectableFields InventoryCopiedFldsSelectableFields { get; set; }
        
        [XmlElementAttribute("InventoryDefaultSelectableFields", Order=65, Form=XmlSchemaForm.Unqualified)]
        public InventoryDefaultSelectableFields InventoryDefaultSelectableFields { get; set; }
        
        [XmlElementAttribute("InventoryFieldNameSelectableFields", Order=66, Form=XmlSchemaForm.Unqualified)]
        public InventoryFieldNameSelectableFields InventoryFieldNameSelectableFields { get; set; }
        
        [XmlElementAttribute("InventoryGeneralSelectableFields", Order=67, Form=XmlSchemaForm.Unqualified)]
        public InventoryGeneralSelectableFields InventoryGeneralSelectableFields { get; set; }
        
        [XmlElementAttribute("InventoryTypeSelectableFields", Order=68, Form=XmlSchemaForm.Unqualified)]
        public InventoryTypeSelectableFields InventoryTypeSelectableFields { get; set; }
        
        [XmlElementAttribute("IrsBkupWithholdSelectableFields", Order=69, Form=XmlSchemaForm.Unqualified)]
        public IrsBkupWithholdSelectableFields IrsBkupWithholdSelectableFields { get; set; }
        
        [XmlElementAttribute("IrsContriLimitSelectableFields", Order=70, Form=XmlSchemaForm.Unqualified)]
        public IrsContriLimitSelectableFields IrsContriLimitSelectableFields { get; set; }
        
        [XmlElementAttribute("ItcFraudSelectableFields", Order=71, Form=XmlSchemaForm.Unqualified)]
        public ItcFraudSelectableFields ItcFraudSelectableFields { get; set; }
        
        [XmlElementAttribute("ItcInstallationSelectableFields", Order=72, Form=XmlSchemaForm.Unqualified)]
        public ItcInstallationSelectableFields ItcInstallationSelectableFields { get; set; }
        
        [XmlElementAttribute("LateChgSelectableFields", Order=73, Form=XmlSchemaForm.Unqualified)]
        public LateChgSelectableFields LateChgSelectableFields { get; set; }
        
        [XmlElementAttribute("LnSegmentDefaultSelectableFields", Order=74, Form=XmlSchemaForm.Unqualified)]
        public LnSegmentDefaultSelectableFields LnSegmentDefaultSelectableFields { get; set; }
        
        [XmlElementAttribute("LoanAppCopiedFldsSelectableFields", Order=75, Form=XmlSchemaForm.Unqualified)]
        public LoanAppCopiedFldsSelectableFields LoanAppCopiedFldsSelectableFields { get; set; }
        
        [XmlElementAttribute("LoanAppDefaultSelectableFields", Order=76, Form=XmlSchemaForm.Unqualified)]
        public LoanAppDefaultSelectableFields LoanAppDefaultSelectableFields { get; set; }
        
        [XmlElementAttribute("LoanAppDenialSelectableFields", Order=77, Form=XmlSchemaForm.Unqualified)]
        public LoanAppDenialSelectableFields LoanAppDenialSelectableFields { get; set; }
        
        [XmlElementAttribute("LoanAppFieldNameSelectableFields", Order=78, Form=XmlSchemaForm.Unqualified)]
        public LoanAppFieldNameSelectableFields LoanAppFieldNameSelectableFields { get; set; }
        
        [XmlElementAttribute("LoanAppFormPktSelectableFields", Order=79, Form=XmlSchemaForm.Unqualified)]
        public LoanAppFormPktSelectableFields LoanAppFormPktSelectableFields { get; set; }
        
        [XmlElementAttribute("LoanAppMiscSelectableFields", Order=80, Form=XmlSchemaForm.Unqualified)]
        public LoanAppMiscSelectableFields LoanAppMiscSelectableFields { get; set; }
        
        [XmlElementAttribute("LoanAppPrintAppSelectableFields", Order=81, Form=XmlSchemaForm.Unqualified)]
        public LoanAppPrintAppSelectableFields LoanAppPrintAppSelectableFields { get; set; }
        
        [XmlElementAttribute("LoanAppReusedFldsSelectableFields", Order=82, Form=XmlSchemaForm.Unqualified)]
        public LoanAppReusedFldsSelectableFields LoanAppReusedFldsSelectableFields { get; set; }
        
        [XmlElementAttribute("LoanAppVerFormSelectableFields", Order=83, Form=XmlSchemaForm.Unqualified)]
        public LoanAppVerFormSelectableFields LoanAppVerFormSelectableFields { get; set; }
        
        [XmlElementAttribute("LoanAppViewAppSelectableFields", Order=84, Form=XmlSchemaForm.Unqualified)]
        public LoanAppViewAppSelectableFields LoanAppViewAppSelectableFields { get; set; }
        
        [XmlElementAttribute("LoanAppWorkFlowSelectableFields", Order=85, Form=XmlSchemaForm.Unqualified)]
        public LoanAppWorkFlowSelectableFields LoanAppWorkFlowSelectableFields { get; set; }
        
        [XmlElementAttribute("LoanDefaultSelectableFields", Order=86, Form=XmlSchemaForm.Unqualified)]
        public LoanDefaultSelectableFields LoanDefaultSelectableFields { get; set; }
        
        [XmlElementAttribute("LoanFieldNameSelectableFields", Order=87, Form=XmlSchemaForm.Unqualified)]
        public LoanFieldNameSelectableFields LoanFieldNameSelectableFields { get; set; }
        
        [XmlElementAttribute("LoanTypeIdRangeSelectableFields", Order=88, Form=XmlSchemaForm.Unqualified)]
        public LoanTypeIdRangeSelectableFields LoanTypeIdRangeSelectableFields { get; set; }
        
        [XmlElementAttribute("LookupTypeNameSelectableFields", Order=89, Form=XmlSchemaForm.Unqualified)]
        public LookupTypeNameSelectableFields LookupTypeNameSelectableFields { get; set; }
        
        [XmlElementAttribute("MiscSelectableFields", Order=90, Form=XmlSchemaForm.Unqualified)]
        public MiscSelectableFields MiscSelectableFields { get; set; }
        
        [XmlElementAttribute("MiscPmtSelectableFields", Order=91, Form=XmlSchemaForm.Unqualified)]
        public MiscPmtSelectableFields MiscPmtSelectableFields { get; set; }
        
        [XmlElementAttribute("MoProductSelectableFields", Order=92, Form=XmlSchemaForm.Unqualified)]
        public MoProductSelectableFields MoProductSelectableFields { get; set; }
        
        [XmlElementAttribute("NameFieldNameSelectableFields", Order=93, Form=XmlSchemaForm.Unqualified)]
        public NameFieldNameSelectableFields NameFieldNameSelectableFields { get; set; }
        
        [XmlElementAttribute("Ncua5300SelectableFields", Order=94, Form=XmlSchemaForm.Unqualified)]
        public Ncua5300SelectableFields Ncua5300SelectableFields { get; set; }
        
        [XmlElementAttribute("NonRegCcSelectableFields", Order=95, Form=XmlSchemaForm.Unqualified)]
        public NonRegCcSelectableFields NonRegCcSelectableFields { get; set; }
        
        [XmlElementAttribute("NoticeSelectableFields", Order=96, Form=XmlSchemaForm.Unqualified)]
        public NoticeSelectableFields NoticeSelectableFields { get; set; }
        
        [XmlElementAttribute("OnlineBlockSelectableFields", Order=97, Form=XmlSchemaForm.Unqualified)]
        public OnlineBlockSelectableFields OnlineBlockSelectableFields { get; set; }
        
        [XmlElementAttribute("OnlineCardSelectableFields", Order=98, Form=XmlSchemaForm.Unqualified)]
        public OnlineCardSelectableFields OnlineCardSelectableFields { get; set; }
        
        [XmlElementAttribute("OnlineFeeSelectableFields", Order=99, Form=XmlSchemaForm.Unqualified)]
        public OnlineFeeSelectableFields OnlineFeeSelectableFields { get; set; }
        
        [XmlElementAttribute("OnlineFileSelectableFields", Order=100, Form=XmlSchemaForm.Unqualified)]
        public OnlineFileSelectableFields OnlineFileSelectableFields { get; set; }
        
        [XmlElementAttribute("OnlineFileMgrSelectableFields", Order=101, Form=XmlSchemaForm.Unqualified)]
        public OnlineFileMgrSelectableFields OnlineFileMgrSelectableFields { get; set; }
        
        [XmlElementAttribute("OnlineMainSelectableFields", Order=102, Form=XmlSchemaForm.Unqualified)]
        public OnlineMainSelectableFields OnlineMainSelectableFields { get; set; }
        
        [XmlElementAttribute("OnlineNetSelectableFields", Order=103, Form=XmlSchemaForm.Unqualified)]
        public OnlineNetSelectableFields OnlineNetSelectableFields { get; set; }
        
        [XmlElementAttribute("OnlineOutletSelectableFields", Order=104, Form=XmlSchemaForm.Unqualified)]
        public OnlineOutletSelectableFields OnlineOutletSelectableFields { get; set; }
        
        [XmlElementAttribute("OnlineSbAddOnSelectableFields", Order=105, Form=XmlSchemaForm.Unqualified)]
        public OnlineSbAddOnSelectableFields OnlineSbAddOnSelectableFields { get; set; }
        
        [XmlElementAttribute("OnlineSbaSelectableFields", Order=106, Form=XmlSchemaForm.Unqualified)]
        public OnlineSbaSelectableFields OnlineSbaSelectableFields { get; set; }
        
        [XmlElementAttribute("OnlineSbiSelectableFields", Order=107, Form=XmlSchemaForm.Unqualified)]
        public OnlineSbiSelectableFields OnlineSbiSelectableFields { get; set; }
        
        [XmlElementAttribute("Param360ViewSelectableFields", Order=108, Form=XmlSchemaForm.Unqualified)]
        public Param360ViewSelectableFields Param360ViewSelectableFields { get; set; }
        
        [XmlElementAttribute("PartStatementSelectableFields", Order=109, Form=XmlSchemaForm.Unqualified)]
        public PartStatementSelectableFields PartStatementSelectableFields { get; set; }
        
        [XmlElementAttribute("PartTrackingTypeSelectableFields", Order=110, Form=XmlSchemaForm.Unqualified)]
        public PartTrackingTypeSelectableFields PartTrackingTypeSelectableFields { get; set; }
        
        [XmlElementAttribute("ParticipantFieldNameSelectableFields", Order=111, Form=XmlSchemaForm.Unqualified)]
        public ParticipantFieldNameSelectableFields ParticipantFieldNameSelectableFields { get; set; }
        
        [XmlElementAttribute("PayCalcSelectableFields", Order=112, Form=XmlSchemaForm.Unqualified)]
        public PayCalcSelectableFields PayCalcSelectableFields { get; set; }
        
        [XmlElementAttribute("PeriodicMtgSelectableFields", Order=113, Form=XmlSchemaForm.Unqualified)]
        public PeriodicMtgSelectableFields PeriodicMtgSelectableFields { get; set; }
        
        [XmlElementAttribute("PlanDefaultSelectableFields", Order=114, Form=XmlSchemaForm.Unqualified)]
        public PlanDefaultSelectableFields PlanDefaultSelectableFields { get; set; }
        
        [XmlElementAttribute("PlanFieldNameSelectableFields", Order=115, Form=XmlSchemaForm.Unqualified)]
        public PlanFieldNameSelectableFields PlanFieldNameSelectableFields { get; set; }
        
        [XmlElementAttribute("PmtAppMethodSelectableFields", Order=116, Form=XmlSchemaForm.Unqualified)]
        public PmtAppMethodSelectableFields PmtAppMethodSelectableFields { get; set; }
        
        [XmlElementAttribute("PositivePaySelectableFields", Order=117, Form=XmlSchemaForm.Unqualified)]
        public PositivePaySelectableFields PositivePaySelectableFields { get; set; }
        
        [XmlElementAttribute("PreferenceDefaultSelectableFields", Order=118, Form=XmlSchemaForm.Unqualified)]
        public PreferenceDefaultSelectableFields PreferenceDefaultSelectableFields { get; set; }
        
        [XmlElementAttribute("PrivGroupSelectableFields", Order=119, Form=XmlSchemaForm.Unqualified)]
        public PrivGroupSelectableFields PrivGroupSelectableFields { get; set; }
        
        [XmlElementAttribute("RegCcSelectableFields", Order=120, Form=XmlSchemaForm.Unqualified)]
        public RegCcSelectableFields RegCcSelectableFields { get; set; }
        
        [XmlElementAttribute("ScreenDefinitionSelectableFields", Order=121, Form=XmlSchemaForm.Unqualified)]
        public ScreenDefinitionSelectableFields ScreenDefinitionSelectableFields { get; set; }
        
        [XmlElementAttribute("SecFieldSelectableFields", Order=122, Form=XmlSchemaForm.Unqualified)]
        public SecFieldSelectableFields SecFieldSelectableFields { get; set; }
        
        [XmlElementAttribute("SecuritySelectableFields", Order=123, Form=XmlSchemaForm.Unqualified)]
        public SecuritySelectableFields SecuritySelectableFields { get; set; }
        
        [XmlElementAttribute("ShareDefaultSelectableFields", Order=124, Form=XmlSchemaForm.Unqualified)]
        public ShareDefaultSelectableFields ShareDefaultSelectableFields { get; set; }
        
        [XmlElementAttribute("ShareFieldNameSelectableFields", Order=125, Form=XmlSchemaForm.Unqualified)]
        public ShareFieldNameSelectableFields ShareFieldNameSelectableFields { get; set; }
        
        [XmlElementAttribute("StatementSelectableFields", Order=126, Form=XmlSchemaForm.Unqualified)]
        public StatementSelectableFields StatementSelectableFields { get; set; }
        
        [XmlElementAttribute("StmtMailNameSelectableFields", Order=127, Form=XmlSchemaForm.Unqualified)]
        public StmtMailNameSelectableFields StmtMailNameSelectableFields { get; set; }
        
        [XmlElementAttribute("StmtMessagesSelectableFields", Order=128, Form=XmlSchemaForm.Unqualified)]
        public StmtMessagesSelectableFields StmtMessagesSelectableFields { get; set; }
        
        [XmlElementAttribute("StockSelectableFields", Order=129, Form=XmlSchemaForm.Unqualified)]
        public StockSelectableFields StockSelectableFields { get; set; }
        
        [XmlElementAttribute("SycClientSelectableFields", Order=130, Form=XmlSchemaForm.Unqualified)]
        public SycClientSelectableFields SycClientSelectableFields { get; set; }
        
        [XmlElementAttribute("SycGeneralSelectableFields", Order=131, Form=XmlSchemaForm.Unqualified)]
        public SycGeneralSelectableFields SycGeneralSelectableFields { get; set; }
        
        [XmlElementAttribute("SymXClientSelectableFields", Order=132, Form=XmlSchemaForm.Unqualified)]
        public SymXClientSelectableFields SymXClientSelectableFields { get; set; }
        
        [XmlElementAttribute("SymXDeviceMapSelectableFields", Order=133, Form=XmlSchemaForm.Unqualified)]
        public SymXDeviceMapSelectableFields SymXDeviceMapSelectableFields { get; set; }
        
        [XmlElementAttribute("SymXGeneralSelectableFields", Order=134, Form=XmlSchemaForm.Unqualified)]
        public SymXGeneralSelectableFields SymXGeneralSelectableFields { get; set; }
        
        [XmlElementAttribute("SymXInstanceSelectableFields", Order=135, Form=XmlSchemaForm.Unqualified)]
        public SymXInstanceSelectableFields SymXInstanceSelectableFields { get; set; }
        
        [XmlElementAttribute("SynapsysMrmSelectableFields", Order=136, Form=XmlSchemaForm.Unqualified)]
        public SynapsysMrmSelectableFields SynapsysMrmSelectableFields { get; set; }
        
        [XmlElementAttribute("TcProductSelectableFields", Order=137, Form=XmlSchemaForm.Unqualified)]
        public TcProductSelectableFields TcProductSelectableFields { get; set; }
        
        [XmlElementAttribute("TellerFeeSelectableFields", Order=138, Form=XmlSchemaForm.Unqualified)]
        public TellerFeeSelectableFields TellerFeeSelectableFields { get; set; }
        
        [XmlElementAttribute("TellerTranFeeSelectableFields", Order=139, Form=XmlSchemaForm.Unqualified)]
        public TellerTranFeeSelectableFields TellerTranFeeSelectableFields { get; set; }
        
        [XmlElementAttribute("TellerTranValidateSelectableFields", Order=140, Form=XmlSchemaForm.Unqualified)]
        public TellerTranValidateSelectableFields TellerTranValidateSelectableFields { get; set; }
        
        [XmlElementAttribute("TptSelectableFields", Order=141, Form=XmlSchemaForm.Unqualified)]
        public TptSelectableFields TptSelectableFields { get; set; }
        
        [XmlElementAttribute("TrackingCodeSelectableFields", Order=142, Form=XmlSchemaForm.Unqualified)]
        public TrackingCodeSelectableFields TrackingCodeSelectableFields { get; set; }
        
        [XmlElementAttribute("UserFmSelectableFields", Order=143, Form=XmlSchemaForm.Unqualified)]
        public UserFmSelectableFields UserFmSelectableFields { get; set; }
        
        [XmlElementAttribute("UserTrackingFmSelectableFields", Order=144, Form=XmlSchemaForm.Unqualified)]
        public UserTrackingFmSelectableFields UserTrackingFmSelectableFields { get; set; }
        
        [XmlElementAttribute("UserTrackingTypeSelectableFields", Order=145, Form=XmlSchemaForm.Unqualified)]
        public UserTrackingTypeSelectableFields UserTrackingTypeSelectableFields { get; set; }
        
        [XmlElementAttribute("WarningsSelectableFields", Order=146, Form=XmlSchemaForm.Unqualified)]
        public WarningsSelectableFields WarningsSelectableFields { get; set; }
        
        [XmlElementAttribute("WdFeeSelectableFields", Order=147, Form=XmlSchemaForm.Unqualified)]
        public WdFeeSelectableFields WdFeeSelectableFields { get; set; }
        
        [XmlElementAttribute("WestUnCommCodeSelectableFields", Order=148, Form=XmlSchemaForm.Unqualified)]
        public WestUnCommCodeSelectableFields WestUnCommCodeSelectableFields { get; set; }
        
        [XmlElementAttribute("WireBfcSelectableFields", Order=149, Form=XmlSchemaForm.Unqualified)]
        public WireBfcSelectableFields WireBfcSelectableFields { get; set; }
        
        [XmlElementAttribute("WireCorpVerSelectableFields", Order=150, Form=XmlSchemaForm.Unqualified)]
        public WireCorpVerSelectableFields WireCorpVerSelectableFields { get; set; }
        
        [XmlElementAttribute("WireIdCodeSelectableFields", Order=151, Form=XmlSchemaForm.Unqualified)]
        public WireIdCodeSelectableFields WireIdCodeSelectableFields { get; set; }
        
        [XmlElementAttribute("WireInCmtCodeSelectableFields", Order=152, Form=XmlSchemaForm.Unqualified)]
        public WireInCmtCodeSelectableFields WireInCmtCodeSelectableFields { get; set; }
        
        [XmlElementAttribute("WireMiscSelectableFields", Order=153, Form=XmlSchemaForm.Unqualified)]
        public WireMiscSelectableFields WireMiscSelectableFields { get; set; }
        
        [XmlElementAttribute("WireOutCmtCodeSelectableFields", Order=154, Form=XmlSchemaForm.Unqualified)]
        public WireOutCmtCodeSelectableFields WireOutCmtCodeSelectableFields { get; set; }
        
        [XmlElementAttribute("WireTypeCodeSelectableFields", Order=155, Form=XmlSchemaForm.Unqualified)]
        public WireTypeCodeSelectableFields WireTypeCodeSelectableFields { get; set; }
        
        [XmlElementAttribute("WorkFlowRepGenSelectableFields", Order=156, Form=XmlSchemaForm.Unqualified)]
        public WorkFlowRepGenSelectableFields WorkFlowRepGenSelectableFields { get; set; }
        
        [XmlElementAttribute("YellowHammerSelectableFields", Order=157, Form=XmlSchemaForm.Unqualified)]
        public YellowHammerSelectableFields YellowHammerSelectableFields { get; set; }
        
        [XmlElementAttribute("Version_1", Order=158, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=159)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ParameterSelectableFields" /> class.</para>
        /// </summary>
        public ParameterSelectableFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
