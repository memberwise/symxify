import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface LoanPledge_2 {
    accountNumber: string;
    amountValue: number;
    amountValueSpecified: boolean;
    amount: number | null;
    collateralCodeValue: number;
    collateralCodeValueSpecified: boolean;
    collateralCode: number | null;
    collateralDescription: string;
    collateralNumber: string;
    effectiveDateValue: string | null;
    effectiveDateValueSpecified: boolean;
    effectiveDate: string | null;
    expirationDateValue: string | null;
    expirationDateValueSpecified: boolean;
    expirationDate: string | null;
    id: string;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    percentValue: number;
    percentValueSpecified: boolean;
    percent: number | null;
    priorityValue: number;
    priorityValueSpecified: boolean;
    priority: number | null;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}