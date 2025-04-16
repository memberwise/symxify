import { RegCc } from "./regCc";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface RegCcSearchPagedSelectFieldsResponse {
    regCc: RegCc[];
    regCcSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
