import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { LnSegmentDefaultSingleSelectableFields } from "./lnSegmentDefaultSingleSelectableFields";
import { VersionType } from "./versionType";
export interface LnSegmentDefaultPagedListSelectFieldsRequest {
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: LnSegmentDefaultSingleSelectableFields;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}
