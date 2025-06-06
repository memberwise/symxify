import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { WireFields_2 } from "./wireFields_2";
import { VersionType } from "./versionType";
export interface UpdateWireByIdRequest {
    wireSequenceNumber: number | null;
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    wireFields: WireFields_2;
    version1: VersionType;
    messageId: string;
    branchId: number | null;
}
