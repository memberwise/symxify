import { PayCalcBalanceCutoff } from "./payCalcBalanceCutoff";
import { PayCalcIntRateCutoff } from "./payCalcIntRateCutoff";
import { PayCalcPayment14 } from "./payCalcPayment14";
import { PayCalcPaymentPercent15 } from "./payCalcPaymentPercent15";
import { PayCalcPayoffMonths } from "./payCalcPayoffMonths";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface PayCalc {
    balanceCutoff: PayCalcBalanceCutoff[];
    balanceCutoffSpecified: boolean;
    balanceIncrementValue: number;
    balanceIncrementValueSpecified: boolean;
    balanceIncrement: number | null;
    balanceIncrementRoundingValue: number;
    balanceIncrementRoundingValueSpecified: boolean;
    balanceIncrementRounding: number | null;
    definedCodeValue: number;
    definedCodeValueSpecified: boolean;
    definedCode: number | null;
    description: string;
    dueGraceDaysValue: number;
    dueGraceDaysValueSpecified: boolean;
    dueGraceDays: number | null;
    intRateCutoff: PayCalcIntRateCutoff[];
    intRateCutoffSpecified: boolean;
    interestAdjPercentValue: number;
    interestAdjPercentValueSpecified: boolean;
    interestAdjPercent: number | null;
    lgDestnPmtCalcSetCodeValue: number;
    lgDestnPmtCalcSetCodeValueSpecified: boolean;
    lgDestnPmtCalcSetCode: number | null;
    lgSourcePmtCalcSetCodeValue: number;
    lgSourcePmtCalcSetCodeValueSpecified: boolean;
    lgSourcePmtCalcSetCode: number | null;
    payment10Value: number;
    payment10ValueSpecified: boolean;
    payment10: number | null;
    payment14: PayCalcPayment14[];
    payment14Specified: boolean;
    paymentCalculationFormulaValue: number;
    paymentCalculationFormulaValueSpecified: boolean;
    paymentCalculationFormula: number | null;
    paymentCalculationSetCodeValue: number;
    paymentCalculationSetCodeValueSpecified: boolean;
    paymentCalculationSetCode: number | null;
    paymentCalculationTypeValue: number;
    paymentCalculationTypeValueSpecified: boolean;
    paymentCalculationType: number | null;
    paymentFrequencyAdjustmentValue: number;
    paymentFrequencyAdjustmentValueSpecified: boolean;
    paymentFrequencyAdjustment: number | null;
    paymentMinimumValue: number;
    paymentMinimumValueSpecified: boolean;
    paymentMinimum: number | null;
    paymentPercent15: PayCalcPaymentPercent15[];
    paymentPercent15Specified: boolean;
    paymentPercent2Value: number;
    paymentPercent2ValueSpecified: boolean;
    paymentPercent2: number | null;
    payoffMonths: PayCalcPayoffMonths[];
    payoffMonthsSpecified: boolean;
    roundPaymentUptoMultipleValue: number;
    roundPaymentUptoMultipleValueSpecified: boolean;
    roundPaymentUptoMultiple: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
