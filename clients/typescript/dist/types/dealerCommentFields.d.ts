import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface DealerCommentFields {
    commentValue: boolean;
    commentValueSpecified: boolean;
    comment: boolean | null;
    effectiveDateValue: boolean;
    effectiveDateValueSpecified: boolean;
    effectiveDate: boolean | null;
    expirationDateValue: boolean;
    expirationDateValueSpecified: boolean;
    expirationDate: boolean | null;
    locatorValue: boolean;
    locatorValueSpecified: boolean;
    locator: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    typeValue: boolean;
    typeValueSpecified: boolean;
    type: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
