import { WireInCmtCodeFields } from "./wireInCmtCodeFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface WireInCmtCodeSelectableFields {
    includeAllWireInCmtCodeFieldsValue: boolean;
    includeAllWireInCmtCodeFieldsValueSpecified: boolean;
    includeAllWireInCmtCodeFields: boolean | null;
    wireInCmtCodeFields: WireInCmtCodeFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}