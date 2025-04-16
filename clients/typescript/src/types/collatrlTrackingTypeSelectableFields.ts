import { CollatrlTrackingTypeFields } from "./collatrlTrackingTypeFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface CollatrlTrackingTypeSelectableFields {
    includeAllCollatrlTrackingTypeFieldsValue: boolean;
    includeAllCollatrlTrackingTypeFieldsValueSpecified: boolean;
    includeAllCollatrlTrackingTypeFields: boolean | null;
    collatrlTrackingTypeFields: CollatrlTrackingTypeFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}