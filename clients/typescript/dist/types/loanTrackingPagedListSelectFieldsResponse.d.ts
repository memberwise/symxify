import { LoanTracking } from "./loanTracking";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface LoanTrackingPagedListSelectFieldsResponse {
    loanTracking: LoanTracking[];
    loanTrackingSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
