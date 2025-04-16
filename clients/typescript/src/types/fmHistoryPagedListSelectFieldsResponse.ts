import { FmHistory } from "./fmHistory";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface FmHistoryPagedListSelectFieldsResponse {
    fmHistory: FmHistory[];
    fmHistorySpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}