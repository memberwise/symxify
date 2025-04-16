import { SycClientFields } from "./sycClientFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface SycClientSelectableFields {
    includeAllSycClientFieldsValue: boolean;
    includeAllSycClientFieldsValueSpecified: boolean;
    includeAllSycClientFields: boolean | null;
    sycClientFields: SycClientFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
