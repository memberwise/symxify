import { Cdm } from "./cdm";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface CdmPagedListSelectFieldsResponse {
    cdm: Cdm[];
    cdmSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
