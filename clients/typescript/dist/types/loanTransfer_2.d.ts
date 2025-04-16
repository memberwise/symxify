import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface LoanTransfer_2 {
    accountNumber: string;
    amountValue: number;
    amountValueSpecified: boolean;
    amount: number | null;
    amountOptionValue: number;
    amountOptionValueSpecified: boolean;
    amountOption: number | null;
    day1Value: number;
    day1ValueSpecified: boolean;
    day1: number | null;
    day2Value: number;
    day2ValueSpecified: boolean;
    day2: number | null;
    effectiveDateValue: string | null;
    effectiveDateValueSpecified: boolean;
    effectiveDate: string | null;
    expirationDateValue: string | null;
    expirationDateValueSpecified: boolean;
    expirationDate: string | null;
    extLoanAccount: string;
    frequencyValue: number;
    frequencyValueSpecified: boolean;
    frequency: number | null;
    id: string;
    idTypeValue: number;
    idTypeValueSpecified: boolean;
    idType: number | null;
    lastDateValue: string | null;
    lastDateValueSpecified: boolean;
    lastDate: string | null;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    maturityCheckValue: number;
    maturityCheckValueSpecified: boolean;
    maturityCheck: number | null;
    maximumBalanceValue: number;
    maximumBalanceValueSpecified: boolean;
    maximumBalance: number | null;
    minimumBalanceValue: number;
    minimumBalanceValueSpecified: boolean;
    minimumBalance: number | null;
    nextDateValue: string | null;
    nextDateValueSpecified: boolean;
    nextDate: string | null;
    paymentTypeValue: number;
    paymentTypeValueSpecified: boolean;
    paymentType: number | null;
    percentValue: number;
    percentValueSpecified: boolean;
    percent: number | null;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    regEValue: number;
    regEValueSpecified: boolean;
    regE: number | null;
    sweepFeeValue: number;
    sweepFeeValueSpecified: boolean;
    sweepFee: number | null;
    sweepFeeId: string;
    sweepFeeIdTypeValue: number;
    sweepFeeIdTypeValueSpecified: boolean;
    sweepFeeIdType: number | null;
    sweepMinimumValue: number;
    sweepMinimumValueSpecified: boolean;
    sweepMinimum: number | null;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
