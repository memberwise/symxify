import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface CtrPerson_2 {
    address: string;
    birthDateValue: string | null;
    birthDateValueSpecified: boolean;
    birthDate: string | null;
    cashinValue: number;
    cashinValueSpecified: boolean;
    cashin: number | null;
    cashoutValue: number;
    cashoutValueSpecified: boolean;
    cashout: number | null;
    city: string;
    countryCode: string;
    dbaFirst: string;
    dbaLast: string;
    dbaLongName: string;
    dbaMiddle: string;
    dbaShortName: string;
    dbaSuffix: string;
    email: string;
    entityFlagValue: number;
    entityFlagValueSpecified: boolean;
    entityFlag: number | null;
    first: string;
    gender: string;
    headquartersValue: number;
    headquartersValueSpecified: boolean;
    headquarters: number | null;
    idIssueByCountry: string;
    idIssueByState: string;
    idNumber: string;
    idTypeOtherDesc: string;
    idVerifyMethodValue: number;
    idVerifyMethodValueSpecified: boolean;
    idVerifyMethod: number | null;
    last: string;
    lastFmDateValue: string | null;
    lastFmDateValueSpecified: boolean;
    lastFmDate: string | null;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    longName: string;
    middle: string;
    multiTransFlagValue: number;
    multiTransFlagValueSpecified: boolean;
    multiTransFlag: number | null;
    naicsCode: string;
    occupation: string;
    phone: string;
    phoneExt: string;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    shortName: string;
    ssn: string;
    ssnTintypeValue: number;
    ssnTintypeValueSpecified: boolean;
    ssnTintype: number | null;
    state: string;
    suffix: string;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    zipCode: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
