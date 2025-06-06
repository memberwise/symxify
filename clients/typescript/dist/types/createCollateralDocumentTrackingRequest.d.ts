import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { CollateralDocumentTrackingFields_2 } from "./collateralDocumentTrackingFields_2";
import { VersionType } from "./versionType";
export interface CreateCollateralDocumentTrackingRequest {
    collateralNumber: string;
    collateralDocumentLocator: number | null;
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    collateralDocumentTrackingFields: CollateralDocumentTrackingFields_2;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}
