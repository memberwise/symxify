import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { InstitutionSingleSelectableFields } from "./institutionSingleSelectableFields";
import { InstitutionSearchFilter } from "./institutionSearchFilter";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface InstitutionSearchPagedSelectFieldsRequest {
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: InstitutionSingleSelectableFields;
    searchFilter: InstitutionSearchFilter;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
    branchIdValue: number;
    branchIdValueSpecified: boolean;
    branchId: number | null;
}
