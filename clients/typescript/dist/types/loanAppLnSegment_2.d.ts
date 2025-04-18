import { LoanAppLnSegmentPmtBucketAmount_2 } from "./loanAppLnSegmentPmtBucketAmount_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface LoanAppLnSegment_2 {
    applyAsBilledValue: number;
    applyAsBilledValueSpecified: boolean;
    applyAsBilled: number | null;
    balanceValue: number;
    balanceValueSpecified: boolean;
    balance: number | null;
    balloonAmountValue: number;
    balloonAmountValueSpecified: boolean;
    balloonAmount: number | null;
    balloonDateValue: string | null;
    balloonDateValueSpecified: boolean;
    balloonDate: string | null;
    beginningCycleDateValue: string | null;
    beginningCycleDateValueSpecified: boolean;
    beginningCycleDate: string | null;
    billingDefaultDaysValue: number;
    billingDefaultDaysValueSpecified: boolean;
    billingDefaultDays: number | null;
    billingMethodValue: number;
    billingMethodValueSpecified: boolean;
    billingMethod: number | null;
    closeDateValue: string | null;
    closeDateValueSpecified: boolean;
    closeDate: string | null;
    description: string;
    discountRateValue: number;
    discountRateValueSpecified: boolean;
    discountRate: number | null;
    exceedLevelPmtAmtValue: number;
    exceedLevelPmtAmtValueSpecified: boolean;
    exceedLevelPmtAmt: number | null;
    firstPaymentDateValue: string | null;
    firstPaymentDateValueSpecified: boolean;
    firstPaymentDate: string | null;
    id: string;
    intUnpaidBilledValue: number;
    intUnpaidBilledValueSpecified: boolean;
    intUnpaidBilled: number | null;
    intYtdValue: number;
    intYtdValueSpecified: boolean;
    intYtd: number | null;
    interestLastYearValue: number;
    interestLastYearValueSpecified: boolean;
    interestLastYear: number | null;
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
    interestUnpaidValue: number;
    interestUnpaidValueSpecified: boolean;
    interestUnpaid: number | null;
    lastPaymentDateValue: string | null;
    lastPaymentDateValueSpecified: boolean;
    lastPaymentDate: string | null;
    levelPaymentAmtValue: number;
    levelPaymentAmtValueSpecified: boolean;
    levelPaymentAmt: number | null;
    levelPrincipalAmtValue: number;
    levelPrincipalAmtValueSpecified: boolean;
    levelPrincipalAmt: number | null;
    maturityDateValue: string | null;
    maturityDateValueSpecified: boolean;
    maturityDate: string | null;
    minimumPaymentValue: number;
    minimumPaymentValueSpecified: boolean;
    minimumPayment: number | null;
    openDateValue: string | null;
    openDateValueSpecified: boolean;
    openDate: string | null;
    originalBalanceValue: number;
    originalBalanceValueSpecified: boolean;
    originalBalance: number | null;
    originalDateValue: string | null;
    originalDateValueSpecified: boolean;
    originalDate: string | null;
    partialPaymentValue: number;
    partialPaymentValueSpecified: boolean;
    partialPayment: number | null;
    paymentValue: number;
    paymentValueSpecified: boolean;
    payment: number | null;
    paymentCalcTypeValue: number;
    paymentCalcTypeValueSpecified: boolean;
    paymentCalcType: number | null;
    paymentDueValue: number;
    paymentDueValueSpecified: boolean;
    paymentDue: number | null;
    paymentOrderValue: number;
    paymentOrderValueSpecified: boolean;
    paymentOrder: number | null;
    paymentTypeValue: number;
    paymentTypeValueSpecified: boolean;
    paymentType: number | null;
    payoffAmountValue: number;
    payoffAmountValueSpecified: boolean;
    payoffAmount: number | null;
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
    pmtBucketAmount: LoanAppLnSegmentPmtBucketAmount_2[];
    pmtBucketAmountSpecified: boolean;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    riskRateValue: number;
    riskRateValueSpecified: boolean;
    riskRate: number | null;
    schdPeriodStartDateValue: string | null;
    schdPeriodStartDateValueSpecified: boolean;
    schdPeriodStartDate: string | null;
    schdPeriodStartRateValue: number;
    schdPeriodStartRateValueSpecified: boolean;
    schdPeriodStartRate: number | null;
    schdRateValue: number;
    schdRateValueSpecified: boolean;
    schdRate: number | null;
    schdRateChangeDateValue: string | null;
    schdRateChangeDateValueSpecified: boolean;
    schdRateChangeDate: string | null;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    variableRateIndicatorValue: number;
    variableRateIndicatorValueSpecified: boolean;
    variableRateIndicator: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
