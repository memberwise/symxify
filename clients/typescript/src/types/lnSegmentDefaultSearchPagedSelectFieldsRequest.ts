import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { LnSegmentDefaultSingleSelectableFields } from "./lnSegmentDefaultSingleSelectableFields";
import { LnSegmentDefaultSearchFilter } from "./lnSegmentDefaultSearchFilter";
import { VersionType } from "./versionType";

export interface LnSegmentDefaultSearchPagedSelectFieldsRequest {
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: LnSegmentDefaultSingleSelectableFields;
    searchFilter: LnSegmentDefaultSearchFilter;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}