import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface MemberRecFields {
    activeDutyValue: boolean;
    activeDutyValueSpecified: boolean;
    activeDuty: boolean | null;
    activeDutySeparationDateValue: boolean;
    activeDutySeparationDateValueSpecified: boolean;
    activeDutySeparationDate: boolean | null;
    activeDutyStartDateValue: boolean;
    activeDutyStartDateValueSpecified: boolean;
    activeDutyStartDate: boolean | null;
    activeDutyVerificationDateValue: boolean;
    activeDutyVerificationDateValueSpecified: boolean;
    activeDutyVerificationDate: boolean | null;
    altEmailValue: boolean;
    altEmailValueSpecified: boolean;
    altEmail: boolean | null;
    birthDateValue: boolean;
    birthDateValueSpecified: boolean;
    birthDate: boolean | null;
    chapter4StatusCodeValue: boolean;
    chapter4StatusCodeValueSpecified: boolean;
    chapter4StatusCode: boolean | null;
    ctrExemptValue: boolean;
    ctrExemptValueSpecified: boolean;
    ctrExempt: boolean | null;
    currGrossMonthPayValue: boolean;
    currGrossMonthPayValueSpecified: boolean;
    currGrossMonthPay: boolean | null;
    currNetMonthPayValue: boolean;
    currNetMonthPayValueSpecified: boolean;
    currNetMonthPay: boolean | null;
    dbaExtendedNameValue: boolean;
    dbaExtendedNameValueSpecified: boolean;
    dbaExtendedName: boolean | null;
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
    dbaNameFormatValue: boolean;
    dbaNameFormatValueSpecified: boolean;
    dbaNameFormat: boolean | null;
    dbaShortNameValue: boolean;
    dbaShortNameValueSpecified: boolean;
    dbaShortName: boolean | null;
    dbaSuffixValue: boolean;
    dbaSuffixValueSpecified: boolean;
    dbaSuffix: boolean | null;
    dbaTitleValue: boolean;
    dbaTitleValueSpecified: boolean;
    dbaTitle: boolean | null;
    deathDateValue: boolean;
    deathDateValueSpecified: boolean;
    deathDate: boolean | null;
    emailValue: boolean;
    emailValueSpecified: boolean;
    email: boolean | null;
    employerNameValue: boolean;
    employerNameValueSpecified: boolean;
    employerName: boolean | null;
    extendedNameValue: boolean;
    extendedNameValueSpecified: boolean;
    extendedName: boolean | null;
    firstValue: boolean;
    firstValueSpecified: boolean;
    first: boolean | null;
    foreignTinValue: boolean;
    foreignTinValueSpecified: boolean;
    foreignTin: boolean | null;
    formW8OnFileValue: boolean;
    formW8OnFileValueSpecified: boolean;
    formW8OnFile: boolean | null;
    gIinValue: boolean;
    gIinValueSpecified: boolean;
    gIin: boolean | null;
    homePhoneValue: boolean;
    homePhoneValueSpecified: boolean;
    homePhone: boolean | null;
    identDocFlag: number[];
    identDocFlagSpecified: boolean;
    identIdDescription: number[];
    identIdDescriptionSpecified: boolean;
    identIdExpireDate: number[];
    identIdExpireDateSpecified: boolean;
    identIdIssueDate: number[];
    identIdIssueDateSpecified: boolean;
    identIdNumber: number[];
    identIdNumberSpecified: boolean;
    identIdType: number[];
    identIdTypeSpecified: boolean;
    identIdVerifyDate: number[];
    identIdVerifyDateSpecified: boolean;
    irsCountryCodeValue: boolean;
    irsCountryCodeValueSpecified: boolean;
    irsCountryCode: boolean | null;
    lastValue: boolean;
    lastValueSpecified: boolean;
    last: boolean | null;
    leiValue: boolean;
    leiValueSpecified: boolean;
    lei: boolean | null;
    licenseValue: boolean;
    licenseValueSpecified: boolean;
    license: boolean | null;
    lobValue: boolean;
    lobValueSpecified: boolean;
    lob: boolean | null;
    longNameValue: boolean;
    longNameValueSpecified: boolean;
    longName: boolean | null;
    mbrActivityDateValue: boolean;
    mbrActivityDateValueSpecified: boolean;
    mbrActivityDate: boolean | null;
    mbrCreateDateValue: boolean;
    mbrCreateDateValueSpecified: boolean;
    mbrCreateDate: boolean | null;
    mbrCurrMthPayChgDateValue: boolean;
    mbrCurrMthPayChgDateValueSpecified: boolean;
    mbrCurrMthPayChgDate: boolean | null;
    mbrDisconnectDateValue: boolean;
    mbrDisconnectDateValueSpecified: boolean;
    mbrDisconnectDate: boolean | null;
    mbrExpDateValue: boolean;
    mbrExpDateValueSpecified: boolean;
    mbrExpDate: boolean | null;
    mbrFileTypeValue: boolean;
    mbrFileTypeValueSpecified: boolean;
    mbrFileType: boolean | null;
    mbrFmLastDateValue: boolean;
    mbrFmLastDateValueSpecified: boolean;
    mbrFmLastDate: boolean | null;
    mbrFmLastPurgeDateValue: boolean;
    mbrFmLastPurgeDateValueSpecified: boolean;
    mbrFmLastPurgeDate: boolean | null;
    mbrRecordChangeDateValue: boolean;
    mbrRecordChangeDateValueSpecified: boolean;
    mbrRecordChangeDate: boolean | null;
    mbrStatusValue: boolean;
    mbrStatusValueSpecified: boolean;
    mbrStatus: boolean | null;
    mbrStatusFmDateValue: boolean;
    mbrStatusFmDateValueSpecified: boolean;
    mbrStatusFmDate: boolean | null;
    memberNumberValue: boolean;
    memberNumberValueSpecified: boolean;
    memberNumber: boolean | null;
    middleValue: boolean;
    middleValueSpecified: boolean;
    middle: boolean | null;
    mobilePhoneValue: boolean;
    mobilePhoneValueSpecified: boolean;
    mobilePhone: boolean | null;
    mothersMaidenNameValue: boolean;
    mothersMaidenNameValueSpecified: boolean;
    mothersMaidenName: boolean | null;
    nameFormatValue: boolean;
    nameFormatValueSpecified: boolean;
    nameFormat: boolean | null;
    nraExemptionCodeValue: boolean;
    nraExemptionCodeValueSpecified: boolean;
    nraExemptionCode: boolean | null;
    nraTaxRateValue: boolean;
    nraTaxRateValueSpecified: boolean;
    nraTaxRate: boolean | null;
    occupationValue: boolean;
    occupationValueSpecified: boolean;
    occupation: boolean | null;
    pagerNumberValue: boolean;
    pagerNumberValueSpecified: boolean;
    pagerNumber: boolean | null;
    phoneTypeValue: boolean;
    phoneTypeValueSpecified: boolean;
    phoneType: boolean | null;
    preferredContactValue: boolean;
    preferredContactValueSpecified: boolean;
    preferredContact: boolean | null;
    preferredContactMethodValue: boolean;
    preferredContactMethodValueSpecified: boolean;
    preferredContactMethod: boolean | null;
    restrictValue: boolean;
    restrictValueSpecified: boolean;
    restrict: boolean | null;
    sexValue: boolean;
    sexValueSpecified: boolean;
    sex: boolean | null;
    shortNameValue: boolean;
    shortNameValueSpecified: boolean;
    shortName: boolean | null;
    ssnValue: boolean;
    ssnValueSpecified: boolean;
    ssn: boolean | null;
    ssnTypeValue: boolean;
    ssnTypeValueSpecified: boolean;
    ssnType: boolean | null;
    substantialOwnerValue: boolean;
    substantialOwnerValueSpecified: boolean;
    substantialOwner: boolean | null;
    suffixValue: boolean;
    suffixValueSpecified: boolean;
    suffix: boolean | null;
    titleValue: boolean;
    titleValueSpecified: boolean;
    title: boolean | null;
    usPersonFlagValue: boolean;
    usPersonFlagValueSpecified: boolean;
    usPersonFlag: boolean | null;
    userAmount1Value: boolean;
    userAmount1ValueSpecified: boolean;
    userAmount1: boolean | null;
    userAmount2Value: boolean;
    userAmount2ValueSpecified: boolean;
    userAmount2: boolean | null;
    userChar1Value: boolean;
    userChar1ValueSpecified: boolean;
    userChar1: boolean | null;
    userChar2Value: boolean;
    userChar2ValueSpecified: boolean;
    userChar2: boolean | null;
    userChar3Value: boolean;
    userChar3ValueSpecified: boolean;
    userChar3: boolean | null;
    userChar4Value: boolean;
    userChar4ValueSpecified: boolean;
    userChar4: boolean | null;
    userDate1Value: boolean;
    userDate1ValueSpecified: boolean;
    userDate1: boolean | null;
    userDate2Value: boolean;
    userDate2ValueSpecified: boolean;
    userDate2: boolean | null;
    w8ExpirationDateValue: boolean;
    w8ExpirationDateValueSpecified: boolean;
    w8ExpirationDate: boolean | null;
    workPhoneValue: boolean;
    workPhoneValueSpecified: boolean;
    workPhone: boolean | null;
    workPhoneExtensionValue: boolean;
    workPhoneExtensionValueSpecified: boolean;
    workPhoneExtension: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}