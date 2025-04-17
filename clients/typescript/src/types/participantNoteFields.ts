import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface ParticipantNoteFields {
    codeValue: boolean;
    codeValueSpecified: boolean;
    code: boolean | null;
    enterDateValue: boolean;
    enterDateValueSpecified: boolean;
    enterDate: boolean | null;
    enterTimeValue: boolean;
    enterTimeValueSpecified: boolean;
    enterTime: boolean | null;
    expirationDateValue: boolean;
    expirationDateValueSpecified: boolean;
    expirationDate: boolean | null;
    idValue: boolean;
    idValueSpecified: boolean;
    id: boolean | null;
    idTypeValue: boolean;
    idTypeValueSpecified: boolean;
    idType: boolean | null;
    locatorValue: boolean;
    locatorValueSpecified: boolean;
    locator: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    text: number[];
    textSpecified: boolean;
    textLineCountValue: boolean;
    textLineCountValueSpecified: boolean;
    textLineCount: boolean | null;
    userIdValue: boolean;
    userIdValueSpecified: boolean;
    userId: boolean | null;
    voidFlagValue: boolean;
    voidFlagValueSpecified: boolean;
    voidFlag: boolean | null;
    voidedByValue: boolean;
    voidedByValueSpecified: boolean;
    voidedBy: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}