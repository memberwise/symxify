import { LoanEscrowFields } from "./loanEscrowFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface LoanEscrowSingleSelectableFields {
    includeAllLoanEscrowFieldsValue: boolean;
    includeAllLoanEscrowFieldsValueSpecified: boolean;
    includeAllLoanEscrowFields: boolean | null;
    loanEscrowFields: LoanEscrowFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}