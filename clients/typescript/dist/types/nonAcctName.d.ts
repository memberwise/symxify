import { NonAcctNameIdentDocFlag } from "./nonAcctNameIdentDocFlag";
import { NonAcctNameIdentIdDescription } from "./nonAcctNameIdentIdDescription";
import { NonAcctNameIdentIdExpireDate } from "./nonAcctNameIdentIdExpireDate";
import { NonAcctNameIdentIdIssueDate } from "./nonAcctNameIdentIdIssueDate";
import { NonAcctNameIdentIdNumber } from "./nonAcctNameIdentIdNumber";
import { NonAcctNameIdentIdType } from "./nonAcctNameIdentIdType";
import { NonAcctNameIdentIdVerifyDate } from "./nonAcctNameIdentIdVerifyDate";
import { NonAcctNameFmHistoryList } from "./nonAcctNameFmHistoryList";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface NonAcctName {
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
    addrCreateDateValue: string;
    addrCreateDateValueSpecified: boolean;
    addrCreateDate: string | null;
    addrDisconnectDateValue: string;
    addrDisconnectDateValueSpecified: boolean;
    addrDisconnectDate: string | null;
    addrExpDateValue: string;
    addrExpDateValueSpecified: boolean;
    addrExpDate: string | null;
    addrFmLastDateValue: string;
    addrFmLastDateValueSpecified: boolean;
    addrFmLastDate: string | null;
    addrFmLastPurgeDateValue: string;
    addrFmLastPurgeDateValueSpecified: boolean;
    addrFmLastPurgeDate: string | null;
    addrRecordChangeDateValue: string;
    addrRecordChangeDateValueSpecified: boolean;
    addrRecordChangeDate: string | null;
    addressTypeValue: number;
    addressTypeValueSpecified: boolean;
    addressType: number | null;
    altEmail: string;
    beneficialOwnerValue: number;
    beneficialOwnerValueSpecified: boolean;
    beneficialOwner: number | null;
    beneficialPercentValue: number;
    beneficialPercentValueSpecified: boolean;
    beneficialPercent: number | null;
    beneficiaryPercentValue: number;
    beneficiaryPercentValueSpecified: boolean;
    beneficiaryPercent: number | null;
    birthDateValue: string;
    birthDateValueSpecified: boolean;
    birthDate: string | null;
    carrierRoute: string;
    chapter4StatusCode: string;
    city: string;
    confidentialValue: number;
    confidentialValueSpecified: boolean;
    confidential: number | null;
    country: string;
    countryCode: string;
    crAddrChgDateValue: string;
    crAddrChgDateValueSpecified: boolean;
    crAddrChgDate: string | null;
    crNameChgDateValue: string;
    crNameChgDateValueSpecified: boolean;
    crNameChgDate: string | null;
    crSsnChgDateValue: string;
    crSsnChgDateValueSpecified: boolean;
    crSsnChgDate: string | null;
    creditReportAddrIndicator: string;
    creditReportAddrIndicatorDateValue: string;
    creditReportAddrIndicatorDateValueSpecified: boolean;
    creditReportAddrIndicatorDate: string | null;
    creditReportConsumerInfo: string;
    creditReportConsumerInfoDateValue: string;
    creditReportConsumerInfoDateValueSpecified: boolean;
    creditReportConsumerInfoDate: string | null;
    ctrExemptValue: number;
    ctrExemptValueSpecified: boolean;
    ctrExempt: number | null;
    currGrossMonthPayValue: number;
    currGrossMonthPayValueSpecified: boolean;
    currGrossMonthPay: number | null;
    currMonthPayChgDateValue: string;
    currMonthPayChgDateValueSpecified: boolean;
    currMonthPayChgDate: string | null;
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
    ecoaCodeValue: number;
    ecoaCodeValueSpecified: boolean;
    ecoaCode: number | null;
    effectiveDateValue: string;
    effectiveDateValueSpecified: boolean;
    effectiveDate: string | null;
    email: string;
    employerName: string;
    expirationDateValue: string;
    expirationDateValueSpecified: boolean;
    expirationDate: string | null;
    extendedName: string;
    extraAddress: string;
    extraInfo: string;
    first: string;
    fmLastPurgeDateValue: string;
    fmLastPurgeDateValueSpecified: boolean;
    fmLastPurgeDate: string | null;
    foreignTin: string;
    formW8OnFileValue: number;
    formW8OnFileValueSpecified: boolean;
    formW8OnFile: number | null;
    gIin: string;
    headquartersValue: number;
    headquartersValueSpecified: boolean;
    headquarters: number | null;
    homePhone: string;
    identDocFlag: NonAcctNameIdentDocFlag[];
    identDocFlagSpecified: boolean;
    identIdDescription: NonAcctNameIdentIdDescription[];
    identIdDescriptionSpecified: boolean;
    identIdExpireDate: NonAcctNameIdentIdExpireDate[];
    identIdExpireDateSpecified: boolean;
    identIdIssueDate: NonAcctNameIdentIdIssueDate[];
    identIdIssueDateSpecified: boolean;
    identIdNumber: NonAcctNameIdentIdNumber[];
    identIdNumberSpecified: boolean;
    identIdType: NonAcctNameIdentIdType[];
    identIdTypeSpecified: boolean;
    identIdVerifyDate: NonAcctNameIdentIdVerifyDate[];
    identIdVerifyDateSpecified: boolean;
    irs1042SAmendNumValue: number;
    irs1042SAmendNumValueSpecified: boolean;
    irs1042SAmendNum: number | null;
    irsCorrectionValue: number;
    irsCorrectionValueSpecified: boolean;
    irsCorrection: number | null;
    irsCountryCode: string;
    last: string;
    lastAddrChgDateValue: string;
    lastAddrChgDateValueSpecified: boolean;
    lastAddrChgDate: string | null;
    lastAddrVerifDateValue: string;
    lastAddrVerifDateValueSpecified: boolean;
    lastAddrVerifDate: string | null;
    lastFmDateValue: string;
    lastFmDateValueSpecified: boolean;
    lastFmDate: string | null;
    lei: string;
    license: string;
    lob: string;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    longName: string;
    mailOverrideValue: number;
    mailOverrideValueSpecified: boolean;
    mailOverride: number | null;
    marketingAddressValue: number;
    marketingAddressValueSpecified: boolean;
    marketingAddress: number | null;
    mbrActivityDateValue: string;
    mbrActivityDateValueSpecified: boolean;
    mbrActivityDate: string | null;
    mbrAddrFileTypeValue: number;
    mbrAddrFileTypeValueSpecified: boolean;
    mbrAddrFileType: number | null;
    mbrAddrNumLink: string;
    mbrAddrNumLinkChgDateValue: string;
    mbrAddrNumLinkChgDateValueSpecified: boolean;
    mbrAddrNumLinkChgDate: string | null;
    mbrAddrNumber: string;
    mbrCreateDateValue: string;
    mbrCreateDateValueSpecified: boolean;
    mbrCreateDate: string | null;
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
    memberNumLink: string;
    memberNumLinkChgDateValue: string;
    memberNumLinkChgDateValueSpecified: boolean;
    memberNumLinkChgDate: string | null;
    memberNumber: string;
    middle: string;
    mobilePhone: string;
    mothersMaidenName: string;
    nameFormatValue: number;
    nameFormatValueSpecified: boolean;
    nameFormat: number | null;
    nonAcctNameFmHistoryList: NonAcctNameFmHistoryList;
    nonAcctNameNum: string;
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
    recordChangeDateValue: string;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    restrictValue: number;
    restrictValueSpecified: boolean;
    restrict: number | null;
    sex: string;
    shortName: string;
    ssn: string;
    ssnCertificationValue: number;
    ssnCertificationValueSpecified: boolean;
    ssnCertification: number | null;
    ssnOverrideValue: number;
    ssnOverrideValueSpecified: boolean;
    ssnOverride: number | null;
    ssnTypeValue: number;
    ssnTypeValueSpecified: boolean;
    ssnType: number | null;
    state: string;
    street: string;
    subTypeValue: number;
    subTypeValueSpecified: boolean;
    subType: number | null;
    substantialOwnerValue: number;
    substantialOwnerValueSpecified: boolean;
    substantialOwner: number | null;
    suffix: string;
    title: string;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
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
    zipCode: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
