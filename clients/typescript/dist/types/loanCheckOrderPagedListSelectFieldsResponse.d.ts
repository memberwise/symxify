import { LoanCheckOrder } from "./loanCheckOrder";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface LoanCheckOrderPagedListSelectFieldsResponse {
    loanCheckOrder: LoanCheckOrder[];
    loanCheckOrderSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
