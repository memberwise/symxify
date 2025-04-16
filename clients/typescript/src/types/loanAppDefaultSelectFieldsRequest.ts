import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { LoanAppDefaultSingleSelectableFields } from "./loanAppDefaultSingleSelectableFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface LoanAppDefaultSelectFieldsRequest {
    loanAppDefaultApplicationTypeValue: number;
    loanAppDefaultApplicationTypeValueSpecified: boolean;
    loanAppDefaultApplicationType: number | null;
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    selectableFields: LoanAppDefaultSingleSelectableFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
    branchIdValue: number;
    branchIdValueSpecified: boolean;
    branchId: number | null;
}