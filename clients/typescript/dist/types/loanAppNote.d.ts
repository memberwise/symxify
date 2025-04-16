import { LoanAppNoteText } from "./loanAppNoteText";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface LoanAppNote {
    codeValue: number;
    codeValueSpecified: boolean;
    code: number | null;
    enterDateValue: string;
    enterDateValueSpecified: boolean;
    enterDate: string | null;
    enterTimeValue: number;
    enterTimeValueSpecified: boolean;
    enterTime: number | null;
    expirationDateValue: string;
    expirationDateValueSpecified: boolean;
    expirationDate: string | null;
    id: string;
    idTypeValue: number;
    idTypeValueSpecified: boolean;
    idType: number | null;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    recordChangeDateValue: string;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    text: LoanAppNoteText[];
    textSpecified: boolean;
    textLineCountValue: number;
    textLineCountValueSpecified: boolean;
    textLineCount: number | null;
    userIdValue: number;
    userIdValueSpecified: boolean;
    userId: number | null;
    voidFlagValue: number;
    voidFlagValueSpecified: boolean;
    voidFlag: number | null;
    voidedByValue: number;
    voidedByValueSpecified: boolean;
    voidedBy: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
