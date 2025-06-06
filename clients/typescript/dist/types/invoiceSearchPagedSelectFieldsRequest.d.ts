import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { InvoiceSingleSelectableFields } from "./invoiceSingleSelectableFields";
import { InvoiceSearchFilter } from "./invoiceSearchFilter";
import { VersionType } from "./versionType";
export interface InvoiceSearchPagedSelectFieldsRequest {
    vendorNumber: string;
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: InvoiceSingleSelectableFields;
    searchFilter: InvoiceSearchFilter;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}
