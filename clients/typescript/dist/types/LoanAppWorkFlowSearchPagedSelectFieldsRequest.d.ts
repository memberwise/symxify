import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { LoanAppWorkFlowSingleSelectableFields } from "./loanAppWorkFlowSingleSelectableFields";
import { LoanAppWorkFlowSearchFilter } from "./loanAppWorkFlowSearchFilter";
import { VersionType } from "./versionType";
export interface LoanAppWorkFlowSearchPagedSelectFieldsRequest {
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: LoanAppWorkFlowSingleSelectableFields;
    searchFilter: LoanAppWorkFlowSearchFilter;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}
