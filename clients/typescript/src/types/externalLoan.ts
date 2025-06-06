import { ExternalLoanNameList } from "./externalLoanNameList";
import { ExternalLoanNoteList } from "./externalLoanNoteList";
import { ExternalLoanTrackingList } from "./externalLoanTrackingList";
import { ExternalLoanTransferList } from "./externalLoanTransferList";
import { ExternalLoanService } from "./externalLoanService";
import { ExternalLoanWarningCode } from "./externalLoanWarningCode";
import { ExternalLoanWarningExpiration } from "./externalLoanWarningExpiration";
import { VersionType } from "./versionType";

export interface ExternalLoan {
    accountNumber: string;
    activityDate: string | null;
    advance: number | null;
    availCredit: number | null;
    availableCashAdvance: number | null;
    balance: number | null;
    cashAdvanceLimit: number | null;
    closeDate: string | null;
    creditLimit: number | null;
    description: string;
    dueDate: string | null;
    escrowPayment: number | null;
    externalLoanNameList: ExternalLoanNameList;
    externalLoanNoteList: ExternalLoanNoteList;
    externalLoanTrackingList: ExternalLoanTrackingList;
    externalLoanTransferList: ExternalLoanTransferList;
    impoundPayment: number | null;
    lastAdvDate: string | null;
    lastFmDate: string | null;
    lastTranDate: string | null;
    lastUpdateDate: string | null;
    lateChargeDue: number | null;
    locator: number | null;
    nrtAvailCredit: number | null;
    nrtAvailableCashAdvance: number | null;
    nrtBalance: number | null;
    nrtCashAdvanceLimit: number | null;
    nrtCloseDate: string | null;
    nrtCreditLimit: number | null;
    nrtDueDate: string | null;
    nrtEscrowPayment: number | null;
    nrtImpoundPayment: number | null;
    nrtLastAdvDate: string | null;
    nrtLateChargeDue: number | null;
    nrtPaymentDue: number | null;
    nrtPrincIntPayment: number | null;
    nrtStatementDate: string | null;
    nrtStatementPrevDate: string | null;
    paymentDue: number | null;
    princIntPayment: number | null;
    recordChangeDate: string | null;
    service: ExternalLoanService[];
    statementDate: string | null;
    statementGroup: number | null;
    statementMailCode: number | null;
    statementPrevDate: string | null;
    status: number | null;
    type: number | null;
    warningCode: ExternalLoanWarningCode[];
    warningExpiration: ExternalLoanWarningExpiration[];
    version1: VersionType;
}