import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface RegCcFields {
    aggregateExceptionValue: boolean;
    aggregateExceptionValueSpecified: boolean;
    aggregateException: boolean | null;
    bankingDayValue: boolean;
    bankingDayValueSpecified: boolean;
    bankingDay: boolean | null;
    bankingDaysOptionValue: boolean;
    bankingDaysOptionValueSpecified: boolean;
    bankingDaysOption: boolean | null;
    branchValue: boolean;
    branchValueSpecified: boolean;
    branch: boolean | null;
    branchReferenceValue: boolean;
    branchReferenceValueSpecified: boolean;
    branchReference: boolean | null;
    branchValidCodeValue: boolean;
    branchValidCodeValueSpecified: boolean;
    branchValidCode: boolean | null;
    businessDaysValue: boolean;
    businessDaysValueSpecified: boolean;
    businessDays: boolean | null;
    excpWarningCodeListValue: boolean;
    excpWarningCodeListValueSpecified: boolean;
    excpWarningCodeList: boolean | null;
    federalReserveHoliday: number[];
    federalReserveHolidaySpecified: boolean;
    foreignItemHoldDaysValue: boolean;
    foreignItemHoldDaysValueSpecified: boolean;
    foreignItemHoldDays: boolean | null;
    holdPolicyValue: boolean;
    holdPolicyValueSpecified: boolean;
    holdPolicy: boolean | null;
    holdWarningCodeListValue: boolean;
    holdWarningCodeListValueSpecified: boolean;
    holdWarningCodeList: boolean | null;
    krHoldBaseAmtOptionValue: boolean;
    krHoldBaseAmtOptionValueSpecified: boolean;
    krHoldBaseAmtOption: boolean | null;
    krHoldBaseOptionValue: boolean;
    krHoldBaseOptionValueSpecified: boolean;
    krHoldBaseOption: boolean | null;
    largeDepositExceptionHoldValue: boolean;
    largeDepositExceptionHoldValueSpecified: boolean;
    largeDepositExceptionHold: boolean | null;
    lastDayAvailableValue: boolean;
    lastDayAvailableValueSpecified: boolean;
    lastDayAvailable: boolean | null;
    localAggrgtExcpHoldDaysValue: boolean;
    localAggrgtExcpHoldDaysValueSpecified: boolean;
    localAggrgtExcpHoldDays: boolean | null;
    localExceptionHoldDaysValue: boolean;
    localExceptionHoldDaysValueSpecified: boolean;
    localExceptionHoldDays: boolean | null;
    localHoldDaysValue: boolean;
    localHoldDaysValueSpecified: boolean;
    localHoldDays: boolean | null;
    maxHoldCalendarDaysValue: boolean;
    maxHoldCalendarDaysValueSpecified: boolean;
    maxHoldCalendarDays: boolean | null;
    newAccountHoldDaysValue: boolean;
    newAccountHoldDaysValueSpecified: boolean;
    newAccountHoldDays: boolean | null;
    newAccountWarningCodeValue: boolean;
    newAccountWarningCodeValueSpecified: boolean;
    newAccountWarningCode: boolean | null;
    nextDayAvailExcpRsnListValue: boolean;
    nextDayAvailExcpRsnListValueSpecified: boolean;
    nextDayAvailExcpRsnList: boolean | null;
    nextDayAvailableValue: boolean;
    nextDayAvailableValueSpecified: boolean;
    nextDayAvailable: boolean | null;
    nextDayDaysValue: boolean;
    nextDayDaysValueSpecified: boolean;
    nextDayDays: boolean | null;
    nonLocalAggrgtExcpHoldDayValue: boolean;
    nonLocalAggrgtExcpHoldDayValueSpecified: boolean;
    nonLocalAggrgtExcpHoldDay: boolean | null;
    nonLocalExceptionHoldDaysValue: boolean;
    nonLocalExceptionHoldDaysValueSpecified: boolean;
    nonLocalExceptionHoldDays: boolean | null;
    nonlocalHoldDaysValue: boolean;
    nonlocalHoldDaysValueSpecified: boolean;
    nonlocalHoldDays: boolean | null;
    repeatedNsfWarningCodeValue: boolean;
    repeatedNsfWarningCodeValueSpecified: boolean;
    repeatedNsfWarningCode: boolean | null;
    routingNumberHoldDays: number[];
    routingNumberHoldDaysSpecified: boolean;
    routingNumberPrefix: number[];
    routingNumberPrefixSpecified: boolean;
    savingsPolicyValue: boolean;
    savingsPolicyValueSpecified: boolean;
    savingsPolicy: boolean | null;
    useMicrRtPrefixValue: boolean;
    useMicrRtPrefixValueSpecified: boolean;
    useMicrRtPrefix: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
