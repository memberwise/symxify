import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { LoanNoteSingleSelectableFields } from "./loanNoteSingleSelectableFields";
import { VersionType } from "./versionType";

export interface LoanNotePagedListSelectFieldsRequest {
    accountNumber: string;
    loanId: string;
    credentials: CredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: LoanNoteSingleSelectableFields;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}