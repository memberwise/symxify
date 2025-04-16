import { AtmFields } from "./atmFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface AtmSelectableFields {
    includeAllAtmFieldsValue: boolean;
    includeAllAtmFieldsValueSpecified: boolean;
    includeAllAtmFields: boolean | null;
    atmFields: AtmFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
