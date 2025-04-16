import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { StockSingleSelectableFields } from "./stockSingleSelectableFields";
import { StockSearchFilter } from "./stockSearchFilter";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface StockSearchPagedSelectFieldsRequest {
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: StockSingleSelectableFields;
    searchFilter: StockSearchFilter;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
    branchIdValue: number;
    branchIdValueSpecified: boolean;
    branchId: number | null;
}