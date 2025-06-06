import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PledgeFields_2 } from "./pledgeFields_2";
import { VersionType } from "./versionType";

export interface CreatePledgeRequest {
    accountNumber: string;
    credentials: CredentialsChoice;
    deviceInformation: DeviceInformation;
    pledgeFields: PledgeFields_2;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}