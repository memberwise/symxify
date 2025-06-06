import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { ExternalAccountSingleSelectableFields } from "./externalAccountSingleSelectableFields";
import { ExternalAccountSearchFilter } from "./externalAccountSearchFilter";
import { VersionType } from "./versionType";

export interface ExternalAccountSearchPagedSelectFieldsRequest {
    accountNumber: string;
    credentials: CredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: ExternalAccountSingleSelectableFields;
    searchFilter: ExternalAccountSearchFilter;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}