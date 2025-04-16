import { RegCcFields } from "./regCcFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface RegCcSelectableFields {
    includeAllRegCcFieldsValue: boolean;
    includeAllRegCcFieldsValueSpecified: boolean;
    includeAllRegCcFields: boolean | null;
    regCcFields: RegCcFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
