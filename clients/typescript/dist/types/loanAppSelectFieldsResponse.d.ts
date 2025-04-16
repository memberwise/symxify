import { LoanApp } from "./loanApp";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface LoanAppSelectFieldsResponse {
    loanApp: LoanApp;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
