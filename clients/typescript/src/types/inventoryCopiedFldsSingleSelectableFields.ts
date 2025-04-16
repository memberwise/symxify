import { InventoryCopiedFldsFields } from "./inventoryCopiedFldsFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface InventoryCopiedFldsSingleSelectableFields {
    includeAllInventoryCopiedFldsFieldsValue: boolean;
    includeAllInventoryCopiedFldsFieldsValueSpecified: boolean;
    includeAllInventoryCopiedFldsFields: boolean | null;
    inventoryCopiedFldsFields: InventoryCopiedFldsFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}