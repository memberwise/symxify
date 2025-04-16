import { PrivGroupFields } from "./privGroupFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface PrivGroupSingleSelectableFields {
    includeAllPrivGroupFieldsValue: boolean;
    includeAllPrivGroupFieldsValueSpecified: boolean;
    includeAllPrivGroupFields: boolean | null;
    privGroupFields: PrivGroupFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
