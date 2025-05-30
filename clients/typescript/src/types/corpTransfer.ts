import { CorpTransferMemo } from "./corpTransferMemo";
import { VersionType } from "./versionType";

export interface CorpTransfer {
    amount: number | null;
    completedByUser: number | null;
    completedDate: string | null;
    completedReason: string;
    completedTime: number | null;
    effectiveDate: string | null;
    enteredByCorporateUser: number | null;
    enteredByMemberUser: number | null;
    enteredDate: string | null;
    enteredTime: number | null;
    enteredValidationMethod: string;
    fromAccount: string;
    fromGlAccount: string;
    fromId: string;
    fromIdType: number | null;
    globalSequence: number | null;
    globalSequenceDate: string | null;
    interestAmount: number | null;
    memo: CorpTransferMemo[];
    noticeDate: string | null;
    notificationDate: string | null;
    notificationMethod: number | null;
    notificationStatus: number | null;
    notificationTime: number | null;
    notificationUser: string;
    originatorStatementDesc: string;
    originatorTransactionSeq: number | null;
    postDate: string | null;
    principalAmount: number | null;
    receiverStatementDesc: string;
    receiverTransactionSeq: number | null;
    status: number | null;
    toAccount: string;
    toGlAccount: string;
    toId: string;
    toIdType: number | null;
    type: number | null;
    version1: VersionType;
}