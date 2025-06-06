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

export interface Statement_2 {
    accountTrackingTypes: string;
    ach: string;
    achTransactions: string;
    additionalPrincipal: string;
    amtDueExpDateStmtMsgCode: StatementAmtDueExpDateStmtMsgCode_2[];
    atm: string;
    atmSummaryLoanTypes: string;
    atmSummaryShareTypes: string;
    audioResponse: string;
    availBalTransfer: string;
    availCashAdvance: string;
    availCombinedCaBt: string;
    balTransferLimit: string;
    beginPromoBal: StatementBeginPromoBal_2[];
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
    checkHoldCommentPrtOption: number | null;
    checkHoldPrintOption: number | null;
    collateralList: StatementCollateralList_2[];
    combinedCaBtLimit: string;
    complaintCorrStmtMsgCode: StatementComplaintCorrStmtMsgCode_2[];
    contactInformation: StatementContactInformation_2[];
    creditAvailable: string;
    creditCarSepForIds: number | null;
    creditCard: string;
    creditCardCouponSummary: boolean | null;
    creditCardDigitLength: number | null;
    creditCardDigitStart: number | null;
    creditCardInactiveZeroBal: number | null;
    creditCardMinPmtDisclOpt: number | null;
    creditCardPayment: number | null;
    creditCardPrinting: number | null;
    creditCardPromotionsTable: boolean | null;
    creditCardSepforSummaries: number | null;
    creditCounselingPhone: string;
    creditLimit: string;
    customStmtMsgCollList: StatementCustomStmtMsgCollList_2[];
    customStmtMsgLoanTypes: StatementCustomStmtMsgLoanTypes_2[];
    customStmtMsgOptionCount: number | null;
    customStmtMsgPurposeList: StatementCustomStmtMsgPurposeList_2[];
    debitCard: string;
    delinquencyDateStmtMsgCode: StatementDelinquencyDateStmtMsgCode_2[];
    delqAmtDueHistoryOption: StatementDelqAmtDueHistoryOption_2[];
    deposit: string;
    dividend: string;
    dividendPrinting: number | null;
    dividendYtd: string;
    dqContactInformation: StatementDqContactInformation_2[];
    draft: string;
    draftSummaryLoanTypes: string;
    draftSummaryShareTypes: string;
    earlyWdPenalty: string;
    endingBalance: string;
    endingPromoBal: StatementEndingPromoBal_2[];
    endingRegularBal: string;
    escrow: string;
    escrowAmount: string;
    escrowUnpaid: string;
    externalLoanTrackingTypes: string;
    fasterPayments: string;
    fee: string;
    feesChargedYtd: string;
    format: number | null;
    generalStatementMessageCode: StatementGeneralStatementMessageCode_2[];
    homeBanking: string;
    homeEquityCollateralCodes: string;
    householdOption: number | null;
    inclLateChgUnpaidChgAmt: boolean | null;
    inclWaivedLateChargeAmt: boolean | null;
    inclWireOriginatorComment: boolean | null;
    include000FeeComments: boolean | null;
    includeAchCheckComments: boolean | null;
    includeAchEccComments: boolean | null;
    includeAchTraceComments: boolean | null;
    includeAddlPrincipalComment: boolean | null;
    includeBalanceSummary: boolean | null;
    includeBulkDepositComments: boolean | null;
    includeCdMoTcComments: boolean | null;
    includeCheckCashingComment: boolean | null;
    includeCkDisbursedComments: boolean | null;
    includeCkReceivedComments: boolean | null;
    includeDivAccrualInfofor: number | null;
    includeDividendAccrualInfo: boolean | null;
    includeFrFdComments: boolean | null;
    includeIntAccrualInfofor: number | null;
    includeInterestAccrualInfo: boolean | null;
    includeMccComments: boolean | null;
    includeMembersRemarks: boolean | null;
    includePreviousYearsTotals: boolean | null;
    inquiryLine: string;
    institutionAddressLine: StatementInstitutionAddressLine_2[];
    insurance: string;
    interestChargedYtd: string;
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
    loanAddon: string;
    loanTrackingTypes: string;
    loanTypes: StatementLoanTypes_2[];
    locAvailAbleDqDays: number | null;
    lostStolenCardPhone: string;
    ltChgStatementMsgCode: StatementLtChgStatementMsgCode_2[];
    mailCodeCforClosedAccts: boolean | null;
    makeCheckPayableto: string;
    maskBeneficiarySsn: number | null;
    memberRemarks: string;
    merchantCategoryCode: string;
    minBalforMinPmtDiscl: number | null;
    minimumInterestDue: number | null;
    mortgageStatementOptionCoun: number | null;
    negativeSignOption: number | null;
    newLoan: string;
    newSharefee: string;
    nonCertificateMaturityDate: boolean | null;
    nontaxDividendYtd: string;
    numberofpagesthisBatch: number | null;
    numberoftimesGenerated: number | null;
    originalBalance: string;
    overdraftItemFeeDesc: string;
    overdrawn: string;
    payment: string;
    paymentPrintOption: number | null;
    paymentSlipPrintingOption: number | null;
    payroll: string;
    penaltyYtd: string;
    pintAprInfo: boolean | null;
    pmtCutoffTimeStmtMsgCode: StatementPmtCutoffTimeStmtMsgCode_2[];
    pos: string;
    postponedLateChg: string;
    principalPaymentDesc: string;
    printAccountReference: boolean | null;
    printAcctRelationshipCode: boolean | null;
    printAddlInstrStmtDiscl: boolean | null;
    printAddrStmtDisclosure: boolean | null;
    printCreditCardLoanId: boolean | null;
    printDraftTracerNumbers: boolean | null;
    printIraContributionTotals: boolean | null;
    printNameTypes: string;
    printOdpFeeAmountTotals: number | null;
    printOtherAccountInfo: boolean | null;
    printPhoneStmtDisclosure: boolean | null;
    printSocialSecurityNumber: boolean | null;
    printStmtDisclosure: number | null;
    printStmtEscrowUnpaidBal: boolean | null;
    printStmtLateChgUnpaidBal: boolean | null;
    printStmtUnappliedPmtBal: boolean | null;
    printTransferAcctNumbers: boolean | null;
    printWebsiteStmtDisclosure: boolean | null;
    printnextDividend: boolean | null;
    promoBalance: StatementPromoBalance_2[];
    promoDescription: StatementPromoDescription_2[];
    promoTermination: StatementPromoTermination_2[];
    purposeList: StatementPurposeList_2[];
    recurring: string;
    refinance: string;
    regZYtdTotalsPrintOption: number | null;
    regularBalance: string;
    relMsgLine11: StatementRelMsgLine11_2[];
    relMsgLine110: StatementRelMsgLine110_2[];
    relMsgLine12: StatementRelMsgLine12_2[];
    relMsgLine13: StatementRelMsgLine13_2[];
    relMsgLine14: StatementRelMsgLine14_2[];
    relMsgLine15: StatementRelMsgLine15_2[];
    relMsgLine16: StatementRelMsgLine16_2[];
    relMsgLine17: StatementRelMsgLine17_2[];
    relMsgLine18: StatementRelMsgLine18_2[];
    relMsgLine19: StatementRelMsgLine19_2[];
    relMsgLine21: StatementRelMsgLine21_2[];
    relMsgLine210: StatementRelMsgLine210_2[];
    relMsgLine22: StatementRelMsgLine22_2[];
    relMsgLine23: StatementRelMsgLine23_2[];
    relMsgLine24: StatementRelMsgLine24_2[];
    relMsgLine25: StatementRelMsgLine25_2[];
    relMsgLine26: StatementRelMsgLine26_2[];
    relMsgLine27: StatementRelMsgLine27_2[];
    relMsgLine28: StatementRelMsgLine28_2[];
    relMsgLine29: StatementRelMsgLine29_2[];
    relationshipCodes: StatementRelationshipCodes_2[];
    salesTaxAmount: string;
    separatePrintoutOption: number | null;
    separatorForIds: number | null;
    separatorforBalanceSummary: number | null;
    separatorforSummaries: number | null;
    servicerAddress: StatementServicerAddress_2[];
    shareTrackingTypes: string;
    sharedBranch: string;
    sortOrder: number | null;
    specifyBranchStmtDisclosure: number | null;
    specifyOvlStmtDisclosureFe: number | null;
    stateWithholdYtd: string;
    stateWithholding: string;
    statementBatchNumber: number | null;
    statementCutoffDate: string | null;
    statementGroupList: string;
    statementSortCount: number | null;
    statementSortRecord: number | null;
    stmtDisclosureAddrSource: number | null;
    stopPayPrintOption: number | null;
    subformat: number | null;
    suppressAcctNumberZeros: boolean | null;
    svLine: StatementSvLine_2[];
    totIntPdFromOpenLease: string;
    totalAggregatePaid: string;
    totalInterestPaid: string;
    totalLoanBkBalance: number | null;
    totalLoanBalance: number | null;
    totalLoanCount: number | null;
    totalLoanInterestYtd: number | null;
    totalOtherAcctCount: number | null;
    totalShareBalance: number | null;
    totalShareCount: number | null;
    totalShareDividendYtd: number | null;
    totalSharePenaltyYtd: number | null;
    totalShareStateWithholdYtd: number | null;
    totalShareWithholdYtd: number | null;
    totalStatementCount: number | null;
    transactionPrintOrder: number | null;
    unappliedPartialPayment: string;
    unappliedPartialPmtChg: string;
    unpaidItemFeeDesc: string;
    useAlternateAddress: boolean | null;
    useLoanOvlStmtDisclosureF: boolean | null;
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
    ytdTotalPrinting: number | null;
    version1: VersionType;
}