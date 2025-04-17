import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface GlHistory {
    amountValue: number;
    amountValueSpecified: boolean;
    amount: number | null;
    comment: string;
    debitCreditCodeValue: number;
    debitCreditCodeValueSpecified: boolean;
    debitCreditCode: number | null;
    effectiveDateValue: string;
    effectiveDateValueSpecified: boolean;
    effectiveDate: string | null;
    glAccountNumber: string;
    glCategoryValue: number;
    glCategoryValueSpecified: boolean;
    glCategory: number | null;
    postDateValue: string;
    postDateValueSpecified: boolean;
    postDate: string | null;
    processorUserValue: number;
    processorUserValueSpecified: boolean;
    processorUser: number | null;
    reference: string;
    sequenceNumberValue: number;
    sequenceNumberValueSpecified: boolean;
    sequenceNumber: number | null;
    userNumberValue: number;
    userNumberValueSpecified: boolean;
    userNumber: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}