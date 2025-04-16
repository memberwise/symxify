import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface LnSegmentDefault {
    applyAsBilledValue: number;
    applyAsBilledValueSpecified: boolean;
    applyAsBilled: number | null;
    billingDefaultDaysValue: number;
    billingDefaultDaysValueSpecified: boolean;
    billingDefaultDays: number | null;
    billingMethodValue: number;
    billingMethodValueSpecified: boolean;
    billingMethod: number | null;
    closeDateValue: string;
    closeDateValueSpecified: boolean;
    closeDate: string | null;
    description: string;
    discountRateValue: number;
    discountRateValueSpecified: boolean;
    discountRate: number | null;
    exceedLevelPmtAmtValue: number;
    exceedLevelPmtAmtValueSpecified: boolean;
    exceedLevelPmtAmt: number | null;
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
    levelPaymentAmtValue: number;
    levelPaymentAmtValueSpecified: boolean;
    levelPaymentAmt: number | null;
    levelPrincipalAmtValue: number;
    levelPrincipalAmtValueSpecified: boolean;
    levelPrincipalAmt: number | null;
    minimumPaymentValue: number;
    minimumPaymentValueSpecified: boolean;
    minimumPayment: number | null;
    paymentCalcTypeValue: number;
    paymentCalcTypeValueSpecified: boolean;
    paymentCalcType: number | null;
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
    periodicStartDateValue: string;
    periodicStartDateValueSpecified: boolean;
    periodicStartDate: string | null;
    periodicStartRateValue: number;
    periodicStartRateValueSpecified: boolean;
    periodicStartRate: number | null;
    riskRateValue: number;
    riskRateValueSpecified: boolean;
    riskRate: number | null;
    segmentTypeValue: number;
    segmentTypeValueSpecified: boolean;
    segmentType: number | null;
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