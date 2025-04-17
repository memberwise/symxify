import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface InvoiceFields {
    achAcknowledgeValue: boolean;
    achAcknowledgeValueSpecified: boolean;
    achAcknowledge: boolean | null;
    achGroupNumberValue: boolean;
    achGroupNumberValueSpecified: boolean;
    achGroupNumber: boolean | null;
    achTranCodeOutValue: boolean;
    achTranCodeOutValueSpecified: boolean;
    achTranCodeOut: boolean | null;
    additionalDescValue: boolean;
    additionalDescValueSpecified: boolean;
    additionalDesc: boolean | null;
    apPaymentTermsTypeValue: boolean;
    apPaymentTermsTypeValueSpecified: boolean;
    apPaymentTermsType: boolean | null;
    approvalValue: boolean;
    approvalValueSpecified: boolean;
    approval: boolean | null;
    completedActions: number[];
    completedActionsSpecified: boolean;
    createAddendaValue: boolean;
    createAddendaValueSpecified: boolean;
    createAddenda: boolean | null;
    descriptionValue: boolean;
    descriptionValueSpecified: boolean;
    description: boolean | null;
    dfiAccountValue: boolean;
    dfiAccountValueSpecified: boolean;
    dfiAccount: boolean | null;
    discountAmountValue: boolean;
    discountAmountValueSpecified: boolean;
    discountAmount: boolean | null;
    discountDateValue: boolean;
    discountDateValueSpecified: boolean;
    discountDate: boolean | null;
    discountTakenValue: boolean;
    discountTakenValueSpecified: boolean;
    discountTaken: boolean | null;
    dueAmount: number[];
    dueAmountSpecified: boolean;
    dueDate: number[];
    dueDateSpecified: boolean;
    dueDateFinalValue: boolean;
    dueDateFinalValueSpecified: boolean;
    dueDateFinal: boolean | null;
    eventValue: boolean;
    eventValueSpecified: boolean;
    event: boolean | null;
    eventDateValue: boolean;
    eventDateValueSpecified: boolean;
    eventDate: boolean | null;
    expEffectiveDateValue: boolean;
    expEffectiveDateValueSpecified: boolean;
    expEffectiveDate: boolean | null;
    expPostDateValue: boolean;
    expPostDateValueSpecified: boolean;
    expPostDate: boolean | null;
    expenseAmount: number[];
    expenseAmountSpecified: boolean;
    expenseTable: number[];
    expenseTableSpecified: boolean;
    glAcctsPayValue: boolean;
    glAcctsPayValueSpecified: boolean;
    glAcctsPay: boolean | null;
    glDiscountValue: boolean;
    glDiscountValueSpecified: boolean;
    glDiscount: boolean | null;
    glExpense: number[];
    glExpenseSpecified: boolean;
    glNameAcctsPayValue: boolean;
    glNameAcctsPayValueSpecified: boolean;
    glNameAcctsPay: boolean | null;
    glNameDiscountValue: boolean;
    glNameDiscountValueSpecified: boolean;
    glNameDiscount: boolean | null;
    glNameExpense: number[];
    glNameExpenseSpecified: boolean;
    imageIdValue: boolean;
    imageIdValueSpecified: boolean;
    imageId: boolean | null;
    invoiceDateValue: boolean;
    invoiceDateValueSpecified: boolean;
    invoiceDate: boolean | null;
    invoiceFrequencyValue: boolean;
    invoiceFrequencyValueSpecified: boolean;
    invoiceFrequency: boolean | null;
    lastFmDateValue: boolean;
    lastFmDateValueSpecified: boolean;
    lastFmDate: boolean | null;
    locatorValue: boolean;
    locatorValueSpecified: boolean;
    locator: boolean | null;
    nextRecurInvoiceDateValue: boolean;
    nextRecurInvoiceDateValueSpecified: boolean;
    nextRecurInvoiceDate: boolean | null;
    numberValue: boolean;
    numberValueSpecified: boolean;
    number: boolean | null;
    originatingInvoiceNumberValue: boolean;
    originatingInvoiceNumberValueSpecified: boolean;
    originatingInvoiceNumber: boolean | null;
    paymentAmount: number[];
    paymentAmountSpecified: boolean;
    paymentCheck: number[];
    paymentCheckSpecified: boolean;
    paymentDate: number[];
    paymentDateSpecified: boolean;
    paymentMethodValue: boolean;
    paymentMethodValueSpecified: boolean;
    paymentMethod: boolean | null;
    poNumberValue: boolean;
    poNumberValueSpecified: boolean;
    poNumber: boolean | null;
    preNoteDfiAccountValue: boolean;
    preNoteDfiAccountValueSpecified: boolean;
    preNoteDfiAccount: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    recurrenceDay1Value: boolean;
    recurrenceDay1ValueSpecified: boolean;
    recurrenceDay1: boolean | null;
    recurrenceDay2Value: boolean;
    recurrenceDay2ValueSpecified: boolean;
    recurrenceDay2: boolean | null;
    recurrenceEndDateValue: boolean;
    recurrenceEndDateValueSpecified: boolean;
    recurrenceEndDate: boolean | null;
    remainingRecurringInvoicesValue: boolean;
    remainingRecurringInvoicesValueSpecified: boolean;
    remainingRecurringInvoices: boolean | null;
    statusValue: boolean;
    statusValueSpecified: boolean;
    status: boolean | null;
    totalExpensesValue: boolean;
    totalExpensesValueSpecified: boolean;
    totalExpenses: boolean | null;
    totalInvoiceAmtDueValue: boolean;
    totalInvoiceAmtDueValueSpecified: boolean;
    totalInvoiceAmtDue: boolean | null;
    totalPaymentsValue: boolean;
    totalPaymentsValueSpecified: boolean;
    totalPayments: boolean | null;
    typeValue: boolean;
    typeValueSpecified: boolean;
    type: boolean | null;
    unpaidBalanceValue: boolean;
    unpaidBalanceValueSpecified: boolean;
    unpaidBalance: boolean | null;
    userValue: boolean;
    userValueSpecified: boolean;
    user: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}