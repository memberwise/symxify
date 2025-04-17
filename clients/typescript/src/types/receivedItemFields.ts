import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface ReceivedItemFields {
    assocAccountNumberValue: boolean;
    assocAccountNumberValueSpecified: boolean;
    assocAccountNumber: boolean | null;
    assocIdValue: boolean;
    assocIdValueSpecified: boolean;
    assocId: boolean | null;
    assocIdTypeValue: boolean;
    assocIdTypeValueSpecified: boolean;
    assocIdType: boolean | null;
    bondDenominationValue: boolean;
    bondDenominationValueSpecified: boolean;
    bondDenomination: boolean | null;
    bondInterestValue: boolean;
    bondInterestValueSpecified: boolean;
    bondInterest: boolean | null;
    bondPrincipalValue: boolean;
    bondPrincipalValueSpecified: boolean;
    bondPrincipal: boolean | null;
    bondRecpCityValue: boolean;
    bondRecpCityValueSpecified: boolean;
    bondRecpCity: boolean | null;
    bondRecpNameValue: boolean;
    bondRecpNameValueSpecified: boolean;
    bondRecpName: boolean | null;
    bondRecpSsnValue: boolean;
    bondRecpSsnValueSpecified: boolean;
    bondRecpSsn: boolean | null;
    bondRecpStateValue: boolean;
    bondRecpStateValueSpecified: boolean;
    bondRecpState: boolean | null;
    bondRecpStreetValue: boolean;
    bondRecpStreetValueSpecified: boolean;
    bondRecpStreet: boolean | null;
    bondRecpZipCodeValue: boolean;
    bondRecpZipCodeValueSpecified: boolean;
    bondRecpZipCode: boolean | null;
    branchValue: boolean;
    branchValueSpecified: boolean;
    branch: boolean | null;
    chargeOffDateValue: boolean;
    chargeOffDateValueSpecified: boolean;
    chargeOffDate: boolean | null;
    collectedDateValue: boolean;
    collectedDateValueSpecified: boolean;
    collectedDate: boolean | null;
    collectionDateValue: boolean;
    collectionDateValueSpecified: boolean;
    collectionDate: boolean | null;
    consoleNumberValue: boolean;
    consoleNumberValueSpecified: boolean;
    consoleNumber: boolean | null;
    disposition: number[];
    dispositionSpecified: boolean;
    fraudCode: number[];
    fraudCodeSpecified: boolean;
    fraudDescription: number[];
    fraudDescriptionSpecified: boolean;
    fraudSeverity: number[];
    fraudSeveritySpecified: boolean;
    fraudVendor: number[];
    fraudVendorSpecified: boolean;
    globalSequenceValue: boolean;
    globalSequenceValueSpecified: boolean;
    globalSequence: boolean | null;
    globalSequenceDateValue: boolean;
    globalSequenceDateValueSpecified: boolean;
    globalSequenceDate: boolean | null;
    inputSourceValue: boolean;
    inputSourceValueSpecified: boolean;
    inputSource: boolean | null;
    itcForeignItemValue: boolean;
    itcForeignItemValueSpecified: boolean;
    itcForeignItem: boolean | null;
    itcReportedValue: boolean;
    itcReportedValueSpecified: boolean;
    itcReported: boolean | null;
    itcStatusCodeValue: boolean;
    itcStatusCodeValueSpecified: boolean;
    itcStatusCode: boolean | null;
    itemAcctNumberValue: boolean;
    itemAcctNumberValueSpecified: boolean;
    itemAcctNumber: boolean | null;
    itemAmountValue: boolean;
    itemAmountValueSpecified: boolean;
    itemAmount: boolean | null;
    itemCheckNumberValue: boolean;
    itemCheckNumberValueSpecified: boolean;
    itemCheckNumber: boolean | null;
    itemIdValue: boolean;
    itemIdValueSpecified: boolean;
    itemId: boolean | null;
    micr1Value: boolean;
    micr1ValueSpecified: boolean;
    micr1: boolean | null;
    micr2Value: boolean;
    micr2ValueSpecified: boolean;
    micr2: boolean | null;
    micrAmountValue: boolean;
    micrAmountValueSpecified: boolean;
    micrAmount: boolean | null;
    micrAuxOnUsValue: boolean;
    micrAuxOnUsValueSpecified: boolean;
    micrAuxOnUs: boolean | null;
    micrEpcValue: boolean;
    micrEpcValueSpecified: boolean;
    micrEpc: boolean | null;
    micrOnUsValue: boolean;
    micrOnUsValueSpecified: boolean;
    micrOnUs: boolean | null;
    micrTransitValue: boolean;
    micrTransitValueSpecified: boolean;
    micrTransit: boolean | null;
    onUsValue: boolean;
    onUsValueSpecified: boolean;
    onUs: boolean | null;
    onUsAcctNumberValue: boolean;
    onUsAcctNumberValueSpecified: boolean;
    onUsAcctNumber: boolean | null;
    onUsIdValue: boolean;
    onUsIdValueSpecified: boolean;
    onUsId: boolean | null;
    onUsIdTypeValue: boolean;
    onUsIdTypeValueSpecified: boolean;
    onUsIdType: boolean | null;
    postDateValue: boolean;
    postDateValueSpecified: boolean;
    postDate: boolean | null;
    postTimeValue: boolean;
    postTimeValueSpecified: boolean;
    postTime: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    rejectDateValue: boolean;
    rejectDateValueSpecified: boolean;
    rejectDate: boolean | null;
    reportDateValue: boolean;
    reportDateValueSpecified: boolean;
    reportDate: boolean | null;
    resubmitDate: number[];
    resubmitDateSpecified: boolean;
    returnDate: number[];
    returnDateSpecified: boolean;
    returnReason: number[];
    returnReasonSpecified: boolean;
    sbFlagValue: boolean;
    sbFlagValueSpecified: boolean;
    sbFlag: boolean | null;
    sbTranSequenceNumberValue: boolean;
    sbTranSequenceNumberValueSpecified: boolean;
    sbTranSequenceNumber: boolean | null;
    sequenceNumberValue: boolean;
    sequenceNumberValueSpecified: boolean;
    sequenceNumber: boolean | null;
    statusValue: boolean;
    statusValueSpecified: boolean;
    status: boolean | null;
    tranSeqNumberAll: number[];
    tranSeqNumberAllSpecified: boolean;
    tranSetIdValue: boolean;
    tranSetIdValueSpecified: boolean;
    tranSetId: boolean | null;
    typeValue: boolean;
    typeValueSpecified: boolean;
    type: boolean | null;
    userNumberValue: boolean;
    userNumberValueSpecified: boolean;
    userNumber: boolean | null;
    voidDateValue: boolean;
    voidDateValueSpecified: boolean;
    voidDate: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}