import { CashLetterAvailableAmount } from "./cashLetterAvailableAmount";
import { CashLetterAvailableDate } from "./cashLetterAvailableDate";
import { CashLetterDayDeferredAmount } from "./cashLetterDayDeferredAmount";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface CashLetter {
    accountInformation: string;
    accountNumber: string;
    adjustedTotalAmountValue: number;
    adjustedTotalAmountValueSpecified: boolean;
    adjustedTotalAmount: number | null;
    adjustmentAmountValue: number;
    adjustmentAmountValueSpecified: boolean;
    adjustmentAmount: number | null;
    adjustmentDateValue: string;
    adjustmentDateValueSpecified: boolean;
    adjustmentDate: string | null;
    availableAmount: CashLetterAvailableAmount[];
    availableAmountSpecified: boolean;
    availableDate: CashLetterAvailableDate[];
    availableDateSpecified: boolean;
    batchId: string;
    branchValue: number;
    branchValueSpecified: boolean;
    branch: number | null;
    calculatedAmountValue: number;
    calculatedAmountValueSpecified: boolean;
    calculatedAmount: number | null;
    calculatedDateValue: string;
    calculatedDateValueSpecified: boolean;
    calculatedDate: string | null;
    cashLetterAmountValue: number;
    cashLetterAmountValueSpecified: boolean;
    cashLetterAmount: number | null;
    cashLetterDateValue: string;
    cashLetterDateValueSpecified: boolean;
    cashLetterDate: string | null;
    corporateId: string;
    creationDateValue: string;
    creationDateValueSpecified: boolean;
    creationDate: string | null;
    creationTimeValue: number;
    creationTimeValueSpecified: boolean;
    creationTime: number | null;
    creditAmountValue: number;
    creditAmountValueSpecified: boolean;
    creditAmount: number | null;
    dayDeferredAmount: CashLetterDayDeferredAmount[];
    dayDeferredAmountSpecified: boolean;
    debitAmountValue: number;
    debitAmountValueSpecified: boolean;
    debitAmount: number | null;
    debitCreditValue: number;
    debitCreditValueSpecified: boolean;
    debitCredit: number | null;
    depositDateValue: string;
    depositDateValueSpecified: boolean;
    depositDate: string | null;
    fedCodeValue: number;
    fedCodeValueSpecified: boolean;
    fedCode: number | null;
    fedReference: string;
    globalSequenceValue: number;
    globalSequenceValueSpecified: boolean;
    globalSequence: number | null;
    globalSequenceDateValue: string;
    globalSequenceDateValueSpecified: boolean;
    globalSequenceDate: string | null;
    immediateAmountValue: number;
    immediateAmountValueSpecified: boolean;
    immediateAmount: number | null;
    itemCountValue: number;
    itemCountValueSpecified: boolean;
    itemCount: number | null;
    memberId: string;
    originalAmountValue: number;
    originalAmountValueSpecified: boolean;
    originalAmount: number | null;
    originalDepositDateValue: string;
    originalDepositDateValueSpecified: boolean;
    originalDepositDate: string | null;
    originatorRt: string;
    payee: string;
    priorAmountValue: number;
    priorAmountValueSpecified: boolean;
    priorAmount: number | null;
    processDateValue: string;
    processDateValueSpecified: boolean;
    processDate: string | null;
    reference: string;
    resubmitAmountValue: number;
    resubmitAmountValueSpecified: boolean;
    resubmitAmount: number | null;
    returnReason: string;
    returnType: string;
    reversalDateValue: string;
    reversalDateValueSpecified: boolean;
    reversalDate: string | null;
    reversalFlagValue: number;
    reversalFlagValueSpecified: boolean;
    reversalFlag: number | null;
    shareId: string;
    statementCode: string;
    thirdPartyInformation: string;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    usCentralRt: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}