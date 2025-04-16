import { InsType } from "./insType";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface InsTypeSelectFieldsResponse {
    insType: InsType;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
