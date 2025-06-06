import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { LoanRateChangeSingleSelectableFields } from "./loanRateChangeSingleSelectableFields";
import { LoanRateChangeSearchFilter } from "./loanRateChangeSearchFilter";
import { VersionType } from "./versionType";

export interface LoanRateChangeSearchPagedSelectFieldsRequest {
    accountNumber: string;
    loanId: string;
    credentials: CredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: LoanRateChangeSingleSelectableFields;
    searchFilter: LoanRateChangeSearchFilter;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}