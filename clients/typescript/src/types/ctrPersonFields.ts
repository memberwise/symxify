import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface CtrPersonFields {
    addressValue: boolean;
    addressValueSpecified: boolean;
    address: boolean | null;
    birthDateValue: boolean;
    birthDateValueSpecified: boolean;
    birthDate: boolean | null;
    cashinValue: boolean;
    cashinValueSpecified: boolean;
    cashin: boolean | null;
    cashoutValue: boolean;
    cashoutValueSpecified: boolean;
    cashout: boolean | null;
    cityValue: boolean;
    cityValueSpecified: boolean;
    city: boolean | null;
    countryCodeValue: boolean;
    countryCodeValueSpecified: boolean;
    countryCode: boolean | null;
    dbaFirstValue: boolean;
    dbaFirstValueSpecified: boolean;
    dbaFirst: boolean | null;
    dbaLastValue: boolean;
    dbaLastValueSpecified: boolean;
    dbaLast: boolean | null;
    dbaLongNameValue: boolean;
    dbaLongNameValueSpecified: boolean;
    dbaLongName: boolean | null;
    dbaMiddleValue: boolean;
    dbaMiddleValueSpecified: boolean;
    dbaMiddle: boolean | null;
    dbaShortNameValue: boolean;
    dbaShortNameValueSpecified: boolean;
    dbaShortName: boolean | null;
    dbaSuffixValue: boolean;
    dbaSuffixValueSpecified: boolean;
    dbaSuffix: boolean | null;
    emailValue: boolean;
    emailValueSpecified: boolean;
    email: boolean | null;
    entityFlagValue: boolean;
    entityFlagValueSpecified: boolean;
    entityFlag: boolean | null;
    firstValue: boolean;
    firstValueSpecified: boolean;
    first: boolean | null;
    genderValue: boolean;
    genderValueSpecified: boolean;
    gender: boolean | null;
    headquartersValue: boolean;
    headquartersValueSpecified: boolean;
    headquarters: boolean | null;
    idIssueByCountryValue: boolean;
    idIssueByCountryValueSpecified: boolean;
    idIssueByCountry: boolean | null;
    idIssueByStateValue: boolean;
    idIssueByStateValueSpecified: boolean;
    idIssueByState: boolean | null;
    idNumberValue: boolean;
    idNumberValueSpecified: boolean;
    idNumber: boolean | null;
    idTypeOtherDescValue: boolean;
    idTypeOtherDescValueSpecified: boolean;
    idTypeOtherDesc: boolean | null;
    idVerifyMethodValue: boolean;
    idVerifyMethodValueSpecified: boolean;
    idVerifyMethod: boolean | null;
    lastValue: boolean;
    lastValueSpecified: boolean;
    last: boolean | null;
    lastFmDateValue: boolean;
    lastFmDateValueSpecified: boolean;
    lastFmDate: boolean | null;
    locatorValue: boolean;
    locatorValueSpecified: boolean;
    locator: boolean | null;
    longNameValue: boolean;
    longNameValueSpecified: boolean;
    longName: boolean | null;
    middleValue: boolean;
    middleValueSpecified: boolean;
    middle: boolean | null;
    multiTransFlagValue: boolean;
    multiTransFlagValueSpecified: boolean;
    multiTransFlag: boolean | null;
    naicsCodeValue: boolean;
    naicsCodeValueSpecified: boolean;
    naicsCode: boolean | null;
    occupationValue: boolean;
    occupationValueSpecified: boolean;
    occupation: boolean | null;
    phoneValue: boolean;
    phoneValueSpecified: boolean;
    phone: boolean | null;
    phoneExtValue: boolean;
    phoneExtValueSpecified: boolean;
    phoneExt: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    shortNameValue: boolean;
    shortNameValueSpecified: boolean;
    shortName: boolean | null;
    ssnValue: boolean;
    ssnValueSpecified: boolean;
    ssn: boolean | null;
    ssnTintypeValue: boolean;
    ssnTintypeValueSpecified: boolean;
    ssnTintype: boolean | null;
    stateValue: boolean;
    stateValueSpecified: boolean;
    state: boolean | null;
    suffixValue: boolean;
    suffixValueSpecified: boolean;
    suffix: boolean | null;
    typeValue: boolean;
    typeValueSpecified: boolean;
    type: boolean | null;
    zipCodeValue: boolean;
    zipCodeValueSpecified: boolean;
    zipCode: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}