import { VersionType } from "./versionType";

export interface ExternalLoanFields {
    accountNumber: boolean | null;
    activityDate: boolean | null;
    advance: boolean | null;
    availCredit: boolean | null;
    availableCashAdvance: boolean | null;
    balance: boolean | null;
    cashAdvanceLimit: boolean | null;
    closeDate: boolean | null;
    creditLimit: boolean | null;
    description: boolean | null;
    dueDate: boolean | null;
    escrowPayment: boolean | null;
    impoundPayment: boolean | null;
    lastAdvDate: boolean | null;
    lastFmDate: boolean | null;
    lastTranDate: boolean | null;
    lastUpdateDate: boolean | null;
    lateChargeDue: boolean | null;
    locator: boolean | null;
    nrtAvailCredit: boolean | null;
    nrtAvailableCashAdvance: boolean | null;
    nrtBalance: boolean | null;
    nrtCashAdvanceLimit: boolean | null;
    nrtCloseDate: boolean | null;
    nrtCreditLimit: boolean | null;
    nrtDueDate: boolean | null;
    nrtEscrowPayment: boolean | null;
    nrtImpoundPayment: boolean | null;
    nrtLastAdvDate: boolean | null;
    nrtLateChargeDue: boolean | null;
    nrtPaymentDue: boolean | null;
    nrtPrincIntPayment: boolean | null;
    nrtStatementDate: boolean | null;
    nrtStatementPrevDate: boolean | null;
    paymentDue: boolean | null;
    princIntPayment: boolean | null;
    recordChangeDate: boolean | null;
    service: number[];
    statementDate: boolean | null;
    statementGroup: boolean | null;
    statementMailCode: boolean | null;
    statementPrevDate: boolean | null;
    status: boolean | null;
    type: boolean | null;
    warningCode: number[];
    warningExpiration: number[];
    version1: VersionType;
}