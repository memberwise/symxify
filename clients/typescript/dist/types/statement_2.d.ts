import { StatementAmtDueExpDateStmtMsgCode_2 } from "./statementAmtDueExpDateStmtMsgCode_2";
import { StatementBeginPromoBal_2 } from "./statementBeginPromoBal_2";
import { StatementCollateralList_2 } from "./statementCollateralList_2";
import { StatementComplaintCorrStmtMsgCode_2 } from "./statementComplaintCorrStmtMsgCode_2";
import { StatementContactInformation_2 } from "./statementContactInformation_2";
import { StatementCustomStmtMsgCollList_2 } from "./statementCustomStmtMsgCollList_2";
import { StatementCustomStmtMsgLoanTypes_2 } from "./statementCustomStmtMsgLoanTypes_2";
import { StatementCustomStmtMsgPurposeList_2 } from "./statementCustomStmtMsgPurposeList_2";
import { StatementDelinquencyDateStmtMsgCode_2 } from "./statementDelinquencyDateStmtMsgCode_2";
import { StatementDelqAmtDueHistoryOption_2 } from "./statementDelqAmtDueHistoryOption_2";
import { StatementDqContactInformation_2 } from "./statementDqContactInformation_2";
import { StatementEndingPromoBal_2 } from "./statementEndingPromoBal_2";
import { StatementGeneralStatementMessageCode_2 } from "./statementGeneralStatementMessageCode_2";
import { StatementInstitutionAddressLine_2 } from "./statementInstitutionAddressLine_2";
import { StatementLnLine_2 } from "./statementLnLine_2";
import { StatementLoanTypes_2 } from "./statementLoanTypes_2";
import { StatementLtChgStatementMsgCode_2 } from "./statementLtChgStatementMsgCode_2";
import { StatementPmtCutoffTimeStmtMsgCode_2 } from "./statementPmtCutoffTimeStmtMsgCode_2";
import { StatementPromoBalance_2 } from "./statementPromoBalance_2";
import { StatementPromoDescription_2 } from "./statementPromoDescription_2";
import { StatementPromoTermination_2 } from "./statementPromoTermination_2";
import { StatementPurposeList_2 } from "./statementPurposeList_2";
import { StatementRelMsgLine11_2 } from "./statementRelMsgLine11_2";
import { StatementRelMsgLine110_2 } from "./statementRelMsgLine110_2";
import { StatementRelMsgLine12_2 } from "./statementRelMsgLine12_2";
import { StatementRelMsgLine13_2 } from "./statementRelMsgLine13_2";
import { StatementRelMsgLine14_2 } from "./statementRelMsgLine14_2";
import { StatementRelMsgLine15_2 } from "./statementRelMsgLine15_2";
import { StatementRelMsgLine16_2 } from "./statementRelMsgLine16_2";
import { StatementRelMsgLine17_2 } from "./statementRelMsgLine17_2";
import { StatementRelMsgLine18_2 } from "./statementRelMsgLine18_2";
import { StatementRelMsgLine19_2 } from "./statementRelMsgLine19_2";
import { StatementRelMsgLine21_2 } from "./statementRelMsgLine21_2";
import { StatementRelMsgLine210_2 } from "./statementRelMsgLine210_2";
import { StatementRelMsgLine22_2 } from "./statementRelMsgLine22_2";
import { StatementRelMsgLine23_2 } from "./statementRelMsgLine23_2";
import { StatementRelMsgLine24_2 } from "./statementRelMsgLine24_2";
import { StatementRelMsgLine25_2 } from "./statementRelMsgLine25_2";
import { StatementRelMsgLine26_2 } from "./statementRelMsgLine26_2";
import { StatementRelMsgLine27_2 } from "./statementRelMsgLine27_2";
import { StatementRelMsgLine28_2 } from "./statementRelMsgLine28_2";
import { StatementRelMsgLine29_2 } from "./statementRelMsgLine29_2";
import { StatementRelationshipCodes_2 } from "./statementRelationshipCodes_2";
import { StatementServicerAddress_2 } from "./statementServicerAddress_2";
import { StatementSvLine_2 } from "./statementSvLine_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface Statement_2 {
    accountTrackingTypes: string;
    ach: string;
    achTransactions: string;
    additionalPrincipal: string;
    amtDueExpDateStmtMsgCode: StatementAmtDueExpDateStmtMsgCode_2[];
    amtDueExpDateStmtMsgCodeSpecified: boolean;
    atm: string;
    atmSummaryLoanTypes: string;
    atmSummaryShareTypes: string;
    audioResponse: string;
    availBalTransfer: string;
    availCashAdvance: string;
    availCombinedCaBt: string;
    balTransferLimit: string;
    beginPromoBal: StatementBeginPromoBal_2[];
    beginPromoBalSpecified: boolean;
    beginRegularBal: string;
    beginningBalance: string;
    billFeeAmount: string;
    billPayment: string;
    bulk: string;
    cardTypesinTranHistory: string;
    cash: string;
    cashAdvanceLimit: string;
    chapter4Withholding: string;
    check: string;
    checkHoldCommentPrtOptionValue: number;
    checkHoldCommentPrtOptionValueSpecified: boolean;
    checkHoldCommentPrtOption: number | null;
    checkHoldPrintOptionValue: number;
    checkHoldPrintOptionValueSpecified: boolean;
    checkHoldPrintOption: number | null;
    collateralList: StatementCollateralList_2[];
    collateralListSpecified: boolean;
    combinedCaBtLimit: string;
    complaintCorrStmtMsgCode: StatementComplaintCorrStmtMsgCode_2[];
    complaintCorrStmtMsgCodeSpecified: boolean;
    contactInformation: StatementContactInformation_2[];
    contactInformationSpecified: boolean;
    creditAvailable: string;
    creditCarSepForIdsValue: number;
    creditCarSepForIdsValueSpecified: boolean;
    creditCarSepForIds: number | null;
    creditCard: string;
    creditCardCouponSummaryValue: boolean;
    creditCardCouponSummaryValueSpecified: boolean;
    creditCardCouponSummary: boolean | null;
    creditCardDigitLengthValue: number;
    creditCardDigitLengthValueSpecified: boolean;
    creditCardDigitLength: number | null;
    creditCardDigitStartValue: number;
    creditCardDigitStartValueSpecified: boolean;
    creditCardDigitStart: number | null;
    creditCardInactiveZeroBalValue: number;
    creditCardInactiveZeroBalValueSpecified: boolean;
    creditCardInactiveZeroBal: number | null;
    creditCardMinPmtDisclOptValue: number;
    creditCardMinPmtDisclOptValueSpecified: boolean;
    creditCardMinPmtDisclOpt: number | null;
    creditCardPaymentValue: number;
    creditCardPaymentValueSpecified: boolean;
    creditCardPayment: number | null;
    creditCardPrintingValue: number;
    creditCardPrintingValueSpecified: boolean;
    creditCardPrinting: number | null;
    creditCardPromotionsTableValue: boolean;
    creditCardPromotionsTableValueSpecified: boolean;
    creditCardPromotionsTable: boolean | null;
    creditCardSepforSummariesValue: number;
    creditCardSepforSummariesValueSpecified: boolean;
    creditCardSepforSummaries: number | null;
    creditCounselingPhone: string;
    creditLimit: string;
    customStmtMsgCollList: StatementCustomStmtMsgCollList_2[];
    customStmtMsgCollListSpecified: boolean;
    customStmtMsgLoanTypes: StatementCustomStmtMsgLoanTypes_2[];
    customStmtMsgLoanTypesSpecified: boolean;
    customStmtMsgOptionCountValue: number;
    customStmtMsgOptionCountValueSpecified: boolean;
    customStmtMsgOptionCount: number | null;
    customStmtMsgPurposeList: StatementCustomStmtMsgPurposeList_2[];
    customStmtMsgPurposeListSpecified: boolean;
    debitCard: string;
    delinquencyDateStmtMsgCode: StatementDelinquencyDateStmtMsgCode_2[];
    delinquencyDateStmtMsgCodeSpecified: boolean;
    delqAmtDueHistoryOption: StatementDelqAmtDueHistoryOption_2[];
    delqAmtDueHistoryOptionSpecified: boolean;
    deposit: string;
    dividend: string;
    dividendPrintingValue: number;
    dividendPrintingValueSpecified: boolean;
    dividendPrinting: number | null;
    dividendYtd: string;
    dqContactInformation: StatementDqContactInformation_2[];
    dqContactInformationSpecified: boolean;
    draft: string;
    draftSummaryLoanTypes: string;
    draftSummaryShareTypes: string;
    earlyWdPenalty: string;
    endingBalance: string;
    endingPromoBal: StatementEndingPromoBal_2[];
    endingPromoBalSpecified: boolean;
    endingRegularBal: string;
    escrow: string;
    escrowAmount: string;
    escrowUnpaid: string;
    externalLoanTrackingTypes: string;
    fasterPayments: string;
    fee: string;
    feesChargedYtd: string;
    formatValue: number;
    formatValueSpecified: boolean;
    format: number | null;
    generalStatementMessageCode: StatementGeneralStatementMessageCode_2[];
    generalStatementMessageCodeSpecified: boolean;
    homeBanking: string;
    homeEquityCollateralCodes: string;
    householdOptionValue: number;
    householdOptionValueSpecified: boolean;
    householdOption: number | null;
    inclLateChgUnpaidChgAmtValue: boolean;
    inclLateChgUnpaidChgAmtValueSpecified: boolean;
    inclLateChgUnpaidChgAmt: boolean | null;
    inclWaivedLateChargeAmtValue: boolean;
    inclWaivedLateChargeAmtValueSpecified: boolean;
    inclWaivedLateChargeAmt: boolean | null;
    inclWireOriginatorCommentValue: boolean;
    inclWireOriginatorCommentValueSpecified: boolean;
    inclWireOriginatorComment: boolean | null;
    include000FeeCommentsValue: boolean;
    include000FeeCommentsValueSpecified: boolean;
    include000FeeComments: boolean | null;
    includeAchCheckCommentsValue: boolean;
    includeAchCheckCommentsValueSpecified: boolean;
    includeAchCheckComments: boolean | null;
    includeAchEccCommentsValue: boolean;
    includeAchEccCommentsValueSpecified: boolean;
    includeAchEccComments: boolean | null;
    includeAchTraceCommentsValue: boolean;
    includeAchTraceCommentsValueSpecified: boolean;
    includeAchTraceComments: boolean | null;
    includeAddlPrincipalCommentValue: boolean;
    includeAddlPrincipalCommentValueSpecified: boolean;
    includeAddlPrincipalComment: boolean | null;
    includeBalanceSummaryValue: boolean;
    includeBalanceSummaryValueSpecified: boolean;
    includeBalanceSummary: boolean | null;
    includeBulkDepositCommentsValue: boolean;
    includeBulkDepositCommentsValueSpecified: boolean;
    includeBulkDepositComments: boolean | null;
    includeCdMoTcCommentsValue: boolean;
    includeCdMoTcCommentsValueSpecified: boolean;
    includeCdMoTcComments: boolean | null;
    includeCheckCashingCommentValue: boolean;
    includeCheckCashingCommentValueSpecified: boolean;
    includeCheckCashingComment: boolean | null;
    includeCkDisbursedCommentsValue: boolean;
    includeCkDisbursedCommentsValueSpecified: boolean;
    includeCkDisbursedComments: boolean | null;
    includeCkReceivedCommentsValue: boolean;
    includeCkReceivedCommentsValueSpecified: boolean;
    includeCkReceivedComments: boolean | null;
    includeDivAccrualInfoforValue: number;
    includeDivAccrualInfoforValueSpecified: boolean;
    includeDivAccrualInfofor: number | null;
    includeDividendAccrualInfoValue: boolean;
    includeDividendAccrualInfoValueSpecified: boolean;
    includeDividendAccrualInfo: boolean | null;
    includeFrFdCommentsValue: boolean;
    includeFrFdCommentsValueSpecified: boolean;
    includeFrFdComments: boolean | null;
    includeIntAccrualInfoforValue: number;
    includeIntAccrualInfoforValueSpecified: boolean;
    includeIntAccrualInfofor: number | null;
    includeInterestAccrualInfoValue: boolean;
    includeInterestAccrualInfoValueSpecified: boolean;
    includeInterestAccrualInfo: boolean | null;
    includeMccCommentsValue: boolean;
    includeMccCommentsValueSpecified: boolean;
    includeMccComments: boolean | null;
    includeMembersRemarksValue: boolean;
    includeMembersRemarksValueSpecified: boolean;
    includeMembersRemarks: boolean | null;
    includePreviousYearsTotalsValue: boolean;
    includePreviousYearsTotalsValueSpecified: boolean;
    includePreviousYearsTotals: boolean | null;
    inquiryLine: string;
    institutionAddressLine: StatementInstitutionAddressLine_2[];
    institutionAddressLineSpecified: boolean;
    insurance: string;
    interestChargedYtd: string;
    interestPrintingValue: number;
    interestPrintingValueSpecified: boolean;
    interestPrinting: number | null;
    interestRefund: string;
    interestYtd: string;
    interestYtdLease: string;
    irsWithholding: string;
    journalVoucher: string;
    kiosk: string;
    lateCharge: string;
    lateChargesUnpaid: string;
    lnLine: StatementLnLine_2[];
    lnLineSpecified: boolean;
    loanAddon: string;
    loanTrackingTypes: string;
    loanTypes: StatementLoanTypes_2[];
    loanTypesSpecified: boolean;
    locAvailAbleDqDaysValue: number;
    locAvailAbleDqDaysValueSpecified: boolean;
    locAvailAbleDqDays: number | null;
    lostStolenCardPhone: string;
    ltChgStatementMsgCode: StatementLtChgStatementMsgCode_2[];
    ltChgStatementMsgCodeSpecified: boolean;
    mailCodeCforClosedAcctsValue: boolean;
    mailCodeCforClosedAcctsValueSpecified: boolean;
    mailCodeCforClosedAccts: boolean | null;
    makeCheckPayableto: string;
    maskBeneficiarySsnValue: number;
    maskBeneficiarySsnValueSpecified: boolean;
    maskBeneficiarySsn: number | null;
    memberRemarks: string;
    merchantCategoryCode: string;
    minBalforMinPmtDisclValue: number;
    minBalforMinPmtDisclValueSpecified: boolean;
    minBalforMinPmtDiscl: number | null;
    minimumInterestDueValue: number;
    minimumInterestDueValueSpecified: boolean;
    minimumInterestDue: number | null;
    mortgageStatementOptionCounValue: number;
    mortgageStatementOptionCounValueSpecified: boolean;
    mortgageStatementOptionCoun: number | null;
    negativeSignOptionValue: number;
    negativeSignOptionValueSpecified: boolean;
    negativeSignOption: number | null;
    newLoan: string;
    newSharefee: string;
    nonCertificateMaturityDateValue: boolean;
    nonCertificateMaturityDateValueSpecified: boolean;
    nonCertificateMaturityDate: boolean | null;
    nontaxDividendYtd: string;
    numberofpagesthisBatchValue: number;
    numberofpagesthisBatchValueSpecified: boolean;
    numberofpagesthisBatch: number | null;
    numberoftimesGeneratedValue: number;
    numberoftimesGeneratedValueSpecified: boolean;
    numberoftimesGenerated: number | null;
    originalBalance: string;
    overdraftItemFeeDesc: string;
    overdrawn: string;
    payment: string;
    paymentPrintOptionValue: number;
    paymentPrintOptionValueSpecified: boolean;
    paymentPrintOption: number | null;
    paymentSlipPrintingOptionValue: number;
    paymentSlipPrintingOptionValueSpecified: boolean;
    paymentSlipPrintingOption: number | null;
    payroll: string;
    penaltyYtd: string;
    pintAprInfoValue: boolean;
    pintAprInfoValueSpecified: boolean;
    pintAprInfo: boolean | null;
    pmtCutoffTimeStmtMsgCode: StatementPmtCutoffTimeStmtMsgCode_2[];
    pmtCutoffTimeStmtMsgCodeSpecified: boolean;
    pos: string;
    postponedLateChg: string;
    principalPaymentDesc: string;
    printAccountReferenceValue: boolean;
    printAccountReferenceValueSpecified: boolean;
    printAccountReference: boolean | null;
    printAcctRelationshipCodeValue: boolean;
    printAcctRelationshipCodeValueSpecified: boolean;
    printAcctRelationshipCode: boolean | null;
    printAddlInstrStmtDisclValue: boolean;
    printAddlInstrStmtDisclValueSpecified: boolean;
    printAddlInstrStmtDiscl: boolean | null;
    printAddrStmtDisclosureValue: boolean;
    printAddrStmtDisclosureValueSpecified: boolean;
    printAddrStmtDisclosure: boolean | null;
    printCreditCardLoanIdValue: boolean;
    printCreditCardLoanIdValueSpecified: boolean;
    printCreditCardLoanId: boolean | null;
    printDraftTracerNumbersValue: boolean;
    printDraftTracerNumbersValueSpecified: boolean;
    printDraftTracerNumbers: boolean | null;
    printIraContributionTotalsValue: boolean;
    printIraContributionTotalsValueSpecified: boolean;
    printIraContributionTotals: boolean | null;
    printNameTypes: string;
    printOdpFeeAmountTotalsValue: number;
    printOdpFeeAmountTotalsValueSpecified: boolean;
    printOdpFeeAmountTotals: number | null;
    printOtherAccountInfoValue: boolean;
    printOtherAccountInfoValueSpecified: boolean;
    printOtherAccountInfo: boolean | null;
    printPhoneStmtDisclosureValue: boolean;
    printPhoneStmtDisclosureValueSpecified: boolean;
    printPhoneStmtDisclosure: boolean | null;
    printSocialSecurityNumberValue: boolean;
    printSocialSecurityNumberValueSpecified: boolean;
    printSocialSecurityNumber: boolean | null;
    printStmtDisclosureValue: number;
    printStmtDisclosureValueSpecified: boolean;
    printStmtDisclosure: number | null;
    printStmtEscrowUnpaidBalValue: boolean;
    printStmtEscrowUnpaidBalValueSpecified: boolean;
    printStmtEscrowUnpaidBal: boolean | null;
    printStmtLateChgUnpaidBalValue: boolean;
    printStmtLateChgUnpaidBalValueSpecified: boolean;
    printStmtLateChgUnpaidBal: boolean | null;
    printStmtUnappliedPmtBalValue: boolean;
    printStmtUnappliedPmtBalValueSpecified: boolean;
    printStmtUnappliedPmtBal: boolean | null;
    printTransferAcctNumbersValue: boolean;
    printTransferAcctNumbersValueSpecified: boolean;
    printTransferAcctNumbers: boolean | null;
    printWebsiteStmtDisclosureValue: boolean;
    printWebsiteStmtDisclosureValueSpecified: boolean;
    printWebsiteStmtDisclosure: boolean | null;
    printnextDividendValue: boolean;
    printnextDividendValueSpecified: boolean;
    printnextDividend: boolean | null;
    promoBalance: StatementPromoBalance_2[];
    promoBalanceSpecified: boolean;
    promoDescription: StatementPromoDescription_2[];
    promoDescriptionSpecified: boolean;
    promoTermination: StatementPromoTermination_2[];
    promoTerminationSpecified: boolean;
    purposeList: StatementPurposeList_2[];
    purposeListSpecified: boolean;
    recurring: string;
    refinance: string;
    regZYtdTotalsPrintOptionValue: number;
    regZYtdTotalsPrintOptionValueSpecified: boolean;
    regZYtdTotalsPrintOption: number | null;
    regularBalance: string;
    relMsgLine11: StatementRelMsgLine11_2[];
    relMsgLine11Specified: boolean;
    relMsgLine110: StatementRelMsgLine110_2[];
    relMsgLine110Specified: boolean;
    relMsgLine12: StatementRelMsgLine12_2[];
    relMsgLine12Specified: boolean;
    relMsgLine13: StatementRelMsgLine13_2[];
    relMsgLine13Specified: boolean;
    relMsgLine14: StatementRelMsgLine14_2[];
    relMsgLine14Specified: boolean;
    relMsgLine15: StatementRelMsgLine15_2[];
    relMsgLine15Specified: boolean;
    relMsgLine16: StatementRelMsgLine16_2[];
    relMsgLine16Specified: boolean;
    relMsgLine17: StatementRelMsgLine17_2[];
    relMsgLine17Specified: boolean;
    relMsgLine18: StatementRelMsgLine18_2[];
    relMsgLine18Specified: boolean;
    relMsgLine19: StatementRelMsgLine19_2[];
    relMsgLine19Specified: boolean;
    relMsgLine21: StatementRelMsgLine21_2[];
    relMsgLine21Specified: boolean;
    relMsgLine210: StatementRelMsgLine210_2[];
    relMsgLine210Specified: boolean;
    relMsgLine22: StatementRelMsgLine22_2[];
    relMsgLine22Specified: boolean;
    relMsgLine23: StatementRelMsgLine23_2[];
    relMsgLine23Specified: boolean;
    relMsgLine24: StatementRelMsgLine24_2[];
    relMsgLine24Specified: boolean;
    relMsgLine25: StatementRelMsgLine25_2[];
    relMsgLine25Specified: boolean;
    relMsgLine26: StatementRelMsgLine26_2[];
    relMsgLine26Specified: boolean;
    relMsgLine27: StatementRelMsgLine27_2[];
    relMsgLine27Specified: boolean;
    relMsgLine28: StatementRelMsgLine28_2[];
    relMsgLine28Specified: boolean;
    relMsgLine29: StatementRelMsgLine29_2[];
    relMsgLine29Specified: boolean;
    relationshipCodes: StatementRelationshipCodes_2[];
    relationshipCodesSpecified: boolean;
    salesTaxAmount: string;
    separatePrintoutOptionValue: number;
    separatePrintoutOptionValueSpecified: boolean;
    separatePrintoutOption: number | null;
    separatorForIdsValue: number;
    separatorForIdsValueSpecified: boolean;
    separatorForIds: number | null;
    separatorforBalanceSummaryValue: number;
    separatorforBalanceSummaryValueSpecified: boolean;
    separatorforBalanceSummary: number | null;
    separatorforSummariesValue: number;
    separatorforSummariesValueSpecified: boolean;
    separatorforSummaries: number | null;
    servicerAddress: StatementServicerAddress_2[];
    servicerAddressSpecified: boolean;
    shareTrackingTypes: string;
    sharedBranch: string;
    sortOrderValue: number;
    sortOrderValueSpecified: boolean;
    sortOrder: number | null;
    specifyBranchStmtDisclosureValue: number;
    specifyBranchStmtDisclosureValueSpecified: boolean;
    specifyBranchStmtDisclosure: number | null;
    specifyOvlStmtDisclosureFeValue: number;
    specifyOvlStmtDisclosureFeValueSpecified: boolean;
    specifyOvlStmtDisclosureFe: number | null;
    stateWithholdYtd: string;
    stateWithholding: string;
    statementBatchNumberValue: number;
    statementBatchNumberValueSpecified: boolean;
    statementBatchNumber: number | null;
    statementCutoffDateValue: string | null;
    statementCutoffDateValueSpecified: boolean;
    statementCutoffDate: string | null;
    statementGroupList: string;
    statementSortCountValue: number;
    statementSortCountValueSpecified: boolean;
    statementSortCount: number | null;
    statementSortRecordValue: number;
    statementSortRecordValueSpecified: boolean;
    statementSortRecord: number | null;
    stmtDisclosureAddrSourceValue: number;
    stmtDisclosureAddrSourceValueSpecified: boolean;
    stmtDisclosureAddrSource: number | null;
    stopPayPrintOptionValue: number;
    stopPayPrintOptionValueSpecified: boolean;
    stopPayPrintOption: number | null;
    subformatValue: number;
    subformatValueSpecified: boolean;
    subformat: number | null;
    suppressAcctNumberZerosValue: boolean;
    suppressAcctNumberZerosValueSpecified: boolean;
    suppressAcctNumberZeros: boolean | null;
    svLine: StatementSvLine_2[];
    svLineSpecified: boolean;
    totIntPdFromOpenLease: string;
    totalAggregatePaid: string;
    totalInterestPaid: string;
    totalLoanBkBalanceValue: number;
    totalLoanBkBalanceValueSpecified: boolean;
    totalLoanBkBalance: number | null;
    totalLoanBalanceValue: number;
    totalLoanBalanceValueSpecified: boolean;
    totalLoanBalance: number | null;
    totalLoanCountValue: number;
    totalLoanCountValueSpecified: boolean;
    totalLoanCount: number | null;
    totalLoanInterestYtdValue: number;
    totalLoanInterestYtdValueSpecified: boolean;
    totalLoanInterestYtd: number | null;
    totalOtherAcctCountValue: number;
    totalOtherAcctCountValueSpecified: boolean;
    totalOtherAcctCount: number | null;
    totalShareBalanceValue: number;
    totalShareBalanceValueSpecified: boolean;
    totalShareBalance: number | null;
    totalShareCountValue: number;
    totalShareCountValueSpecified: boolean;
    totalShareCount: number | null;
    totalShareDividendYtdValue: number;
    totalShareDividendYtdValueSpecified: boolean;
    totalShareDividendYtd: number | null;
    totalSharePenaltyYtdValue: number;
    totalSharePenaltyYtdValueSpecified: boolean;
    totalSharePenaltyYtd: number | null;
    totalShareStateWithholdYtdValue: number;
    totalShareStateWithholdYtdValueSpecified: boolean;
    totalShareStateWithholdYtd: number | null;
    totalShareWithholdYtdValue: number;
    totalShareWithholdYtdValueSpecified: boolean;
    totalShareWithholdYtd: number | null;
    totalStatementCountValue: number;
    totalStatementCountValueSpecified: boolean;
    totalStatementCount: number | null;
    transactionPrintOrderValue: number;
    transactionPrintOrderValueSpecified: boolean;
    transactionPrintOrder: number | null;
    unappliedPartialPayment: string;
    unappliedPartialPmtChg: string;
    unpaidItemFeeDesc: string;
    useAlternateAddressValue: boolean;
    useAlternateAddressValueSpecified: boolean;
    useAlternateAddress: boolean | null;
    useLoanOvlStmtDisclosureFValue: boolean;
    useLoanOvlStmtDisclosureFValueSpecified: boolean;
    useLoanOvlStmtDisclosureF: boolean | null;
    useTabularStatementFormatValue: boolean;
    useTabularStatementFormatValueSpecified: boolean;
    useTabularStatementFormat: boolean | null;
    userDefinedSourceCode0: string;
    userDefinedSourceCode1: string;
    userDefinedSourceCode2: string;
    userDefinedSourceCode3: string;
    userDefinedSourceCode4: string;
    userDefinedSourceCode5: string;
    userDefinedSourceCode6: string;
    userDefinedSourceCode7: string;
    userDefinedSourceCode8: string;
    userDefinedSourceCode9: string;
    waivedLateCharge: string;
    wdDepSummaryLoanTypes: string;
    wdDepSummaryShareTypes: string;
    wire: string;
    wireOriginator: string;
    withdrawal: string;
    withholdingYtd: string;
    ytdTotalPrintingValue: number;
    ytdTotalPrintingValueSpecified: boolean;
    ytdTotalPrinting: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
