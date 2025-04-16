import { PayCalc } from "./payCalc";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface PayCalcSearchPagedSelectFieldsResponse {
    payCalc: PayCalc[];
    payCalcSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}