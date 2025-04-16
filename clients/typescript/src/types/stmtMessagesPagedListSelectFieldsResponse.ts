import { StmtMessages } from "./stmtMessages";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface StmtMessagesPagedListSelectFieldsResponse {
    stmtMessages: StmtMessages[];
    stmtMessagesSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}