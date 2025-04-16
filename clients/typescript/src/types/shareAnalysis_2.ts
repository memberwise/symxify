import { ShareAnalysisCounter_2 } from "./shareAnalysisCounter_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface ShareAnalysis_2 {
    cashAmtTotalValue: number;
    cashAmtTotalValueSpecified: boolean;
    cashAmtTotal: number | null;
    counter: ShareAnalysisCounter_2[];
    counterSpecified: boolean;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    planValue: number;
    planValueSpecified: boolean;
    plan: number | null;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    statementDateValue: string | null;
    statementDateValueSpecified: boolean;
    statementDate: string | null;
    statementGroupValue: number;
    statementGroupValueSpecified: boolean;
    statementGroup: number | null;
    statementPrevDateValue: string | null;
    statementPrevDateValueSpecified: boolean;
    statementPrevDate: string | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}