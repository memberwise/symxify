import { BitMap } from "./bitMap";
import { OnlineCardLimitCustomCondition } from "./onlineCardLimitCustomCondition";
import { OnlineCardLimitDescription } from "./onlineCardLimitDescription";
import { OnlineCardLimitMcc } from "./onlineCardLimitMcc";
import { OnlineCardLimitSourceCodes } from "./onlineCardLimitSourceCodes";
import { OnlineCardLimitTransactionCodes } from "./onlineCardLimitTransactionCodes";
import { OnlineCardLimitTransactionSubTypes } from "./onlineCardLimitTransactionSubTypes";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface OnlineCard {
    activateOnFirstPinTranValue: boolean;
    activateOnFirstPinTranValueSpecified: boolean;
    activateOnFirstPinTran: boolean | null;
    aggregateLimitingCardTypes: BitMap;
    alternateDraftAccountValue: number;
    alternateDraftAccountValueSpecified: boolean;
    alternateDraftAccount: number | null;
    alternateFundingAccountValue: number;
    alternateFundingAccountValueSpecified: boolean;
    alternateFundingAccount: number | null;
    alwaysPosttoFundingList: string;
    atmAmountLimitFields: string;
    atmAmountUsedFields: string;
    atmCountLimitFields: string;
    atmCountUsedFields: string;
    atmDepAmtLimitPerCardValue: boolean;
    atmDepAmtLimitPerCardValueSpecified: boolean;
    atmDepAmtLimitPerCard: boolean | null;
    atmDepositCountLimitingValue: boolean;
    atmDepositCountLimitingValueSpecified: boolean;
    atmDepositCountLimiting: boolean | null;
    billPaymentCategorizationValue: number;
    billPaymentCategorizationValueSpecified: boolean;
    billPaymentCategorization: number | null;
    bin: string;
    binTypeValue: number;
    binTypeValueSpecified: boolean;
    binType: number | null;
    bpAmountLimitFields: string;
    bpAmountUsedFields: string;
    bpCountLimitFields: string;
    bpCountUsedFields: string;
    cardLimitingOptionValue: number;
    cardLimitingOptionValueSpecified: boolean;
    cardLimitingOption: number | null;
    cardNumberLengthValue: number;
    cardNumberLengthValueSpecified: boolean;
    cardNumberLength: number | null;
    cardNumberinTranHistoryValue: boolean;
    cardNumberinTranHistoryValueSpecified: boolean;
    cardNumberinTranHistory: boolean | null;
    cardTypeValue: number;
    cardTypeValueSpecified: boolean;
    cardType: number | null;
    chargeMasterCardCcaFeeValue: boolean;
    chargeMasterCardCcaFeeValueSpecified: boolean;
    chargeMasterCardCcaFee: boolean | null;
    chargeMasterCardIcaFeeValue: boolean;
    chargeMasterCardIcaFeeValueSpecified: boolean;
    chargeMasterCardIcaFee: boolean | null;
    checkActivationDateValue: boolean;
    checkActivationDateValueSpecified: boolean;
    checkActivationDate: boolean | null;
    checkOnlineMsgExpDateValue: boolean;
    checkOnlineMsgExpDateValueSpecified: boolean;
    checkOnlineMsgExpDate: boolean | null;
    chgVisaMultiCrrncyIsaFeeValue: boolean;
    chgVisaMultiCrrncyIsaFeeValueSpecified: boolean;
    chgVisaMultiCrrncyIsaFee: boolean | null;
    chgVisasGlCrrncyIsaFeeValue: boolean;
    chgVisasGlCrrncyIsaFeeValueSpecified: boolean;
    chgVisasGlCrrncyIsaFee: boolean | null;
    creditFacilityValue: number;
    creditFacilityValueSpecified: boolean;
    creditFacility: number | null;
    deactivatePreviousCardValue: boolean;
    deactivatePreviousCardValueSpecified: boolean;
    deactivatePreviousCard: boolean | null;
    deactvPrevCardExclWarnCdValue: number;
    deactvPrevCardExclWarnCdValueSpecified: boolean;
    deactvPrevCardExclWarnCd: number | null;
    fundingAccountValue: number;
    fundingAccountValueSpecified: boolean;
    fundingAccount: number | null;
    idLogicOptionValue: number;
    idLogicOptionValueSpecified: boolean;
    idLogicOption: number | null;
    limitCustomCondition: OnlineCardLimitCustomCondition[];
    limitCustomConditionSpecified: boolean;
    limitDescription: OnlineCardLimitDescription[];
    limitDescriptionSpecified: boolean;
    limitMcc: OnlineCardLimitMcc[];
    limitMccSpecified: boolean;
    limitSourceCodes: OnlineCardLimitSourceCodes[];
    limitSourceCodesSpecified: boolean;
    limitTransactionCodes: OnlineCardLimitTransactionCodes[];
    limitTransactionCodesSpecified: boolean;
    limitTransactionSubTypes: OnlineCardLimitTransactionSubTypes[];
    limitTransactionSubTypesSpecified: boolean;
    masterCardCcaRateValue: number;
    masterCardCcaRateValueSpecified: boolean;
    masterCardCcaRate: number | null;
    masterCardIcaRateValue: number;
    masterCardIcaRateValueSpecified: boolean;
    masterCardIcaRate: number | null;
    matchOnlineMsgExpDateValue: boolean;
    matchOnlineMsgExpDateValueSpecified: boolean;
    matchOnlineMsgExpDate: boolean | null;
    maxAfdApprForGreaterAmtValue: number;
    maxAfdApprForGreaterAmtValueSpecified: boolean;
    maxAfdApprForGreaterAmt: number | null;
    mccInTranHistoryValue: boolean;
    mccInTranHistoryValueSpecified: boolean;
    mccInTranHistory: boolean | null;
    odToleranceAvailBalList: string;
    odTransferAvailBalList: string;
    overdrawToleranceApprList: string;
    overdrawTransferApprList: string;
    pctOverLocAvailBalList: string;
    posAmountLimitFields: string;
    posAmountUsedFields: string;
    posCountLimitFields: string;
    posCountUsedFields: string;
    posttoAltDraftList: string;
    posttoAltFundingList: string;
    serviceAccessCodeValue: number;
    serviceAccessCodeValueSpecified: boolean;
    serviceAccessCode: number | null;
    sigAmountLimitFields: string;
    sigAmountUsedFields: string;
    sigCountLimitFields: string;
    sigCountUsedFields: string;
    signatureDescription: string;
    suffixPositionValue: number;
    suffixPositionValueSpecified: boolean;
    suffixPosition: number | null;
    uniqueCardNumberValue: boolean;
    uniqueCardNumberValueSpecified: boolean;
    uniqueCardNumber: boolean | null;
    useAccessEnableFlagsValue: boolean;
    useAccessEnableFlagsValueSpecified: boolean;
    useAccessEnableFlags: boolean | null;
    validateCheckDigitValue: boolean;
    validateCheckDigitValueSpecified: boolean;
    validateCheckDigit: boolean | null;
    visaMultiCurrencyIsaRateValue: number;
    visaMultiCurrencyIsaRateValueSpecified: boolean;
    visaMultiCurrencyIsaRate: number | null;
    visaSingleCurrencyIsaRateValue: number;
    visaSingleCurrencyIsaRateValueSpecified: boolean;
    visaSingleCurrencyIsaRate: number | null;
    version1: VersionType;
    merchantReturnAuthsValue: number;
    merchantReturnAuthsValueSpecified: boolean;
    merchantReturnAuths: number | null;
    version2: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
