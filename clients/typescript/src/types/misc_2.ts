import { BitMap } from "./bitMap";
import { MiscDbEvolution_2 } from "./miscDbEvolution_2";
import { MiscDbEvolutionReport_2 } from "./miscDbEvolutionReport_2";
import { MiscDraftPreauthorized_2 } from "./miscDraftPreauthorized_2";
import { MiscEmployeePayroll_2 } from "./miscEmployeePayroll_2";
import { MiscPaymentHistoryDayCutoff_2 } from "./miscPaymentHistoryDayCutoff_2";
import { MiscRelAltCourtesyPayFee1_2 } from "./miscRelAltCourtesyPayFee1_2";
import { MiscRelAltCourtesyPayFee2_2 } from "./miscRelAltCourtesyPayFee2_2";
import { MiscRelAltCourtesyPayFee3_2 } from "./miscRelAltCourtesyPayFee3_2";
import { MiscRelAltCourtesyPayFee4_2 } from "./miscRelAltCourtesyPayFee4_2";
import { MiscRelAltCourtesyPayFee5_2 } from "./miscRelAltCourtesyPayFee5_2";
import { MiscRelAltCourtesyPayFee6_2 } from "./miscRelAltCourtesyPayFee6_2";
import { MiscRelAltCourtesyPayTier1_2 } from "./miscRelAltCourtesyPayTier1_2";
import { MiscRelAltCourtesyPayTier2_2 } from "./miscRelAltCourtesyPayTier2_2";
import { MiscRelAltCourtesyPayTier3_2 } from "./miscRelAltCourtesyPayTier3_2";
import { MiscRelAltCourtesyPayTier4_2 } from "./miscRelAltCourtesyPayTier4_2";
import { MiscRelAltCourtesyPayTier5_2 } from "./miscRelAltCourtesyPayTier5_2";
import { MiscRelAltCourtesyPayTier6_2 } from "./miscRelAltCourtesyPayTier6_2";
import { MiscRelCodeList_2 } from "./miscRelCodeList_2";
import { MiscRelCourtesyPayFee1_2 } from "./miscRelCourtesyPayFee1_2";
import { MiscRelCourtesyPayFee2_2 } from "./miscRelCourtesyPayFee2_2";
import { MiscRelCourtesyPayFee3_2 } from "./miscRelCourtesyPayFee3_2";
import { MiscRelCourtesyPayFee4_2 } from "./miscRelCourtesyPayFee4_2";
import { MiscRelCourtesyPayFee5_2 } from "./miscRelCourtesyPayFee5_2";
import { MiscRelCourtesyPayFee6_2 } from "./miscRelCourtesyPayFee6_2";
import { MiscRelCourtesyPayTier1_2 } from "./miscRelCourtesyPayTier1_2";
import { MiscRelCourtesyPayTier2_2 } from "./miscRelCourtesyPayTier2_2";
import { MiscRelCourtesyPayTier3_2 } from "./miscRelCourtesyPayTier3_2";
import { MiscRelCourtesyPayTier4_2 } from "./miscRelCourtesyPayTier4_2";
import { MiscRelCourtesyPayTier5_2 } from "./miscRelCourtesyPayTier5_2";
import { MiscRelCourtesyPayTier6_2 } from "./miscRelCourtesyPayTier6_2";
import { MiscRelOverdrawAddonXfrFee_2 } from "./miscRelOverdrawAddonXfrFee_2";
import { MiscRelOverdrawComboXfrFee_2 } from "./miscRelOverdrawComboXfrFee_2";
import { MiscRelOverdrawWdXfrFee_2 } from "./miscRelOverdrawWdXfrFee_2";
import { VersionType } from "./versionType";

export interface Misc_2 {
    acceptThresholdPmtinTllr: boolean | null;
    acceptUnappliedPmtinTlr: boolean | null;
    accountManagerSpecfile: string;
    acctVerifyOnIqFmMenus: boolean | null;
    acctVerifyonXfrDeposit: boolean | null;
    acsSys: boolean | null;
    addtoCheckPayeeLines: boolean | null;
    apAchPayments: boolean | null;
    audioAccessLen: number | null;
    audioLnApp: boolean | null;
    audioPinHbPwdAccess: number | null;
    autoBatch: boolean | null;
    availBalHoldTypeExclList: BitMap;
    bankruptcy: boolean | null;
    batchOutputtoPrintControl: boolean | null;
    biodentify: boolean | null;
    bondsRequireMicrData: number | null;
    bulkDepHoldIncludesCash: boolean | null;
    bulkDepositHoldDays: number | null;
    bulkReconDays: number | null;
    cardActRounding: boolean | null;
    cardDisputeWarning: number | null;
    cardNumberMask: string;
    cardSwipeAuditFile: string;
    cashReportingGlCodes: BitMap;
    ccBalanceTransfer: boolean | null;
    ccExpansion: boolean | null;
    cdmSys: boolean | null;
    certApyEarnedDisclosure: number | null;
    certPenaltybyPowerOn: boolean | null;
    certifiedExpirationDays: number | null;
    cfmCdmSys: boolean | null;
    chapter4TaxRate: number | null;
    chargeOffPaymentOrder: number | null;
    chargePartialCapFee: boolean | null;
    chargedOffLoanPmtOption: number | null;
    chargedOffLoanTypesList: BitMap;
    chargedOffShareDepOption: number | null;
    chargedOffShareTypesList: BitMap;
    checkDepTrack: boolean | null;
    checkFmHistoryControl: number | null;
    checkName: string;
    checkPrintFormat: number | null;
    checkValidatorUse: number | null;
    checkingName: string;
    checksRequireMicrData: number | null;
    chgAcctNumWizLookupType: number | null;
    chgAcctNumWizSpecfile: string;
    ckValidatorRtNumber: string;
    cmntByCdMoTcTrancodes: boolean | null;
    cmntByFdFrTrancodes: boolean | null;
    cmntByKcTrancode: boolean | null;
    cmntByKdKoKsTrancodes: boolean | null;
    cmntByKrTranCode: boolean | null;
    cmntByNsfAchAmount: boolean | null;
    cmntByNsfDraftAmount: boolean | null;
    cmntBySpTrancode: boolean | null;
    cmntbyCheckHold: boolean | null;
    cmntbyTellerTrnCodeFees: boolean | null;
    collateralSystem: boolean | null;
    combinationLoans: boolean | null;
    commentCode0Allowed: number | null;
    commentCodeRequired: number | null;
    confirmationSequence: number | null;
    courtesyPayCommentCode: number | null;
    courtesyPayFeeDescription: string;
    courtesyPayFeeGlCode: number | null;
    createMemoExceptionItems: boolean | null;
    createRateChangeComment: boolean | null;
    credRepSys: boolean | null;
    creditCardLocAvailable: number | null;
    creditDebitCardTypeList: BitMap;
    csTtInquiries: boolean | null;
    ctr: boolean | null;
    cuType: number | null;
    cusoInstitution: number | null;
    databaseEncryption: number | null;
    dbEvolution: MiscDbEvolution_2[];
    dbEvolutionReport: MiscDbEvolutionReport_2[];
    dealerReserveAccounting: boolean | null;
    demandTranCheckReference: string;
    demandTranMaxLookbackDays: number | null;
    demandTranMerchVerHoldDays: number | null;
    disbursalTransactionTypes: BitMap;
    displayAcctMgrFmHistory: boolean | null;
    displayMemberMgrFmHistory: boolean | null;
    displayRmtOvrAckMsg: boolean | null;
    displayRmtOvrAlertMsg: boolean | null;
    displayRmtOvrPrivBrList: BitMap;
    displayRmtOvrPrivList: boolean | null;
    divPeriodStartMethod: number | null;
    dividendName: string;
    dividendRoundingMethod: number | null;
    dormancyDays: number | null;
    dormancyUseCorrespondDate: boolean | null;
    dqCardNoticeNumber: number | null;
    draftNumberofLookBackDays: number | null;
    draftPreauthorized: MiscDraftPreauthorized_2[];
    draftStopDuplicates: number | null;
    driversLcnsSwipeAuditFile: string;
    employeePayroll: MiscEmployeePayroll_2[];
    enableTextMode: boolean | null;
    escrow: boolean | null;
    escrowShareTypeList: BitMap;
    excessiveCheck: number | null;
    expandWarningCodes: boolean | null;
    externalAcct: boolean | null;
    externalLoan: boolean | null;
    feeTypesToCapList: BitMap;
    fileRevision: string;
    finRepSequence: number | null;
    floats: boolean | null;
    fmHistoryControl: number | null;
    forcedCommentFormatList: BitMap;
    glAccountantPreference: number | null;
    glCheckDisbursedPrompt: boolean | null;
    glCommentByPowerOn: boolean | null;
    glDailyAccrual: boolean | null;
    glMonth: number | null;
    glTranslationBranchAcctIng: number | null;
    glTranslationBranchLevel: number | null;
    glTranslationMaxBranch: number | null;
    glTranslationMaxUser: number | null;
    glYearStartMonth: number | null;
    globalSequence: number | null;
    guaranteedHoldTypeList: BitMap;
    hbAudioPasswordHashCode: number | null;
    hbPasswordEnforceMixedCase: boolean | null;
    hbPasswordMaxAge: number | null;
    hbPasswordMaxRepeatChars: number | null;
    hbPasswordMaximumLength: number | null;
    hbPasswordMinAge: number | null;
    hbPasswordMinAlphaChars: number | null;
    hbPasswordMinDiffChars: number | null;
    hbPasswordMinNumericChars: number | null;
    hbPasswordMinOtherChars: number | null;
    hbPasswordMinSpecialChars: number | null;
    hbPasswordMinimumLength: number | null;
    hbPasswordMode: number | null;
    hbPasswordRecycleTimes: number | null;
    hbPwSpecialCharsAllowed: string;
    hbUsernameMaximumLength: number | null;
    hbUsernameMinimumLength: number | null;
    holdReuseDays: number | null;
    holdReuseMethod: number | null;
    idNumberMask: string;
    identificationLine: number | null;
    institution: number | null;
    insuranceUpdtsActivityDate: boolean | null;
    intAccrCmtLnTypes: BitMap;
    irs1042SUfidLastUsed: number | null;
    itcAutoAcceptOnPrompts: boolean | null;
    itcAutomatedOnPosting: boolean | null;
    itcDefaultCheckHoldDays: number | null;
    itcDeviceEnabled: boolean | null;
    itcEndorsement: number | null;
    itcMicrLookupTypeList: string;
    itcModuleEnabled: boolean | null;
    kitingSuspectAmt: number | null;
    kitingSuspectDepositCount: number | null;
    kitingSuspectDepositDays: number | null;
    kitingSuspectWaiveWarning: number | null;
    lastSystemDate: string | null;
    lateChgAccrCmtLnTypes: BitMap;
    leaseSys: boolean | null;
    legalEntityIdentifier: string;
    limitDeclChkAxsFeeChgDt: string | null;
    limitDeclChkAxsFeeFirst: number | null;
    limitDeclChkAxsFeeFolowng: number | null;
    limitLateFeeFirst: number | null;
    limitLateFeeFollowing: number | null;
    limitLateFeeMethodChgDate: string | null;
    limitOvlFeeFirst: number | null;
    limitOvlFeeFollowing: number | null;
    limitOvlFeeMethodChgDate: string | null;
    lnPmtHoldinAvailAmtCalc: number | null;
    loanAppSys: boolean | null;
    loanCommentbyPowerOn: boolean | null;
    loanExclusionWarnCodeList: BitMap;
    loanInterestAccrual: boolean | null;
    loanPayoffIncludesInsurance: boolean | null;
    loanTypeList: BitMap;
    logAccessEvents: boolean | null;
    maprCreditCardFeeTypes: BitMap;
    maprNonBonaFideFeeTypes: BitMap;
    maskCardTypes: BitMap;
    maskLoanTypes: BitMap;
    maskLoanappFinanceTypes: BitMap;
    maskLookupTypes: BitMap;
    maximumFutureEffectiveDays: number | null;
    maximumWdBelowAvailable: number | null;
    mbrInstLogins: boolean | null;
    militaryAprFeeTypes: BitMap;
    minimumRetentionPercent: number | null;
    moneyPrintFormat: number | null;
    nameKeyExpansion: number | null;
    nameMerge: boolean | null;
    newBillingCalculations: boolean | null;
    newWireUscExtractCutoffTi: number | null;
    nextAccountNumber: string;
    nextAccountPrefix: number | null;
    nextAccountStep: number | null;
    nextBatchId: number | null;
    nextCollateralNumber: string;
    nextCollateralStep: number | null;
    nextDocumentNumber: string;
    nextDocumentStep: number | null;
    nextNoteNumber: string;
    nextNoteStep: number | null;
    noticeFormat: number | null;
    numberOfInvalidPinAttempts: number | null;
    odsProcessCount: number | null;
    odtAuthFeeOvrSrcCodes: string;
    odtAuthFeeRecurSrcCodes: string;
    ofacChecking: boolean | null;
    ofacCorpCheckSpecfile: string;
    ofacMatchAcceptedWoPriv: number | null;
    onUsDraftCommentCode: number | null;
    onUsOverdrawOption: number | null;
    onlineParameterOption: number | null;
    overdraftTol: boolean | null;
    overdrawAddonDqGraceDays: number | null;
    overdrawAddonIncrement: number | null;
    overdrawAddonMaxOverLoc: number | null;
    overdrawAddonPctOverLoc: number | null;
    overdrawFeeOption: number | null;
    overdrawIncrementOverride: number | null;
    overdrawNoticeSpecfile: string;
    overdrawRegDLimiting: boolean | null;
    overdrawTierOption: number | null;
    overdrawTransferFeeGlCode: number | null;
    overdrawWithdrawalIncrement: number | null;
    passwordExpWarningDays: number | null;
    passwordHashing: boolean | null;
    passwordMaxInvalidAttempts: number | null;
    passwordMaximumAge: number | null;
    passwordMaximumRepeatChars: number | null;
    passwordMinimumAge: number | null;
    passwordMinimumAlphaChars: number | null;
    passwordMinimumDiffChars: number | null;
    passwordMinimumLength: number | null;
    passwordMinimumNumChars: number | null;
    passwordMinimumOtherChars: number | null;
    passwordRecycleTimes: number | null;
    passwordsCaseSensitive: boolean | null;
    paymentHistoryDayCutoff: MiscPaymentHistoryDayCutoff_2[];
    pinChangeDays: number | null;
    pinMask: string;
    positivePayDraft: boolean | null;
    powerOnControlDeluxeEditor: boolean | null;
    preAuthWireUscExtractCuto: number | null;
    primeShareTypeList: BitMap;
    printInstitutiononNotice: number | null;
    printInstitutiononReceipt: number | null;
    printItcImages: number | null;
    promptForMicrInfoInDrOn: number | null;
    promptfor000CrtsyPayFee: boolean | null;
    promptfor000TransferFee: boolean | null;
    rateDecimalDigits: number | null;
    rcntTellerActWaiveWarning: number | null;
    rcntTllrActvtyCnslsList: BitMap;
    rcntTllrActvtyCriteria: number | null;
    rcntTllrActvtyIncludeTllr: boolean | null;
    rcntTllrActvtyReqMultTllr: boolean | null;
    reactivateSecurityOvrMsg: number | null;
    receiptAddressPrint: number | null;
    receiptAlternateAddress: number | null;
    receiptBalancePrint: number | null;
    receiptOtherAccountOption: number | null;
    receiptPreviousBalance: boolean | null;
    receiptPrint: number | null;
    receiptReprintEnable: boolean | null;
    receiptSuppressXferAcct: boolean | null;
    recentTellerActivityDays: number | null;
    regDLimitingMethod: number | null;
    regDLimitingTypeList: BitMap;
    regulationZFeeTypes: BitMap;
    relAltCourtesyPayFee1: MiscRelAltCourtesyPayFee1_2[];
    relAltCourtesyPayFee2: MiscRelAltCourtesyPayFee2_2[];
    relAltCourtesyPayFee3: MiscRelAltCourtesyPayFee3_2[];
    relAltCourtesyPayFee4: MiscRelAltCourtesyPayFee4_2[];
    relAltCourtesyPayFee5: MiscRelAltCourtesyPayFee5_2[];
    relAltCourtesyPayFee6: MiscRelAltCourtesyPayFee6_2[];
    relAltCourtesyPayTier1: MiscRelAltCourtesyPayTier1_2[];
    relAltCourtesyPayTier2: MiscRelAltCourtesyPayTier2_2[];
    relAltCourtesyPayTier3: MiscRelAltCourtesyPayTier3_2[];
    relAltCourtesyPayTier4: MiscRelAltCourtesyPayTier4_2[];
    relAltCourtesyPayTier5: MiscRelAltCourtesyPayTier5_2[];
    relAltCourtesyPayTier6: MiscRelAltCourtesyPayTier6_2[];
    relCodeList: MiscRelCodeList_2[];
    relCourtesyPayFee1: MiscRelCourtesyPayFee1_2[];
    relCourtesyPayFee2: MiscRelCourtesyPayFee2_2[];
    relCourtesyPayFee3: MiscRelCourtesyPayFee3_2[];
    relCourtesyPayFee4: MiscRelCourtesyPayFee4_2[];
    relCourtesyPayFee5: MiscRelCourtesyPayFee5_2[];
    relCourtesyPayFee6: MiscRelCourtesyPayFee6_2[];
    relCourtesyPayTier1: MiscRelCourtesyPayTier1_2[];
    relCourtesyPayTier2: MiscRelCourtesyPayTier2_2[];
    relCourtesyPayTier3: MiscRelCourtesyPayTier3_2[];
    relCourtesyPayTier4: MiscRelCourtesyPayTier4_2[];
    relCourtesyPayTier5: MiscRelCourtesyPayTier5_2[];
    relCourtesyPayTier6: MiscRelCourtesyPayTier6_2[];
    relOverdrawAddonXfrFee: MiscRelOverdrawAddonXfrFee_2[];
    relOverdrawComboXfrFee: MiscRelOverdrawComboXfrFee_2[];
    relOverdrawWdXfrFee: MiscRelOverdrawWdXfrFee_2[];
    reportSequenceNumberLength: number | null;
    rsaFiId: string;
    rtNumber: string;
    savingsName: string;
    sbaDistrRoundingMethod: number | null;
    sbaLoans: boolean | null;
    scopeofMembership: number | null;
    secureCardPins: boolean | null;
    shareApyEarnedDisclosure: number | null;
    shareCloseOption: number | null;
    shareCommentbyPowerOn: boolean | null;
    shareDividendAccrual: boolean | null;
    shareExclusionWarnCodeList: BitMap;
    shareTypesForOnList: BitMap;
    shareTypesForSwList: BitMap;
    signatureLine: number | null;
    sourceCodeOptionAch: number | null;
    sourceCodeOptionBillPay: number | null;
    sourceCodeOptionCard: number | null;
    sourceCodeOptionHomeBank: number | null;
    sourceCodeOptionPos: number | null;
    sourceCodeOptionSharedBr: number | null;
    ssnTinMask: string;
    stateReporting: string;
    stopPayExpirationDays: number | null;
    stopPayExpirationMonths: number | null;
    stopPayTrancodeTypes: string;
    stopPreviousOverdrafts: number | null;
    storeFwdMode: number | null;
    svAnalysisSys: boolean | null;
    symConnectDialog: boolean | null;
    symFormEmailFormat: number | null;
    symFormImagingFormat: number | null;
    symFormRegLev: number | null;
    systemDate: string | null;
    tellerFeDecrOccurrenceCt: number | null;
    tellerFeDecreaseFeeCt: number | null;
    tellerFePromptFeeType: boolean | null;
    tellerTranRecapSlDesc: boolean | null;
    tellerTranSpecfile: string;
    tellerTrnNameDisplay: BitMap;
    thirdPartyMfa: boolean | null;
    tllrActvtyUsersList: BitMap;
    tllrTranAnalysisUpdateOpt: number | null;
    tranPostLockMethod: number | null;
    tranSequence: number | null;
    ttValidRg: number | null;
    typeLength: number | null;
    uiMaxRecsPerResponse: number | null;
    uncollectedFeeOption: number | null;
    updateExtLoanAddrRealTime: number | null;
    usCentralExtct: boolean | null;
    useBondRedemptionTable: boolean | null;
    useCdmForRecyclerVoid: boolean | null;
    useLrScreenDefinitions: boolean | null;
    userActivityControl: number | null;
    userDormancyDays: number | null;
    userTempPasswordExpHours: number | null;
    verbalStopExpirationDays: number | null;
    waiveLateChargeLnTypes: BitMap;
    wdBelowAvailableOption: number | null;
    wdCountSourceList: string;
    wire: boolean | null;
    wireBatchDate: string | null;
    wireBatchNbr: number | null;
    wireHoldDays: number | null;
    withdrawalOverdrawOption: number | null;
    yellowHammer: boolean | null;
    version1: VersionType;
    misModuleEnableD: boolean | null;
    version2: VersionType;
}