import { ExcpAddInfoFields } from "./excpAddInfoFields";
import { VersionType } from "./versionType";
export interface ExcpAddInfoSingleSelectableFields {
    includeAllExcpAddInfoFields: boolean | null;
    excpAddInfoFields: ExcpAddInfoFields;
    version1: VersionType;
}
