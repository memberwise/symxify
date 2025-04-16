import { Eft } from "./eft";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface EftSelectFieldsResponse {
    eft: Eft;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
