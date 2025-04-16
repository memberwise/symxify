import { LoanDefaultPromoAdvanceCutoff_2 } from "./loanDefaultPromoAdvanceCutoff_2";
import { LoanDefaultPromoEffectDate_2 } from "./loanDefaultPromoEffectDate_2";
import { LoanDefaultPromoExpireDate_2 } from "./loanDefaultPromoExpireDate_2";
import { LoanDefaultPromoRate_2 } from "./loanDefaultPromoRate_2";
import { LoanDefaultPromoRateMax_2 } from "./loanDefaultPromoRateMax_2";
import { LoanDefaultPromoRateMin_2 } from "./loanDefaultPromoRateMin_2";
import { LoanDefaultPromoRateOffset_2 } from "./loanDefaultPromoRateOffset_2";
import { LoanDefaultPromoRateType_2 } from "./loanDefaultPromoRateType_2";
import { LoanDefaultPromoType_2 } from "./loanDefaultPromoType_2";
import { LoanDefaultService_2 } from "./loanDefaultService_2";
import { LoanDefaultWarningCode_2 } from "./loanDefaultWarningCode_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface LoanDefault_2 {
    allowUnappliedPmtValue: number;
    allowUnappliedPmtValueSpecified: boolean;
    allowUnappliedPmt: number | null;
    amortizationSchdValue: number;
    amortizationSchdValueSpecified: boolean;
    amortizationSchd: number | null;
    amortizationSchdTypeValue: number;
    amortizationSchdTypeValueSpecified: boolean;
    amortizationSchdType: number | null;
    amortizationTermValue: number;
    amortizationTermValueSpecified: boolean;
    amortizationTerm: number | null;
    applyAsBilledValue: number;
    applyAsBilledValueSpecified: boolean;
    applyAsBilled: number | null;
    approvalCodeValue: number;
    approvalCodeValueSpecified: boolean;
    approvalCode: number | null;
    armNoticeValue: number;
    armNoticeValueSpecified: boolean;
    armNotice: number | null;
    availCreditCalcValue: number;
    availCreditCalcValueSpecified: boolean;
    availCreditCalc: number | null;
    billingDefaultDaysValue: number;
    billingDefaultDaysValueSpecified: boolean;
    billingDefaultDays: number | null;
    billingMethodValue: number;
    billingMethodValueSpecified: boolean;
    billingMethod: number | null;
    billingNoticeValue: number;
    billingNoticeValueSpecified: boolean;
    billingNotice: number | null;
    billingNoticeMinValue: number;
    billingNoticeMinValueSpecified: boolean;
    billingNoticeMin: number | null;
    btLimitMaxValue: number;
    btLimitMaxValueSpecified: boolean;
    btLimitMax: number | null;
    btPercentValue: number;
    btPercentValueSpecified: boolean;
    btPercent: number | null;
    caLimitMaxValue: number;
    caLimitMaxValueSpecified: boolean;
    caLimitMax: number | null;
    caPercentValue: number;
    caPercentValueSpecified: boolean;
    caPercent: number | null;
    callItemSchdValue: number;
    callItemSchdValueSpecified: boolean;
    callItemSchd: number | null;
    callItemSchdTypeValue: number;
    callItemSchdTypeValueSpecified: boolean;
    callItemSchdType: number | null;
    cancelableValue: number;
    cancelableValueSpecified: boolean;
    cancelable: number | null;
    cappedFeesAmountCapValue: number;
    cappedFeesAmountCapValueSpecified: boolean;
    cappedFeesAmountCap: number | null;
    cappedFeesCountCapValue: number;
    cappedFeesCountCapValueSpecified: boolean;
    cappedFeesCountCap: number | null;
    checkDigits: string;
    closeDateValue: string | null;
    closeDateValueSpecified: boolean;
    closeDate: string | null;
    collateralCodeValue: number;
    collateralCodeValueSpecified: boolean;
    collateralCode: number | null;
    combinedCaBtLimitMaxValue: number;
    combinedCaBtLimitMaxValueSpecified: boolean;
    combinedCaBtLimitMax: number | null;
    combinedCaBtPercentValue: number;
    combinedCaBtPercentValueSpecified: boolean;
    combinedCaBtPercent: number | null;
    comboLnSegmentMaxValue: number;
    comboLnSegmentMaxValueSpecified: boolean;
    comboLnSegmentMax: number | null;
    comboPmtOrderMethValue: number;
    comboPmtOrderMethValueSpecified: boolean;
    comboPmtOrderMeth: number | null;
    comboSeg0PmtOrderValue: number;
    comboSeg0PmtOrderValueSpecified: boolean;
    comboSeg0PmtOrder: number | null;
    corporateUserTransferCodeValue: number;
    corporateUserTransferCodeValueSpecified: boolean;
    corporateUserTransferCode: number | null;
    crIntTypeInd: string;
    credLimitExpirationValue: string | null;
    credLimitExpirationValueSpecified: boolean;
    credLimitExpiration: string | null;
    creditLimitValue: number;
    creditLimitValueSpecified: boolean;
    creditLimit: number | null;
    creditLimitGroupValue: number;
    creditLimitGroupValueSpecified: boolean;
    creditLimitGroup: number | null;
    creditReportingCodeValue: number;
    creditReportingCodeValueSpecified: boolean;
    creditReportingCode: number | null;
    cuTotalsUseCodeValue: number;
    cuTotalsUseCodeValueSpecified: boolean;
    cuTotalsUseCode: number | null;
    dealerCity: string;
    dealerCounty: string;
    dealerState: string;
    description: string;
    discountRateValue: number;
    discountRateValueSpecified: boolean;
    discountRate: number | null;
    dqCalculationMethodValue: number;
    dqCalculationMethodValueSpecified: boolean;
    dqCalculationMethod: number | null;
    dqNoticeNumberValue: number;
    dqNoticeNumberValueSpecified: boolean;
    dqNoticeNumber: number | null;
    dqNoticeTypeValue: number;
    dqNoticeTypeValueSpecified: boolean;
    dqNoticeType: number | null;
    dueDateAdvanceCodeValue: number;
    dueDateAdvanceCodeValueSpecified: boolean;
    dueDateAdvanceCode: number | null;
    dueDay1Value: number;
    dueDay1ValueSpecified: boolean;
    dueDay1: number | null;
    dueDay2Value: number;
    dueDay2ValueSpecified: boolean;
    dueDay2: number | null;
    ecoaCodeValue: number;
    ecoaCodeValueSpecified: boolean;
    ecoaCode: number | null;
    effectiveAprValue: number;
    effectiveAprValueSpecified: boolean;
    effectiveApr: number | null;
    exceedLevelPmtAmtValue: number;
    exceedLevelPmtAmtValueSpecified: boolean;
    exceedLevelPmtAmt: number | null;
    fasb91AlternateTermValue: number;
    fasb91AlternateTermValueSpecified: boolean;
    fasb91AlternateTerm: number | null;
    fasb91CodeValue: number;
    fasb91CodeValueSpecified: boolean;
    fasb91Code: number | null;
    feesChargesPostingOptionValue: number;
    feesChargesPostingOptionValueSpecified: boolean;
    feesChargesPostingOption: number | null;
    fixedDealerCityTaxRateValue: number;
    fixedDealerCityTaxRateValueSpecified: boolean;
    fixedDealerCityTaxRate: number | null;
    fixedDealerCountyTaxRateValue: number;
    fixedDealerCountyTaxRateValueSpecified: boolean;
    fixedDealerCountyTaxRate: number | null;
    fixedDealerStateTaxRateValue: number;
    fixedDealerStateTaxRateValueSpecified: boolean;
    fixedDealerStateTaxRate: number | null;
    fixedLesseeCityTaxRateValue: number;
    fixedLesseeCityTaxRateValueSpecified: boolean;
    fixedLesseeCityTaxRate: number | null;
    fixedLesseeCountyTaxRateValue: number;
    fixedLesseeCountyTaxRateValueSpecified: boolean;
    fixedLesseeCountyTaxRate: number | null;
    fixedLesseeStateTaxRateValue: number;
    fixedLesseeStateTaxRateValueSpecified: boolean;
    fixedLesseeStateTaxRate: number | null;
    glAccrualStatusOptionValue: number;
    glAccrualStatusOptionValueSpecified: boolean;
    glAccrualStatusOption: number | null;
    initialArmNoticeValue: number;
    initialArmNoticeValueSpecified: boolean;
    initialArmNotice: number | null;
    initialBcdSettingOptionValue: number;
    initialBcdSettingOptionValueSpecified: boolean;
    initialBcdSettingOption: number | null;
    insuranceMaxValue: number;
    insuranceMaxValueSpecified: boolean;
    insuranceMax: number | null;
    insuranceTypeValue: number;
    insuranceTypeValueSpecified: boolean;
    insuranceType: number | null;
    intPayoffCalcValue: number;
    intPayoffCalcValueSpecified: boolean;
    intPayoffCalc: number | null;
    interestRateValue: number;
    interestRateValueSpecified: boolean;
    interestRate: number | null;
    interestRateIndexValue: number;
    interestRateIndexValueSpecified: boolean;
    interestRateIndex: number | null;
    interestRateMarginValue: number;
    interestRateMarginValueSpecified: boolean;
    interestRateMargin: number | null;
    interestRateMarginSignValue: number;
    interestRateMarginSignValueSpecified: boolean;
    interestRateMarginSign: number | null;
    interestRateMaxValue: number;
    interestRateMaxValueSpecified: boolean;
    interestRateMax: number | null;
    interestRateMinValue: number;
    interestRateMinValueSpecified: boolean;
    interestRateMin: number | null;
    interestTypeValue: number;
    interestTypeValueSpecified: boolean;
    interestType: number | null;
    lateChargeTypeValue: number;
    lateChargeTypeValueSpecified: boolean;
    lateChargeType: number | null;
    leaseDispositionDateValue: string | null;
    leaseDispositionDateValueSpecified: boolean;
    leaseDispositionDate: string | null;
    leaseDispositionFeeValue: number;
    leaseDispositionFeeValueSpecified: boolean;
    leaseDispositionFee: number | null;
    leaseTerminateDateValue: string | null;
    leaseTerminateDateValueSpecified: boolean;
    leaseTerminateDate: string | null;
    leaseTerminateFeeValue: number;
    leaseTerminateFeeValueSpecified: boolean;
    leaseTerminateFee: number | null;
    lesseeCity: string;
    lesseeCounty: string;
    lesseeState: string;
    levelPaymentAmtValue: number;
    levelPaymentAmtValueSpecified: boolean;
    levelPaymentAmt: number | null;
    levelPrincipalAmtValue: number;
    levelPrincipalAmtValueSpecified: boolean;
    levelPrincipalAmt: number | null;
    loanCodeValue: number;
    loanCodeValueSpecified: boolean;
    loanCode: number | null;
    loanTypeValue: number;
    loanTypeValueSpecified: boolean;
    loanType: number | null;
    maxDueDateAdvancePeriodValue: number;
    maxDueDateAdvancePeriodValueSpecified: boolean;
    maxDueDateAdvancePeriod: number | null;
    memberUserTransferCodeValue: number;
    memberUserTransferCodeValueSpecified: boolean;
    memberUserTransferCode: number | null;
    mfoelIdValue: number;
    mfoelIdValueSpecified: boolean;
    mfoelId: number | null;
    minAdvanceValue: number;
    minAdvanceValueSpecified: boolean;
    minAdvance: number | null;
    minBalanceValue: number;
    minBalanceValueSpecified: boolean;
    minBalance: number | null;
    minimumPaymentValue: number;
    minimumPaymentValueSpecified: boolean;
    minimumPayment: number | null;
    newLoanDueDateCodeValue: number;
    newLoanDueDateCodeValueSpecified: boolean;
    newLoanDueDateCode: number | null;
    newSegCutoffDaysValue: number;
    newSegCutoffDaysValueSpecified: boolean;
    newSegCutoffDays: number | null;
    newSegCutoffOptionValue: number;
    newSegCutoffOptionValueSpecified: boolean;
    newSegCutoffOption: number | null;
    nickname: string;
    noteNumber: string;
    occupancyTypeValue: number;
    occupancyTypeValueSpecified: boolean;
    occupancyType: number | null;
    originalRateValue: number;
    originalRateValueSpecified: boolean;
    originalRate: number | null;
    ovlAuthFeeValue: number;
    ovlAuthFeeValueSpecified: boolean;
    ovlAuthFee: number | null;
    ovlOptInValue: number;
    ovlOptInValueSpecified: boolean;
    ovlOptIn: number | null;
    ovlPrevAuthFeeValue: number;
    ovlPrevAuthFeeValueSpecified: boolean;
    ovlPrevAuthFee: number | null;
    ovlStmtDisclFeeValue: number;
    ovlStmtDisclFeeValueSpecified: boolean;
    ovlStmtDisclFee: number | null;
    paymentValue: number;
    paymentValueSpecified: boolean;
    payment: number | null;
    paymentApplicationMethodValue: number;
    paymentApplicationMethodValueSpecified: boolean;
    paymentApplicationMethod: number | null;
    paymentCalcTypeValue: number;
    paymentCalcTypeValueSpecified: boolean;
    paymentCalcType: number | null;
    paymentCountValue: number;
    paymentCountValueSpecified: boolean;
    paymentCount: number | null;
    paymentFrequencyValue: number;
    paymentFrequencyValueSpecified: boolean;
    paymentFrequency: number | null;
    paymentMethodValue: number;
    paymentMethodValueSpecified: boolean;
    paymentMethod: number | null;
    paymentSkipStartDayValue: number;
    paymentSkipStartDayValueSpecified: boolean;
    paymentSkipStartDay: number | null;
    paymentSkipsValue: number;
    paymentSkipsValueSpecified: boolean;
    paymentSkips: number | null;
    paymentTypeValue: number;
    paymentTypeValueSpecified: boolean;
    paymentType: number | null;
    percentPrincipalValue: number;
    percentPrincipalValueSpecified: boolean;
    percentPrincipal: number | null;
    periodicCapValue: number;
    periodicCapValueSpecified: boolean;
    periodicCap: number | null;
    periodicFrequencyValue: number;
    periodicFrequencyValueSpecified: boolean;
    periodicFrequency: number | null;
    periodicStartDateValue: string | null;
    periodicStartDateValueSpecified: boolean;
    periodicStartDate: string | null;
    periodicStartRateValue: number;
    periodicStartRateValueSpecified: boolean;
    periodicStartRate: number | null;
    prepaymentPenaltyValue: number;
    prepaymentPenaltyValueSpecified: boolean;
    prepaymentPenalty: number | null;
    promoAdvanceCutoff: LoanDefaultPromoAdvanceCutoff_2[];
    promoAdvanceCutoffSpecified: boolean;
    promoEffectDate: LoanDefaultPromoEffectDate_2[];
    promoEffectDateSpecified: boolean;
    promoExpireDate: LoanDefaultPromoExpireDate_2[];
    promoExpireDateSpecified: boolean;
    promoRate: LoanDefaultPromoRate_2[];
    promoRateSpecified: boolean;
    promoRateMax: LoanDefaultPromoRateMax_2[];
    promoRateMaxSpecified: boolean;
    promoRateMin: LoanDefaultPromoRateMin_2[];
    promoRateMinSpecified: boolean;
    promoRateOffset: LoanDefaultPromoRateOffset_2[];
    promoRateOffsetSpecified: boolean;
    promoRateType: LoanDefaultPromoRateType_2[];
    promoRateTypeSpecified: boolean;
    promoType: LoanDefaultPromoType_2[];
    promoTypeSpecified: boolean;
    propertyAddressTypeValue: number;
    propertyAddressTypeValueSpecified: boolean;
    propertyAddressType: number | null;
    purposeCodeValue: number;
    purposeCodeValueSpecified: boolean;
    purposeCode: number | null;
    putItemSchdValue: number;
    putItemSchdValueSpecified: boolean;
    putItemSchd: number | null;
    putItemSchdTypeValue: number;
    putItemSchdTypeValueSpecified: boolean;
    putItemSchdType: number | null;
    rateChangeCycleMonthsValue: number;
    rateChangeCycleMonthsValueSpecified: boolean;
    rateChangeCycleMonths: number | null;
    rateRoundingMethodValue: number;
    rateRoundingMethodValueSpecified: boolean;
    rateRoundingMethod: number | null;
    reference: string;
    refundPostCodeValue: number;
    refundPostCodeValueSpecified: boolean;
    refundPostCode: number | null;
    riskRateValue: number;
    riskRateValueSpecified: boolean;
    riskRate: number | null;
    roundRateToValue: number;
    roundRateToValueSpecified: boolean;
    roundRateTo: number | null;
    salesTaxCityIndicatorValue: number;
    salesTaxCityIndicatorValueSpecified: boolean;
    salesTaxCityIndicator: number | null;
    salesTaxCountyIndicatorValue: number;
    salesTaxCountyIndicatorValueSpecified: boolean;
    salesTaxCountyIndicator: number | null;
    salesTaxStateIndicatorValue: number;
    salesTaxStateIndicatorValueSpecified: boolean;
    salesTaxStateIndicator: number | null;
    securedCodeValue: number;
    securedCodeValueSpecified: boolean;
    securedCode: number | null;
    seg0Description: string;
    seg0LevelPrinPmtValue: number;
    seg0LevelPrinPmtValueSpecified: boolean;
    seg0LevelPrinPmt: number | null;
    seg0PaymentOrderValue: number;
    seg0PaymentOrderValueSpecified: boolean;
    seg0PaymentOrder: number | null;
    service: LoanDefaultService_2[];
    serviceSpecified: boolean;
    splitRateValue: number;
    splitRateValueSpecified: boolean;
    splitRate: number | null;
    splitRateBalanceValue: number;
    splitRateBalanceValueSpecified: boolean;
    splitRateBalance: number | null;
    statementGroupValue: number;
    statementGroupValueSpecified: boolean;
    statementGroup: number | null;
    statementMailCodeValue: number;
    statementMailCodeValueSpecified: boolean;
    statementMailCode: number | null;
    stmtMaxLateFeeValue: number;
    stmtMaxLateFeeValueSpecified: boolean;
    stmtMaxLateFee: number | null;
    stmtMaxPenaltyAprValue: number;
    stmtMaxPenaltyAprValueSpecified: boolean;
    stmtMaxPenaltyApr: number | null;
    studentLoanCodeValue: number;
    studentLoanCodeValueSpecified: boolean;
    studentLoanCode: number | null;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    unamortizedFeesValue: number;
    unamortizedFeesValueSpecified: boolean;
    unamortizedFees: number | null;
    userAmount1Value: number;
    userAmount1ValueSpecified: boolean;
    userAmount1: number | null;
    userAmount2Value: number;
    userAmount2ValueSpecified: boolean;
    userAmount2: number | null;
    userChar1: string;
    userChar2: string;
    userChar3: string;
    userChar4: string;
    userDate1Value: string | null;
    userDate1ValueSpecified: boolean;
    userDate1: string | null;
    userDate2Value: string | null;
    userDate2ValueSpecified: boolean;
    userDate2: string | null;
    variableRateIndicatorValue: number;
    variableRateIndicatorValueSpecified: boolean;
    variableRateIndicator: number | null;
    warningCode: LoanDefaultWarningCode_2[];
    warningCodeSpecified: boolean;
    version1: VersionType;
    investorValue: number;
    investorValueSpecified: boolean;
    investor: number | null;
    remittanceTypeValue: number;
    remittanceTypeValueSpecified: boolean;
    remittanceType: number | null;
    version2: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}