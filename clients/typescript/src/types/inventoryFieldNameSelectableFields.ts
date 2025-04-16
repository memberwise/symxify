import { InventoryFieldNameFields } from "./inventoryFieldNameFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface InventoryFieldNameSelectableFields {
    includeAllInventoryFieldNameFieldsValue: boolean;
    includeAllInventoryFieldNameFieldsValueSpecified: boolean;
    includeAllInventoryFieldNameFields: boolean | null;
    inventoryFieldNameFields: InventoryFieldNameFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}