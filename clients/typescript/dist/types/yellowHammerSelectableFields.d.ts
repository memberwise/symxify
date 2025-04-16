import { YellowHammerFields } from "./yellowHammerFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface YellowHammerSelectableFields {
    includeAllYellowHammerFieldsValue: boolean;
    includeAllYellowHammerFieldsValueSpecified: boolean;
    includeAllYellowHammerFields: boolean | null;
    yellowHammerFields: YellowHammerFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
