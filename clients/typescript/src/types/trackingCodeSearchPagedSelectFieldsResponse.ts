import { TrackingCode } from "./trackingCode";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface TrackingCodeSearchPagedSelectFieldsResponse {
    trackingCode: TrackingCode[];
    trackingCodeSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}