import { OnlineNetFields } from "./onlineNetFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface OnlineNetSingleSelectableFields {
    includeAllOnlineNetFieldsValue: boolean;
    includeAllOnlineNetFieldsValueSpecified: boolean;
    includeAllOnlineNetFields: boolean | null;
    onlineNetFields: OnlineNetFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
