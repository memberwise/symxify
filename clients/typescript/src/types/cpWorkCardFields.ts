import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface CpWorkCardFields {
    activeValue: boolean;
    activeValueSpecified: boolean;
    active: boolean | null;
    closeDateValue: boolean;
    closeDateValueSpecified: boolean;
    closeDate: boolean | null;
    fmLastDateValue: boolean;
    fmLastDateValueSpecified: boolean;
    fmLastDate: boolean | null;
    lastCollectorIdValue: boolean;
    lastCollectorIdValueSpecified: boolean;
    lastCollectorId: boolean | null;
    lastWorkDateValue: boolean;
    lastWorkDateValueSpecified: boolean;
    lastWorkDate: boolean | null;
    lastWorktimeValue: boolean;
    lastWorktimeValueSpecified: boolean;
    lastWorktime: boolean | null;
    locatorValue: boolean;
    locatorValueSpecified: boolean;
    locator: boolean | null;
    nextWorkDateValue: boolean;
    nextWorkDateValueSpecified: boolean;
    nextWorkDate: boolean | null;
    notePurgeDateValue: boolean;
    notePurgeDateValueSpecified: boolean;
    notePurgeDate: boolean | null;
    priorityValue: boolean;
    priorityValueSpecified: boolean;
    priority: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    secCollectorId: number[];
    secCollectorIdSpecified: boolean;
    secPriority: number[];
    secPrioritySpecified: boolean;
    typeValue: boolean;
    typeValueSpecified: boolean;
    type: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}