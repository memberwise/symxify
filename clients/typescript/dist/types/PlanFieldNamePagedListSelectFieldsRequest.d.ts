import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { PlanFieldNameSingleSelectableFields } from "./planFieldNameSingleSelectableFields";
import { VersionType } from "./versionType";
export interface PlanFieldNamePagedListSelectFieldsRequest {
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: PlanFieldNameSingleSelectableFields;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}
