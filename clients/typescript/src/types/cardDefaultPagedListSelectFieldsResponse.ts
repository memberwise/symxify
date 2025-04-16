import { CardDefault } from "./cardDefault";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface CardDefaultPagedListSelectFieldsResponse {
    cardDefault: CardDefault[];
    cardDefaultSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}