import { SymXDeviceMapFields } from "./symXDeviceMapFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface SymXDeviceMapSingleSelectableFields {
    includeAllSymXDeviceMapFieldsValue: boolean;
    includeAllSymXDeviceMapFieldsValueSpecified: boolean;
    includeAllSymXDeviceMapFields: boolean | null;
    symXDeviceMapFields: SymXDeviceMapFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}