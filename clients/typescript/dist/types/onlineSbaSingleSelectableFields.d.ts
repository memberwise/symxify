import { OnlineSbaFields } from "./onlineSbaFields";
import { VersionType } from "./versionType";
export interface OnlineSbaSingleSelectableFields {
    includeAllOnlineSbaFields: boolean | null;
    onlineSbaFields: OnlineSbaFields;
    version1: VersionType;
}
