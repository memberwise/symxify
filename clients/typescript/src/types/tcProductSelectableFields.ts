import { TcProductFields } from "./tcProductFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface TcProductSelectableFields {
    includeAllTcProductFieldsValue: boolean;
    includeAllTcProductFieldsValueSpecified: boolean;
    includeAllTcProductFields: boolean | null;
    tcProductFields: TcProductFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}