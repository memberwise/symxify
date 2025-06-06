import { EpisysDbExtractFields } from "./episysDbExtractFields";
import { VersionType } from "./versionType";

export interface EpisysDbExtractSingleSelectableFields {
    includeAllEpisysDbExtractFields: boolean | null;
    episysDbExtractFields: EpisysDbExtractFields;
    version1: VersionType;
}