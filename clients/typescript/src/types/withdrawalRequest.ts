import { AmountInfo } from "./amountInfo";
import { GlAccounts } from "./glAccounts";
import { GlCodes } from "./glCodes";
import { AuthorizationType } from "./authorizationType";
import { CheckIssuerType } from "./checkIssuerType";
import { PayeeInformation } from "./payeeInformation";
import { Printer } from "./printer";
import { Dispenser } from "./dispenser";
import { CashDeviceType } from "./cashDeviceType";
import { ReversalType } from "./reversalType";
import { TransactionsBaseRequest } from "./transactionsBaseRequest";

export interface WithdrawalRequest extends TransactionsBaseRequest {
    accountNumber: string;
    shareId: string;
    withdrawalAmounts: AmountInfo;
    glAccounts: GlAccounts;
    glCodes: GlCodes;
    authorizationTypeValue: AuthorizationType;
    authorizationTypeValueSpecified: boolean;
    authorizationType: AuthorizationType | null;
    sourceCode: string;
    checkNumber: string;
    checkIssuerValue: CheckIssuerType;
    checkIssuerValueSpecified: boolean;
    checkIssuer: CheckIssuerType | null;
    checkAccountCodeValue: number;
    checkAccountCodeValueSpecified: boolean;
    checkAccountCode: number | null;
    checkReference: string;
    commentCodeValue: number;
    commentCodeValueSpecified: boolean;
    commentCode: number | null;
    comment: string;
    effectiveDateValue: string;
    effectiveDateValueSpecified: boolean;
    effectiveDate: string | null;
    payee: PayeeInformation;
    regulationDLimitedValue: boolean | null;
    regulationDLimitedValueSpecified: boolean;
    regulationDLimited: boolean | null;
    forcePostRequestedValue: boolean;
    forcePostRequestedValueSpecified: boolean;
    forcePostRequested: boolean | null;
    recurrenceRequestedValue: boolean;
    recurrenceRequestedValueSpecified: boolean;
    recurrenceRequested: boolean | null;
    tracerNumber: string;
    draftNumber: string;
    printer: Printer[];
    printerSpecified: boolean;
    dispenser: Dispenser[];
    dispenserSpecified: boolean;
    cashDevice: CashDeviceType;
    calculateCheckValue: boolean;
    calculateCheckValueSpecified: boolean;
    calculateCheck: boolean | null;
    glComment: string;
    reversal: ReversalType;
}