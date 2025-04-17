import { Vendor } from "./vendor";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface VendorSelectFieldsFilterChildrenResponse {
    vendor: Vendor;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
