import { VersionType } from "./versionType";

export interface Comment {
    effectiveDate: string | null;
    expirationDate: string | null;
    locator: number | null;
    recordChangeDate: string | null;
    text: string;
    type: number | null;
    version1: VersionType;
}