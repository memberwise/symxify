import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface DeleteEftNameRequest {
    accountNumber: string;
    eftLocatorValue: number;
    eftLocatorValueSpecified: boolean;
    eftLocator: number | null;
    eftNameLocatorValue: number;
    eftNameLocatorValueSpecified: boolean;
    eftNameLocator: number | null;
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