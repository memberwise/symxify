import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface InventoryGeneralSearchFilter {
    query: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}