import { StatementAmtDueExpDateStmtMsgCode } from "./statementAmtDueExpDateStmtMsgCode";
import { StatementBeginPromoBal } from "./statementBeginPromoBal";
import { StatementCollateralList } from "./statementCollateralList";
import { StatementComplaintCorrStmtMsgCode } from "./statementComplaintCorrStmtMsgCode";
import { StatementContactInformation } from "./statementContactInformation";
import { StatementCustomStmtMsgCollList } from "./statementCustomStmtMsgCollList";
import { StatementCustomStmtMsgLoanTypes } from "./statementCustomStmtMsgLoanTypes";
import { StatementCustomStmtMsgPurposeList } from "./statementCustomStmtMsgPurposeList";
import { StatementDelinquencyDateStmtMsgCode } from "./statementDelinquencyDateStmtMsgCode";
import { StatementDelqAmtDueHistoryOption } from "./statementDelqAmtDueHistoryOption";
import { StatementDqContactInformation } from "./statementDqContactInformation";
import { StatementEndingPromoBal } from "./statementEndingPromoBal";
import { StatementGeneralStatementMessageCode } from "./statementGeneralStatementMessageCode";
import { StatementInstitutionAddressLine } from "./statementInstitutionAddressLine";
import { StatementLnLine } from "./statementLnLine";
import { StatementLoanTypes } from "./statementLoanTypes";
import { StatementLtChgStatementMsgCode } from "./statementLtChgStatementMsgCode";
import { StatementPmtCutoffTimeStmtMsgCode } from "./statementPmtCutoffTimeStmtMsgCode";
import { StatementPromoBalance } from "./statementPromoBalance";
import { StatementPromoDescription } from "./statementPromoDescription";
import { StatementPromoTermination } from "./statementPromoTermination";
import { StatementPurposeList } from "./statementPurposeList";
import { StatementRelMsgLine11 } from "./statementRelMsgLine11";
import { StatementRelMsgLine110 } from "./statementRelMsgLine110";
import { StatementRelMsgLine12 } from "./statementRelMsgLine12";
import { StatementRelMsgLine13 } from "./statementRelMsgLine13";
import { StatementRelMsgLine14 } from "./statementRelMsgLine14";
import { StatementRelMsgLine15 } from "./statementRelMsgLine15";
import { StatementRelMsgLine16 } from "./statementRelMsgLine16";
import { StatementRelMsgLine17 } from "./statementRelMsgLine17";
import { StatementRelMsgLine18 } from "./statementRelMsgLine18";
import { StatementRelMsgLine19 } from "./statementRelMsgLine19";
import { StatementRelMsgLine21 } from "./statementRelMsgLine21";
import { StatementRelMsgLine210 } from "./statementRelMsgLine210";
import { StatementRelMsgLine22 } from "./statementRelMsgLine22";
import { StatementRelMsgLine23 } from "./statementRelMsgLine23";
import { StatementRelMsgLine24 } from "./statementRelMsgLine24";
import { StatementRelMsgLine25 } from "./statementRelMsgLine25";
import { StatementRelMsgLine26 } from "./statementRelMsgLine26";
import { StatementRelMsgLine27 } from "./statementRelMsgLine27";
import { StatementRelMsgLine28 } from "./statementRelMsgLine28";
import { StatementRelMsgLine29 } from "./statementRelMsgLine29";
import { StatementRelationshipCodes } from "./statementRelationshipCodes";
import { StatementServicerAddress } from "./statementServicerAddress";
import { StatementSvLine } from "./statementSvLine";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface Statement {
    accountTrackingTypes: string;
    ach: string;
    achTransactions: string;
    additionalPrincipal: string;
    amtDueExpDateStmtMsgCode: StatementAmtDueExpDateStmtMsgCode[];
    amtDueExpDateStmtMsgCodeSpecified: boolean;
    atm: string;
    atmSummaryLoanTypes: string;
    atmSummaryShareTypes: string;
    audioResponse: string;
    availBalTransfer: string;
    availCashAdvance: string;
    availCombinedCaBt: string;
    balTransferLimit: string;
    beginPromoBal: StatementBeginPromoBal[];
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
    collateralList: StatementCollateralList[];
    collateralListSpecified: boolean;
    combinedCaBtLimit: string;
    complaintCorrStmtMsgCode: StatementComplaintCorrStmtMsgCode[];
    complaintCorrStmtMsgCodeSpecified: boolean;
    contactInformation: StatementContactInformation[];
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
    customStmtMsgCollList: StatementCustomStmtMsgCollList[];
    customStmtMsgCollListSpecified: boolean;
    customStmtMsgLoanTypes: StatementCustomStmtMsgLoanTypes[];
    customStmtMsgLoanTypesSpecified: boolean;
    customStmtMsgOptionCountValue: number;
    customStmtMsgOptionCountValueSpecified: boolean;
    customStmtMsgOptionCount: number | null;
    customStmtMsgPurposeList: StatementCustomStmtMsgPurposeList[];
    customStmtMsgPurposeListSpecified: boolean;
    debitCard: string;
    delinquencyDateStmtMsgCode: StatementDelinquencyDateStmtMsgCode[];
    delinquencyDateStmtMsgCodeSpecified: boolean;
    delqAmtDueHistoryOption: StatementDelqAmtDueHistoryOption[];
    delqAmtDueHistoryOptionSpecified: boolean;
    deposit: string;
    dividend: string;
    dividendPrintingValue: number;
    dividendPrintingValueSpecified: boolean;
    dividendPrinting: number | null;
    dividendYtd: string;
    dqContactInformation: StatementDqContactInformation[];
    dqContactInformationSpecified: boolean;
    draft: string;
    draftSummaryLoanTypes: string;
    draftSummaryShareTypes: string;
    earlyWdPenalty: string;
    endingBalance: string;
    endingPromoBal: StatementEndingPromoBal[];
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
    generalStatementMessageCode: StatementGeneralStatementMessageCode[];
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
    institutionAddressLine: StatementInstitutionAddressLine[];
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
    lnLine: StatementLnLine[];
    lnLineSpecified: boolean;
    loanAddon: string;
    loanTrackingTypes: string;
    loanTypes: StatementLoanTypes[];
    loanTypesSpecified: boolean;
    locAvailAbleDqDaysValue: number;
    locAvailAbleDqDaysValueSpecified: boolean;
    locAvailAbleDqDays: number | null;
    lostStolenCardPhone: string;
    ltChgStatementMsgCode: StatementLtChgStatementMsgCode[];
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
    pmtCutoffTimeStmtMsgCode: StatementPmtCutoffTimeStmtMsgCode[];
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
    promoBalance: StatementPromoBalance[];
    promoBalanceSpecified: boolean;
    promoDescription: StatementPromoDescription[];
    promoDescriptionSpecified: boolean;
    promoTermination: StatementPromoTermination[];
    promoTerminationSpecified: boolean;
    purposeList: StatementPurposeList[];
    purposeListSpecified: boolean;
    recurring: string;
    refinance: string;
    regZYtdTotalsPrintOptionValue: number;
    regZYtdTotalsPrintOptionValueSpecified: boolean;
    regZYtdTotalsPrintOption: number | null;
    regularBalance: string;
    relMsgLine11: StatementRelMsgLine11[];
    relMsgLine11Specified: boolean;
    relMsgLine110: StatementRelMsgLine110[];
    relMsgLine110Specified: boolean;
    relMsgLine12: StatementRelMsgLine12[];
    relMsgLine12Specified: boolean;
    relMsgLine13: StatementRelMsgLine13[];
    relMsgLine13Specified: boolean;
    relMsgLine14: StatementRelMsgLine14[];
    relMsgLine14Specified: boolean;
    relMsgLine15: StatementRelMsgLine15[];
    relMsgLine15Specified: boolean;
    relMsgLine16: StatementRelMsgLine16[];
    relMsgLine16Specified: boolean;
    relMsgLine17: StatementRelMsgLine17[];
    relMsgLine17Specified: boolean;
    relMsgLine18: StatementRelMsgLine18[];
    relMsgLine18Specified: boolean;
    relMsgLine19: StatementRelMsgLine19[];
    relMsgLine19Specified: boolean;
    relMsgLine21: StatementRelMsgLine21[];
    relMsgLine21Specified: boolean;
    relMsgLine210: StatementRelMsgLine210[];
    relMsgLine210Specified: boolean;
    relMsgLine22: StatementRelMsgLine22[];
    relMsgLine22Specified: boolean;
    relMsgLine23: StatementRelMsgLine23[];
    relMsgLine23Specified: boolean;
    relMsgLine24: StatementRelMsgLine24[];
    relMsgLine24Specified: boolean;
    relMsgLine25: StatementRelMsgLine25[];
    relMsgLine25Specified: boolean;
    relMsgLine26: StatementRelMsgLine26[];
    relMsgLine26Specified: boolean;
    relMsgLine27: StatementRelMsgLine27[];
    relMsgLine27Specified: boolean;
    relMsgLine28: StatementRelMsgLine28[];
    relMsgLine28Specified: boolean;
    relMsgLine29: StatementRelMsgLine29[];
    relMsgLine29Specified: boolean;
    relationshipCodes: StatementRelationshipCodes[];
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
    servicerAddress: StatementServicerAddress[];
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
    statementCutoffDateValue: string;
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
    svLine: StatementSvLine[];
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