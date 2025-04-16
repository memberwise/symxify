import { DivTableBalanceCutoff } from "./divTableBalanceCutoff";
import { DivTableLrbGraceDays } from "./divTableLrbGraceDays";
import { DivTableMarginRate } from "./divTableMarginRate";
import { DivTableRate } from "./divTableRate";
import { DivTableRelCodeList } from "./divTableRelCodeList";
import { DivTableTable } from "./divTableTable";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface DivTable {
    balanceCutoff: DivTableBalanceCutoff[];
    balanceCutoffSpecified: boolean;
    collectedBalMaxHoldDaysValue: number;
    collectedBalMaxHoldDaysValueSpecified: boolean;
    collectedBalMaxHoldDays: number | null;
    compoundingValue: number;
    compoundingValueSpecified: boolean;
    compounding: number | null;
    definedCodeValue: number;
    definedCodeValueSpecified: boolean;
    definedCode: number | null;
    divIndexTableOptionValue: number;
    divIndexTableOptionValueSpecified: boolean;
    divIndexTableOption: number | null;
    fillInRateMethodValue: number;
    fillInRateMethodValueSpecified: boolean;
    fillInRateMethod: number | null;
    frequencyValue: number;
    frequencyValueSpecified: boolean;
    frequency: number | null;
    incrementValue: number;
    incrementValueSpecified: boolean;
    increment: number | null;
    lrbGraceDays: DivTableLrbGraceDays[];
    lrbGraceDaysSpecified: boolean;
    marginRate: DivTableMarginRate[];
    marginRateSpecified: boolean;
    methodValue: number;
    methodValueSpecified: boolean;
    method: number | null;
    minDailyBalanceValue: number;
    minDailyBalanceValueSpecified: boolean;
    minDailyBalance: number | null;
    minimumBalanceValue: number;
    minimumBalanceValueSpecified: boolean;
    minimumBalance: number | null;
    newAccountCodeValue: number;
    newAccountCodeValueSpecified: boolean;
    newAccountCode: number | null;
    paymentCodeValue: number;
    paymentCodeValueSpecified: boolean;
    paymentCode: number | null;
    postAverageBalanceCommentValue: boolean;
    postAverageBalanceCommentValueSpecified: boolean;
    postAverageBalanceComment: boolean | null;
    rate: DivTableRate[];
    rateSpecified: boolean;
    rateSelectionValue: number;
    rateSelectionValueSpecified: boolean;
    rateSelection: number | null;
    relCodeList: DivTableRelCodeList[];
    relCodeListSpecified: boolean;
    scheduleTypeValue: number;
    scheduleTypeValueSpecified: boolean;
    scheduleType: number | null;
    table: DivTableTable[];
    tableSpecified: boolean;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}