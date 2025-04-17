import { GlAccountTrackingFields } from "./glAccountTrackingFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface GlAccountTrackingSelectableFields {
    includeAllGlAccountTrackingFieldsValue: boolean;
    includeAllGlAccountTrackingFieldsValueSpecified: boolean;
    includeAllGlAccountTrackingFields: boolean | null;
    glAccountTrackingFields: GlAccountTrackingFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}