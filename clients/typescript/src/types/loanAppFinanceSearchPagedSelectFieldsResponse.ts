import { LoanAppFinance } from "./loanAppFinance";
import { VersionType } from "./versionType";

export interface LoanAppFinanceSearchPagedSelectFieldsResponse {
    loanAppFinance: LoanAppFinance[];
    token: string;
    version1: VersionType;
    messageId: string;
}