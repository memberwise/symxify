import { PlanDefaultFields } from "./planDefaultFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface PlanDefaultSingleSelectableFields {
    includeAllPlanDefaultFieldsValue: boolean;
    includeAllPlanDefaultFieldsValueSpecified: boolean;
    includeAllPlanDefaultFields: boolean | null;
    planDefaultFields: PlanDefaultFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}