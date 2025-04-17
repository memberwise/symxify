import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { WireOfacDetailsSingleSelectableFields } from "./wireOfacDetailsSingleSelectableFields";
import { WireOfacDetailsSearchFilter } from "./wireOfacDetailsSearchFilter";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface WireOfacDetailsSearchPagedSelectFieldsRequest {
    wireSequenceNumberValue: number;
    wireSequenceNumberValueSpecified: boolean;
    wireSequenceNumber: number | null;
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: WireOfacDetailsSingleSelectableFields;
    searchFilter: WireOfacDetailsSearchFilter;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
    branchIdValue: number;
    branchIdValueSpecified: boolean;
    branchId: number | null;
}
