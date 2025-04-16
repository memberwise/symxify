import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { IrsDistributionSingleSelectableFields } from "./irsDistributionSingleSelectableFields";
import { IrsDistributionSearchFilter } from "./irsDistributionSearchFilter";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface IrsDistributionSearchPagedSelectFieldsRequest {
    accountNumber: string;
    irsLocatorValue: number;
    irsLocatorValueSpecified: boolean;
    irsLocator: number | null;
    credentials: CredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: IrsDistributionSingleSelectableFields;
    searchFilter: IrsDistributionSearchFilter;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
    branchIdValue: number;
    branchIdValueSpecified: boolean;
    branchId: number | null;
}
