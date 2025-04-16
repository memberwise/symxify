import { LoanAppLnSegment } from "./loanAppLnSegment";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface LoanAppLnSegmentSearchPagedSelectFieldsResponse {
    loanAppLnSegment: LoanAppLnSegment[];
    loanAppLnSegmentSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
