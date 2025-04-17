import { DealerCommentFields } from "./dealerCommentFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface DealerCommentSelectableFields {
    includeAllDealerCommentFieldsValue: boolean;
    includeAllDealerCommentFieldsValueSpecified: boolean;
    includeAllDealerCommentFields: boolean | null;
    dealerCommentFields: DealerCommentFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
