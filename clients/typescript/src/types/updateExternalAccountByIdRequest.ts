import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { ExternalAccountFields_2 } from "./externalAccountFields_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface UpdateExternalAccountByIdRequest {
    accountNumber: string;
    externalAccountLocatorValue: number;
    externalAccountLocatorValueSpecified: boolean;
    externalAccountLocator: number | null;
    credentials: CredentialsChoice;
    deviceInformation: DeviceInformation;
    externalAccountFields: ExternalAccountFields_2;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
    branchIdValue: number;
    branchIdValueSpecified: boolean;
    branchId: number | null;
}