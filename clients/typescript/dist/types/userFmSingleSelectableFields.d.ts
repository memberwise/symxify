import { UserFmFields } from "./userFmFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface UserFmSingleSelectableFields {
    includeAllUserFmFieldsValue: boolean;
    includeAllUserFmFieldsValueSpecified: boolean;
    includeAllUserFmFields: boolean | null;
    userFmFields: UserFmFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
