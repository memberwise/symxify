import { AnalysisPlanFields } from "./analysisPlanFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface AnalysisPlanSelectableFields {
    includeAllAnalysisPlanFieldsValue: boolean;
    includeAllAnalysisPlanFieldsValueSpecified: boolean;
    includeAllAnalysisPlanFields: boolean | null;
    analysisPlanFields: AnalysisPlanFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
