import { LateChg } from "./lateChg";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface LateChgPagedListSelectFieldsResponse {
    lateChg: LateChg[];
    lateChgSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}