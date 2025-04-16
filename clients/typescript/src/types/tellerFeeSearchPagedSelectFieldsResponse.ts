import { TellerFee } from "./tellerFee";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface TellerFeeSearchPagedSelectFieldsResponse {
    tellerFee: TellerFee[];
    tellerFeeSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}