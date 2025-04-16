import { CardWiz } from "./cardWiz";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface CardWizSearchPagedSelectFieldsResponse {
    cardWiz: CardWiz[];
    cardWizSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}