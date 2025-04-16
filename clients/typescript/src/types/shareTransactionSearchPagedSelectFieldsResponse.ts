import { ShareTransaction } from "./shareTransaction";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface ShareTransactionSearchPagedSelectFieldsResponse {
    shareTransaction: ShareTransaction[];
    shareTransactionSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}