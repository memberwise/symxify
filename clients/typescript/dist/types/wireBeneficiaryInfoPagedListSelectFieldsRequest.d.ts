import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { WireBeneficiaryInfoSingleSelectableFields } from "./wireBeneficiaryInfoSingleSelectableFields";
import { VersionType } from "./versionType";
export interface WireBeneficiaryInfoPagedListSelectFieldsRequest {
    wireSequenceNumber: number | null;
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: WireBeneficiaryInfoSingleSelectableFields;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}
