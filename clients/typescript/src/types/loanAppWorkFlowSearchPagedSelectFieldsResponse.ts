import { LoanAppWorkFlow } from "./loanAppWorkFlow";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface LoanAppWorkFlowSearchPagedSelectFieldsResponse {
    loanAppWorkFlow: LoanAppWorkFlow[];
    loanAppWorkFlowSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}