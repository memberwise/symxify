import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { LoanLnSegmentBillingSingleSelectableFields } from "./loanLnSegmentBillingSingleSelectableFields";
import { LoanLnSegmentBillingSearchFilter } from "./loanLnSegmentBillingSearchFilter";
import { VersionType } from "./versionType";

export interface LoanLnSegmentBillingSearchPagedSelectFieldsRequest {
    accountNumber: string;
    loanId: string;
    loanLnSegmentId: string;
    credentials: CredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: LoanLnSegmentBillingSingleSelectableFields;
    searchFilter: LoanLnSegmentBillingSearchFilter;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}