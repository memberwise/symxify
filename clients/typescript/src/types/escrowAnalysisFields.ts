import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface EscrowAnalysisFields {
    analysisPastDueExceptionsValue: boolean;
    analysisPastDueExceptionsValueSpecified: boolean;
    analysisPastDueExceptions: boolean | null;
    deficiencyGe1EscrwPayMthdValue: boolean;
    deficiencyGe1EscrwPayMthdValueSpecified: boolean;
    deficiencyGe1EscrwPayMthd: boolean | null;
    deficiencyGeAmount: number[];
    deficiencyGeAmountSpecified: boolean;
    deficiencyGeNbrOfMonths: number[];
    deficiencyGeNbrOfMonthsSpecified: boolean;
    deficiencyLt1EscrwPayMthdValue: boolean;
    deficiencyLt1EscrwPayMthdValueSpecified: boolean;
    deficiencyLt1EscrwPayMthd: boolean | null;
    deficiencyLtAmount: number[];
    deficiencyLtAmountSpecified: boolean;
    deficiencyLtNbrOfMonths: number[];
    deficiencyLtNbrOfMonthsSpecified: boolean;
    escrowOverageMinDollarAmtValue: boolean;
    escrowOverageMinDollarAmtValueSpecified: boolean;
    escrowOverageMinDollarAmt: boolean | null;
    escrowOverageMinPercentageValue: boolean;
    escrowOverageMinPercentageValueSpecified: boolean;
    escrowOverageMinPercentage: boolean | null;
    escrowOverageProcessingMthdValue: boolean;
    escrowOverageProcessingMthdValueSpecified: boolean;
    escrowOverageProcessingMthd: boolean | null;
    newPaymentRoundingValue: boolean;
    newPaymentRoundingValueSpecified: boolean;
    newPaymentRounding: boolean | null;
    paymentChangeThresholdValue: boolean;
    paymentChangeThresholdValueSpecified: boolean;
    paymentChangeThreshold: boolean | null;
    shortageGe1EscrowPayMethdValue: boolean;
    shortageGe1EscrowPayMethdValueSpecified: boolean;
    shortageGe1EscrowPayMethd: boolean | null;
    shortageGeAmount: number[];
    shortageGeAmountSpecified: boolean;
    shortageGeNbrOfMonths: number[];
    shortageGeNbrOfMonthsSpecified: boolean;
    shortageLt1EscrowPayMethdValue: boolean;
    shortageLt1EscrowPayMethdValueSpecified: boolean;
    shortageLt1EscrowPayMethd: boolean | null;
    shortageLtAmount: number[];
    shortageLtAmountSpecified: boolean;
    shortageLtNbrOfMonths: number[];
    shortageLtNbrOfMonthsSpecified: boolean;
    warningCodeListValue: boolean;
    warningCodeListValueSpecified: boolean;
    warningCodeList: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}