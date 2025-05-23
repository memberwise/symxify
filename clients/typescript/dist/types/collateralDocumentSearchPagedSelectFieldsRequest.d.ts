import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { CollateralDocumentSingleSelectableFields } from "./collateralDocumentSingleSelectableFields";
import { CollateralDocumentSearchFilter } from "./collateralDocumentSearchFilter";
import { VersionType } from "./versionType";
export interface CollateralDocumentSearchPagedSelectFieldsRequest {
    collateralNumber: string;
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: CollateralDocumentSingleSelectableFields;
    searchFilter: CollateralDocumentSearchFilter;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}
