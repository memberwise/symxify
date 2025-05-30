import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { DealerCommentSingleSelectableFields } from "./dealerCommentSingleSelectableFields";
import { DealerCommentSearchFilter } from "./dealerCommentSearchFilter";
import { VersionType } from "./versionType";
export interface DealerCommentSearchPagedSelectFieldsRequest {
    dealerNumber: string;
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: DealerCommentSingleSelectableFields;
    searchFilter: DealerCommentSearchFilter;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}
