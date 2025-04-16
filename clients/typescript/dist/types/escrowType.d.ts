import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface EscrowType {
    adjustPaymentPortionValue: boolean;
    adjustPaymentPortionValueSpecified: boolean;
    adjustPaymentPortion: boolean | null;
    crEscDividendinPayoffValue: boolean;
    crEscDividendinPayoffValueSpecified: boolean;
    crEscDividendinPayoff: boolean | null;
    daysinAdvancetoPrintRptValue: number;
    daysinAdvancetoPrintRptValueSpecified: boolean;
    daysinAdvancetoPrintRpt: number | null;
    definedCodeValue: number;
    definedCodeValueSpecified: boolean;
    definedCode: number | null;
    description: string;
    escrowTypePropertyValue: number;
    escrowTypePropertyValueSpecified: boolean;
    escrowTypeProperty: number | null;
    includeEscrowBalinPayoffValue: number;
    includeEscrowBalinPayoffValueSpecified: boolean;
    includeEscrowBalinPayoff: number | null;
    includeinEscrowAnalysisValue: boolean;
    includeinEscrowAnalysisValueSpecified: boolean;
    includeinEscrowAnalysis: boolean | null;
    invoiceTypeValue: number;
    invoiceTypeValueSpecified: boolean;
    invoiceType: number | null;
    numberofCushionMonthsValue: number;
    numberofCushionMonthsValueSpecified: boolean;
    numberofCushionMonths: number | null;
    paymentTypeValue: number;
    paymentTypeValueSpecified: boolean;
    paymentType: number | null;
    statementDescription: string;
    transactionDescription: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
