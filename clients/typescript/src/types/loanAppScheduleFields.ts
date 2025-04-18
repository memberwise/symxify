import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface LoanAppScheduleFields {
    applyAsBilledValue: boolean;
    applyAsBilledValueSpecified: boolean;
    applyAsBilled: boolean | null;
    beginningDateValue: boolean;
    beginningDateValueSpecified: boolean;
    beginningDate: boolean | null;
    billingDefaultDaysValue: boolean;
    billingDefaultDaysValueSpecified: boolean;
    billingDefaultDays: boolean | null;
    billingMethodValue: boolean;
    billingMethodValueSpecified: boolean;
    billingMethod: boolean | null;
    billingNoticeValue: boolean;
    billingNoticeValueSpecified: boolean;
    billingNotice: boolean | null;
    billingNoticeMinValue: boolean;
    billingNoticeMinValueSpecified: boolean;
    billingNoticeMin: boolean | null;
    dqCalculationMethodValue: boolean;
    dqCalculationMethodValueSpecified: boolean;
    dqCalculationMethod: boolean | null;
    dueDay1Value: boolean;
    dueDay1ValueSpecified: boolean;
    dueDay1: boolean | null;
    dueDay2Value: boolean;
    dueDay2ValueSpecified: boolean;
    dueDay2: boolean | null;
    exceedLevelPmtAmtValue: boolean;
    exceedLevelPmtAmtValueSpecified: boolean;
    exceedLevelPmtAmt: boolean | null;
    expirationValue: boolean;
    expirationValueSpecified: boolean;
    expiration: boolean | null;
    idValue: boolean;
    idValueSpecified: boolean;
    id: boolean | null;
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
    paymentValue: boolean;
    paymentValueSpecified: boolean;
    payment: boolean | null;
    paymentCalcTypeValue: boolean;
    paymentCalcTypeValueSpecified: boolean;
    paymentCalcType: boolean | null;
    paymentDescriptionValue: boolean;
    paymentDescriptionValueSpecified: boolean;
    paymentDescription: boolean | null;
    paymentTypeValue: boolean;
    paymentTypeValueSpecified: boolean;
    paymentType: boolean | null;
    percentPrincipalValue: boolean;
    percentPrincipalValueSpecified: boolean;
    percentPrincipal: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    repeatCodeValue: boolean;
    repeatCodeValueSpecified: boolean;
    repeatCode: boolean | null;
    useRateChangeProcessIngValue: boolean;
    useRateChangeProcessIngValueSpecified: boolean;
    useRateChangeProcessIng: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}