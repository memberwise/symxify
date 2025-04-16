import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface OnlineFeeFields {
    accountTypesValue: boolean;
    accountTypesValueSpecified: boolean;
    accountTypes: boolean | null;
    acquirerNetworkIdsValue: boolean;
    acquirerNetworkIdsValueSpecified: boolean;
    acquirerNetworkIds: boolean | null;
    cardAcceptorNameValue: boolean;
    cardAcceptorNameValueSpecified: boolean;
    cardAcceptorName: boolean | null;
    cardTypesValue: boolean;
    cardTypesValueSpecified: boolean;
    cardTypes: boolean | null;
    coOpTransactionValue: boolean;
    coOpTransactionValueSpecified: boolean;
    coOpTransaction: boolean | null;
    customCriterionValue: boolean;
    customCriterionValueSpecified: boolean;
    customCriterion: boolean | null;
    excludeServiceCodesValue: boolean;
    excludeServiceCodesValueSpecified: boolean;
    excludeServiceCodes: boolean | null;
    feeCountLevelValue: boolean;
    feeCountLevelValueSpecified: boolean;
    feeCountLevel: boolean | null;
    feeCountNumberValue: boolean;
    feeCountNumberValueSpecified: boolean;
    feeCountNumber: boolean | null;
    feeCountTotalsValue: boolean;
    feeCountTotalsValueSpecified: boolean;
    feeCountTotals: boolean | null;
    feeDescriptionValue: boolean;
    feeDescriptionValueSpecified: boolean;
    feeDescription: boolean | null;
    feeGlCodeValue: boolean;
    feeGlCodeValueSpecified: boolean;
    feeGlCode: boolean | null;
    feePostingOptionValue: boolean;
    feePostingOptionValueSpecified: boolean;
    feePostingOption: boolean | null;
    includeServiceCodesValue: boolean;
    includeServiceCodesValueSpecified: boolean;
    includeServiceCodes: boolean | null;
    relationFeeAmount: number[];
    relationFeeAmountSpecified: boolean;
    relationRelCodes: number[];
    relationRelCodesSpecified: boolean;
    relationWaiveCount: number[];
    relationWaiveCountSpecified: boolean;
    ruleDescriptionValue: boolean;
    ruleDescriptionValueSpecified: boolean;
    ruleDescription: boolean | null;
    ruleOrdinalValue: boolean;
    ruleOrdinalValueSpecified: boolean;
    ruleOrdinal: boolean | null;
    rulePositionValue: boolean;
    rulePositionValueSpecified: boolean;
    rulePosition: boolean | null;
    shareLoanValue: boolean;
    shareLoanValueSpecified: boolean;
    shareLoan: boolean | null;
    shareLoanTypesValue: boolean;
    shareLoanTypesValueSpecified: boolean;
    shareLoanTypes: boolean | null;
    terminalTableValue: boolean;
    terminalTableValueSpecified: boolean;
    terminalTable: boolean | null;
    transactionCodesValue: boolean;
    transactionCodesValueSpecified: boolean;
    transactionCodes: boolean | null;
    transactionTypesValue: boolean;
    transactionTypesValueSpecified: boolean;
    transactionTypes: boolean | null;
    warningCodeExclListValue: boolean;
    warningCodeExclListValueSpecified: boolean;
    warningCodeExclList: boolean | null;
    warningCodeInclListValue: boolean;
    warningCodeInclListValueSpecified: boolean;
    warningCodeInclList: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
