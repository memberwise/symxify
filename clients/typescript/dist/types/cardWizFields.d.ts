import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface CardWizFields {
    activateCardNoteCodeValue: boolean;
    activateCardNoteCodeValueSpecified: boolean;
    activateCardNoteCode: boolean | null;
    activateCardRestrctnLvlValue: boolean;
    activateCardRestrctnLvlValueSpecified: boolean;
    activateCardRestrctnLvl: boolean | null;
    allowCardActivationValue: boolean;
    allowCardActivationValueSpecified: boolean;
    allowCardActivation: boolean | null;
    allowCardCreationValue: boolean;
    allowCardCreationValueSpecified: boolean;
    allowCardCreation: boolean | null;
    allowCrossAccountAccessValue: boolean;
    allowCrossAccountAccessValueSpecified: boolean;
    allowCrossAccountAccess: boolean | null;
    allowNewNameValue: boolean;
    allowNewNameValueSpecified: boolean;
    allowNewName: boolean | null;
    allowNonIndividualNameValue: boolean;
    allowNonIndividualNameValueSpecified: boolean;
    allowNonIndividualName: boolean | null;
    automaticallySetAccessValue: boolean;
    automaticallySetAccessValueSpecified: boolean;
    automaticallySetAccess: boolean | null;
    captureBlockCardNoteCodeValue: boolean;
    captureBlockCardNoteCodeValueSpecified: boolean;
    captureBlockCardNoteCode: boolean | null;
    captureBlockCardOptionsValue: boolean;
    captureBlockCardOptionsValueSpecified: boolean;
    captureBlockCardOptions: boolean | null;
    cardBlockCodesValue: boolean;
    cardBlockCodesValueSpecified: boolean;
    cardBlockCodes: boolean | null;
    cardBlockRestrctnLvlValue: boolean;
    cardBlockRestrctnLvlValueSpecified: boolean;
    cardBlockRestrctnLvl: boolean | null;
    cardCreateRestrctnLvlValue: boolean;
    cardCreateRestrctnLvlValueSpecified: boolean;
    cardCreateRestrctnLvl: boolean | null;
    cardCreateRestrictWarnListValue: boolean;
    cardCreateRestrictWarnListValueSpecified: boolean;
    cardCreateRestrictWarnList: boolean | null;
    cardCreationNoteCodeValue: boolean;
    cardCreationNoteCodeValueSpecified: boolean;
    cardCreationNoteCode: boolean | null;
    cardNumberFormatValue: boolean;
    cardNumberFormatValueSpecified: boolean;
    cardNumberFormat: boolean | null;
    cardStatusReasonCodesValue: boolean;
    cardStatusReasonCodesValueSpecified: boolean;
    cardStatusReasonCodes: boolean | null;
    cardSuffixHighValue: boolean;
    cardSuffixHighValueSpecified: boolean;
    cardSuffixHigh: boolean | null;
    cardSuffixLowValue: boolean;
    cardSuffixLowValueSpecified: boolean;
    cardSuffixLow: boolean | null;
    cardTypeValue: boolean;
    cardTypeValueSpecified: boolean;
    cardType: boolean | null;
    chkTypesValue: boolean;
    chkTypesValueSpecified: boolean;
    chkTypes: boolean | null;
    copyShareLoanAccessValue: boolean;
    copyShareLoanAccessValueSpecified: boolean;
    copyShareLoanAccess: boolean | null;
    creditCardTypesValue: boolean;
    creditCardTypesValueSpecified: boolean;
    creditCardTypes: boolean | null;
    definedValue: boolean;
    definedValueSpecified: boolean;
    defined: boolean | null;
    digitalIssueValue: boolean;
    digitalIssueValueSpecified: boolean;
    digitalIssue: boolean | null;
    displayCardFieldsValue: boolean;
    displayCardFieldsValueSpecified: boolean;
    displayCardFields: boolean | null;
    displayIssueCodeValue: boolean;
    displayIssueCodeValueSpecified: boolean;
    displayIssueCode: boolean | null;
    displayNameFieldsValue: boolean;
    displayNameFieldsValueSpecified: boolean;
    displayNameFields: boolean | null;
    displayNewCardNumberValue: boolean;
    displayNewCardNumberValueSpecified: boolean;
    displayNewCardNumber: boolean | null;
    expirationMonthsValue: boolean;
    expirationMonthsValueSpecified: boolean;
    expirationMonths: boolean | null;
    expirationMonthsHighValue: boolean;
    expirationMonthsHighValueSpecified: boolean;
    expirationMonthsHigh: boolean | null;
    expirationMonthsLowValue: boolean;
    expirationMonthsLowValueSpecified: boolean;
    expirationMonthsLow: boolean | null;
    fmLoanReferenceFieldValue: boolean;
    fmLoanReferenceFieldValueSpecified: boolean;
    fmLoanReferenceField: boolean | null;
    forceReissRestrictWarnListValue: boolean;
    forceReissRestrictWarnListValueSpecified: boolean;
    forceReissRestrictWarnList: boolean | null;
    forceReissueCardNoteCodeValue: boolean;
    forceReissueCardNoteCodeValueSpecified: boolean;
    forceReissueCardNoteCode: boolean | null;
    forceReissueOptionsValue: boolean;
    forceReissueOptionsValueSpecified: boolean;
    forceReissueOptions: boolean | null;
    forceReissueRestrctnLvlValue: boolean;
    forceReissueRestrctnLvlValueSpecified: boolean;
    forceReissueRestrctnLvl: boolean | null;
    instantIssueValue: boolean;
    instantIssueValueSpecified: boolean;
    instantIssue: boolean | null;
    instantIssueExpMonthsValue: boolean;
    instantIssueExpMonthsValueSpecified: boolean;
    instantIssueExpMonths: boolean | null;
    jointNameFields: number[];
    jointNameFieldsSpecified: boolean;
    jointNameTypesValue: boolean;
    jointNameTypesValueSpecified: boolean;
    jointNameTypes: boolean | null;
    linkSharesLoansValue: boolean;
    linkSharesLoansValueSpecified: boolean;
    linkSharesLoans: boolean | null;
    loanTypesValue: boolean;
    loanTypesValueSpecified: boolean;
    loanTypes: boolean | null;
    locTypesValue: boolean;
    locTypesValueSpecified: boolean;
    locTypes: boolean | null;
    maxAllowableChkIdsValue: boolean;
    maxAllowableChkIdsValueSpecified: boolean;
    maxAllowableChkIds: boolean | null;
    maxAllowableCreditCardIdsValue: boolean;
    maxAllowableCreditCardIdsValueSpecified: boolean;
    maxAllowableCreditCardIds: boolean | null;
    maxAllowableLoanIdsValue: boolean;
    maxAllowableLoanIdsValueSpecified: boolean;
    maxAllowableLoanIds: boolean | null;
    maxAllowableLocIdsValue: boolean;
    maxAllowableLocIdsValueSpecified: boolean;
    maxAllowableLocIds: boolean | null;
    maxAllowableSavIdsValue: boolean;
    maxAllowableSavIdsValueSpecified: boolean;
    maxAllowableSavIds: boolean | null;
    maxAllowedUserDef: number[];
    maxAllowedUserDefSpecified: boolean;
    maxExtraEmbossLineLengthValue: boolean;
    maxExtraEmbossLineLengthValueSpecified: boolean;
    maxExtraEmbossLineLength: boolean | null;
    maxNameLengthValue: boolean;
    maxNameLengthValueSpecified: boolean;
    maxNameLength: boolean | null;
    miscId1AccessValue: boolean;
    miscId1AccessValueSpecified: boolean;
    miscId1Access: boolean | null;
    miscId1TypesValue: boolean;
    miscId1TypesValueSpecified: boolean;
    miscId1Types: boolean | null;
    miscId2AccessValue: boolean;
    miscId2AccessValueSpecified: boolean;
    miscId2Access: boolean | null;
    miscId2TypesValue: boolean;
    miscId2TypesValueSpecified: boolean;
    miscId2Types: boolean | null;
    miscId3AccessValue: boolean;
    miscId3AccessValueSpecified: boolean;
    miscId3Access: boolean | null;
    miscId3TypesValue: boolean;
    miscId3TypesValueSpecified: boolean;
    miscId3Types: boolean | null;
    nameRecordCopyOptionValue: boolean;
    nameRecordCopyOptionValueSpecified: boolean;
    nameRecordCopyOption: boolean | null;
    nextSequentialNumberValue: boolean;
    nextSequentialNumberValueSpecified: boolean;
    nextSequentialNumber: boolean | null;
    nextSequentialStepValue: boolean;
    nextSequentialStepValueSpecified: boolean;
    nextSequentialStep: boolean | null;
    nextSuffixStepValue: boolean;
    nextSuffixStepValueSpecified: boolean;
    nextSuffixStep: boolean | null;
    nextSuffixinCardNumStepValue: boolean;
    nextSuffixinCardNumStepValueSpecified: boolean;
    nextSuffixinCardNumStep: boolean | null;
    onlExpDaysforForceReissueValue: boolean;
    onlExpDaysforForceReissueValueSpecified: boolean;
    onlExpDaysforForceReissue: boolean | null;
    onlineCardIssueValue: boolean;
    onlineCardIssueValueSpecified: boolean;
    onlineCardIssue: boolean | null;
    onlineReissueExpDateHighValue: boolean;
    onlineReissueExpDateHighValueSpecified: boolean;
    onlineReissueExpDateHigh: boolean | null;
    onlineReissueExpDateLowValue: boolean;
    onlineReissueExpDateLowValueSpecified: boolean;
    onlineReissueExpDateLow: boolean | null;
    onlineReissueMonthsValue: boolean;
    onlineReissueMonthsValueSpecified: boolean;
    onlineReissueMonths: boolean | null;
    onlineRushCardOptionsValue: boolean;
    onlineRushCardOptionsValueSpecified: boolean;
    onlineRushCardOptions: boolean | null;
    optionalSpecfileValue: boolean;
    optionalSpecfileValueSpecified: boolean;
    optionalSpecfile: boolean | null;
    pinOffsetRandomGenerationValue: boolean;
    pinOffsetRandomGenerationValueSpecified: boolean;
    pinOffsetRandomGeneration: boolean | null;
    randomNumberHighValue: boolean;
    randomNumberHighValueSpecified: boolean;
    randomNumberHigh: boolean | null;
    randomNumberLowValue: boolean;
    randomNumberLowValueSpecified: boolean;
    randomNumberLow: boolean | null;
    reissueCardsWithSameNbrValue: boolean;
    reissueCardsWithSameNbrValueSpecified: boolean;
    reissueCardsWithSameNbr: boolean | null;
    requiredFundingTypeValue: boolean;
    requiredFundingTypeValueSpecified: boolean;
    requiredFundingType: boolean | null;
    restorePrevExpActiveDateValue: boolean;
    restorePrevExpActiveDateValueSpecified: boolean;
    restorePrevExpActiveDate: boolean | null;
    savTypesValue: boolean;
    savTypesValueSpecified: boolean;
    savTypes: boolean | null;
    selectNamesFromValue: boolean;
    selectNamesFromValueSpecified: boolean;
    selectNamesFrom: boolean | null;
    serviceCodeValue: boolean;
    serviceCodeValueSpecified: boolean;
    serviceCode: boolean | null;
    setActivationDateValue: boolean;
    setActivationDateValueSpecified: boolean;
    setActivationDate: boolean | null;
    setCardStatustoIssuedValue: boolean;
    setCardStatustoIssuedValueSpecified: boolean;
    setCardStatustoIssued: boolean | null;
    setCloseDateValue: boolean;
    setCloseDateValueSpecified: boolean;
    setCloseDate: boolean | null;
    setEffectiveDateValue: boolean;
    setEffectiveDateValueSpecified: boolean;
    setEffectiveDate: boolean | null;
    setEffectiveDateFieldValue: boolean;
    setEffectiveDateFieldValueSpecified: boolean;
    setEffectiveDateField: boolean | null;
    setInstantIssueFieldValue: boolean;
    setInstantIssueFieldValueSpecified: boolean;
    setInstantIssueField: boolean | null;
    suffixinCardNumberHighValue: boolean;
    suffixinCardNumberHighValueSpecified: boolean;
    suffixinCardNumberHigh: boolean | null;
    suffixinCardNumberLowValue: boolean;
    suffixinCardNumberLowValueSpecified: boolean;
    suffixinCardNumberLow: boolean | null;
    uniqueCardNumberValue: boolean;
    uniqueCardNumberValueSpecified: boolean;
    uniqueCardNumber: boolean | null;
    useCardSuffixFieldValue: boolean;
    useCardSuffixFieldValueSpecified: boolean;
    useCardSuffixField: boolean | null;
    userDefAccessType: number[];
    userDefAccessTypeSpecified: boolean;
    userDefAllowedTypes: number[];
    userDefAllowedTypesSpecified: boolean;
    userDefIdType: number[];
    userDefIdTypeSpecified: boolean;
    validateShareLoanAccessValue: boolean;
    validateShareLoanAccessValueSpecified: boolean;
    validateShareLoanAccess: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
