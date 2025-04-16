import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface LoanTransferFields {
    accountNumberValue: boolean;
    accountNumberValueSpecified: boolean;
    accountNumber: boolean | null;
    amountValue: boolean;
    amountValueSpecified: boolean;
    amount: boolean | null;
    amountOptionValue: boolean;
    amountOptionValueSpecified: boolean;
    amountOption: boolean | null;
    day1Value: boolean;
    day1ValueSpecified: boolean;
    day1: boolean | null;
    day2Value: boolean;
    day2ValueSpecified: boolean;
    day2: boolean | null;
    effectiveDateValue: boolean;
    effectiveDateValueSpecified: boolean;
    effectiveDate: boolean | null;
    expirationDateValue: boolean;
    expirationDateValueSpecified: boolean;
    expirationDate: boolean | null;
    extLoanAccountValue: boolean;
    extLoanAccountValueSpecified: boolean;
    extLoanAccount: boolean | null;
    frequencyValue: boolean;
    frequencyValueSpecified: boolean;
    frequency: boolean | null;
    idValue: boolean;
    idValueSpecified: boolean;
    id: boolean | null;
    idTypeValue: boolean;
    idTypeValueSpecified: boolean;
    idType: boolean | null;
    lastDateValue: boolean;
    lastDateValueSpecified: boolean;
    lastDate: boolean | null;
    locatorValue: boolean;
    locatorValueSpecified: boolean;
    locator: boolean | null;
    maturityCheckValue: boolean;
    maturityCheckValueSpecified: boolean;
    maturityCheck: boolean | null;
    maximumBalanceValue: boolean;
    maximumBalanceValueSpecified: boolean;
    maximumBalance: boolean | null;
    minimumBalanceValue: boolean;
    minimumBalanceValueSpecified: boolean;
    minimumBalance: boolean | null;
    nextDateValue: boolean;
    nextDateValueSpecified: boolean;
    nextDate: boolean | null;
    paymentTypeValue: boolean;
    paymentTypeValueSpecified: boolean;
    paymentType: boolean | null;
    percentValue: boolean;
    percentValueSpecified: boolean;
    percent: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    regEValue: boolean;
    regEValueSpecified: boolean;
    regE: boolean | null;
    sweepFeeValue: boolean;
    sweepFeeValueSpecified: boolean;
    sweepFee: boolean | null;
    sweepFeeIdValue: boolean;
    sweepFeeIdValueSpecified: boolean;
    sweepFeeId: boolean | null;
    sweepFeeIdTypeValue: boolean;
    sweepFeeIdTypeValueSpecified: boolean;
    sweepFeeIdType: boolean | null;
    sweepMinimumValue: boolean;
    sweepMinimumValueSpecified: boolean;
    sweepMinimum: boolean | null;
    typeValue: boolean;
    typeValueSpecified: boolean;
    type: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
