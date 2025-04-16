import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { CpWorkCardTrackingFields_2 } from "./cpWorkCardTrackingFields_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface UpdateCpWorkCardTrackingByIdRequest {
    accountNumber: string;
    cpWorkCardLocatorValue: number;
    cpWorkCardLocatorValueSpecified: boolean;
    cpWorkCardLocator: number | null;
    cpWorkCardTrackingLocatorValue: number;
    cpWorkCardTrackingLocatorValueSpecified: boolean;
    cpWorkCardTrackingLocator: number | null;
    credentials: CredentialsChoice;
    deviceInformation: DeviceInformation;
    cpWorkCardTrackingFields: CpWorkCardTrackingFields_2;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
    branchIdValue: number;
    branchIdValueSpecified: boolean;
    branchId: number | null;
}