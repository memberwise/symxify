import { VersionType } from "./versionType";

export interface MemberRecFields {
    activeDuty: boolean | null;
    activeDutySeparationDate: boolean | null;
    activeDutyStartDate: boolean | null;
    activeDutyVerificationDate: boolean | null;
    altEmail: boolean | null;
    birthDate: boolean | null;
    chapter4StatusCode: boolean | null;
    ctrExempt: boolean | null;
    currGrossMonthPay: boolean | null;
    currNetMonthPay: boolean | null;
    dbaExtendedName: boolean | null;
    dbaFirst: boolean | null;
    dbaLast: boolean | null;
    dbaLongName: boolean | null;
    dbaMiddle: boolean | null;
    dbaNameFormat: boolean | null;
    dbaShortName: boolean | null;
    dbaSuffix: boolean | null;
    dbaTitle: boolean | null;
    deathDate: boolean | null;
    email: boolean | null;
    employerName: boolean | null;
    extendedName: boolean | null;
    first: boolean | null;
    foreignTin: boolean | null;
    formW8OnFile: boolean | null;
    gIin: boolean | null;
    homePhone: boolean | null;
    identDocFlag: number[];
    identIdDescription: number[];
    identIdExpireDate: number[];
    identIdIssueDate: number[];
    identIdNumber: number[];
    identIdType: number[];
    identIdVerifyDate: number[];
    irsCountryCode: boolean | null;
    last: boolean | null;
    lei: boolean | null;
    license: boolean | null;
    lob: boolean | null;
    longName: boolean | null;
    mbrActivityDate: boolean | null;
    mbrCreateDate: boolean | null;
    mbrCurrMthPayChgDate: boolean | null;
    mbrDisconnectDate: boolean | null;
    mbrExpDate: boolean | null;
    mbrFileType: boolean | null;
    mbrFmLastDate: boolean | null;
    mbrFmLastPurgeDate: boolean | null;
    mbrRecordChangeDate: boolean | null;
    mbrStatus: boolean | null;
    mbrStatusFmDate: boolean | null;
    memberNumber: boolean | null;
    middle: boolean | null;
    mobilePhone: boolean | null;
    mothersMaidenName: boolean | null;
    nameFormat: boolean | null;
    nraExemptionCode: boolean | null;
    nraTaxRate: boolean | null;
    occupation: boolean | null;
    pagerNumber: boolean | null;
    phoneType: boolean | null;
    preferredContact: boolean | null;
    preferredContactMethod: boolean | null;
    restrict: boolean | null;
    sex: boolean | null;
    shortName: boolean | null;
    ssn: boolean | null;
    ssnType: boolean | null;
    substantialOwner: boolean | null;
    suffix: boolean | null;
    title: boolean | null;
    usPersonFlag: boolean | null;
    userAmount1: boolean | null;
    userAmount2: boolean | null;
    userChar1: boolean | null;
    userChar2: boolean | null;
    userChar3: boolean | null;
    userChar4: boolean | null;
    userDate1: boolean | null;
    userDate2: boolean | null;
    w8ExpirationDate: boolean | null;
    workPhone: boolean | null;
    workPhoneExtension: boolean | null;
    version1: VersionType;
}