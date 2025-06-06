import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { SecFieldSingleSelectableFields } from "./secFieldSingleSelectableFields";
import { SecFieldSearchFilter } from "./secFieldSearchFilter";
import { VersionType } from "./versionType";

export interface SecFieldSearchPagedSelectFieldsRequest {
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: SecFieldSingleSelectableFields;
    searchFilter: SecFieldSearchFilter;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}