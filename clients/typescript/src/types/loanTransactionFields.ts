import { VersionType } from "./versionType";

export interface LoanTransactionFields {
    accountNumber: boolean | null;
    actionCode: boolean | null;
    activityDate: boolean | null;
    adjustmentCode: boolean | null;
    balSegCount: boolean | null;
    balSegId: number[];
    balSegPmtChangeDate: number[];
    balSegPrevFirstPmtDate: number[];
    balanceChange: boolean | null;
    batchSequence: boolean | null;
    billedFeeAmount: boolean | null;
    branch: boolean | null;
    calcMicrRt: boolean | null;
    comment: boolean | null;
    commentCode: boolean | null;
    confirmationNumber: boolean | null;
    confirmationSeq: boolean | null;
    consoleNumber: boolean | null;
    description: boolean | null;
    dispositionFee: boolean | null;
    draftNumber: boolean | null;
    effectiveDate: boolean | null;
    escrowAmount: boolean | null;
    escrowAppliedBalChg: boolean | null;
    escrowUnpaidBalChg: boolean | null;
    feeAmount: boolean | null;
    feeCountBy: boolean | null;
    feeExmtCrtsyAmt: boolean | null;
    id: boolean | null;
    idType: boolean | null;
    intEffectDate: boolean | null;
    interest: boolean | null;
    lastTranDate: boolean | null;
    lateChgFieldsValid: boolean | null;
    lateChgUnpaidChgAmt: boolean | null;
    lateChgWaivedAmt: boolean | null;
    maturityLoanDueDate: boolean | null;
    memberBranch: boolean | null;
    micrAcctNum: boolean | null;
    micrRt: boolean | null;
    miscExpenseAmount: boolean | null;
    newBalance: boolean | null;
    postDate: boolean | null;
    postTime: boolean | null;
    prevAvailBalance: boolean | null;
    prevLateChgAccrued: boolean | null;
    prevLateChgDate: boolean | null;
    processorUser: boolean | null;
    recurringTran: boolean | null;
    regDCheckCode: boolean | null;
    regDTransferCode: boolean | null;
    regECode: boolean | null;
    salesTaxAmount: boolean | null;
    securityLevels: boolean | null;
    sequenceNumber: boolean | null;
    sourceCode: boolean | null;
    stmtDesc: number[];
    subActionCode: boolean | null;
    subSource: boolean | null;
    subSourceDescr: boolean | null;
    terminationFee: boolean | null;
    tracerNumber: boolean | null;
    tranAmount: boolean | null;
    transferCode: boolean | null;
    unappliedPartialPmtChg: boolean | null;
    userNumber: boolean | null;
    userOverride: boolean | null;
    voidCode: boolean | null;
    version1: VersionType;
}