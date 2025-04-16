import { CollateralType } from "./collateralType";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface CollateralTypeSearchPagedSelectFieldsResponse {
    collateralType: CollateralType[];
    collateralTypeSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
