import { AcsServiceAction } from "./acsServiceAction";
import { AcsServiceActionCreateRecord } from "./acsServiceActionCreateRecord";
import { AcsServiceActionCreateText } from "./acsServiceActionCreateText";
import { AcsServiceActionCreateType } from "./acsServiceActionCreateType";
import { AcsServiceCompDataType } from "./acsServiceCompDataType";
import { AcsServiceCompareNum } from "./acsServiceCompareNum";
import { AcsServiceComparisonMethod } from "./acsServiceComparisonMethod";
import { AcsServiceComparisonValue } from "./acsServiceComparisonValue";
import { AcsServiceCriteria12 } from "./acsServiceCriteria12";
import { AcsServiceCriteriaOperator } from "./acsServiceCriteriaOperator";
import { AcsServiceMenuOption } from "./acsServiceMenuOption";
import { AcsServiceScript } from "./acsServiceScript";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface AcsService {
    acquireItems: string;
    acquireOptionValue: number;
    acquireOptionValueSpecified: boolean;
    acquireOption: number | null;
    acsServiceTypeValue: number;
    acsServiceTypeValueSpecified: boolean;
    acsServiceType: number | null;
    action: AcsServiceAction[];
    actionSpecified: boolean;
    actionCreateRecord: AcsServiceActionCreateRecord[];
    actionCreateRecordSpecified: boolean;
    actionCreateText: AcsServiceActionCreateText[];
    actionCreateTextSpecified: boolean;
    actionCreateType: AcsServiceActionCreateType[];
    actionCreateTypeSpecified: boolean;
    compDataType: AcsServiceCompDataType[];
    compDataTypeSpecified: boolean;
    compareNum: AcsServiceCompareNum[];
    compareNumSpecified: boolean;
    comparisonMethod: AcsServiceComparisonMethod[];
    comparisonMethodSpecified: boolean;
    comparisonValue: AcsServiceComparisonValue[];
    comparisonValueSpecified: boolean;
    consolidateMaxValue: number;
    consolidateMaxValueSpecified: boolean;
    consolidateMax: number | null;
    criteria12: AcsServiceCriteria12[];
    criteria12Specified: boolean;
    criteriaOperator: AcsServiceCriteriaOperator[];
    criteriaOperatorSpecified: boolean;
    description: string;
    excludeMatchValue: boolean;
    excludeMatchValueSpecified: boolean;
    excludeMatch: boolean | null;
    factsLetterfile: string;
    menuOption: AcsServiceMenuOption[];
    menuOptionSpecified: boolean;
    newLoanTypeValue: number;
    newLoanTypeValueSpecified: boolean;
    newLoanType: number | null;
    pointsValue: number;
    pointsValueSpecified: boolean;
    points: number | null;
    script: AcsServiceScript[];
    scriptSpecified: boolean;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}