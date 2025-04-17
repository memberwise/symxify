import { CheckFmHistoryFields } from "./checkFmHistoryFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface CheckFmHistorySelectableFields {
    includeAllCheckFmHistoryFieldsValue: boolean;
    includeAllCheckFmHistoryFieldsValueSpecified: boolean;
    includeAllCheckFmHistoryFields: boolean | null;
    checkFmHistoryFields: CheckFmHistoryFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
