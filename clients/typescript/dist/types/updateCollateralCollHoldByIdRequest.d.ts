import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { CollateralCollHoldFields_2 } from "./collateralCollHoldFields_2";
import { VersionType } from "./versionType";
export interface UpdateCollateralCollHoldByIdRequest {
    collateralNumber: string;
    collateralCollHoldLocator: number | null;
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    collateralCollHoldFields: CollateralCollHoldFields_2;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}
