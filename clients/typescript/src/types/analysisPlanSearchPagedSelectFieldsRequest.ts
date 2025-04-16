import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { AnalysisPlanSingleSelectableFields } from "./analysisPlanSingleSelectableFields";
import { AnalysisPlanSearchFilter } from "./analysisPlanSearchFilter";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface AnalysisPlanSearchPagedSelectFieldsRequest {
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: AnalysisPlanSingleSelectableFields;
    searchFilter: AnalysisPlanSearchFilter;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
    branchIdValue: number;
    branchIdValueSpecified: boolean;
    branchId: number | null;
}