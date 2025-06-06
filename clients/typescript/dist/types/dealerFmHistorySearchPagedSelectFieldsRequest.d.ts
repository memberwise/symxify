import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { DealerFmHistorySingleSelectableFields } from "./dealerFmHistorySingleSelectableFields";
import { DealerFmHistorySearchFilter } from "./dealerFmHistorySearchFilter";
import { VersionType } from "./versionType";
export interface DealerFmHistorySearchPagedSelectFieldsRequest {
    dealerNumber: string;
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: DealerFmHistorySingleSelectableFields;
    searchFilter: DealerFmHistorySearchFilter;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}
