import { DealerTracking } from "./dealerTracking";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface DealerTrackingSearchPagedSelectFieldsResponse {
    dealerTracking: DealerTracking[];
    dealerTrackingSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}