import { NameFields_2 } from "./nameFields_2";
import { PreferenceFields_2 } from "./preferenceFields_2";
import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { AccountFields_2 } from "./accountFields_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface CreateAccountRequest {
    nameFields: NameFields_2;
    preferenceFields: PreferenceFields_2;
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    accountFields: AccountFields_2;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
    branchIdValue: number;
    branchIdValueSpecified: boolean;
    branchId: number | null;
}
