import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { VersionType } from "./versionType";

export interface DeleteShareNameRequest {
    accountNumber: string;
    shareId: string;
    shareNameLocator: number | null;
    credentials: CredentialsChoice;
    deviceInformation: DeviceInformation;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}