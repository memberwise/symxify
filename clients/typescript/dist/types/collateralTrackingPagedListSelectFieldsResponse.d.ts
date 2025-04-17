import { CollateralTracking } from "./collateralTracking";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface CollateralTrackingPagedListSelectFieldsResponse {
    collateralTracking: CollateralTracking[];
    collateralTrackingSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
