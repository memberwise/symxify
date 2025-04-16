import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface ActivityFmFields {
    branchValue: boolean;
    branchValueSpecified: boolean;
    branch: boolean | null;
    consoleValue: boolean;
    consoleValueSpecified: boolean;
    console: boolean | null;
    dateValue: boolean;
    dateValueSpecified: boolean;
    date: boolean | null;
    helpCodeValue: boolean;
    helpCodeValueSpecified: boolean;
    helpCode: boolean | null;
    sessionValue: boolean;
    sessionValueSpecified: boolean;
    session: boolean | null;
    timeValue: boolean;
    timeValueSpecified: boolean;
    time: boolean | null;
    userInputValue: boolean;
    userInputValueSpecified: boolean;
    userInput: boolean | null;
    userNumberValue: boolean;
    userNumberValueSpecified: boolean;
    userNumber: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}