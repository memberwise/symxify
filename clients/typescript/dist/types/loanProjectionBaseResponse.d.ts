export interface LoanProjectionBaseResponse {
    statusMessage: string;
    paymentValue: number;
    paymentValueSpecified: boolean;
    payment: number | null;
    loanAmountValue: number;
    loanAmountValueSpecified: boolean;
    loanAmount: number | null;
    paymentCountValue: number;
    paymentCountValueSpecified: boolean;
    paymentCount: number | null;
    finalPaymentValue: number;
    finalPaymentValueSpecified: boolean;
    finalPayment: number | null;
    finalDueDateValue: string;
    finalDueDateValueSpecified: boolean;
    finalDueDate: string | null;
    firstPaymentDateValue: string;
    firstPaymentDateValueSpecified: boolean;
    firstPaymentDate: string | null;
    totalInterestValue: number;
    totalInterestValueSpecified: boolean;
    totalInterest: number | null;
    totalPaymentsValue: number;
    totalPaymentsValueSpecified: boolean;
    totalPayments: number | null;
    totalEscrowValue: number;
    totalEscrowValueSpecified: boolean;
    totalEscrow: number | null;
    totalMaprFeesValue: number;
    totalMaprFeesValueSpecified: boolean;
    totalMaprFees: number | null;
    lifeValue: number;
    lifeValueSpecified: boolean;
    life: number | null;
    disabilityValue: number;
    disabilityValueSpecified: boolean;
    disability: number | null;
    lifeError: string;
    disabilityError: string;
    aprValue: number;
    aprValueSpecified: boolean;
    apr: number | null;
    maprValue: number;
    maprValueSpecified: boolean;
    mapr: number | null;
    messageId: string;
    statusCodeValue: number;
    statusCodeValueSpecified: boolean;
    statusCode: number | null;
}
