import { BitMap } from "./bitMap";
import { OnlineMainGroupMccHoldTime } from "./onlineMainGroupMccHoldTime";
import { OnlineMainGroupMccHoldUnits } from "./onlineMainGroupMccHoldUnits";
import { OnlineMainGroupMccSourceCodes } from "./onlineMainGroupMccSourceCodes";
import { OnlineMainMccTypes } from "./onlineMainMccTypes";
import { OnlineMainRelAltCourtesyPayFee1 } from "./onlineMainRelAltCourtesyPayFee1";
import { OnlineMainRelAltCourtesyPayFee2 } from "./onlineMainRelAltCourtesyPayFee2";
import { OnlineMainRelAltCourtesyPayFee3 } from "./onlineMainRelAltCourtesyPayFee3";
import { OnlineMainRelAltCourtesyPayFee4 } from "./onlineMainRelAltCourtesyPayFee4";
import { OnlineMainRelAltCourtesyPayFee5 } from "./onlineMainRelAltCourtesyPayFee5";
import { OnlineMainRelAltCourtesyPayFee6 } from "./onlineMainRelAltCourtesyPayFee6";
import { OnlineMainRelAltCourtesyPayTier1 } from "./onlineMainRelAltCourtesyPayTier1";
import { OnlineMainRelAltCourtesyPayTier2 } from "./onlineMainRelAltCourtesyPayTier2";
import { OnlineMainRelAltCourtesyPayTier3 } from "./onlineMainRelAltCourtesyPayTier3";
import { OnlineMainRelAltCourtesyPayTier4 } from "./onlineMainRelAltCourtesyPayTier4";
import { OnlineMainRelAltCourtesyPayTier5 } from "./onlineMainRelAltCourtesyPayTier5";
import { OnlineMainRelAltCourtesyPayTier6 } from "./onlineMainRelAltCourtesyPayTier6";
import { OnlineMainRelCodeList } from "./onlineMainRelCodeList";
import { OnlineMainRelCourtesyPayFee1 } from "./onlineMainRelCourtesyPayFee1";
import { OnlineMainRelCourtesyPayFee2 } from "./onlineMainRelCourtesyPayFee2";
import { OnlineMainRelCourtesyPayFee3 } from "./onlineMainRelCourtesyPayFee3";
import { OnlineMainRelCourtesyPayFee4 } from "./onlineMainRelCourtesyPayFee4";
import { OnlineMainRelCourtesyPayFee5 } from "./onlineMainRelCourtesyPayFee5";
import { OnlineMainRelCourtesyPayFee6 } from "./onlineMainRelCourtesyPayFee6";
import { OnlineMainRelCourtesyPayTier1 } from "./onlineMainRelCourtesyPayTier1";
import { OnlineMainRelCourtesyPayTier2 } from "./onlineMainRelCourtesyPayTier2";
import { OnlineMainRelCourtesyPayTier3 } from "./onlineMainRelCourtesyPayTier3";
import { OnlineMainRelCourtesyPayTier4 } from "./onlineMainRelCourtesyPayTier4";
import { OnlineMainRelCourtesyPayTier5 } from "./onlineMainRelCourtesyPayTier5";
import { OnlineMainRelCourtesyPayTier6 } from "./onlineMainRelCourtesyPayTier6";
import { OnlineMainRelNsfFee } from "./onlineMainRelNsfFee";
import { OnlineMainRelOverdrawAddonXfrFee } from "./onlineMainRelOverdrawAddonXfrFee";
import { OnlineMainRelOverdrawComboXfrFee } from "./onlineMainRelOverdrawComboXfrFee";
import { OnlineMainRelOverdrawWdXfrFee } from "./onlineMainRelOverdrawWdXfrFee";
import { OnlineMainRelOvlFee } from "./onlineMainRelOvlFee";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface OnlineMain {
    acceptLoanThresholdPaymentValue: boolean;
    acceptLoanThresholdPaymentValueSpecified: boolean;
    acceptLoanThresholdPayment: boolean | null;
    acceptUnappliedPartialPmtValue: boolean;
    acceptUnappliedPartialPmtValueSpecified: boolean;
    acceptUnappliedPartialPmt: boolean | null;
    appendAtmTerminalIdValue: boolean;
    appendAtmTerminalIdValueSpecified: boolean;
    appendAtmTerminalId: boolean | null;
    atmAvailBalApprExclList: BitMap;
    atmAvailBalPostExclList: BitMap;
    atmFeeDescription: string;
    atmWarningCodeList: BitMap;
    avsActionValue: number;
    avsActionValueSpecified: boolean;
    avsAction: number | null;
    avsMethodValue: number;
    avsMethodValueSpecified: boolean;
    avsMethod: number | null;
    billPayFeeDescription: string;
    bpAvailBalApprExclList: BitMap;
    bpAvailBalPostExclList: BitMap;
    bpWarningCodeList: BitMap;
    cardinHistoryDigitCountValue: number;
    cardinHistoryDigitCountValueSpecified: boolean;
    cardinHistoryDigitCount: number | null;
    cashMccTypes: BitMap;
    chargePartialCapFeeValue: boolean;
    chargePartialCapFeeValueSpecified: boolean;
    chargePartialCapFee: boolean | null;
    checkWarningCodeList: BitMap;
    chng1GasAuthHoldAmountValue: number;
    chng1GasAuthHoldAmountValueSpecified: boolean;
    chng1GasAuthHoldAmount: number | null;
    clearingGlCodeValue: number;
    clearingGlCodeValueSpecified: boolean;
    clearingGlCode: number | null;
    courtesyNoticesValue: number;
    courtesyNoticesValueSpecified: boolean;
    courtesyNotices: number | null;
    courtesyPayCommentCodeValue: number;
    courtesyPayCommentCodeValueSpecified: boolean;
    courtesyPayCommentCode: number | null;
    courtesyPayFeeDescription: string;
    courtesyPayFeeGlCodeValue: number;
    courtesyPayFeeGlCodeValueSpecified: boolean;
    courtesyPayFeeGlCode: number | null;
    createExceptionItemsValue: boolean;
    createExceptionItemsValueSpecified: boolean;
    createExceptionItems: boolean | null;
    creditCardFeeDescription: string;
    cuAtmCheckDepHoldDaysValue: number;
    cuAtmCheckDepHoldDaysValueSpecified: boolean;
    cuAtmCheckDepHoldDays: number | null;
    cuAtmEnvDepHoldDaysValue: number;
    cuAtmEnvDepHoldDaysValueSpecified: boolean;
    cuAtmEnvDepHoldDays: number | null;
    cuAtmUseRegCcPolicyValue: boolean;
    cuAtmUseRegCcPolicyValueSpecified: boolean;
    cuAtmUseRegCcPolicy: boolean | null;
    debitCardFeeDescription: string;
    depWarningCodeList: BitMap;
    dqGraceDaysForAddonValue: number;
    dqGraceDaysForAddonValueSpecified: boolean;
    dqGraceDaysForAddon: number | null;
    dqGraceDaysForWdValue: number;
    dqGraceDaysForWdValueSpecified: boolean;
    dqGraceDaysForWd: number | null;
    dqWarningCodeList: BitMap;
    duplicateKeyPurgeTimeValue: number;
    duplicateKeyPurgeTimeValueSpecified: boolean;
    duplicateKeyPurgeTime: number | null;
    duplicateKeyRetentionDaysValue: number;
    duplicateKeyRetentionDaysValueSpecified: boolean;
    duplicateKeyRetentionDays: number | null;
    envWarningCodeList: BitMap;
    feeTypeToCap: BitMap;
    frgnAtmCheckDepHoldDaysValue: number;
    frgnAtmCheckDepHoldDaysValueSpecified: boolean;
    frgnAtmCheckDepHoldDays: number | null;
    frgnAtmEnvDepHoldDaysValue: number;
    frgnAtmEnvDepHoldDaysValueSpecified: boolean;
    frgnAtmEnvDepHoldDays: number | null;
    frgnAtmUseRegCcPolicyValue: boolean;
    frgnAtmUseRegCcPolicyValueSpecified: boolean;
    frgnAtmUseRegCcPolicy: boolean | null;
    glCategoryValue: number;
    glCategoryValueSpecified: boolean;
    glCategory: number | null;
    graceAmountforCashPaymentsValue: number;
    graceAmountforCashPaymentsValueSpecified: boolean;
    graceAmountforCashPayments: number | null;
    groupMccHoldTime: OnlineMainGroupMccHoldTime[];
    groupMccHoldTimeSpecified: boolean;
    groupMccHoldUnits: OnlineMainGroupMccHoldUnits[];
    groupMccHoldUnitsSpecified: boolean;
    groupMccSourceCodes: OnlineMainGroupMccSourceCodes[];
    groupMccSourceCodesSpecified: boolean;
    holdWarningCodeList: BitMap;
    includeOnlineFeesinApprValue: boolean;
    includeOnlineFeesinApprValueSpecified: boolean;
    includeOnlineFeesinAppr: boolean | null;
    institutionName: string;
    masterCardCcaFeeGlCodeValue: number;
    masterCardCcaFeeGlCodeValueSpecified: boolean;
    masterCardCcaFeeGlCode: number | null;
    masterCardIcaFeeGlCodeValue: number;
    masterCardIcaFeeGlCodeValueSpecified: boolean;
    masterCardIcaFeeGlCode: number | null;
    maxInvalidPinAttemptsValue: number;
    maxInvalidPinAttemptsValueSpecified: boolean;
    maxInvalidPinAttempts: number | null;
    maximumAddonOverLocValue: number;
    maximumAddonOverLocValueSpecified: boolean;
    maximumAddonOverLoc: number | null;
    maximumWdBelowAvailableValue: number;
    maximumWdBelowAvailableValueSpecified: boolean;
    maximumWdBelowAvailable: number | null;
    mccTypes: OnlineMainMccTypes[];
    mccTypesSpecified: boolean;
    minimumLineofCreditAddonValue: number;
    minimumLineofCreditAddonValueSpecified: boolean;
    minimumLineofCreditAddon: number | null;
    noticesPrinterTypeValue: number;
    noticesPrinterTypeValueSpecified: boolean;
    noticesPrinterType: number | null;
    nsfFeeDescIfNotPaid: string;
    nsfFeeDescIfPaid: string;
    nsfFeeForUncollectedFundsValue: boolean;
    nsfFeeForUncollectedFundsValueSpecified: boolean;
    nsfFeeForUncollectedFunds: boolean | null;
    nsfFeeGlCodeValue: number;
    nsfFeeGlCodeValueSpecified: boolean;
    nsfFeeGlCode: number | null;
    nsfNoticesValue: boolean;
    nsfNoticesValueSpecified: boolean;
    nsfNotices: boolean | null;
    odTransferFeeCalcOptionValue: number;
    odTransferFeeCalcOptionValueSpecified: boolean;
    odTransferFeeCalcOption: number | null;
    odtAuthFeeOvrSrcCodes: string;
    odtAuthFeeRecurSrcCodes: string;
    onlyLoanTransferNoticesValue: boolean;
    onlyLoanTransferNoticesValueSpecified: boolean;
    onlyLoanTransferNotices: boolean | null;
    overdrawAddonDqGraceDaysValue: number;
    overdrawAddonDqGraceDaysValueSpecified: boolean;
    overdrawAddonDqGraceDays: number | null;
    overdrawAddonIncrementValue: number;
    overdrawAddonIncrementValueSpecified: boolean;
    overdrawAddonIncrement: number | null;
    overdrawAddonMaxOverLocValue: number;
    overdrawAddonMaxOverLocValueSpecified: boolean;
    overdrawAddonMaxOverLoc: number | null;
    overdrawAddonPctOverLocValue: number;
    overdrawAddonPctOverLocValueSpecified: boolean;
    overdrawAddonPctOverLoc: number | null;
    overdrawFeeOptionValue: number;
    overdrawFeeOptionValueSpecified: boolean;
    overdrawFeeOption: number | null;
    overdrawIncrementOverrideValue: number;
    overdrawIncrementOverrideValueSpecified: boolean;
    overdrawIncrementOverride: number | null;
    overdrawNoticesfor2NdAcctValue: boolean;
    overdrawNoticesfor2NdAcctValueSpecified: boolean;
    overdrawNoticesfor2NdAcct: boolean | null;
    overdrawOptionValue: number;
    overdrawOptionValueSpecified: boolean;
    overdrawOption: number | null;
    overdrawRegDLimitingValue: boolean;
    overdrawRegDLimitingValueSpecified: boolean;
    overdrawRegDLimiting: boolean | null;
    overdrawTierOptionValue: number;
    overdrawTierOptionValueSpecified: boolean;
    overdrawTierOption: number | null;
    overdrawTransferFeeGlCodeValue: number;
    overdrawTransferFeeGlCodeValueSpecified: boolean;
    overdrawTransferFeeGlCode: number | null;
    overdrawTransferNoticesValue: number;
    overdrawTransferNoticesValueSpecified: boolean;
    overdrawTransferNotices: number | null;
    overdrawWithdrawalIncrementValue: number;
    overdrawWithdrawalIncrementValueSpecified: boolean;
    overdrawWithdrawalIncrement: number | null;
    ovlFeeDescIfNotPaid: string;
    ovlFeeDescIfPaid: string;
    ovlFeeForUncollectedFundsValue: boolean;
    ovlFeeForUncollectedFundsValueSpecified: boolean;
    ovlFeeForUncollectedFunds: boolean | null;
    ovlFeeGlCodeValue: number;
    ovlFeeGlCodeValueSpecified: boolean;
    ovlFeeGlCode: number | null;
    ovlNoticesValue: boolean;
    ovlNoticesValueSpecified: boolean;
    ovlNotices: boolean | null;
    percentOverLineofCreditValue: number;
    percentOverLineofCreditValueSpecified: boolean;
    percentOverLineofCredit: number | null;
    pinPreAuthGasHoldTimeValue: number;
    pinPreAuthGasHoldTimeValueSpecified: boolean;
    pinPreAuthGasHoldTime: number | null;
    pinPreAuthGasHoldUnitsValue: number;
    pinPreAuthGasHoldUnitsValueSpecified: boolean;
    pinPreAuthGasHoldUnits: number | null;
    posAvailBalAuthExclList: BitMap;
    posAvailBalPostExclList: BitMap;
    posFeeDescription: string;
    posWarningCodeList: BitMap;
    postAtmBalanceInquiriesValue: boolean;
    postAtmBalanceInquiriesValueSpecified: boolean;
    postAtmBalanceInquiries: boolean | null;
    postAtmStatementsValue: boolean;
    postAtmStatementsValueSpecified: boolean;
    postAtmStatements: boolean | null;
    preAuthExpHoldMatchDaysValue: number;
    preAuthExpHoldMatchDaysValueSpecified: boolean;
    preAuthExpHoldMatchDays: number | null;
    preAuthFmHistoryOptionValue: number;
    preAuthFmHistoryOptionValueSpecified: boolean;
    preAuthFmHistoryOption: number | null;
    preAuthHoldTimeValue: number;
    preAuthHoldTimeValueSpecified: boolean;
    preAuthHoldTime: number | null;
    preAuthHoldUnitsValue: number;
    preAuthHoldUnitsValueSpecified: boolean;
    preAuthHoldUnits: number | null;
    preAuthMatchVarianceValue: number;
    preAuthMatchVarianceValueSpecified: boolean;
    preAuthMatchVariance: number | null;
    preAuthMaxHoldDaysValue: number;
    preAuthMaxHoldDaysValueSpecified: boolean;
    preAuthMaxHoldDays: number | null;
    preAuthTeHoldTimeValue: number;
    preAuthTeHoldTimeValueSpecified: boolean;
    preAuthTeHoldTime: number | null;
    preAuthTeHoldUnitsValue: number;
    preAuthTeHoldUnitsValueSpecified: boolean;
    preAuthTeHoldUnits: number | null;
    prependRegECommentsValue: boolean;
    prependRegECommentsValueSpecified: boolean;
    prependRegEComments: boolean | null;
    relAltCourtesyPayFee1: OnlineMainRelAltCourtesyPayFee1[];
    relAltCourtesyPayFee1Specified: boolean;
    relAltCourtesyPayFee2: OnlineMainRelAltCourtesyPayFee2[];
    relAltCourtesyPayFee2Specified: boolean;
    relAltCourtesyPayFee3: OnlineMainRelAltCourtesyPayFee3[];
    relAltCourtesyPayFee3Specified: boolean;
    relAltCourtesyPayFee4: OnlineMainRelAltCourtesyPayFee4[];
    relAltCourtesyPayFee4Specified: boolean;
    relAltCourtesyPayFee5: OnlineMainRelAltCourtesyPayFee5[];
    relAltCourtesyPayFee5Specified: boolean;
    relAltCourtesyPayFee6: OnlineMainRelAltCourtesyPayFee6[];
    relAltCourtesyPayFee6Specified: boolean;
    relAltCourtesyPayTier1: OnlineMainRelAltCourtesyPayTier1[];
    relAltCourtesyPayTier1Specified: boolean;
    relAltCourtesyPayTier2: OnlineMainRelAltCourtesyPayTier2[];
    relAltCourtesyPayTier2Specified: boolean;
    relAltCourtesyPayTier3: OnlineMainRelAltCourtesyPayTier3[];
    relAltCourtesyPayTier3Specified: boolean;
    relAltCourtesyPayTier4: OnlineMainRelAltCourtesyPayTier4[];
    relAltCourtesyPayTier4Specified: boolean;
    relAltCourtesyPayTier5: OnlineMainRelAltCourtesyPayTier5[];
    relAltCourtesyPayTier5Specified: boolean;
    relAltCourtesyPayTier6: OnlineMainRelAltCourtesyPayTier6[];
    relAltCourtesyPayTier6Specified: boolean;
    relCodeList: OnlineMainRelCodeList[];
    relCodeListSpecified: boolean;
    relCourtesyPayFee1: OnlineMainRelCourtesyPayFee1[];
    relCourtesyPayFee1Specified: boolean;
    relCourtesyPayFee2: OnlineMainRelCourtesyPayFee2[];
    relCourtesyPayFee2Specified: boolean;
    relCourtesyPayFee3: OnlineMainRelCourtesyPayFee3[];
    relCourtesyPayFee3Specified: boolean;
    relCourtesyPayFee4: OnlineMainRelCourtesyPayFee4[];
    relCourtesyPayFee4Specified: boolean;
    relCourtesyPayFee5: OnlineMainRelCourtesyPayFee5[];
    relCourtesyPayFee5Specified: boolean;
    relCourtesyPayFee6: OnlineMainRelCourtesyPayFee6[];
    relCourtesyPayFee6Specified: boolean;
    relCourtesyPayTier1: OnlineMainRelCourtesyPayTier1[];
    relCourtesyPayTier1Specified: boolean;
    relCourtesyPayTier2: OnlineMainRelCourtesyPayTier2[];
    relCourtesyPayTier2Specified: boolean;
    relCourtesyPayTier3: OnlineMainRelCourtesyPayTier3[];
    relCourtesyPayTier3Specified: boolean;
    relCourtesyPayTier4: OnlineMainRelCourtesyPayTier4[];
    relCourtesyPayTier4Specified: boolean;
    relCourtesyPayTier5: OnlineMainRelCourtesyPayTier5[];
    relCourtesyPayTier5Specified: boolean;
    relCourtesyPayTier6: OnlineMainRelCourtesyPayTier6[];
    relCourtesyPayTier6Specified: boolean;
    relNsfFee: OnlineMainRelNsfFee[];
    relNsfFeeSpecified: boolean;
    relOverdrawAddonXfrFee: OnlineMainRelOverdrawAddonXfrFee[];
    relOverdrawAddonXfrFeeSpecified: boolean;
    relOverdrawComboXfrFee: OnlineMainRelOverdrawComboXfrFee[];
    relOverdrawComboXfrFeeSpecified: boolean;
    relOverdrawWdXfrFee: OnlineMainRelOverdrawWdXfrFee[];
    relOverdrawWdXfrFeeSpecified: boolean;
    relOvlFee: OnlineMainRelOvlFee[];
    relOvlFeeSpecified: boolean;
    reportTitle: string;
    sigAvailBalAuthExclList: BitMap;
    sigAvailBalPostExclList: BitMap;
    sigPreAuthGasHoldTimeValue: number;
    sigPreAuthGasHoldTimeValueSpecified: boolean;
    sigPreAuthGasHoldTime: number | null;
    sigPreAuthGasHoldUnitsValue: number;
    sigPreAuthGasHoldUnitsValueSpecified: boolean;
    sigPreAuthGasHoldUnits: number | null;
    sigWarningCodeList: BitMap;
    useFeeStatusfromAuth: string;
    useLowQualMatchFeeStatus: string;
    useNetworkPreAuthHoldTimeValue: boolean;
    useNetworkPreAuthHoldTimeValueSpecified: boolean;
    useNetworkPreAuthHoldTime: boolean | null;
    usePostExclListonFinReq: string;
    visaMultiCrrncyIsaFeeGlValue: number;
    visaMultiCrrncyIsaFeeGlValueSpecified: boolean;
    visaMultiCrrncyIsaFeeGl: number | null;
    visaSglCrrncyIsaFeeGlValue: number;
    visaSglCrrncyIsaFeeGlValueSpecified: boolean;
    visaSglCrrncyIsaFeeGl: number | null;
    waiveFeeforAuthAdvice: string;
    waiveFeeonNoHoldMatch: string;
    waiveFeeonNoHoldRecur: string;
    wdBelowAvailableOptionValue: number;
    wdBelowAvailableOptionValueSpecified: boolean;
    wdBelowAvailableOption: number | null;
    wdWarningCodeList: BitMap;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}