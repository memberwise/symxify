import { PortfolioNoteFields } from "./portfolioNoteFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface PortfolioNoteSelectableFields {
    includeAllPortfolioNoteFieldsValue: boolean;
    includeAllPortfolioNoteFieldsValueSpecified: boolean;
    includeAllPortfolioNoteFields: boolean | null;
    portfolioNoteFields: PortfolioNoteFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
