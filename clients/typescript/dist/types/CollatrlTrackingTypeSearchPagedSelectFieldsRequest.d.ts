import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { CollatrlTrackingTypeSingleSelectableFields } from "./collatrlTrackingTypeSingleSelectableFields";
import { CollatrlTrackingTypeSearchFilter } from "./collatrlTrackingTypeSearchFilter";
import { VersionType } from "./versionType";
export interface CollatrlTrackingTypeSearchPagedSelectFieldsRequest {
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: CollatrlTrackingTypeSingleSelectableFields;
    searchFilter: CollatrlTrackingTypeSearchFilter;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}
