import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { DealerNoteSingleSelectableFields } from "./dealerNoteSingleSelectableFields";
import { VersionType } from "./versionType";

export interface DealerNotePagedListSelectFieldsRequest {
    dealerNumber: string;
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: DealerNoteSingleSelectableFields;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}