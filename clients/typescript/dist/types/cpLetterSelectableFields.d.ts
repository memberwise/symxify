import { CpLetterFields } from "./cpLetterFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface CpLetterSelectableFields {
    includeAllCpLetterFieldsValue: boolean;
    includeAllCpLetterFieldsValueSpecified: boolean;
    includeAllCpLetterFields: boolean | null;
    cpLetterFields: CpLetterFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
