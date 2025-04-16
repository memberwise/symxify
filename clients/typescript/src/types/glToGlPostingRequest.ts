import { GlCode } from "./glCode";
import { AmountInformation } from "./amountInformation";
import { CheckIssuerType } from "./checkIssuerType";
import { PayeeInformation } from "./payeeInformation";
import { TransactionsBaseRequest } from "./transactionsBaseRequest";

export interface GlToGlPostingRequest extends TransactionsBaseRequest {
    donorAccountNumber: string;
    donorGlCode: GlCode;
    recipientAccountNumber: string;
    recipientGlCode: GlCode;
    amounts: AmountInformation;
    checkIssuerValue: CheckIssuerType;
    checkIssuerValueSpecified: boolean;
    checkIssuer: CheckIssuerType | null;
    comment: string;
    payee: PayeeInformation;
    sourceCode: string;
    effectiveDateValue: string;
    effectiveDateValueSpecified: boolean;
    effectiveDate: string | null;
    commentCodeValue: number;
    commentCodeValueSpecified: boolean;
    commentCode: number | null;
    checkReference: string;
    recurrenceRequestedValue: boolean;
    recurrenceRequestedValueSpecified: boolean;
    recurrenceRequested: boolean | null;
    calculateCheckValue: boolean;
    calculateCheckValueSpecified: boolean;
    calculateCheck: boolean | null;
}