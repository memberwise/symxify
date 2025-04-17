import { MemberRecIdentDocFlag } from "./memberRecIdentDocFlag";
import { MemberRecIdentIdDescription } from "./memberRecIdentIdDescription";
import { MemberRecIdentIdExpireDate } from "./memberRecIdentIdExpireDate";
import { MemberRecIdentIdIssueDate } from "./memberRecIdentIdIssueDate";
import { MemberRecIdentIdNumber } from "./memberRecIdentIdNumber";
import { MemberRecIdentIdType } from "./memberRecIdentIdType";
import { MemberRecIdentIdVerifyDate } from "./memberRecIdentIdVerifyDate";
import { MemberRecFmHistoryList } from "./memberRecFmHistoryList";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface MemberRec {
    activeDutyValue: number;
    activeDutyValueSpecified: boolean;
    activeDuty: number | null;
    activeDutySeparationDateValue: string;
    activeDutySeparationDateValueSpecified: boolean;
    activeDutySeparationDate: string | null;
    activeDutyStartDateValue: string;
    activeDutyStartDateValueSpecified: boolean;
    activeDutyStartDate: string | null;
    activeDutyVerificationDateValue: string;
    activeDutyVerificationDateValueSpecified: boolean;
    activeDutyVerificationDate: string | null;
    altEmail: string;
    birthDateValue: string;
    birthDateValueSpecified: boolean;
    birthDate: string | null;
    chapter4StatusCode: string;
    ctrExemptValue: number;
    ctrExemptValueSpecified: boolean;
    ctrExempt: number | null;
    currGrossMonthPayValue: number;
    currGrossMonthPayValueSpecified: boolean;
    currGrossMonthPay: number | null;
    currNetMonthPayValue: number;
    currNetMonthPayValueSpecified: boolean;
    currNetMonthPay: number | null;
    dbaExtendedName: string;
    dbaFirst: string;
    dbaLast: string;
    dbaLongName: string;
    dbaMiddle: string;
    dbaNameFormatValue: number;
    dbaNameFormatValueSpecified: boolean;
    dbaNameFormat: number | null;
    dbaShortName: string;
    dbaSuffix: string;
    dbaTitle: string;
    deathDateValue: string;
    deathDateValueSpecified: boolean;
    deathDate: string | null;
    email: string;
    employerName: string;
    extendedName: string;
    first: string;
    foreignTin: string;
    formW8OnFileValue: number;
    formW8OnFileValueSpecified: boolean;
    formW8OnFile: number | null;
    gIin: string;
    homePhone: string;
    identDocFlag: MemberRecIdentDocFlag[];
    identDocFlagSpecified: boolean;
    identIdDescription: MemberRecIdentIdDescription[];
    identIdDescriptionSpecified: boolean;
    identIdExpireDate: MemberRecIdentIdExpireDate[];
    identIdExpireDateSpecified: boolean;
    identIdIssueDate: MemberRecIdentIdIssueDate[];
    identIdIssueDateSpecified: boolean;
    identIdNumber: MemberRecIdentIdNumber[];
    identIdNumberSpecified: boolean;
    identIdType: MemberRecIdentIdType[];
    identIdTypeSpecified: boolean;
    identIdVerifyDate: MemberRecIdentIdVerifyDate[];
    identIdVerifyDateSpecified: boolean;
    irsCountryCode: string;
    last: string;
    lei: string;
    license: string;
    lob: string;
    longName: string;
    mbrActivityDateValue: string;
    mbrActivityDateValueSpecified: boolean;
    mbrActivityDate: string | null;
    mbrCreateDateValue: string;
    mbrCreateDateValueSpecified: boolean;
    mbrCreateDate: string | null;
    mbrCurrMthPayChgDateValue: string;
    mbrCurrMthPayChgDateValueSpecified: boolean;
    mbrCurrMthPayChgDate: string | null;
    mbrDisconnectDateValue: string;
    mbrDisconnectDateValueSpecified: boolean;
    mbrDisconnectDate: string | null;
    mbrExpDateValue: string;
    mbrExpDateValueSpecified: boolean;
    mbrExpDate: string | null;
    mbrFileTypeValue: number;
    mbrFileTypeValueSpecified: boolean;
    mbrFileType: number | null;
    mbrFmLastDateValue: string;
    mbrFmLastDateValueSpecified: boolean;
    mbrFmLastDate: string | null;
    mbrFmLastPurgeDateValue: string;
    mbrFmLastPurgeDateValueSpecified: boolean;
    mbrFmLastPurgeDate: string | null;
    mbrRecordChangeDateValue: string;
    mbrRecordChangeDateValueSpecified: boolean;
    mbrRecordChangeDate: string | null;
    mbrStatusValue: number;
    mbrStatusValueSpecified: boolean;
    mbrStatus: number | null;
    mbrStatusFmDateValue: string;
    mbrStatusFmDateValueSpecified: boolean;
    mbrStatusFmDate: string | null;
    memberNumber: string;
    memberRecFmHistoryList: MemberRecFmHistoryList;
    middle: string;
    mobilePhone: string;
    mothersMaidenName: string;
    nameFormatValue: number;
    nameFormatValueSpecified: boolean;
    nameFormat: number | null;
    nraExemptionCode: string;
    nraTaxRateValue: number;
    nraTaxRateValueSpecified: boolean;
    nraTaxRate: number | null;
    occupation: string;
    pagerNumber: string;
    phoneTypeValue: number;
    phoneTypeValueSpecified: boolean;
    phoneType: number | null;
    preferredContact: string;
    preferredContactMethodValue: number;
    preferredContactMethodValueSpecified: boolean;
    preferredContactMethod: number | null;
    restrictValue: number;
    restrictValueSpecified: boolean;
    restrict: number | null;
    sex: string;
    shortName: string;
    ssn: string;
    ssnTypeValue: number;
    ssnTypeValueSpecified: boolean;
    ssnType: number | null;
    substantialOwnerValue: number;
    substantialOwnerValueSpecified: boolean;
    substantialOwner: number | null;
    suffix: string;
    title: string;
    usPersonFlagValue: number;
    usPersonFlagValueSpecified: boolean;
    usPersonFlag: number | null;
    userAmount1Value: number;
    userAmount1ValueSpecified: boolean;
    userAmount1: number | null;
    userAmount2Value: number;
    userAmount2ValueSpecified: boolean;
    userAmount2: number | null;
    userChar1: string;
    userChar2: string;
    userChar3: string;
    userChar4: string;
    userDate1Value: string;
    userDate1ValueSpecified: boolean;
    userDate1: string | null;
    userDate2Value: string;
    userDate2ValueSpecified: boolean;
    userDate2: string | null;
    w8ExpirationDateValue: string;
    w8ExpirationDateValueSpecified: boolean;
    w8ExpirationDate: string | null;
    workPhone: string;
    workPhoneExtension: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}