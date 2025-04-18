import { AccountDefaultCountLimit_2 } from "./accountDefaultCountLimit_2";
import { AccountDefaultLimit_2 } from "./accountDefaultLimit_2";
import { AccountDefaultPerItemLimit_2 } from "./accountDefaultPerItemLimit_2";
import { AccountDefaultWarningCode_2 } from "./accountDefaultWarningCode_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface AccountDefault_2 {
    acctTypeValue: number;
    acctTypeValueSpecified: boolean;
    acctType: number | null;
    cappedFeesAmountCapValue: number;
    cappedFeesAmountCapValueSpecified: boolean;
    cappedFeesAmountCap: number | null;
    cappedFeesCountCapValue: number;
    cappedFeesCountCapValueSpecified: boolean;
    cappedFeesCountCap: number | null;
    closeDateValue: string | null;
    closeDateValueSpecified: boolean;
    closeDate: string | null;
    commercialCodeValue: number;
    commercialCodeValueSpecified: boolean;
    commercialCode: number | null;
    countLimit: AccountDefaultCountLimit_2[];
    countLimitSpecified: boolean;
    eStmtEnableValue: number;
    eStmtEnableValueSpecified: boolean;
    eStmtEnable: number | null;
    eStmtNotifyValue: number;
    eStmtNotifyValueSpecified: boolean;
    eStmtNotify: number | null;
    enableFloatValue: number;
    enableFloatValueSpecified: boolean;
    enableFloat: number | null;
    headOfHouseholdValue: number;
    headOfHouseholdValueSpecified: boolean;
    headOfHousehold: number | null;
    krHoldBaseAmountValue: number;
    krHoldBaseAmountValueSpecified: boolean;
    krHoldBaseAmount: number | null;
    limit: AccountDefaultLimit_2[];
    limitSpecified: boolean;
    memberGroupValue: number;
    memberGroupValueSpecified: boolean;
    memberGroup: number | null;
    memberStatusValue: number;
    memberStatusValueSpecified: boolean;
    memberStatus: number | null;
    nonRegCcCheckHoldBaseAmtValue: number;
    nonRegCcCheckHoldBaseAmtValueSpecified: boolean;
    nonRegCcCheckHoldBaseAmt: number | null;
    perItemLimit: AccountDefaultPerItemLimit_2[];
    perItemLimitSpecified: boolean;
    proxyDateValue: string | null;
    proxyDateValueSpecified: boolean;
    proxyDate: string | null;
    reference: string;
    relationshipCodeValue: number;
    relationshipCodeValueSpecified: boolean;
    relationshipCode: number | null;
    relationshipOverrideValue: number;
    relationshipOverrideValueSpecified: boolean;
    relationshipOverride: number | null;
    relationshipOverrideEffDateValue: string | null;
    relationshipOverrideEffDateValueSpecified: boolean;
    relationshipOverrideEffDate: string | null;
    relationshipOverrideExpDateValue: string | null;
    relationshipOverrideExpDateValueSpecified: boolean;
    relationshipOverrideExpDate: string | null;
    restrictValue: number;
    restrictValueSpecified: boolean;
    restrict: number | null;
    stateReporting: string;
    statementMailCodeValue: number;
    statementMailCodeValueSpecified: boolean;
    statementMailCode: number | null;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    userAmount1Value: number;
    userAmount1ValueSpecified: boolean;
    userAmount1: number | null;
    userAmount2Value: number;
    userAmount2ValueSpecified: boolean;
    userAmount2: number | null;
    userChar1: string;
    userChar2: string;
    userChar3: string;
    userChar4: string;
    userDate1Value: string | null;
    userDate1ValueSpecified: boolean;
    userDate1: string | null;
    userDate2Value: string | null;
    userDate2ValueSpecified: boolean;
    userDate2: string | null;
    warningCode: AccountDefaultWarningCode_2[];
    warningCodeSpecified: boolean;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
