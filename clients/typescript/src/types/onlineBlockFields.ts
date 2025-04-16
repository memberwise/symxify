import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface OnlineBlockFields {
    blockWarningsListValue: boolean;
    blockWarningsListValueSpecified: boolean;
    blockWarningsList: boolean | null;
    cardAcceptorCountryCodeValue: boolean;
    cardAcceptorCountryCodeValueSpecified: boolean;
    cardAcceptorCountryCode: boolean | null;
    cardAcceptorIdCodeValue: boolean;
    cardAcceptorIdCodeValueSpecified: boolean;
    cardAcceptorIdCode: boolean | null;
    cardAcceptorNameValue: boolean;
    cardAcceptorNameValueSpecified: boolean;
    cardAcceptorName: boolean | null;
    cardAcceptorStatesValue: boolean;
    cardAcceptorStatesValueSpecified: boolean;
    cardAcceptorStates: boolean | null;
    cardAcceptorZipCodesValue: boolean;
    cardAcceptorZipCodesValueSpecified: boolean;
    cardAcceptorZipCodes: boolean | null;
    cardNotPresentValue: boolean;
    cardNotPresentValueSpecified: boolean;
    cardNotPresent: boolean | null;
    cardTypesValue: boolean;
    cardTypesValueSpecified: boolean;
    cardTypes: boolean | null;
    descriptionValue: boolean;
    descriptionValueSpecified: boolean;
    description: boolean | null;
    emvFallbackValue: boolean;
    emvFallbackValueSpecified: boolean;
    emvFallback: boolean | null;
    excludedCountryCodesValue: boolean;
    excludedCountryCodesValueSpecified: boolean;
    excludedCountryCodes: boolean | null;
    expirationDateValue: boolean;
    expirationDateValueSpecified: boolean;
    expirationDate: boolean | null;
    masterCardRiskScoreValue: boolean;
    masterCardRiskScoreValueSpecified: boolean;
    masterCardRiskScore: boolean | null;
    maximumTransactionAmountValue: boolean;
    maximumTransactionAmountValueSpecified: boolean;
    maximumTransactionAmount: boolean | null;
    merchantTypesValue: boolean;
    merchantTypesValueSpecified: boolean;
    merchantTypes: boolean | null;
    minimumTransactionAmountValue: boolean;
    minimumTransactionAmountValueSpecified: boolean;
    minimumTransactionAmount: boolean | null;
    overrideWarningsListValue: boolean;
    overrideWarningsListValueSpecified: boolean;
    overrideWarningsList: boolean | null;
    panEntryModesValue: boolean;
    panEntryModesValueSpecified: boolean;
    panEntryModes: boolean | null;
    persontoPersonPaymentValue: boolean;
    persontoPersonPaymentValueSpecified: boolean;
    persontoPersonPayment: boolean | null;
    pinlessPinTransactionValue: boolean;
    pinlessPinTransactionValueSpecified: boolean;
    pinlessPinTransaction: boolean | null;
    pseudoTerminalIdValue: boolean;
    pseudoTerminalIdValueSpecified: boolean;
    pseudoTerminalId: boolean | null;
    ruleNumberValue: boolean;
    ruleNumberValueSpecified: boolean;
    ruleNumber: boolean | null;
    terminalIdValue: boolean;
    terminalIdValueSpecified: boolean;
    terminalId: boolean | null;
    trackingRecordOverrideValue: boolean;
    trackingRecordOverrideValueSpecified: boolean;
    trackingRecordOverride: boolean | null;
    transactionCodesValue: boolean;
    transactionCodesValueSpecified: boolean;
    transactionCodes: boolean | null;
    transactionTypesValue: boolean;
    transactionTypesValueSpecified: boolean;
    transactionTypes: boolean | null;
    visaAdvAuthScoreValue: boolean;
    visaAdvAuthScoreValueSpecified: boolean;
    visaAdvAuthScore: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}