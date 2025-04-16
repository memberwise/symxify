import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface CardAccess_2 {
    accessTypeValue: number;
    accessTypeValueSpecified: boolean;
    accessType: number | null;
    accountNumber: string;
    enableDepositValue: number;
    enableDepositValueSpecified: boolean;
    enableDeposit: number | null;
    enableFmValue: number;
    enableFmValueSpecified: boolean;
    enableFm: number | null;
    enableInquiryValue: number;
    enableInquiryValueSpecified: boolean;
    enableInquiry: number | null;
    enableWithdrawalValue: number;
    enableWithdrawalValueSpecified: boolean;
    enableWithdrawal: number | null;
    extLoanAccount: string;
    id: string;
    idTypeValue: number;
    idTypeValueSpecified: boolean;
    idType: number | null;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    qualifier: string;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}