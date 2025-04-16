import { LoanScheduleFields } from "./loanScheduleFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface LoanScheduleSingleSelectableFields {
    includeAllLoanScheduleFieldsValue: boolean;
    includeAllLoanScheduleFieldsValueSpecified: boolean;
    includeAllLoanScheduleFields: boolean | null;
    loanScheduleFields: LoanScheduleFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
