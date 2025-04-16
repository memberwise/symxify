import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface ShareHoldFields {
    achRecurringStopValue: boolean;
    achRecurringStopValueSpecified: boolean;
    achRecurringStop: boolean | null;
    amountValue: boolean;
    amountValueSpecified: boolean;
    amount: boolean | null;
    availableBalanceValue: boolean;
    availableBalanceValueSpecified: boolean;
    availableBalance: boolean | null;
    effectiveDateValue: boolean;
    effectiveDateValueSpecified: boolean;
    effectiveDate: boolean | null;
    expirationDateValue: boolean;
    expirationDateValueSpecified: boolean;
    expirationDate: boolean | null;
    expirationTimeValue: boolean;
    expirationTimeValueSpecified: boolean;
    expirationTime: boolean | null;
    feeCodeValue: boolean;
    feeCodeValueSpecified: boolean;
    feeCode: boolean | null;
    feeDescriptionValue: boolean;
    feeDescriptionValueSpecified: boolean;
    feeDescription: boolean | null;
    holdCreationDateValue: boolean;
    holdCreationDateValueSpecified: boolean;
    holdCreationDate: boolean | null;
    holdCreationTimeValue: boolean;
    holdCreationTimeValueSpecified: boolean;
    holdCreationTime: boolean | null;
    ledgerBalanceValue: boolean;
    ledgerBalanceValueSpecified: boolean;
    ledgerBalance: boolean | null;
    locatorValue: boolean;
    locatorValueSpecified: boolean;
    locator: boolean | null;
    matchDateValue: boolean;
    matchDateValueSpecified: boolean;
    matchDate: boolean | null;
    matchTimeValue: boolean;
    matchTimeValueSpecified: boolean;
    matchTime: boolean | null;
    memberBranchValue: boolean;
    memberBranchValueSpecified: boolean;
    memberBranch: boolean | null;
    payeeNameValue: boolean;
    payeeNameValueSpecified: boolean;
    payeeName: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    reference1Value: boolean;
    reference1ValueSpecified: boolean;
    reference1: boolean | null;
    reference2Value: boolean;
    reference2ValueSpecified: boolean;
    reference2: boolean | null;
    reference3Value: boolean;
    reference3ValueSpecified: boolean;
    reference3: boolean | null;
    reference4Value: boolean;
    reference4ValueSpecified: boolean;
    reference4: boolean | null;
    stopPayCodeValue: boolean;
    stopPayCodeValueSpecified: boolean;
    stopPayCode: boolean | null;
    transactionTypeValue: boolean;
    transactionTypeValueSpecified: boolean;
    transactionType: boolean | null;
    typeValue: boolean;
    typeValueSpecified: boolean;
    type: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
