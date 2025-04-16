import { GlCode } from "./glCode";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface GlCodeSearchPagedSelectFieldsResponse {
    glCode: GlCode[];
    glCodeSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
