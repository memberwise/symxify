import { GlAccountBudget_2 } from "./glAccountBudget_2";
import { GlAccountHistoricalBalance_2 } from "./glAccountHistoricalBalance_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface GlAccount_2 {
    balNextGlMonthValue: number;
    balNextGlMonthValueSpecified: boolean;
    balNextGlMonth: number | null;
    balanceValue: number;
    balanceValueSpecified: boolean;
    balance: number | null;
    balanceLastYearValue: number;
    balanceLastYearValueSpecified: boolean;
    balanceLastYear: number | null;
    balanceNextPeriodValue: number;
    balanceNextPeriodValueSpecified: boolean;
    balanceNextPeriod: number | null;
    balanceSheetColumnValue: number;
    balanceSheetColumnValueSpecified: boolean;
    balanceSheetColumn: number | null;
    balanceYtdValue: number;
    balanceYtdValueSpecified: boolean;
    balanceYtd: number | null;
    blankLineCodeValue: number;
    blankLineCodeValueSpecified: boolean;
    blankLineCode: number | null;
    branch: string;
    budget: GlAccountBudget_2[];
    budgetSpecified: boolean;
    commentCodeValue: number;
    commentCodeValueSpecified: boolean;
    commentCode: number | null;
    dcRestrictionLevelValue: number;
    dcRestrictionLevelValueSpecified: boolean;
    dcRestrictionLevel: number | null;
    distributionCodeValue: number;
    distributionCodeValueSpecified: boolean;
    distributionCode: number | null;
    fmLastPurgeDateValue: string | null;
    fmLastPurgeDateValueSpecified: boolean;
    fmLastPurgeDate: string | null;
    fmLevelValue: number;
    fmLevelValueSpecified: boolean;
    fmLevel: number | null;
    formatTypeValue: number;
    formatTypeValueSpecified: boolean;
    formatType: number | null;
    historicalBalance: GlAccountHistoricalBalance_2[];
    historicalBalanceSpecified: boolean;
    indentationCodeValue: number;
    indentationCodeValueSpecified: boolean;
    indentationCode: number | null;
    iqLevelValue: number;
    iqLevelValueSpecified: boolean;
    iqLevel: number | null;
    lastFmDateValue: string | null;
    lastFmDateValueSpecified: boolean;
    lastFmDate: string | null;
    lastPurgeDateValue: string | null;
    lastPurgeDateValueSpecified: boolean;
    lastPurgeDate: string | null;
    lastTranDateValue: string | null;
    lastTranDateValueSpecified: boolean;
    lastTranDate: string | null;
    lookup: string;
    name: string;
    number: string;
    openCodeValue: number;
    openCodeValueSpecified: boolean;
    openCode: number | null;
    printingCodeValue: number;
    printingCodeValueSpecified: boolean;
    printingCode: number | null;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    restrictionLevelValue: number;
    restrictionLevelValueSpecified: boolean;
    restrictionLevel: number | null;
    subTypeValue: number;
    subTypeValueSpecified: boolean;
    subType: number | null;
    suffix: string;
    totalGlBudgetValue: number;
    totalGlBudgetValueSpecified: boolean;
    totalGlBudget: number | null;
    totalLevelValue: number;
    totalLevelValueSpecified: boolean;
    totalLevel: number | null;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    underscoreCodeValue: number;
    underscoreCodeValueSpecified: boolean;
    underscoreCode: number | null;
    usageTypeValue: number;
    usageTypeValueSpecified: boolean;
    usageType: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}