import { ShareTransferFields } from "./shareTransferFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface ShareTransferSelectableFields {
    includeAllShareTransferFieldsValue: boolean;
    includeAllShareTransferFieldsValueSpecified: boolean;
    includeAllShareTransferFields: boolean | null;
    shareTransferFields: ShareTransferFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}