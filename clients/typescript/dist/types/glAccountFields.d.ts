import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface GlAccountFields {
    balNextGlMonthValue: boolean;
    balNextGlMonthValueSpecified: boolean;
    balNextGlMonth: boolean | null;
    balanceValue: boolean;
    balanceValueSpecified: boolean;
    balance: boolean | null;
    balanceLastYearValue: boolean;
    balanceLastYearValueSpecified: boolean;
    balanceLastYear: boolean | null;
    balanceNextPeriodValue: boolean;
    balanceNextPeriodValueSpecified: boolean;
    balanceNextPeriod: boolean | null;
    balanceSheetColumnValue: boolean;
    balanceSheetColumnValueSpecified: boolean;
    balanceSheetColumn: boolean | null;
    balanceYtdValue: boolean;
    balanceYtdValueSpecified: boolean;
    balanceYtd: boolean | null;
    blankLineCodeValue: boolean;
    blankLineCodeValueSpecified: boolean;
    blankLineCode: boolean | null;
    branchValue: boolean;
    branchValueSpecified: boolean;
    branch: boolean | null;
    budget: number[];
    budgetSpecified: boolean;
    commentCodeValue: boolean;
    commentCodeValueSpecified: boolean;
    commentCode: boolean | null;
    dcRestrictionLevelValue: boolean;
    dcRestrictionLevelValueSpecified: boolean;
    dcRestrictionLevel: boolean | null;
    distributionCodeValue: boolean;
    distributionCodeValueSpecified: boolean;
    distributionCode: boolean | null;
    fmLastPurgeDateValue: boolean;
    fmLastPurgeDateValueSpecified: boolean;
    fmLastPurgeDate: boolean | null;
    fmLevelValue: boolean;
    fmLevelValueSpecified: boolean;
    fmLevel: boolean | null;
    formatTypeValue: boolean;
    formatTypeValueSpecified: boolean;
    formatType: boolean | null;
    historicalBalance: number[];
    historicalBalanceSpecified: boolean;
    indentationCodeValue: boolean;
    indentationCodeValueSpecified: boolean;
    indentationCode: boolean | null;
    iqLevelValue: boolean;
    iqLevelValueSpecified: boolean;
    iqLevel: boolean | null;
    lastFmDateValue: boolean;
    lastFmDateValueSpecified: boolean;
    lastFmDate: boolean | null;
    lastPurgeDateValue: boolean;
    lastPurgeDateValueSpecified: boolean;
    lastPurgeDate: boolean | null;
    lastTranDateValue: boolean;
    lastTranDateValueSpecified: boolean;
    lastTranDate: boolean | null;
    lookupValue: boolean;
    lookupValueSpecified: boolean;
    lookup: boolean | null;
    nameValue: boolean;
    nameValueSpecified: boolean;
    name: boolean | null;
    numberValue: boolean;
    numberValueSpecified: boolean;
    number: boolean | null;
    openCodeValue: boolean;
    openCodeValueSpecified: boolean;
    openCode: boolean | null;
    printingCodeValue: boolean;
    printingCodeValueSpecified: boolean;
    printingCode: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    restrictionLevelValue: boolean;
    restrictionLevelValueSpecified: boolean;
    restrictionLevel: boolean | null;
    subTypeValue: boolean;
    subTypeValueSpecified: boolean;
    subType: boolean | null;
    suffixValue: boolean;
    suffixValueSpecified: boolean;
    suffix: boolean | null;
    totalGlBudgetValue: boolean;
    totalGlBudgetValueSpecified: boolean;
    totalGlBudget: boolean | null;
    totalLevelValue: boolean;
    totalLevelValueSpecified: boolean;
    totalLevel: boolean | null;
    typeValue: boolean;
    typeValueSpecified: boolean;
    type: boolean | null;
    underscoreCodeValue: boolean;
    underscoreCodeValueSpecified: boolean;
    underscoreCode: boolean | null;
    usageTypeValue: boolean;
    usageTypeValueSpecified: boolean;
    usageType: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
