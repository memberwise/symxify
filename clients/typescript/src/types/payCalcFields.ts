import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface PayCalcFields {
    balanceCutoff: number[];
    balanceCutoffSpecified: boolean;
    balanceIncrementValue: boolean;
    balanceIncrementValueSpecified: boolean;
    balanceIncrement: boolean | null;
    balanceIncrementRoundingValue: boolean;
    balanceIncrementRoundingValueSpecified: boolean;
    balanceIncrementRounding: boolean | null;
    definedCodeValue: boolean;
    definedCodeValueSpecified: boolean;
    definedCode: boolean | null;
    descriptionValue: boolean;
    descriptionValueSpecified: boolean;
    description: boolean | null;
    dueGraceDaysValue: boolean;
    dueGraceDaysValueSpecified: boolean;
    dueGraceDays: boolean | null;
    intRateCutoff: number[];
    intRateCutoffSpecified: boolean;
    interestAdjPercentValue: boolean;
    interestAdjPercentValueSpecified: boolean;
    interestAdjPercent: boolean | null;
    lgDestnPmtCalcSetCodeValue: boolean;
    lgDestnPmtCalcSetCodeValueSpecified: boolean;
    lgDestnPmtCalcSetCode: boolean | null;
    lgSourcePmtCalcSetCodeValue: boolean;
    lgSourcePmtCalcSetCodeValueSpecified: boolean;
    lgSourcePmtCalcSetCode: boolean | null;
    payment10Value: boolean;
    payment10ValueSpecified: boolean;
    payment10: boolean | null;
    payment14: number[];
    payment14Specified: boolean;
    paymentCalculationFormulaValue: boolean;
    paymentCalculationFormulaValueSpecified: boolean;
    paymentCalculationFormula: boolean | null;
    paymentCalculationSetCodeValue: boolean;
    paymentCalculationSetCodeValueSpecified: boolean;
    paymentCalculationSetCode: boolean | null;
    paymentCalculationTypeValue: boolean;
    paymentCalculationTypeValueSpecified: boolean;
    paymentCalculationType: boolean | null;
    paymentFrequencyAdjustmentValue: boolean;
    paymentFrequencyAdjustmentValueSpecified: boolean;
    paymentFrequencyAdjustment: boolean | null;
    paymentMinimumValue: boolean;
    paymentMinimumValueSpecified: boolean;
    paymentMinimum: boolean | null;
    paymentPercent15: number[];
    paymentPercent15Specified: boolean;
    paymentPercent2Value: boolean;
    paymentPercent2ValueSpecified: boolean;
    paymentPercent2: boolean | null;
    payoffMonths: number[];
    payoffMonthsSpecified: boolean;
    roundPaymentUptoMultipleValue: boolean;
    roundPaymentUptoMultipleValueSpecified: boolean;
    roundPaymentUptoMultiple: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}