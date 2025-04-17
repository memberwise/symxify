import { DealerFields } from "./dealerFields";
import { DealerCommentSelectableFields } from "./dealerCommentSelectableFields";
import { DealerFmHistorySelectableFields } from "./dealerFmHistorySelectableFields";
import { DealerNoteSelectableFields } from "./dealerNoteSelectableFields";
import { DealerTrackingSelectableFields } from "./dealerTrackingSelectableFields";
import { ReservePlanSelectableFields } from "./reservePlanSelectableFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface DealerSelectableFields {
    includeAllDealerFieldsValue: boolean;
    includeAllDealerFieldsValueSpecified: boolean;
    includeAllDealerFields: boolean | null;
    dealerFields: DealerFields;
    dealerCommentSelectableFields: DealerCommentSelectableFields;
    dealerFmHistorySelectableFields: DealerFmHistorySelectableFields;
    dealerNoteSelectableFields: DealerNoteSelectableFields;
    dealerTrackingSelectableFields: DealerTrackingSelectableFields;
    reservePlanSelectableFields: ReservePlanSelectableFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}