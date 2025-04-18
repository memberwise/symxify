import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface LnSegmentDefaultFields {
    applyAsBilledValue: boolean;
    applyAsBilledValueSpecified: boolean;
    applyAsBilled: boolean | null;
    billingDefaultDaysValue: boolean;
    billingDefaultDaysValueSpecified: boolean;
    billingDefaultDays: boolean | null;
    billingMethodValue: boolean;
    billingMethodValueSpecified: boolean;
    billingMethod: boolean | null;
    closeDateValue: boolean;
    closeDateValueSpecified: boolean;
    closeDate: boolean | null;
    descriptionValue: boolean;
    descriptionValueSpecified: boolean;
    description: boolean | null;
    discountRateValue: boolean;
    discountRateValueSpecified: boolean;
    discountRate: boolean | null;
    exceedLevelPmtAmtValue: boolean;
    exceedLevelPmtAmtValueSpecified: boolean;
    exceedLevelPmtAmt: boolean | null;
    interestRateValue: boolean;
    interestRateValueSpecified: boolean;
    interestRate: boolean | null;
    interestRateIndexValue: boolean;
    interestRateIndexValueSpecified: boolean;
    interestRateIndex: boolean | null;
    interestRateMarginValue: boolean;
    interestRateMarginValueSpecified: boolean;
    interestRateMargin: boolean | null;
    interestRateMarginSignValue: boolean;
    interestRateMarginSignValueSpecified: boolean;
    interestRateMarginSign: boolean | null;
    interestRateMaxValue: boolean;
    interestRateMaxValueSpecified: boolean;
    interestRateMax: boolean | null;
    interestRateMinValue: boolean;
    interestRateMinValueSpecified: boolean;
    interestRateMin: boolean | null;
    interestTypeValue: boolean;
    interestTypeValueSpecified: boolean;
    interestType: boolean | null;
    levelPaymentAmtValue: boolean;
    levelPaymentAmtValueSpecified: boolean;
    levelPaymentAmt: boolean | null;
    levelPrincipalAmtValue: boolean;
    levelPrincipalAmtValueSpecified: boolean;
    levelPrincipalAmt: boolean | null;
    minimumPaymentValue: boolean;
    minimumPaymentValueSpecified: boolean;
    minimumPayment: boolean | null;
    paymentCalcTypeValue: boolean;
    paymentCalcTypeValueSpecified: boolean;
    paymentCalcType: boolean | null;
    paymentTypeValue: boolean;
    paymentTypeValueSpecified: boolean;
    paymentType: boolean | null;
    percentPrincipalValue: boolean;
    percentPrincipalValueSpecified: boolean;
    percentPrincipal: boolean | null;
    periodicCapValue: boolean;
    periodicCapValueSpecified: boolean;
    periodicCap: boolean | null;
    periodicFrequencyValue: boolean;
    periodicFrequencyValueSpecified: boolean;
    periodicFrequency: boolean | null;
    periodicStartDateValue: boolean;
    periodicStartDateValueSpecified: boolean;
    periodicStartDate: boolean | null;
    periodicStartRateValue: boolean;
    periodicStartRateValueSpecified: boolean;
    periodicStartRate: boolean | null;
    riskRateValue: boolean;
    riskRateValueSpecified: boolean;
    riskRate: boolean | null;
    segmentTypeValue: boolean;
    segmentTypeValueSpecified: boolean;
    segmentType: boolean | null;
    typeValue: boolean;
    typeValueSpecified: boolean;
    type: boolean | null;
    variableRateIndicatorValue: boolean;
    variableRateIndicatorValueSpecified: boolean;
    variableRateIndicator: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
