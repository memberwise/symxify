import { DocExcpNotice } from "./docExcpNotice";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface DocExcpNoticePagedListSelectFieldsResponse {
    docExcpNotice: DocExcpNotice[];
    docExcpNoticeSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
