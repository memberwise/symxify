import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { EftTransferSingleSelectableFields } from "./eftTransferSingleSelectableFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface EftTransferSelectFieldsRequest {
    accountNumber: string;
    eftLocatorValue: number;
    eftLocatorValueSpecified: boolean;
    eftLocator: number | null;
    eftTransferLocatorValue: number;
    eftTransferLocatorValueSpecified: boolean;
    eftTransferLocator: number | null;
    credentials: CredentialsChoice;
    deviceInformation: DeviceInformation;
    selectableFields: EftTransferSingleSelectableFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
    branchIdValue: number;
    branchIdValueSpecified: boolean;
    branchId: number | null;
}
