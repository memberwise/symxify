import { LoanName } from "./loanName";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface LoanNamePagedListSelectFieldsResponse {
    loanName: LoanName[];
    loanNameSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
