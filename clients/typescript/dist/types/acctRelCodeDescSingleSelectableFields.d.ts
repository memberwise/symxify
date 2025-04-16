import { AcctRelCodeDescFields } from "./acctRelCodeDescFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface AcctRelCodeDescSingleSelectableFields {
    includeAllAcctRelCodeDescFieldsValue: boolean;
    includeAllAcctRelCodeDescFieldsValueSpecified: boolean;
    includeAllAcctRelCodeDescFields: boolean | null;
    acctRelCodeDescFields: AcctRelCodeDescFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
