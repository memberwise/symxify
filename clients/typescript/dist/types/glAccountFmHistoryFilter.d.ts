import { VersionType } from "./versionType";
export interface GlAccountFmHistoryFilter {
    startPostDate: string | null;
    endPostDate: string | null;
    query: string;
    version1: VersionType;
}
