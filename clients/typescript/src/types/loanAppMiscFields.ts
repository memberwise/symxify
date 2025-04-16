import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface LoanAppMiscFields {
    accountValue: boolean;
    accountValueSpecified: boolean;
    account: boolean | null;
    accountTypeValue: boolean;
    accountTypeValueSpecified: boolean;
    accountType: boolean | null;
    additionalInfoHeader: number[];
    additionalInfoHeaderSpecified: boolean;
    additionalInfoJustify: number[];
    additionalInfoJustifySpecified: boolean;
    additionalInfoSpecfileNameValue: boolean;
    additionalInfoSpecfileNameValueSpecified: boolean;
    additionalInfoSpecfileName: boolean | null;
    appTypeMaritalStatus: number[];
    appTypeMaritalStatusSpecified: boolean;
    autoCalcDebtRatiosValue: boolean;
    autoCalcDebtRatiosValueSpecified: boolean;
    autoCalcDebtRatios: boolean | null;
    autoCalcTotalsValue: boolean;
    autoCalcTotalsValueSpecified: boolean;
    autoCalcTotals: boolean | null;
    autoCreateFinanceRecordsValue: boolean;
    autoCreateFinanceRecordsValueSpecified: boolean;
    autoCreateFinanceRecords: boolean | null;
    autoCreatePersonRecordsValue: boolean;
    autoCreatePersonRecordsValueSpecified: boolean;
    autoCreatePersonRecords: boolean | null;
    automateRetrievalofCredRptValue: boolean;
    automateRetrievalofCredRptValueSpecified: boolean;
    automateRetrievalofCredRpt: boolean | null;
    automateWorkflowStepsValue: boolean;
    automateWorkflowStepsValueSpecified: boolean;
    automateWorkflowSteps: boolean | null;
    clearReusedAppNotesValue: boolean;
    clearReusedAppNotesValueSpecified: boolean;
    clearReusedAppNotes: boolean | null;
    consolidateFinanceRecListValue: boolean;
    consolidateFinanceRecListValueSpecified: boolean;
    consolidateFinanceRecList: boolean | null;
    copyIncometoMemberRecordValue: boolean;
    copyIncometoMemberRecordValueSpecified: boolean;
    copyIncometoMemberRecord: boolean | null;
    copyMovetoNewExistingAcctValue: boolean;
    copyMovetoNewExistingAcctValueSpecified: boolean;
    copyMovetoNewExistingAcct: boolean | null;
    createNoteWhenForwardedValue: boolean;
    createNoteWhenForwardedValueSpecified: boolean;
    createNoteWhenForwarded: boolean | null;
    creditUnionNameTransunion: number[];
    creditUnionNameTransunionSpecified: boolean;
    debtRatioExcludeCurrAppValue: boolean;
    debtRatioExcludeCurrAppValueSpecified: boolean;
    debtRatioExcludeCurrApp: boolean | null;
    debtRatioIncludeOtherAppValue: boolean;
    debtRatioIncludeOtherAppValueSpecified: boolean;
    debtRatioIncludeOtherApp: boolean | null;
    defaultBranchValue: boolean;
    defaultBranchValueSpecified: boolean;
    defaultBranch: boolean | null;
    disclosureSpecfileNameValue: boolean;
    disclosureSpecfileNameValueSpecified: boolean;
    disclosureSpecfileName: boolean | null;
    dlrRsrvAcctgTrackingTypeValue: boolean;
    dlrRsrvAcctgTrackingTypeValueSpecified: boolean;
    dlrRsrvAcctgTrackingType: boolean | null;
    excludeTrdItemsTransunion: number[];
    excludeTrdItemsTransunionSpecified: boolean;
    fieldCtrlProjectionScreenValue: boolean;
    fieldCtrlProjectionScreenValueSpecified: boolean;
    fieldCtrlProjectionScreen: boolean | null;
    fundingSpecfileNameValue: boolean;
    fundingSpecfileNameValueSpecified: boolean;
    fundingSpecfileName: boolean | null;
    fundingTrackingTypeValue: boolean;
    fundingTrackingTypeValueSpecified: boolean;
    fundingTrackingType: boolean | null;
    loanApplicationIdValue: boolean;
    loanApplicationIdValueSpecified: boolean;
    loanApplicationId: boolean | null;
    loanCreationOptionValue: boolean;
    loanCreationOptionValueSpecified: boolean;
    loanCreationOption: boolean | null;
    masterAppValue: boolean;
    masterAppValueSpecified: boolean;
    masterApp: boolean | null;
    membershipApplicationTypeValue: boolean;
    membershipApplicationTypeValueSpecified: boolean;
    membershipApplicationType: boolean | null;
    msgUserIdsValue: boolean;
    msgUserIdsValueSpecified: boolean;
    msgUserIds: boolean | null;
    nonMemberAccount: number[];
    nonMemberAccountSpecified: boolean;
    restrictApplicationDateValue: boolean;
    restrictApplicationDateValueSpecified: boolean;
    restrictApplicationDate: boolean | null;
    restrictApplicationTypeValue: boolean;
    restrictApplicationTypeValueSpecified: boolean;
    restrictApplicationType: boolean | null;
    restrictApprovalAmountValue: boolean;
    restrictApprovalAmountValueSpecified: boolean;
    restrictApprovalAmount: boolean | null;
    restrictApprovalCodeValue: boolean;
    restrictApprovalCodeValueSpecified: boolean;
    restrictApprovalCode: boolean | null;
    restrictApprovalDateValue: boolean;
    restrictApprovalDateValueSpecified: boolean;
    restrictApprovalDate: boolean | null;
    restrictBalloonAmountValue: boolean;
    restrictBalloonAmountValueSpecified: boolean;
    restrictBalloonAmount: boolean | null;
    restrictBalloonDateValue: boolean;
    restrictBalloonDateValueSpecified: boolean;
    restrictBalloonDate: boolean | null;
    restrictCounterOffExpDateValue: boolean;
    restrictCounterOffExpDateValueSpecified: boolean;
    restrictCounterOffExpDate: boolean | null;
    restrictCounterOrigAmtValue: boolean;
    restrictCounterOrigAmtValueSpecified: boolean;
    restrictCounterOrigAmt: boolean | null;
    restrictCreationDateValue: boolean;
    restrictCreationDateValueSpecified: boolean;
    restrictCreationDate: boolean | null;
    restrictCuDraftBalValue: boolean;
    restrictCuDraftBalValueSpecified: boolean;
    restrictCuDraftBal: boolean | null;
    restrictCuLocLoanBalValue: boolean;
    restrictCuLocLoanBalValueSpecified: boolean;
    restrictCuLocLoanBal: boolean | null;
    restrictCuLocPmtsValue: boolean;
    restrictCuLocPmtsValueSpecified: boolean;
    restrictCuLocPmts: boolean | null;
    restrictCuOeLoanBalValue: boolean;
    restrictCuOeLoanBalValueSpecified: boolean;
    restrictCuOeLoanBal: boolean | null;
    restrictCuOePmtsValue: boolean;
    restrictCuOePmtsValueSpecified: boolean;
    restrictCuOePmts: boolean | null;
    restrictCuShareBalValue: boolean;
    restrictCuShareBalValueSpecified: boolean;
    restrictCuShareBal: boolean | null;
    restrictCuTotalCreditLimValue: boolean;
    restrictCuTotalCreditLimValueSpecified: boolean;
    restrictCuTotalCreditLim: boolean | null;
    restrictDebtRatio1Value: boolean;
    restrictDebtRatio1ValueSpecified: boolean;
    restrictDebtRatio1: boolean | null;
    restrictDebtRatio2Value: boolean;
    restrictDebtRatio2ValueSpecified: boolean;
    restrictDebtRatio2: boolean | null;
    restrictDebtRatio3Value: boolean;
    restrictDebtRatio3ValueSpecified: boolean;
    restrictDebtRatio3: boolean | null;
    restrictDebtRatio4Value: boolean;
    restrictDebtRatio4ValueSpecified: boolean;
    restrictDebtRatio4: boolean | null;
    restrictDebtRatio5Value: boolean;
    restrictDebtRatio5ValueSpecified: boolean;
    restrictDebtRatio5: boolean | null;
    restrictDecisionCodeValue: boolean;
    restrictDecisionCodeValueSpecified: boolean;
    restrictDecisionCode: boolean | null;
    restrictDecisionDateValue: boolean;
    restrictDecisionDateValueSpecified: boolean;
    restrictDecisionDate: boolean | null;
    restrictInsuranceTypeValue: boolean;
    restrictInsuranceTypeValueSpecified: boolean;
    restrictInsuranceType: boolean | null;
    restrictInterestRateValue: boolean;
    restrictInterestRateValueSpecified: boolean;
    restrictInterestRate: boolean | null;
    restrictLoanAmountValue: boolean;
    restrictLoanAmountValueSpecified: boolean;
    restrictLoanAmount: boolean | null;
    restrictLoanCreditLimitValue: boolean;
    restrictLoanCreditLimitValueSpecified: boolean;
    restrictLoanCreditLimit: boolean | null;
    restrictLoanMaturityDateValue: boolean;
    restrictLoanMaturityDateValueSpecified: boolean;
    restrictLoanMaturityDate: boolean | null;
    restrictLoanTerminMoValue: boolean;
    restrictLoanTerminMoValueSpecified: boolean;
    restrictLoanTerminMo: boolean | null;
    restrictLoanTypeValue: boolean;
    restrictLoanTypeValueSpecified: boolean;
    restrictLoanType: boolean | null;
    restrictPaymentAmountValue: boolean;
    restrictPaymentAmountValueSpecified: boolean;
    restrictPaymentAmount: boolean | null;
    restrictPaymentFreqValue: boolean;
    restrictPaymentFreqValueSpecified: boolean;
    restrictPaymentFreq: boolean | null;
    restrictSglPremDisValue: boolean;
    restrictSglPremDisValueSpecified: boolean;
    restrictSglPremDis: boolean | null;
    restrictSglPremLifeValue: boolean;
    restrictSglPremLifeValueSpecified: boolean;
    restrictSglPremLife: boolean | null;
    scriptedLoanFundingValue: boolean;
    scriptedLoanFundingValueSpecified: boolean;
    scriptedLoanFunding: boolean | null;
    searchExistingCredRptsDaysValue: boolean;
    searchExistingCredRptsDaysValueSpecified: boolean;
    searchExistingCredRptsDays: boolean | null;
    trdItemFinSkpBlankDescValue: boolean;
    trdItemFinSkpBlankDescValueSpecified: boolean;
    trdItemFinSkpBlankDesc: boolean | null;
    trdItemFinSkpZeroValue: boolean;
    trdItemFinSkpZeroValueSpecified: boolean;
    trdItemFinSkpZero: boolean | null;
    trdItemMinPmtCutoffValue: boolean;
    trdItemMinPmtCutoffValueSpecified: boolean;
    trdItemMinPmtCutoff: boolean | null;
    trdItemMnthlyPmtRateValue: boolean;
    trdItemMnthlyPmtRateValueSpecified: boolean;
    trdItemMnthlyPmtRate: boolean | null;
    userIdsValue: boolean;
    userIdsValueSpecified: boolean;
    userIds: boolean | null;
    validateLnInterestAmountValue: boolean;
    validateLnInterestAmountValueSpecified: boolean;
    validateLnInterestAmount: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}