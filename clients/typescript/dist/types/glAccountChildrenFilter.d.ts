import { GlAccountFmHistoryFilter } from "./glAccountFmHistoryFilter";
import { GlAccountTrackingFilter } from "./glAccountTrackingFilter";
import { GlHistoryFilter } from "./glHistoryFilter";
import { GlSubaccountFilter } from "./glSubaccountFilter";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface GlAccountChildrenFilter {
    glAccountFmHistoryFilter: GlAccountFmHistoryFilter;
    glAccountTrackingFilter: GlAccountTrackingFilter;
    glHistoryFilter: GlHistoryFilter;
    glSubaccountFilter: GlSubaccountFilter;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
