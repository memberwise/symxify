import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { ShareAnalysisPlanSingleSelectableFields } from "./shareAnalysisPlanSingleSelectableFields";
import { VersionType } from "./versionType";
export interface ShareAnalysisPlanPagedListSelectFieldsRequest {
    accountNumber: string;
    shareId: string;
    credentials: CredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: ShareAnalysisPlanSingleSelectableFields;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}
