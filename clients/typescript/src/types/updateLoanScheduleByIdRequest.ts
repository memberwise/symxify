import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { LoanScheduleFields_2 } from "./loanScheduleFields_2";
import { VersionType } from "./versionType";

export interface UpdateLoanScheduleByIdRequest {
    accountNumber: string;
    loanId: string;
    loanScheduleId: string;
    credentials: CredentialsChoice;
    deviceInformation: DeviceInformation;
    loanScheduleFields: LoanScheduleFields_2;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}