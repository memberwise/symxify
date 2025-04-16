import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface LoanRateChange_2 {
    creationDateValue: string | null;
    creationDateValueSpecified: boolean;
    creationDate: string | null;
    id: string;
    indexRateValue: number;
    indexRateValueSpecified: boolean;
    indexRate: number | null;
    interestRateValue: number;
    interestRateValueSpecified: boolean;
    interestRate: number | null;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    paymentChangeDateValue: string | null;
    paymentChangeDateValueSpecified: boolean;
    paymentChangeDate: string | null;
    periodicStartDateValue: string | null;
    periodicStartDateValueSpecified: boolean;
    periodicStartDate: string | null;
    periodicStartRateValue: number;
    periodicStartRateValueSpecified: boolean;
    periodicStartRate: number | null;
    rateChangeDateValue: string | null;
    rateChangeDateValueSpecified: boolean;
    rateChangeDate: string | null;
    reamortizedPaymentValue: number;
    reamortizedPaymentValueSpecified: boolean;
    reamortizedPayment: number | null;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}