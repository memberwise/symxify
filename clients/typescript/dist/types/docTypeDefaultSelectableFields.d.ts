import { DocTypeDefaultFields } from "./docTypeDefaultFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface DocTypeDefaultSelectableFields {
    includeAllDocTypeDefaultFieldsValue: boolean;
    includeAllDocTypeDefaultFieldsValueSpecified: boolean;
    includeAllDocTypeDefaultFields: boolean | null;
    docTypeDefaultFields: DocTypeDefaultFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
