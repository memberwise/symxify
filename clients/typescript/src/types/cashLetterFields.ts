import { VersionType } from "./versionType";

export interface CashLetterFields {
    accountInformation: boolean | null;
    accountNumber: boolean | null;
    adjustedTotalAmount: boolean | null;
    adjustmentAmount: boolean | null;
    adjustmentDate: boolean | null;
    availableAmount: number[];
    availableDate: number[];
    batchId: boolean | null;
    branch: boolean | null;
    calculatedAmount: boolean | null;
    calculatedDate: boolean | null;
    cashLetterAmount: boolean | null;
    cashLetterDate: boolean | null;
    corporateId: boolean | null;
    creationDate: boolean | null;
    creationTime: boolean | null;
    creditAmount: boolean | null;
    dayDeferredAmount: number[];
    debitAmount: boolean | null;
    debitCredit: boolean | null;
    depositDate: boolean | null;
    fedCode: boolean | null;
    fedReference: boolean | null;
    globalSequence: boolean | null;
    globalSequenceDate: boolean | null;
    immediateAmount: boolean | null;
    itemCount: boolean | null;
    memberId: boolean | null;
    originalAmount: boolean | null;
    originalDepositDate: boolean | null;
    originatorRt: boolean | null;
    payee: boolean | null;
    priorAmount: boolean | null;
    processDate: boolean | null;
    reference: boolean | null;
    resubmitAmount: boolean | null;
    returnReason: boolean | null;
    returnType: boolean | null;
    reversalDate: boolean | null;
    reversalFlag: boolean | null;
    shareId: boolean | null;
    statementCode: boolean | null;
    thirdPartyInformation: boolean | null;
    type: boolean | null;
    usCentralRt: boolean | null;
    version1: VersionType;
}