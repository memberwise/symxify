import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { CollateralTypeSingleSelectableFields } from "./collateralTypeSingleSelectableFields";
import { CollateralTypeSearchFilter } from "./collateralTypeSearchFilter";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface CollateralTypeSearchPagedSelectFieldsRequest {
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: CollateralTypeSingleSelectableFields;
    searchFilter: CollateralTypeSearchFilter;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
    branchIdValue: number;
    branchIdValueSpecified: boolean;
    branchId: number | null;
}
