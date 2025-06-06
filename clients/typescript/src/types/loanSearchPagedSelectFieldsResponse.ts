import { Loan } from "./loan";
import { VersionType } from "./versionType";

export interface LoanSearchPagedSelectFieldsResponse {
    loan: Loan[];
    token: string;
    version1: VersionType;
    messageId: string;
}