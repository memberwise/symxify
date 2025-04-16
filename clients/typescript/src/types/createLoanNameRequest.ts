import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { LoanNameFields_2 } from "./loanNameFields_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface CreateLoanNameRequest {
    accountNumber: string;
    loanId: string;
    credentials: CredentialsChoice;
    deviceInformation: DeviceInformation;
    loanNameFields: LoanNameFields_2;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
    branchIdValue: number;
    branchIdValueSpecified: boolean;
    branchId: number | null;
}