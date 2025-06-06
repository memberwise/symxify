import { InstitutionFields } from "./institutionFields";
import { VersionType } from "./versionType";

export interface InstitutionSingleSelectableFields {
    includeAllInstitutionFields: boolean | null;
    institutionFields: InstitutionFields;
    version1: VersionType;
}