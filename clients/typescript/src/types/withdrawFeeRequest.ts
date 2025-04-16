import { DonorIdType } from "./donorIdType";
import { AuthorizationType } from "./authorizationType";
import { GlAccounts } from "./glAccounts";
import { GlCodes } from "./glCodes";
import { TransactionsBaseRequest } from "./transactionsBaseRequest";

export interface WithdrawFeeRequest extends TransactionsBaseRequest {
    accountNumber: string;
    donorId: string;
    donorTypeValue: DonorIdType;
    donorTypeValueSpecified: boolean;
    donorType: DonorIdType | null;
    totalAmountValue: number;
    totalAmountValueSpecified: boolean;
    totalAmount: number | null;
    authorizationTypeValue: AuthorizationType;
    authorizationTypeValueSpecified: boolean;
    authorizationType: AuthorizationType | null;
    feeCodeValue: number;
    feeCodeValueSpecified: boolean;
    feeCode: number | null;
    comment: string;
    commentCodeValue: number;
    commentCodeValueSpecified: boolean;
    commentCode: number | null;
    effectiveDateValue: string;
    effectiveDateValueSpecified: boolean;
    effectiveDate: string | null;
    glAccounts: GlAccounts;
    glCodes: GlCodes;
    sourceCode: string;
    forcePostRequestedValue: boolean;
    forcePostRequestedValueSpecified: boolean;
    forcePostRequested: boolean | null;
    recurrenceRequestedValue: boolean;
    recurrenceRequestedValueSpecified: boolean;
    recurrenceRequested: boolean | null;
    glComment: string;
}