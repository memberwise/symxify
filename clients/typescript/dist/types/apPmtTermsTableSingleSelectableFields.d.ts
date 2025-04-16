import { ApPmtTermsTableFields } from "./apPmtTermsTableFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface ApPmtTermsTableSingleSelectableFields {
    includeAllApPmtTermsTableFieldsValue: boolean;
    includeAllApPmtTermsTableFieldsValueSpecified: boolean;
    includeAllApPmtTermsTableFields: boolean | null;
    apPmtTermsTableFields: ApPmtTermsTableFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
