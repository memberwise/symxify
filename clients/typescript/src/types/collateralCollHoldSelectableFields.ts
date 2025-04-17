import { CollateralCollHoldFields } from "./collateralCollHoldFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface CollateralCollHoldSelectableFields {
    includeAllCollateralCollHoldFieldsValue: boolean;
    includeAllCollateralCollHoldFieldsValueSpecified: boolean;
    includeAllCollateralCollHoldFields: boolean | null;
    collateralCollHoldFields: CollateralCollHoldFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}