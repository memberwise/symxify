import { CtrForeign } from "./ctrForeign";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface CtrForeignPagedListSelectFieldsResponse {
    ctrForeign: CtrForeign[];
    ctrForeignSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
