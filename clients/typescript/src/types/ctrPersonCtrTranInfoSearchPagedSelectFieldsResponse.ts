import { CtrPersonCtrTranInfo } from "./ctrPersonCtrTranInfo";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface CtrPersonCtrTranInfoSearchPagedSelectFieldsResponse {
    ctrPersonCtrTranInfo: CtrPersonCtrTranInfo[];
    ctrPersonCtrTranInfoSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}