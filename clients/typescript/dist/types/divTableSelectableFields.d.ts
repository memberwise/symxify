import { DivTableFields } from "./divTableFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface DivTableSelectableFields {
    includeAllDivTableFieldsValue: boolean;
    includeAllDivTableFieldsValueSpecified: boolean;
    includeAllDivTableFields: boolean | null;
    divTableFields: DivTableFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
