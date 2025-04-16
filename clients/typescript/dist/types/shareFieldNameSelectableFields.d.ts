import { ShareFieldNameFields } from "./shareFieldNameFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface ShareFieldNameSelectableFields {
    includeAllShareFieldNameFieldsValue: boolean;
    includeAllShareFieldNameFieldsValueSpecified: boolean;
    includeAllShareFieldNameFields: boolean | null;
    shareFieldNameFields: ShareFieldNameFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
