import { InsTable } from "./insTable";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface InsTableSearchPagedSelectFieldsResponse {
    insTable: InsTable[];
    insTableSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
