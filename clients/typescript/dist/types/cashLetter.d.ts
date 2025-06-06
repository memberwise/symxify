import { CashLetterAvailableAmount } from "./cashLetterAvailableAmount";
import { CashLetterAvailableDate } from "./cashLetterAvailableDate";
import { CashLetterDayDeferredAmount } from "./cashLetterDayDeferredAmount";
import { VersionType } from "./versionType";
export interface CashLetter {
    accountInformation: string;
    accountNumber: string;
    adjustedTotalAmount: number | null;
    adjustmentAmount: number | null;
    adjustmentDate: string | null;
    availableAmount: CashLetterAvailableAmount[];
    availableDate: CashLetterAvailableDate[];
    batchId: string;
    branch: number | null;
    calculatedAmount: number | null;
    calculatedDate: string | null;
    cashLetterAmount: number | null;
    cashLetterDate: string | null;
    corporateId: string;
    creationDate: string | null;
    creationTime: number | null;
    creditAmount: number | null;
    dayDeferredAmount: CashLetterDayDeferredAmount[];
    debitAmount: number | null;
    debitCredit: number | null;
    depositDate: string | null;
    fedCode: number | null;
    fedReference: string;
    globalSequence: number | null;
    globalSequenceDate: string | null;
    immediateAmount: number | null;
    itemCount: number | null;
    memberId: string;
    originalAmount: number | null;
    originalDepositDate: string | null;
    originatorRt: string;
    payee: string;
    priorAmount: number | null;
    processDate: string | null;
    reference: string;
    resubmitAmount: number | null;
    returnReason: string;
    returnType: string;
    reversalDate: string | null;
    reversalFlag: number | null;
    shareId: string;
    statementCode: string;
    thirdPartyInformation: string;
    type: number | null;
    usCentralRt: string;
    version1: VersionType;
}
