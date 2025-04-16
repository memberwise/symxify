import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { IrsSingleSelectableFields } from "./irsSingleSelectableFields";
import { IrsSearchFilter } from "./irsSearchFilter";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface IrsSearchPagedSelectFieldsRequest {
    accountNumber: string;
    credentials: CredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: IrsSingleSelectableFields;
    searchFilter: IrsSearchFilter;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
    branchIdValue: number;
    branchIdValueSpecified: boolean;
    branchId: number | null;
}
