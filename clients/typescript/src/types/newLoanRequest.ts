import { AmountInformation } from "./amountInformation";
import { CheckIssuerType } from "./checkIssuerType";
import { GlAccounts } from "./glAccounts";
import { GlCodes } from "./glCodes";
import { PayeeInformation } from "./payeeInformation";
import { AuthorizationType } from "./authorizationType";
import { Printer } from "./printer";
import { Dispenser } from "./dispenser";
import { TransactionsBaseRequest } from "./transactionsBaseRequest";

export interface NewLoanRequest extends TransactionsBaseRequest {
    accountNumber: string;
    loanId: string;
    loanAmounts: AmountInformation;
    checkNumber: string;
    checkIssuerValue: CheckIssuerType;
    checkIssuerValueSpecified: boolean;
    checkIssuer: CheckIssuerType | null;
    comment: string;
    checkAccountCodeValue: number;
    checkAccountCodeValueSpecified: boolean;
    checkAccountCode: number | null;
    glAccounts: GlAccounts;
    glCodes: GlCodes;
    payee: PayeeInformation;
    authorizationTypeValue: AuthorizationType;
    authorizationTypeValueSpecified: boolean;
    authorizationType: AuthorizationType | null;
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
    forcePostRequestedValue: boolean;
    forcePostRequestedValueSpecified: boolean;
    forcePostRequested: boolean | null;
    tracerNumber: string;
    draftNumber: string;
    printer: Printer[];
    printerSpecified: boolean;
    dispenser: Dispenser[];
    dispenserSpecified: boolean;
    calculateCheckValue: boolean;
    calculateCheckValueSpecified: boolean;
    calculateCheck: boolean | null;
    glComment: string;
}