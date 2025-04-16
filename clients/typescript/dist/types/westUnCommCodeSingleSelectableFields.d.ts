import { WestUnCommCodeFields } from "./westUnCommCodeFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface WestUnCommCodeSingleSelectableFields {
    includeAllWestUnCommCodeFieldsValue: boolean;
    includeAllWestUnCommCodeFieldsValueSpecified: boolean;
    includeAllWestUnCommCodeFields: boolean | null;
    westUnCommCodeFields: WestUnCommCodeFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
