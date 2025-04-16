import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface LateChg {
    addLateChargetoPmtValue: number;
    addLateChargetoPmtValueSpecified: boolean;
    addLateChargetoPmt: number | null;
    additionalFlatFeeValue: number;
    additionalFlatFeeValueSpecified: boolean;
    additionalFlatFee: number | null;
    includeEscrowAmountValue: number;
    includeEscrowAmountValueSpecified: boolean;
    includeEscrowAmount: number | null;
    lateChargeFormulaValue: number;
    lateChargeFormulaValueSpecified: boolean;
    lateChargeFormula: number | null;
    lateChargeGraceDaysValue: number;
    lateChargeGraceDaysValueSpecified: boolean;
    lateChargeGraceDays: number | null;
    lateChargeMaximumValue: number;
    lateChargeMaximumValueSpecified: boolean;
    lateChargeMaximum: number | null;
    lateChargeMinimumValue: number;
    lateChargeMinimumValueSpecified: boolean;
    lateChargeMinimum: number | null;
    lateChargeRateValue: number;
    lateChargeRateValueSpecified: boolean;
    lateChargeRate: number | null;
    lateChargeTypeValue: number;
    lateChargeTypeValueSpecified: boolean;
    lateChargeType: number | null;
    subformatValue: number;
    subformatValueSpecified: boolean;
    subformat: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}