import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { LoanFieldNameSingleSelectableFields } from "./loanFieldNameSingleSelectableFields";
import { LoanFieldNameSearchFilter } from "./loanFieldNameSearchFilter";
import { VersionType } from "./versionType";

export interface LoanFieldNameSearchPagedSelectFieldsRequest {
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: LoanFieldNameSingleSelectableFields;
    searchFilter: LoanFieldNameSearchFilter;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}