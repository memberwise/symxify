import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { SecuritySingleSelectableFields } from "./securitySingleSelectableFields";
import { SecuritySearchFilter } from "./securitySearchFilter";
import { VersionType } from "./versionType";

export interface SecuritySearchPagedSelectFieldsRequest {
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: SecuritySingleSelectableFields;
    searchFilter: SecuritySearchFilter;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}