import { GlSubaccountFields } from "./glSubaccountFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface GlSubaccountSingleSelectableFields {
    includeAllGlSubaccountFieldsValue: boolean;
    includeAllGlSubaccountFieldsValueSpecified: boolean;
    includeAllGlSubaccountFields: boolean | null;
    glSubaccountFields: GlSubaccountFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
