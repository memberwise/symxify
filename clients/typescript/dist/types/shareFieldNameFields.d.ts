import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface ShareFieldNameFields {
    fieldValue: boolean;
    fieldValueSpecified: boolean;
    field: boolean | null;
    fieldNameValue: boolean;
    fieldNameValueSpecified: boolean;
    fieldName: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
