import { SymXInstance } from "./symXInstance";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface SymXInstanceSearchPagedSelectFieldsResponse {
    symXInstance: SymXInstance[];
    symXInstanceSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
