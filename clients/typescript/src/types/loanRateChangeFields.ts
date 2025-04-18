import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface LoanRateChangeFields {
    creationDateValue: boolean;
    creationDateValueSpecified: boolean;
    creationDate: boolean | null;
    idValue: boolean;
    idValueSpecified: boolean;
    id: boolean | null;
    indexRateValue: boolean;
    indexRateValueSpecified: boolean;
    indexRate: boolean | null;
    interestRateValue: boolean;
    interestRateValueSpecified: boolean;
    interestRate: boolean | null;
    locatorValue: boolean;
    locatorValueSpecified: boolean;
    locator: boolean | null;
    paymentChangeDateValue: boolean;
    paymentChangeDateValueSpecified: boolean;
    paymentChangeDate: boolean | null;
    periodicStartDateValue: boolean;
    periodicStartDateValueSpecified: boolean;
    periodicStartDate: boolean | null;
    periodicStartRateValue: boolean;
    periodicStartRateValueSpecified: boolean;
    periodicStartRate: boolean | null;
    rateChangeDateValue: boolean;
    rateChangeDateValueSpecified: boolean;
    rateChangeDate: boolean | null;
    reamortizedPaymentValue: boolean;
    reamortizedPaymentValueSpecified: boolean;
    reamortizedPayment: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}