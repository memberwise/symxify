import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface DeleteLoanEscrowAnalysisRequest {
    accountNumber: string;
    loanId: string;
    loanEscrowAnalysisLocatorValue: number;
    loanEscrowAnalysisLocatorValueSpecified: boolean;
    loanEscrowAnalysisLocator: number | null;
    credentials: CredentialsChoice;
    deviceInformation: DeviceInformation;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
    branchIdValue: number;
    branchIdValueSpecified: boolean;
    branchId: number | null;
}