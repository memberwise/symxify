import { ExternalLoanNoteFields } from "./externalLoanNoteFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface ExternalLoanNoteSelectableFields {
    includeAllExternalLoanNoteFieldsValue: boolean;
    includeAllExternalLoanNoteFieldsValueSpecified: boolean;
    includeAllExternalLoanNoteFields: boolean | null;
    externalLoanNoteFields: ExternalLoanNoteFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
