import { DealerNoteFields } from "./dealerNoteFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface DealerNoteSingleSelectableFields {
    includeAllDealerNoteFieldsValue: boolean;
    includeAllDealerNoteFieldsValueSpecified: boolean;
    includeAllDealerNoteFields: boolean | null;
    dealerNoteFields: DealerNoteFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
