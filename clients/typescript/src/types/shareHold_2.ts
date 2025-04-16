import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface ShareHold_2 {
    achRecurringStopValue: number;
    achRecurringStopValueSpecified: boolean;
    achRecurringStop: number | null;
    amountValue: number;
    amountValueSpecified: boolean;
    amount: number | null;
    availableBalanceValue: number;
    availableBalanceValueSpecified: boolean;
    availableBalance: number | null;
    effectiveDateValue: string | null;
    effectiveDateValueSpecified: boolean;
    effectiveDate: string | null;
    expirationDateValue: string | null;
    expirationDateValueSpecified: boolean;
    expirationDate: string | null;
    expirationTimeValue: number;
    expirationTimeValueSpecified: boolean;
    expirationTime: number | null;
    feeCodeValue: number;
    feeCodeValueSpecified: boolean;
    feeCode: number | null;
    feeDescription: string;
    holdCreationDateValue: string | null;
    holdCreationDateValueSpecified: boolean;
    holdCreationDate: string | null;
    holdCreationTime: string;
    ledgerBalanceValue: number;
    ledgerBalanceValueSpecified: boolean;
    ledgerBalance: number | null;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    matchDateValue: string | null;
    matchDateValueSpecified: boolean;
    matchDate: string | null;
    matchTimeValue: number;
    matchTimeValueSpecified: boolean;
    matchTime: number | null;
    memberBranch: string;
    payeeName: string;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    reference1: string;
    reference2: string;
    reference3: string;
    reference4: string;
    stopPayCodeValue: number;
    stopPayCodeValueSpecified: boolean;
    stopPayCode: number | null;
    transactionTypeValue: number;
    transactionTypeValueSpecified: boolean;
    transactionType: number | null;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}