import { WdFeeFields } from "./wdFeeFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface WdFeeSingleSelectableFields {
    includeAllWdFeeFieldsValue: boolean;
    includeAllWdFeeFieldsValueSpecified: boolean;
    includeAllWdFeeFields: boolean | null;
    wdFeeFields: WdFeeFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
