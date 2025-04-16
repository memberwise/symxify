import { AccountDefaultFields } from "./accountDefaultFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface AccountDefaultSingleSelectableFields {
    includeAllAccountDefaultFieldsValue: boolean;
    includeAllAccountDefaultFieldsValueSpecified: boolean;
    includeAllAccountDefaultFields: boolean | null;
    accountDefaultFields: AccountDefaultFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}