import { ExternalLoanNoteText_2 } from "./externalLoanNoteText_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface ExternalLoanNote_2 {
    codeValue: number;
    codeValueSpecified: boolean;
    code: number | null;
    enterDateValue: string | null;
    enterDateValueSpecified: boolean;
    enterDate: string | null;
    enterTimeValue: number;
    enterTimeValueSpecified: boolean;
    enterTime: number | null;
    expirationDateValue: string | null;
    expirationDateValueSpecified: boolean;
    expirationDate: string | null;
    id: string;
    idTypeValue: number;
    idTypeValueSpecified: boolean;
    idType: number | null;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    text: ExternalLoanNoteText_2[];
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