import { CpWorkCardNoteList } from "./cpWorkCardNoteList";
import { CpWorkCardTrackingList } from "./cpWorkCardTrackingList";
import { CpWorkCardSecCollectorId } from "./cpWorkCardSecCollectorId";
import { CpWorkCardSecPriority } from "./cpWorkCardSecPriority";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface CpWorkCard {
    activeValue: number;
    activeValueSpecified: boolean;
    active: number | null;
    closeDateValue: string;
    closeDateValueSpecified: boolean;
    closeDate: string | null;
    cpWorkCardNoteList: CpWorkCardNoteList;
    cpWorkCardTrackingList: CpWorkCardTrackingList;
    fmLastDateValue: string;
    fmLastDateValueSpecified: boolean;
    fmLastDate: string | null;
    lastCollectorIdValue: number;
    lastCollectorIdValueSpecified: boolean;
    lastCollectorId: number | null;
    lastWorkDateValue: string;
    lastWorkDateValueSpecified: boolean;
    lastWorkDate: string | null;
    lastWorktimeValue: number;
    lastWorktimeValueSpecified: boolean;
    lastWorktime: number | null;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    nextWorkDateValue: string;
    nextWorkDateValueSpecified: boolean;
    nextWorkDate: string | null;
    notePurgeDateValue: string;
    notePurgeDateValueSpecified: boolean;
    notePurgeDate: string | null;
    priority: string;
    recordChangeDateValue: string;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    secCollectorId: CpWorkCardSecCollectorId[];
    secCollectorIdSpecified: boolean;
    secPriority: CpWorkCardSecPriority[];
    secPrioritySpecified: boolean;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}