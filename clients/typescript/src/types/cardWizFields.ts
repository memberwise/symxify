import { VersionType } from "./versionType";

export interface CardWizFields {
    activateCardNoteCode: boolean | null;
    activateCardRestrctnLvl: boolean | null;
    allowCardActivation: boolean | null;
    allowCardCreation: boolean | null;
    allowCrossAccountAccess: boolean | null;
    allowNewName: boolean | null;
    allowNonIndividualName: boolean | null;
    automaticallySetAccess: boolean | null;
    captureBlockCardNoteCode: boolean | null;
    captureBlockCardOptions: boolean | null;
    cardBlockCodes: boolean | null;
    cardBlockRestrctnLvl: boolean | null;
    cardCreateRestrctnLvl: boolean | null;
    cardCreateRestrictWarnList: boolean | null;
    cardCreationNoteCode: boolean | null;
    cardNumberFormat: boolean | null;
    cardStatusReasonCodes: boolean | null;
    cardSuffixHigh: boolean | null;
    cardSuffixLow: boolean | null;
    cardType: boolean | null;
    chkTypes: boolean | null;
    copyShareLoanAccess: boolean | null;
    creditCardTypes: boolean | null;
    defined: boolean | null;
    digitalIssue: boolean | null;
    displayCardFields: boolean | null;
    displayIssueCode: boolean | null;
    displayNameFields: boolean | null;
    displayNewCardNumber: boolean | null;
    expirationMonths: boolean | null;
    expirationMonthsHigh: boolean | null;
    expirationMonthsLow: boolean | null;
    fmLoanReferenceField: boolean | null;
    forceReissRestrictWarnList: boolean | null;
    forceReissueCardNoteCode: boolean | null;
    forceReissueOptions: boolean | null;
    forceReissueRestrctnLvl: boolean | null;
    instantIssue: boolean | null;
    instantIssueExpMonths: boolean | null;
    jointNameFields: number[];
    jointNameTypes: boolean | null;
    linkSharesLoans: boolean | null;
    loanTypes: boolean | null;
    locTypes: boolean | null;
    maxAllowableChkIds: boolean | null;
    maxAllowableCreditCardIds: boolean | null;
    maxAllowableLoanIds: boolean | null;
    maxAllowableLocIds: boolean | null;
    maxAllowableSavIds: boolean | null;
    maxAllowedUserDef: number[];
    maxExtraEmbossLineLength: boolean | null;
    maxNameLength: boolean | null;
    miscId1Access: boolean | null;
    miscId1Types: boolean | null;
    miscId2Access: boolean | null;
    miscId2Types: boolean | null;
    miscId3Access: boolean | null;
    miscId3Types: boolean | null;
    nameRecordCopyOption: boolean | null;
    nextSequentialNumber: boolean | null;
    nextSequentialStep: boolean | null;
    nextSuffixStep: boolean | null;
    nextSuffixinCardNumStep: boolean | null;
    onlExpDaysforForceReissue: boolean | null;
    onlineCardIssue: boolean | null;
    onlineReissueExpDateHigh: boolean | null;
    onlineReissueExpDateLow: boolean | null;
    onlineReissueMonths: boolean | null;
    onlineRushCardOptions: boolean | null;
    optionalSpecfile: boolean | null;
    pinOffsetRandomGeneration: boolean | null;
    randomNumberHigh: boolean | null;
    randomNumberLow: boolean | null;
    reissueCardsWithSameNbr: boolean | null;
    requiredFundingType: boolean | null;
    restorePrevExpActiveDate: boolean | null;
    savTypes: boolean | null;
    selectNamesFrom: boolean | null;
    serviceCode: boolean | null;
    setActivationDate: boolean | null;
    setCardStatustoIssued: boolean | null;
    setCloseDate: boolean | null;
    setEffectiveDate: boolean | null;
    setEffectiveDateField: boolean | null;
    setInstantIssueField: boolean | null;
    suffixinCardNumberHigh: boolean | null;
    suffixinCardNumberLow: boolean | null;
    uniqueCardNumber: boolean | null;
    useCardSuffixField: boolean | null;
    userDefAccessType: number[];
    userDefAllowedTypes: number[];
    userDefIdType: number[];
    validateShareLoanAccess: boolean | null;
    version1: VersionType;
}