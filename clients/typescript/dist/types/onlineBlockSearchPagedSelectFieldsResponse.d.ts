import { OnlineBlock } from "./onlineBlock";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface OnlineBlockSearchPagedSelectFieldsResponse {
    onlineBlock: OnlineBlock[];
    onlineBlockSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
