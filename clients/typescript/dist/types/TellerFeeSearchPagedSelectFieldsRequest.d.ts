import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { TellerFeeSingleSelectableFields } from "./tellerFeeSingleSelectableFields";
import { TellerFeeSearchFilter } from "./tellerFeeSearchFilter";
import { VersionType } from "./versionType";
export interface TellerFeeSearchPagedSelectFieldsRequest {
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: TellerFeeSingleSelectableFields;
    searchFilter: TellerFeeSearchFilter;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}
