import { LoanAppPrintApp } from "./loanAppPrintApp";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface LoanAppPrintAppSearchPagedSelectFieldsResponse {
    loanAppPrintApp: LoanAppPrintApp[];
    loanAppPrintAppSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
