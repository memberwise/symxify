import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { AccountDefaultSingleSelectableFields } from "./accountDefaultSingleSelectableFields";
import { AccountDefaultSearchFilter } from "./accountDefaultSearchFilter";
import { VersionType } from "./versionType";
export interface AccountDefaultSearchPagedSelectFieldsRequest {
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: AccountDefaultSingleSelectableFields;
    searchFilter: AccountDefaultSearchFilter;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}
