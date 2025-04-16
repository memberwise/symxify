import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface CashOrderVendorFields {
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}