import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface DispenserAdjustType {
    glCodeValue: number;
    glCodeValueSpecified: boolean;
    glCode: number | null;
    srcGlCodeValue: number;
    srcGlCodeValueSpecified: boolean;
    srcGlCode: number | null;
    denominationValue: number;
    denominationValueSpecified: boolean;
    denomination: number | null;
    adjustAmountValue: number;
    adjustAmountValueSpecified: boolean;
    adjustAmount: number | null;
    replenishAmountValue: number;
    replenishAmountValueSpecified: boolean;
    replenishAmount: number | null;
    warnAmountValue: number;
    warnAmountValueSpecified: boolean;
    warnAmount: number | null;
    resetDispenserValue: boolean;
    resetDispenserValueSpecified: boolean;
    resetDispenser: boolean | null;
    dispenserIdValue: number;
    dispenserIdValueSpecified: boolean;
    dispenserId: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}