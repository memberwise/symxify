import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PledgeFields_2 } from "./pledgeFields_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface UpdatePledgeByIdRequest {
    accountNumber: string;
    pledgeLocatorValue: number;
    pledgeLocatorValueSpecified: boolean;
    pledgeLocator: number | null;
    credentials: CredentialsChoice;
    deviceInformation: DeviceInformation;
    pledgeFields: PledgeFields_2;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
    branchIdValue: number;
    branchIdValueSpecified: boolean;
    branchId: number | null;
}
