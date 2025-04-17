import { CollateralDocument } from "./collateralDocument";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface CollateralDocumentSelectFieldsFilterChildrenResponse {
    collateralDocument: CollateralDocument;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}