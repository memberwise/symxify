import { LoanAlternateAddress_2 } from "./loanAlternateAddress_2";
import { LoanAlternatePhone_2 } from "./loanAlternatePhone_2";
import { LoanBalXfrAvgBalance_2 } from "./loanBalXfrAvgBalance_2";
import { LoanBalXfrNewBalance_2 } from "./loanBalXfrNewBalance_2";
import { LoanBalXfrOldBalance_2 } from "./loanBalXfrOldBalance_2";
import { LoanBilledFeeBucketAmount_2 } from "./loanBilledFeeBucketAmount_2";
import { LoanBtAddOnSinceLastStmt_2 } from "./loanBtAddOnSinceLastStmt_2";
import { LoanBtPmtSinceLastStmt_2 } from "./loanBtPmtSinceLastStmt_2";
import { LoanBureauScore_2 } from "./loanBureauScore_2";
import { LoanCaAddOnSinceLastStmt_2 } from "./loanCaAddOnSinceLastStmt_2";
import { LoanCaPmtSinceLastStmt_2 } from "./loanCaPmtSinceLastStmt_2";
import { LoanCashAdvAvgBalance_2 } from "./loanCashAdvAvgBalance_2";
import { LoanCashAdvNewBalance_2 } from "./loanCashAdvNewBalance_2";
import { LoanCashAdvOldBalance_2 } from "./loanCashAdvOldBalance_2";
import { LoanCcPromoEffectDate_2 } from "./loanCcPromoEffectDate_2";
import { LoanCrPmtHistory_2 } from "./loanCrPmtHistory_2";
import { LoanEscrowBucketAmount_2 } from "./loanEscrowBucketAmount_2";
import { LoanFeeCount_2 } from "./loanFeeCount_2";
import { LoanOvlCycleCount_2 } from "./loanOvlCycleCount_2";
import { LoanPayeeLine_2 } from "./loanPayeeLine_2";
import { LoanPayeePhone_2 } from "./loanPayeePhone_2";
import { LoanPaymentHistory_2 } from "./loanPaymentHistory_2";
import { LoanPmtBucketAmount_2 } from "./loanPmtBucketAmount_2";
import { LoanPmtBucketDueDate_2 } from "./loanPmtBucketDueDate_2";
import { LoanPreMthIntAccrued_2 } from "./loanPreMthIntAccrued_2";
import { LoanPreMthIntAccumLtd_2 } from "./loanPreMthIntAccumLtd_2";
import { LoanPreMthIntPaid_2 } from "./loanPreMthIntPaid_2";
import { LoanPromoAdvanceCutoff_2 } from "./loanPromoAdvanceCutoff_2";
import { LoanPromoBalance_2 } from "./loanPromoBalance_2";
import { LoanPromoEffectDate_2 } from "./loanPromoEffectDate_2";
import { LoanPromoExpireDate_2 } from "./loanPromoExpireDate_2";
import { LoanPromoRate_2 } from "./loanPromoRate_2";
import { LoanPromoRateMax_2 } from "./loanPromoRateMax_2";
import { LoanPromoRateMin_2 } from "./loanPromoRateMin_2";
import { LoanPromoRateOffset_2 } from "./loanPromoRateOffset_2";
import { LoanPromoRateType_2 } from "./loanPromoRateType_2";
import { LoanPromoTotalAdvances_2 } from "./loanPromoTotalAdvances_2";
import { LoanPromoType_2 } from "./loanPromoType_2";
import { LoanPuAddOnSinceLastStmt_2 } from "./loanPuAddOnSinceLastStmt_2";
import { LoanPuPmtSinceLastStmt_2 } from "./loanPuPmtSinceLastStmt_2";
import { LoanPurchAvgBalance_2 } from "./loanPurchAvgBalance_2";
import { LoanPurchNewBalance_2 } from "./loanPurchNewBalance_2";
import { LoanPurchOldBalance_2 } from "./loanPurchOldBalance_2";
import { LoanSeg0PmtBucketAmt_2 } from "./loanSeg0PmtBucketAmt_2";
import { LoanService_2 } from "./loanService_2";
import { LoanWarningCode_2 } from "./loanWarningCode_2";
import { LoanWarningExpiration_2 } from "./loanWarningExpiration_2";
import { VersionType } from "./versionType";
export interface Loan_2 {
    accelerationAmt: number | null;
    accelerationGoodThruDate: string | null;
    accelerationStmtMsgCode: number | null;
    accrReinstatementDate: string | null;
    accrualStatus: number | null;
    acquisitionBalance: number | null;
    acquisitionDate: string | null;
    activityDate: string | null;
    advanceAmount: number | null;
    agencyAcctNumber: string;
    agencyIdentifier: number | null;
    allowUnappliedPmt: number | null;
    altPmtEffective: string | null;
    altPmtExpiration: string | null;
    alternateAddress: LoanAlternateAddress_2[];
    alternateNameLocator: number | null;
    alternateNameType: number | null;
    alternatePayment: number | null;
    alternatePhone: LoanAlternatePhone_2[];
    amortizationSchd: number | null;
    amortizationSchdType: number | null;
    amortizationTerm: number | null;
    applicationId: string;
    applyAsBilled: number | null;
    approvalCode: number | null;
    approvalDate: string | null;
    apr: number | null;
    armNotice: number | null;
    assessorParcelNumber: string;
    availCreditCalc: number | null;
    availableBalanceTransfer: number | null;
    availableCashAdvance: number | null;
    availableCombinedCabt: number | null;
    availableCredit: number | null;
    avgWeightedIntRate: number | null;
    balXfrAvgBalance: LoanBalXfrAvgBalance_2[];
    balXfrNewBalance: LoanBalXfrNewBalance_2[];
    balXfrOldBalance: LoanBalXfrOldBalance_2[];
    balance: number | null;
    balanceTransferLimit: number | null;
    balloonAmount: number | null;
    balloonDate: string | null;
    bcdDay1: number | null;
    bcdDay2: number | null;
    beginningCycleDate: string | null;
    beginningYearBalance: number | null;
    billedFeeBucketAmount: LoanBilledFeeBucketAmount_2[];
    billedFeeLastYear: number | null;
    billedFeeLstYrNoAdj: number | null;
    billedFeeUnpaid: number | null;
    billedFeeYtd: number | null;
    billedFeeYtdNoAdj: number | null;
    billingDefaultDays: number | null;
    billingMethod: number | null;
    billingNotice: number | null;
    billingNoticeMin: number | null;
    bkChapterReported: number | null;
    branch: number | null;
    btAddOnSinceLastStmt: LoanBtAddOnSinceLastStmt_2[];
    btIntCharge: number | null;
    btLimitMax: number | null;
    btNewIntUnpaid: number | null;
    btOldIntUnpaid: number | null;
    btPercent: number | null;
    btPmtSinceLastStmt: LoanBtPmtSinceLastStmt_2[];
    btTransIntCharge: number | null;
    bureauScore: LoanBureauScore_2[];
    caAddOnSinceLastStmt: LoanCaAddOnSinceLastStmt_2[];
    caBtTransIntChargeBilledYtd: number | null;
    caIntCharge: number | null;
    caLimitMax: number | null;
    caNewIntUnpaid: number | null;
    caOldIntUnpaid: number | null;
    caPercent: number | null;
    caPmtSinceLastStmt: LoanCaPmtSinceLastStmt_2[];
    caTransIntCharge: number | null;
    callItemSchd: number | null;
    callItemSchdType: number | null;
    cancelable: number | null;
    cappedFeesAmountCap: number | null;
    cappedFeesAmtPeriod: number | null;
    cappedFeesCntPeriod: number | null;
    cappedFeesCountCap: number | null;
    cardActDeclChkAxsFeeEventDate: string | null;
    cardActLateFeeEventDate: string | null;
    cardActOverLimitFeeEventDate: string | null;
    cardActReturnItemFeeEventDate: string | null;
    cashAdvAvgBalance: LoanCashAdvAvgBalance_2[];
    cashAdvNewBalance: LoanCashAdvNewBalance_2[];
    cashAdvOldBalance: LoanCashAdvOldBalance_2[];
    cashAdvanceLimit: number | null;
    ccIntBilledLastYear: number | null;
    ccIntBilledYtd: number | null;
    ccPromoEffectDate: LoanCcPromoEffectDate_2[];
    chargeOffAmount: number | null;
    chargeOffDate: string | null;
    chargeOffType: number | null;
    checkDigits: string;
    citySalesTaxRate: number | null;
    closeDate: string | null;
    cntySalesTaxRate: number | null;
    collateralCode: number | null;
    collateralDate: string | null;
    combinedCaBtLimit: number | null;
    combinedCaBtLimitMax: number | null;
    combinedCaBtPercent: number | null;
    comboLnSegmentMax: number | null;
    comboPmtOrderMeth: number | null;
    comboSeg0PmtOrder: number | null;
    corporateUserTransferCode: number | null;
    couponCode: number | null;
    crHighBal: number | null;
    crIntTypeInd: string;
    crPmtCurrent: string;
    crPmtHistory: LoanCrPmtHistory_2[];
    createdAtBranch: number | null;
    createdByUser: number | null;
    credLimitExpiration: string | null;
    creditLimit: number | null;
    creditLimitGroup: number | null;
    creditReportComment: string;
    creditReportCompliance: string;
    creditReportConsumerInfo: string;
    creditReportConsumerInfoDate: string | null;
    creditReportLastStatus: number | null;
    creditReportNumber: string;
    creditReportOccurDate: string | null;
    creditReportTransferDate: string | null;
    creditReportTransferIndicator: number | null;
    creditReportTransferName: string;
    creditReportingCode: number | null;
    creditRptDeferredPmtStart: string | null;
    creditScore: number | null;
    creditScoreType: number | null;
    cuTotalsUseCode: number | null;
    currIntPayable: number | null;
    currMonthPaidInt: number | null;
    currStmtFees: number | null;
    currStmtIntAccrd: number | null;
    currStmtLossMitAmtDue: number | null;
    dealerCity: string;
    dealerCode: string;
    dealerCounty: string;
    dealerReserve: number | null;
    dealerState: string;
    description: string;
    discountRate: number | null;
    dqCalculationMethod: number | null;
    dqCardDate: string | null;
    dqNoticeDate: string | null;
    dqNoticeNumber: number | null;
    dqNoticeType: number | null;
    dueDate: string | null;
    dueDateAdvanceCode: number | null;
    dueDay1: number | null;
    dueDay2: number | null;
    earlyIntervntnNoticeDate: string | null;
    ecoaCode: number | null;
    effectiveApr: number | null;
    effectiveBalance: number | null;
    escrowAmount: number | null;
    escrowApplied: number | null;
    escrowBucketAmount: LoanEscrowBucketAmount_2[];
    escrowId: string;
    escrowUnpaid: number | null;
    exceedLevelPmtAmt: number | null;
    fasb91AlternateTerm: number | null;
    fasb91Code: number | null;
    feeAddOnSinceLastStmt: number | null;
    feeBillingAmount: number | null;
    feeBillingDate: string | null;
    feeCount: LoanFeeCount_2[];
    feeNewBalance: number | null;
    feeOldBalance: number | null;
    feePmtSinceLastStmt: number | null;
    feesChargesPostingOption: number | null;
    feesLastYear: number | null;
    feesLastYrNoAdj: number | null;
    feesYtd: number | null;
    feesYtdNoAdj: number | null;
    finalChgOffStmtDate: string | null;
    finalChgOffStmtMsgCode: number | null;
    firstInsBirthDate: string | null;
    firstPaymentDate: string | null;
    fixedDealerCityTaxRate: number | null;
    fixedDealerCountyTaxRate: number | null;
    fixedDealerStateTaxRate: number | null;
    fixedLesseeCityTaxRate: number | null;
    fixedLesseeCountyTaxRate: number | null;
    fixedLesseeStateTaxRate: number | null;
    foreclosureEffectDate: string | null;
    foreclosureExpireDate: string | null;
    foreclosureStmtMsgCode: number | null;
    glAccrualStatusOption: number | null;
    highRiskCode: number | null;
    hmdaUniversalLoanIdentifier1: string;
    hmdaUniversalLoanIdentifier2: string;
    id: string;
    indirectDealerNum: string;
    indirectPlanId: string;
    initArmNoticeCreationDate: string | null;
    initialArmNotice: number | null;
    initialBcdSettingOption: number | null;
    insuranceBalance: number | null;
    insuranceLastYear: number | null;
    insuranceLstYrNoAdj: number | null;
    insuranceMax: number | null;
    insuranceType: number | null;
    insuranceYtd: number | null;
    insuranceYtdNoAdj: number | null;
    intPaidPartialDayAmt: number | null;
    intPaidToDate: string | null;
    intPayoffCalc: number | null;
    intUnpaidBilled: number | null;
    interestDate: string | null;
    interestDue: number | null;
    interestFromOpen: number | null;
    interestLastYear: number | null;
    interestRate: number | null;
    interestRateIndex: number | null;
    interestRateMargin: number | null;
    interestRateMarginSign: number | null;
    interestRateMax: number | null;
    interestRateMin: number | null;
    interestType: number | null;
    interestUnpaid: number | null;
    interestYtd: number | null;
    lastAccrReversalDate: string | null;
    lastAccrUpdateDate: string | null;
    lastAccrualReversal: number | null;
    lastAdvanceDate: string | null;
    lastArmNoticeCreationDate: string | null;
    lastCrReportDate: string | null;
    lastFmDate: string | null;
    lastPaymentDate: string | null;
    lastPurgeDate: string | null;
    lastTranDate: string | null;
    lateChargeAccrued: number | null;
    lateChargeDate: string | null;
    lateChargeDue: number | null;
    lateChargeLastYear: number | null;
    lateChargeType: number | null;
    lateChargeUnpaid: number | null;
    lateChargeYtd: number | null;
    lateChgLastYrNoAdj: number | null;
    lateChgPdFromOpen: number | null;
    lateChgWaivedFromOpen: number | null;
    lateChgWaivedLastYear: number | null;
    lateChgWaivedYtd: number | null;
    lateChgYtdNoAdj: number | null;
    leaseDispositionDate: string | null;
    leaseDispositionFee: number | null;
    leaseTerminateDate: string | null;
    leaseTerminateFee: number | null;
    ledgerAccrual: number | null;
    ledgerAccrualDate: string | null;
    lesseeCity: string;
    lesseeCounty: string;
    lesseeState: string;
    levelPaymentAmt: number | null;
    levelPrincipalAmt: number | null;
    loanCode: number | null;
    lossMitEffectDate: string | null;
    lossMitExpireDate: string | null;
    lossMitPayment: number | null;
    lossMitPmtStmtMsgCode: number | null;
    lossMitStmtMsgCode: number | null;
    lrlnBalance: number | null;
    lrlnDate: string | null;
    maprCurrStmtIntAccrd: number | null;
    maturityDate: string | null;
    maxDueDateAdvancePeriod: number | null;
    maxLoanDueDate: string | null;
    memberUserTransferCode: number | null;
    mfoelId: number | null;
    micrAcctNumber: string;
    militaryAprLoan: number | null;
    minAdvance: number | null;
    minBalance: number | null;
    minimumPayment: number | null;
    mortgInsCollLastYr: number | null;
    mortgInsCollYtd: number | null;
    mortgageIdNumber: string;
    mtdAccruedInt: number | null;
    mtdAccumulatedInt: number | null;
    mtdPaidInt: number | null;
    mtdPriorRateAccrual: number | null;
    mtgNumProp: number | null;
    newLoanDueDateCode: number | null;
    newSegCutoffDays: number | null;
    newSegCutoffOption: number | null;
    nextRateChangeDate: string | null;
    nextStmtDate: string | null;
    nickname: string;
    noteNumber: string;
    nsfLastYear: number | null;
    nsfMonthToDate: number | null;
    nsfYtd: number | null;
    occupancyType: number | null;
    openDate: string | null;
    origInsuranceType: number | null;
    origRiskGrade: string;
    origUnamortizedFees: number | null;
    originalBalance: number | null;
    originalDate: string | null;
    originalRate: number | null;
    originationBalance: number | null;
    ovlAuthFee: number | null;
    ovlAuthFeeEffDate: string | null;
    ovlCycleCount: LoanOvlCycleCount_2[];
    ovlOptIn: number | null;
    ovlPrevAuthFee: number | null;
    ovlStmtDisclFee: number | null;
    partialPayment: number | null;
    participationNumber: string;
    pastDueAmount: number | null;
    payeeLine: LoanPayeeLine_2[];
    payeeNameLocator: number | null;
    payeeNameType: number | null;
    payeePhone: LoanPayeePhone_2[];
    payment: number | null;
    paymentApplicationMethod: number | null;
    paymentCalcType: number | null;
    paymentCount: number | null;
    paymentDue: number | null;
    paymentFrequency: number | null;
    paymentHistory: LoanPaymentHistory_2[];
    paymentMethod: number | null;
    paymentSkipStartDay: number | null;
    paymentSkips: number | null;
    paymentType: number | null;
    payoffAmount: number | null;
    percentPrincipal: number | null;
    periodicCap: number | null;
    periodicFrequency: number | null;
    periodicStartDate: string | null;
    periodicStartRate: number | null;
    pmiLastYear: number | null;
    pmiLtvRatio: number | null;
    pmiPurchasePrice: number | null;
    pmiYtd: number | null;
    pmtBucketAmount: LoanPmtBucketAmount_2[];
    pmtBucketDueDate: LoanPmtBucketDueDate_2[];
    pointsLastYear: number | null;
    pointsYtd: number | null;
    positivePayDraft: number | null;
    preMthIntAccrued: LoanPreMthIntAccrued_2[];
    preMthIntAccumLtd: LoanPreMthIntAccumLtd_2[];
    preMthIntPaid: LoanPreMthIntPaid_2[];
    prepaidFinanceChg: number | null;
    prepaymentPenalty: number | null;
    prepaymentPenaltyExpDate: string | null;
    prevBeginningYearBalance: number | null;
    prevStmtFees: number | null;
    prevStmtIntAccrd: number | null;
    prevStmtLossMitAmtDue: number | null;
    prinPaidFromOpen: number | null;
    principalLastYear: number | null;
    principalYtd: number | null;
    promoAdvanceCutoff: LoanPromoAdvanceCutoff_2[];
    promoBalance: LoanPromoBalance_2[];
    promoEffectDate: LoanPromoEffectDate_2[];
    promoExpireDate: LoanPromoExpireDate_2[];
    promoRate: LoanPromoRate_2[];
    promoRateMax: LoanPromoRateMax_2[];
    promoRateMin: LoanPromoRateMin_2[];
    promoRateOffset: LoanPromoRateOffset_2[];
    promoRateType: LoanPromoRateType_2[];
    promoTotalAdvances: LoanPromoTotalAdvances_2[];
    promoType: LoanPromoType_2[];
    propertyAddressType: number | null;
    propertyJurisdiction: string;
    puAddOnSinceLastStmt: LoanPuAddOnSinceLastStmt_2[];
    puIntCharge: number | null;
    puNewIntUnpaid: number | null;
    puOldIntUnpaid: number | null;
    puPmtSinceLastStmt: LoanPuPmtSinceLastStmt_2[];
    purchAvgBalance: LoanPurchAvgBalance_2[];
    purchNewBalance: LoanPurchNewBalance_2[];
    purchOldBalance: LoanPurchOldBalance_2[];
    purposeCode: number | null;
    putItemSchd: number | null;
    putItemSchdType: number | null;
    rateChangeCycleMonths: number | null;
    rateRoundingMethod: number | null;
    recordChangeDate: string | null;
    reference: string;
    refinanceBalance: number | null;
    refinanceCounter: number | null;
    refinanceDate: string | null;
    refundLastYear: number | null;
    refundPostCode: number | null;
    refundYtd: number | null;
    regECount: number | null;
    regPaymentsTmtMsgCode: number | null;
    reinstatementAmt: number | null;
    reinstatementGoodThruDate: string | null;
    reinstatementStmtMsgCode: number | null;
    riskRate: number | null;
    roundRateTo: number | null;
    salesTaxCityIndicator: number | null;
    salesTaxCountyIndicator: number | null;
    salesTaxDue: number | null;
    salesTaxPayoff: number | null;
    salesTaxRate: number | null;
    salesTaxStateIndicator: number | null;
    sbaGpNumber: string;
    schdPeriodStartDate: string | null;
    schdPeriodStartRate: number | null;
    schdRate: number | null;
    schdRateChangeDate: string | null;
    schdSplitBalance: number | null;
    schdSplitRate: number | null;
    secondInsBirthDate: string | null;
    securedAmount: number | null;
    securedCode: number | null;
    seg0Balance: number | null;
    seg0BeginningCycleDate: string | null;
    seg0CurrStmtIntAccrd: number | null;
    seg0Description: string;
    seg0IntUnpaid: number | null;
    seg0IntUnpaidBilled: number | null;
    seg0InterestLastYear: number | null;
    seg0InterestYtd: number | null;
    seg0LevelPrinPmt: number | null;
    seg0PartialPmt: number | null;
    seg0Payment: number | null;
    seg0PaymentDue: number | null;
    seg0PaymentOrder: number | null;
    seg0PayoffAmt: number | null;
    seg0PmtBucketAmt: LoanSeg0PmtBucketAmt_2[];
    seg0PrevStmtIntAccrd: number | null;
    sendFinalChgOffStmt: number | null;
    service: LoanService_2[];
    singlePremiumDisability: number | null;
    singlePremiumLife: number | null;
    splitRate: number | null;
    splitRateBalance: number | null;
    stateSalesTaxRate: number | null;
    statementDate: string | null;
    statementGroup: number | null;
    statementMailCode: number | null;
    statementNewBalance: number | null;
    statementOldBalance: number | null;
    statementPrevDate: string | null;
    stmtCcIntBilledYtd: number | null;
    stmtEscrowUnpaid: number | null;
    stmtFeesLastYear: number | null;
    stmtFeesYtd: number | null;
    stmtIntFromOpen: number | null;
    stmtLateChargeLastYear: number | null;
    stmtLateChargeYtd: number | null;
    stmtLateChgUnpaid: number | null;
    stmtLtChgPdFrmOpn: number | null;
    stmtMaxLateFee: number | null;
    stmtMaxPenaltyApr: number | null;
    stmtNoteStartDate: string | null;
    stmtPrinPdFromOpen: number | null;
    stmtPrincipalLastYear: number | null;
    stmtPrincipalYtd: number | null;
    stmtUnappliedPartialPmt: number | null;
    studentCoveredPeriodEnd: string | null;
    studentLoanCapIntLastYear: number | null;
    studentLoanCapIntYtd: number | null;
    studentLoanCode: number | null;
    studentLoanOrigFeeLastYear: number | null;
    studentLoanOrigFeeYtd: number | null;
    thresholdPmt: number | null;
    totalAccrualReversal: number | null;
    totalBtBalanceToDate: number | null;
    totalCaBalanceToDate: number | null;
    totalFeeBalanceToDate: number | null;
    totalPuBalanceToDate: number | null;
    type: number | null;
    unAdjThresholdPmt: number | null;
    unAdjaPaymentDue: number | null;
    unamortizedFees: number | null;
    unappliedPartialPmt: number | null;
    userAmount1: number | null;
    userAmount2: number | null;
    userChar1: string;
    userChar2: string;
    userChar3: string;
    userChar4: string;
    userDate1: string | null;
    userDate2: string | null;
    variableRateIndicator: number | null;
    vin: string;
    warningCode: LoanWarningCode_2[];
    warningExpiration: LoanWarningExpiration_2[];
    version1: VersionType;
    investor: number | null;
    remittanceType: number | null;
    version2: VersionType;
}
