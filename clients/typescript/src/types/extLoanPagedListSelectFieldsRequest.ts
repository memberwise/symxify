import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { ExtLoanSingleSelectableFields } from "./extLoanSingleSelectableFields";
import { VersionType } from "./versionType";

export interface ExtLoanPagedListSelectFieldsRequest {
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: ExtLoanSingleSelectableFields;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}