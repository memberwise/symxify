import { BitMap } from "./bitMap";
import { RegCcFederalReserveHoliday_2 } from "./regCcFederalReserveHoliday_2";
import { RegCcRoutingNumberHoldDays_2 } from "./regCcRoutingNumberHoldDays_2";
import { RegCcRoutingNumberPrefix_2 } from "./regCcRoutingNumberPrefix_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface RegCc_2 {
    aggregateExceptionValue: number;
    aggregateExceptionValueSpecified: boolean;
    aggregateException: number | null;
    bankingDayValue: string | null;
    bankingDayValueSpecified: boolean;
    bankingDay: string | null;
    bankingDaysOptionValue: number;
    bankingDaysOptionValueSpecified: boolean;
    bankingDaysOption: number | null;
    branchValue: number;
    branchValueSpecified: boolean;
    branch: number | null;
    branchReferenceValue: number;
    branchReferenceValueSpecified: boolean;
    branchReference: number | null;
    branchValidCodeValue: number;
    branchValidCodeValueSpecified: boolean;
    branchValidCode: number | null;
    businessDays: string;
    excpWarningCodeList: BitMap;
    federalReserveHoliday: RegCcFederalReserveHoliday_2[];
    federalReserveHolidaySpecified: boolean;
    foreignItemHoldDaysValue: number;
    foreignItemHoldDaysValueSpecified: boolean;
    foreignItemHoldDays: number | null;
    holdPolicyValue: number;
    holdPolicyValueSpecified: boolean;
    holdPolicy: number | null;
    holdWarningCodeList: BitMap;
    krHoldBaseAmtOptionValue: number;
    krHoldBaseAmtOptionValueSpecified: boolean;
    krHoldBaseAmtOption: number | null;
    krHoldBaseOptionValue: number;
    krHoldBaseOptionValueSpecified: boolean;
    krHoldBaseOption: number | null;
    largeDepositExceptionHoldValue: number;
    largeDepositExceptionHoldValueSpecified: boolean;
    largeDepositExceptionHold: number | null;
    lastDayAvailableValue: number;
    lastDayAvailableValueSpecified: boolean;
    lastDayAvailable: number | null;
    localAggrgtExcpHoldDaysValue: number;
    localAggrgtExcpHoldDaysValueSpecified: boolean;
    localAggrgtExcpHoldDays: number | null;
    localExceptionHoldDaysValue: number;
    localExceptionHoldDaysValueSpecified: boolean;
    localExceptionHoldDays: number | null;
    localHoldDaysValue: number;
    localHoldDaysValueSpecified: boolean;
    localHoldDays: number | null;
    maxHoldCalendarDaysValue: number;
    maxHoldCalendarDaysValueSpecified: boolean;
    maxHoldCalendarDays: number | null;
    newAccountHoldDaysValue: number;
    newAccountHoldDaysValueSpecified: boolean;
    newAccountHoldDays: number | null;
    newAccountWarningCodeValue: number;
    newAccountWarningCodeValueSpecified: boolean;
    newAccountWarningCode: number | null;
    nextDayAvailExcpRsnList: BitMap;
    nextDayAvailableValue: number;
    nextDayAvailableValueSpecified: boolean;
    nextDayAvailable: number | null;
    nextDayDaysValue: number;
    nextDayDaysValueSpecified: boolean;
    nextDayDays: number | null;
    nonLocalAggrgtExcpHoldDayValue: number;
    nonLocalAggrgtExcpHoldDayValueSpecified: boolean;
    nonLocalAggrgtExcpHoldDay: number | null;
    nonLocalExceptionHoldDaysValue: number;
    nonLocalExceptionHoldDaysValueSpecified: boolean;
    nonLocalExceptionHoldDays: number | null;
    nonlocalHoldDaysValue: number;
    nonlocalHoldDaysValueSpecified: boolean;
    nonlocalHoldDays: number | null;
    repeatedNsfWarningCodeValue: number;
    repeatedNsfWarningCodeValueSpecified: boolean;
    repeatedNsfWarningCode: number | null;
    routingNumberHoldDays: RegCcRoutingNumberHoldDays_2[];
    routingNumberHoldDaysSpecified: boolean;
    routingNumberPrefix: RegCcRoutingNumberPrefix_2[];
    routingNumberPrefixSpecified: boolean;
    savingsPolicyValue: number;
    savingsPolicyValueSpecified: boolean;
    savingsPolicy: number | null;
    useMicrRtPrefixValue: boolean;
    useMicrRtPrefixValueSpecified: boolean;
    useMicrRtPrefix: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}