import { LoanNameIdentDocFlag_2 } from "./loanNameIdentDocFlag_2";
import { LoanNameIdentIdDescription_2 } from "./loanNameIdentIdDescription_2";
import { LoanNameIdentIdExpireDate_2 } from "./loanNameIdentIdExpireDate_2";
import { LoanNameIdentIdIssueDate_2 } from "./loanNameIdentIdIssueDate_2";
import { LoanNameIdentIdNumber_2 } from "./loanNameIdentIdNumber_2";
import { LoanNameIdentIdType_2 } from "./loanNameIdentIdType_2";
import { LoanNameIdentIdVerifyDate_2 } from "./loanNameIdentIdVerifyDate_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface LoanName_2 {
    activeDutyValue: number;
    activeDutyValueSpecified: boolean;
    activeDuty: number | null;
    activeDutySeparationDateValue: string | null;
    activeDutySeparationDateValueSpecified: boolean;
    activeDutySeparationDate: string | null;
    activeDutyStartDateValue: string | null;
    activeDutyStartDateValueSpecified: boolean;
    activeDutyStartDate: string | null;
    activeDutyVerificationDateValue: string | null;
    activeDutyVerificationDateValueSpecified: boolean;
    activeDutyVerificationDate: string | null;
    addrCreateDateValue: string | null;
    addrCreateDateValueSpecified: boolean;
    addrCreateDate: string | null;
    addrDisconnectDateValue: string | null;
    addrDisconnectDateValueSpecified: boolean;
    addrDisconnectDate: string | null;
    addrExpDateValue: string | null;
    addrExpDateValueSpecified: boolean;
    addrExpDate: string | null;
    addrFmLastDateValue: string | null;
    addrFmLastDateValueSpecified: boolean;
    addrFmLastDate: string | null;
    addrFmLastPurgeDateValue: string | null;
    addrFmLastPurgeDateValueSpecified: boolean;
    addrFmLastPurgeDate: string | null;
    addrRecordChangeDateValue: string | null;
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
    birthDateValue: string | null;
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
    crAddrChgDateValue: string | null;
    crAddrChgDateValueSpecified: boolean;
    crAddrChgDate: string | null;
    crNameChgDateValue: string | null;
    crNameChgDateValueSpecified: boolean;
    crNameChgDate: string | null;
    crSsnChgDateValue: string | null;
    crSsnChgDateValueSpecified: boolean;
    crSsnChgDate: string | null;
    creditReportAddrIndicator: string;
    creditReportAddrIndicatorDateValue: string | null;
    creditReportAddrIndicatorDateValueSpecified: boolean;
    creditReportAddrIndicatorDate: string | null;
    creditReportConsumerInfo: string;
    creditReportConsumerInfoDateValue: string | null;
    creditReportConsumerInfoDateValueSpecified: boolean;
    creditReportConsumerInfoDate: string | null;
    ctrExemptValue: number;
    ctrExemptValueSpecified: boolean;
    ctrExempt: number | null;
    currGrossMonthPayValue: number;
    currGrossMonthPayValueSpecified: boolean;
    currGrossMonthPay: number | null;
    currMonthPayChgDateValue: string | null;
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
    deathDateValue: string | null;
    deathDateValueSpecified: boolean;
    deathDate: string | null;
    ecoaCodeValue: number;
    ecoaCodeValueSpecified: boolean;
    ecoaCode: number | null;
    effectiveDateValue: string | null;
    effectiveDateValueSpecified: boolean;
    effectiveDate: string | null;
    email: string;
    employerName: string;
    expirationDateValue: string | null;
    expirationDateValueSpecified: boolean;
    expirationDate: string | null;
    extendedName: string;
    extraAddress: string;
    extraInfo: string;
    first: string;
    fmLastPurgeDateValue: string | null;
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
    identDocFlag: LoanNameIdentDocFlag_2[];
    identDocFlagSpecified: boolean;
    identIdDescription: LoanNameIdentIdDescription_2[];
    identIdDescriptionSpecified: boolean;
    identIdExpireDate: LoanNameIdentIdExpireDate_2[];
    identIdExpireDateSpecified: boolean;
    identIdIssueDate: LoanNameIdentIdIssueDate_2[];
    identIdIssueDateSpecified: boolean;
    identIdNumber: LoanNameIdentIdNumber_2[];
    identIdNumberSpecified: boolean;
    identIdType: LoanNameIdentIdType_2[];
    identIdTypeSpecified: boolean;
    identIdVerifyDate: LoanNameIdentIdVerifyDate_2[];
    identIdVerifyDateSpecified: boolean;
    irs1042SAmendNumValue: number;
    irs1042SAmendNumValueSpecified: boolean;
    irs1042SAmendNum: number | null;
    irsCorrectionValue: number;
    irsCorrectionValueSpecified: boolean;
    irsCorrection: number | null;
    irsCountryCode: string;
    last: string;
    lastAddrChgDateValue: string | null;
    lastAddrChgDateValueSpecified: boolean;
    lastAddrChgDate: string | null;
    lastAddrVerifDateValue: string | null;
    lastAddrVerifDateValueSpecified: boolean;
    lastAddrVerifDate: string | null;
    lastFmDateValue: string | null;
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
    mbrActivityDateValue: string | null;
    mbrActivityDateValueSpecified: boolean;
    mbrActivityDate: string | null;
    mbrAddrFileTypeValue: number;
    mbrAddrFileTypeValueSpecified: boolean;
    mbrAddrFileType: number | null;
    mbrAddrNumLink: string;
    mbrAddrNumLinkChgDateValue: string | null;
    mbrAddrNumLinkChgDateValueSpecified: boolean;
    mbrAddrNumLinkChgDate: string | null;
    mbrAddrNumber: string;
    mbrCreateDateValue: string | null;
    mbrCreateDateValueSpecified: boolean;
    mbrCreateDate: string | null;
    mbrDisconnectDateValue: string | null;
    mbrDisconnectDateValueSpecified: boolean;
    mbrDisconnectDate: string | null;
    mbrExpDateValue: string | null;
    mbrExpDateValueSpecified: boolean;
    mbrExpDate: string | null;
    mbrFileTypeValue: number;
    mbrFileTypeValueSpecified: boolean;
    mbrFileType: number | null;
    mbrFmLastDateValue: string | null;
    mbrFmLastDateValueSpecified: boolean;
    mbrFmLastDate: string | null;
    mbrFmLastPurgeDateValue: string | null;
    mbrFmLastPurgeDateValueSpecified: boolean;
    mbrFmLastPurgeDate: string | null;
    mbrRecordChangeDateValue: string | null;
    mbrRecordChangeDateValueSpecified: boolean;
    mbrRecordChangeDate: string | null;
    mbrStatusValue: number;
    mbrStatusValueSpecified: boolean;
    mbrStatus: number | null;
    mbrStatusFmDateValue: string | null;
    mbrStatusFmDateValueSpecified: boolean;
    mbrStatusFmDate: string | null;
    memberNumLink: string;
    memberNumLinkChgDateValue: string | null;
    memberNumLinkChgDateValueSpecified: boolean;
    memberNumLinkChgDate: string | null;
    memberNumber: string;
    middle: string;
    mobilePhone: string;
    mothersMaidenName: string;
    nameFormatValue: number;
    nameFormatValueSpecified: boolean;
    nameFormat: number | null;
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
    recordChangeDateValue: string | null;
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
    userDate1Value: string | null;
    userDate1ValueSpecified: boolean;
    userDate1: string | null;
    userDate2Value: string | null;
    userDate2ValueSpecified: boolean;
    userDate2: string | null;
    w8ExpirationDateValue: string | null;
    w8ExpirationDateValueSpecified: boolean;
    w8ExpirationDate: string | null;
    workPhone: string;
    workPhoneExtension: string;
    zipCode: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
