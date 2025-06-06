import { VersionType } from "./versionType";
export interface LoanDefaultFields {
    allowUnappliedPmt: boolean | null;
    amortizationSchd: boolean | null;
    amortizationSchdType: boolean | null;
    amortizationTerm: boolean | null;
    applyAsBilled: boolean | null;
    approvalCode: boolean | null;
    armNotice: boolean | null;
    availCreditCalc: boolean | null;
    billingDefaultDays: boolean | null;
    billingMethod: boolean | null;
    billingNotice: boolean | null;
    billingNoticeMin: boolean | null;
    btLimitMax: boolean | null;
    btPercent: boolean | null;
    caLimitMax: boolean | null;
    caPercent: boolean | null;
    callItemSchd: boolean | null;
    callItemSchdType: boolean | null;
    cancelable: boolean | null;
    cappedFeesAmountCap: boolean | null;
    cappedFeesCountCap: boolean | null;
    checkDigits: boolean | null;
    closeDate: boolean | null;
    collateralCode: boolean | null;
    combinedCaBtLimitMax: boolean | null;
    combinedCaBtPercent: boolean | null;
    comboLnSegmentMax: boolean | null;
    comboPmtOrderMeth: boolean | null;
    comboSeg0PmtOrder: boolean | null;
    corporateUserTransferCode: boolean | null;
    crIntTypeInd: boolean | null;
    credLimitExpiration: boolean | null;
    creditLimit: boolean | null;
    creditLimitGroup: boolean | null;
    creditReportingCode: boolean | null;
    cuTotalsUseCode: boolean | null;
    dealerCity: boolean | null;
    dealerCounty: boolean | null;
    dealerState: boolean | null;
    description: boolean | null;
    discountRate: boolean | null;
    dqCalculationMethod: boolean | null;
    dqNoticeNumber: boolean | null;
    dqNoticeType: boolean | null;
    dueDateAdvanceCode: boolean | null;
    dueDay1: boolean | null;
    dueDay2: boolean | null;
    ecoaCode: boolean | null;
    effectiveApr: boolean | null;
    exceedLevelPmtAmt: boolean | null;
    fasb91AlternateTerm: boolean | null;
    fasb91Code: boolean | null;
    feesChargesPostingOption: boolean | null;
    fixedDealerCityTaxRate: boolean | null;
    fixedDealerCountyTaxRate: boolean | null;
    fixedDealerStateTaxRate: boolean | null;
    fixedLesseeCityTaxRate: boolean | null;
    fixedLesseeCountyTaxRate: boolean | null;
    fixedLesseeStateTaxRate: boolean | null;
    glAccrualStatusOption: boolean | null;
    initialArmNotice: boolean | null;
    initialBcdSettingOption: boolean | null;
    insuranceMax: boolean | null;
    insuranceType: boolean | null;
    intPayoffCalc: boolean | null;
    interestRate: boolean | null;
    interestRateIndex: boolean | null;
    interestRateMargin: boolean | null;
    interestRateMarginSign: boolean | null;
    interestRateMax: boolean | null;
    interestRateMin: boolean | null;
    interestType: boolean | null;
    lateChargeType: boolean | null;
    leaseDispositionDate: boolean | null;
    leaseDispositionFee: boolean | null;
    leaseTerminateDate: boolean | null;
    leaseTerminateFee: boolean | null;
    lesseeCity: boolean | null;
    lesseeCounty: boolean | null;
    lesseeState: boolean | null;
    levelPaymentAmt: boolean | null;
    levelPrincipalAmt: boolean | null;
    loanCode: boolean | null;
    loanType: boolean | null;
    maxDueDateAdvancePeriod: boolean | null;
    memberUserTransferCode: boolean | null;
    mfoelId: boolean | null;
    minAdvance: boolean | null;
    minBalance: boolean | null;
    minimumPayment: boolean | null;
    newLoanDueDateCode: boolean | null;
    newSegCutoffDays: boolean | null;
    newSegCutoffOption: boolean | null;
    nickname: boolean | null;
    noteNumber: boolean | null;
    occupancyType: boolean | null;
    originalRate: boolean | null;
    ovlAuthFee: boolean | null;
    ovlOptIn: boolean | null;
    ovlPrevAuthFee: boolean | null;
    ovlStmtDisclFee: boolean | null;
    payment: boolean | null;
    paymentApplicationMethod: boolean | null;
    paymentCalcType: boolean | null;
    paymentCount: boolean | null;
    paymentFrequency: boolean | null;
    paymentMethod: boolean | null;
    paymentSkipStartDay: boolean | null;
    paymentSkips: boolean | null;
    paymentType: boolean | null;
    percentPrincipal: boolean | null;
    periodicCap: boolean | null;
    periodicFrequency: boolean | null;
    periodicStartDate: boolean | null;
    periodicStartRate: boolean | null;
    prepaymentPenalty: boolean | null;
    promoAdvanceCutoff: number[];
    promoEffectDate: number[];
    promoExpireDate: number[];
    promoRate: number[];
    promoRateMax: number[];
    promoRateMin: number[];
    promoRateOffset: number[];
    promoRateType: number[];
    promoType: number[];
    propertyAddressType: boolean | null;
    purposeCode: boolean | null;
    putItemSchd: boolean | null;
    putItemSchdType: boolean | null;
    rateChangeCycleMonths: boolean | null;
    rateRoundingMethod: boolean | null;
    reference: boolean | null;
    refundPostCode: boolean | null;
    riskRate: boolean | null;
    roundRateTo: boolean | null;
    salesTaxCityIndicator: boolean | null;
    salesTaxCountyIndicator: boolean | null;
    salesTaxStateIndicator: boolean | null;
    securedCode: boolean | null;
    seg0Description: boolean | null;
    seg0LevelPrinPmt: boolean | null;
    seg0PaymentOrder: boolean | null;
    service: number[];
    splitRate: boolean | null;
    splitRateBalance: boolean | null;
    statementGroup: boolean | null;
    statementMailCode: boolean | null;
    stmtMaxLateFee: boolean | null;
    stmtMaxPenaltyApr: boolean | null;
    studentLoanCode: boolean | null;
    type: boolean | null;
    unamortizedFees: boolean | null;
    userAmount1: boolean | null;
    userAmount2: boolean | null;
    userChar1: boolean | null;
    userChar2: boolean | null;
    userChar3: boolean | null;
    userChar4: boolean | null;
    userDate1: boolean | null;
    userDate2: boolean | null;
    variableRateIndicator: boolean | null;
    warningCode: number[];
    version1: VersionType;
    investor: boolean | null;
    remittanceType: boolean | null;
    version2: VersionType;
}
