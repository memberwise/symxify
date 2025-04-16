import { OnlineMainFields } from "./onlineMainFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface OnlineMainSingleSelectableFields {
    includeAllOnlineMainFieldsValue: boolean;
    includeAllOnlineMainFieldsValueSpecified: boolean;
    includeAllOnlineMainFields: boolean | null;
    onlineMainFields: OnlineMainFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}