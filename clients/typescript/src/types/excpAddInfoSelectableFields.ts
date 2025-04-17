import { ExcpAddInfoFields } from "./excpAddInfoFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface ExcpAddInfoSelectableFields {
    includeAllExcpAddInfoFieldsValue: boolean;
    includeAllExcpAddInfoFieldsValueSpecified: boolean;
    includeAllExcpAddInfoFields: boolean | null;
    excpAddInfoFields: ExcpAddInfoFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}