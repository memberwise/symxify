import { BitMap } from "./bitMap";
import { OnlineMainGroupMccHoldTime_2 } from "./onlineMainGroupMccHoldTime_2";
import { OnlineMainGroupMccHoldUnits_2 } from "./onlineMainGroupMccHoldUnits_2";
import { OnlineMainGroupMccSourceCodes_2 } from "./onlineMainGroupMccSourceCodes_2";
import { OnlineMainMccTypes_2 } from "./onlineMainMccTypes_2";
import { OnlineMainRelAltCourtesyPayFee1_2 } from "./onlineMainRelAltCourtesyPayFee1_2";
import { OnlineMainRelAltCourtesyPayFee2_2 } from "./onlineMainRelAltCourtesyPayFee2_2";
import { OnlineMainRelAltCourtesyPayFee3_2 } from "./onlineMainRelAltCourtesyPayFee3_2";
import { OnlineMainRelAltCourtesyPayFee4_2 } from "./onlineMainRelAltCourtesyPayFee4_2";
import { OnlineMainRelAltCourtesyPayFee5_2 } from "./onlineMainRelAltCourtesyPayFee5_2";
import { OnlineMainRelAltCourtesyPayFee6_2 } from "./onlineMainRelAltCourtesyPayFee6_2";
import { OnlineMainRelAltCourtesyPayTier1_2 } from "./onlineMainRelAltCourtesyPayTier1_2";
import { OnlineMainRelAltCourtesyPayTier2_2 } from "./onlineMainRelAltCourtesyPayTier2_2";
import { OnlineMainRelAltCourtesyPayTier3_2 } from "./onlineMainRelAltCourtesyPayTier3_2";
import { OnlineMainRelAltCourtesyPayTier4_2 } from "./onlineMainRelAltCourtesyPayTier4_2";
import { OnlineMainRelAltCourtesyPayTier5_2 } from "./onlineMainRelAltCourtesyPayTier5_2";
import { OnlineMainRelAltCourtesyPayTier6_2 } from "./onlineMainRelAltCourtesyPayTier6_2";
import { OnlineMainRelCodeList_2 } from "./onlineMainRelCodeList_2";
import { OnlineMainRelCourtesyPayFee1_2 } from "./onlineMainRelCourtesyPayFee1_2";
import { OnlineMainRelCourtesyPayFee2_2 } from "./onlineMainRelCourtesyPayFee2_2";
import { OnlineMainRelCourtesyPayFee3_2 } from "./onlineMainRelCourtesyPayFee3_2";
import { OnlineMainRelCourtesyPayFee4_2 } from "./onlineMainRelCourtesyPayFee4_2";
import { OnlineMainRelCourtesyPayFee5_2 } from "./onlineMainRelCourtesyPayFee5_2";
import { OnlineMainRelCourtesyPayFee6_2 } from "./onlineMainRelCourtesyPayFee6_2";
import { OnlineMainRelCourtesyPayTier1_2 } from "./onlineMainRelCourtesyPayTier1_2";
import { OnlineMainRelCourtesyPayTier2_2 } from "./onlineMainRelCourtesyPayTier2_2";
import { OnlineMainRelCourtesyPayTier3_2 } from "./onlineMainRelCourtesyPayTier3_2";
import { OnlineMainRelCourtesyPayTier4_2 } from "./onlineMainRelCourtesyPayTier4_2";
import { OnlineMainRelCourtesyPayTier5_2 } from "./onlineMainRelCourtesyPayTier5_2";
import { OnlineMainRelCourtesyPayTier6_2 } from "./onlineMainRelCourtesyPayTier6_2";
import { OnlineMainRelNsfFee_2 } from "./onlineMainRelNsfFee_2";
import { OnlineMainRelOverdrawAddonXfrFee_2 } from "./onlineMainRelOverdrawAddonXfrFee_2";
import { OnlineMainRelOverdrawComboXfrFee_2 } from "./onlineMainRelOverdrawComboXfrFee_2";
import { OnlineMainRelOverdrawWdXfrFee_2 } from "./onlineMainRelOverdrawWdXfrFee_2";
import { OnlineMainRelOvlFee_2 } from "./onlineMainRelOvlFee_2";
import { VersionType } from "./versionType";
export interface OnlineMain_2 {
    acceptLoanThresholdPayment: boolean | null;
    acceptUnappliedPartialPmt: boolean | null;
    appendAtmTerminalId: boolean | null;
    atmAvailBalApprExclList: BitMap;
    atmAvailBalPostExclList: BitMap;
    atmFeeDescription: string;
    atmWarningCodeList: BitMap;
    avsAction: number | null;
    avsMethod: number | null;
    billPayFeeDescription: string;
    bpAvailBalApprExclList: BitMap;
    bpAvailBalPostExclList: BitMap;
    bpWarningCodeList: BitMap;
    cardinHistoryDigitCount: number | null;
    cashMccTypes: BitMap;
    chargePartialCapFee: boolean | null;
    checkWarningCodeList: BitMap;
    chng1GasAuthHoldAmount: number | null;
    clearingGlCode: number | null;
    courtesyNotices: number | null;
    courtesyPayCommentCode: number | null;
    courtesyPayFeeDescription: string;
    courtesyPayFeeGlCode: number | null;
    createExceptionItems: boolean | null;
    creditCardFeeDescription: string;
    cuAtmCheckDepHoldDays: number | null;
    cuAtmEnvDepHoldDays: number | null;
    cuAtmUseRegCcPolicy: boolean | null;
    debitCardFeeDescription: string;
    depWarningCodeList: BitMap;
    dqGraceDaysForAddon: number | null;
    dqGraceDaysForWd: number | null;
    dqWarningCodeList: BitMap;
    duplicateKeyPurgeTime: number | null;
    duplicateKeyRetentionDays: number | null;
    envWarningCodeList: BitMap;
    feeTypeToCap: BitMap;
    frgnAtmCheckDepHoldDays: number | null;
    frgnAtmEnvDepHoldDays: number | null;
    frgnAtmUseRegCcPolicy: boolean | null;
    glCategory: number | null;
    graceAmountforCashPayments: number | null;
    groupMccHoldTime: OnlineMainGroupMccHoldTime_2[];
    groupMccHoldUnits: OnlineMainGroupMccHoldUnits_2[];
    groupMccSourceCodes: OnlineMainGroupMccSourceCodes_2[];
    holdWarningCodeList: BitMap;
    includeOnlineFeesinAppr: boolean | null;
    institutionName: string;
    masterCardCcaFeeGlCode: number | null;
    masterCardIcaFeeGlCode: number | null;
    maxInvalidPinAttempts: number | null;
    maximumAddonOverLoc: number | null;
    maximumWdBelowAvailable: number | null;
    mccTypes: OnlineMainMccTypes_2[];
    minimumLineofCreditAddon: number | null;
    noticesPrinterType: number | null;
    nsfFeeDescIfNotPaid: string;
    nsfFeeDescIfPaid: string;
    nsfFeeForUncollectedFunds: boolean | null;
    nsfFeeGlCode: number | null;
    nsfNotices: boolean | null;
    odTransferFeeCalcOption: number | null;
    odtAuthFeeOvrSrcCodes: string;
    odtAuthFeeRecurSrcCodes: string;
    onlyLoanTransferNotices: boolean | null;
    overdrawAddonDqGraceDays: number | null;
    overdrawAddonIncrement: number | null;
    overdrawAddonMaxOverLoc: number | null;
    overdrawAddonPctOverLoc: number | null;
    overdrawFeeOption: number | null;
    overdrawIncrementOverride: number | null;
    overdrawNoticesfor2NdAcct: boolean | null;
    overdrawOption: number | null;
    overdrawRegDLimiting: boolean | null;
    overdrawTierOption: number | null;
    overdrawTransferFeeGlCode: number | null;
    overdrawTransferNotices: number | null;
    overdrawWithdrawalIncrement: number | null;
    ovlFeeDescIfNotPaid: string;
    ovlFeeDescIfPaid: string;
    ovlFeeForUncollectedFunds: boolean | null;
    ovlFeeGlCode: number | null;
    ovlNotices: boolean | null;
    percentOverLineofCredit: number | null;
    pinPreAuthGasHoldTime: number | null;
    pinPreAuthGasHoldUnits: number | null;
    posAvailBalAuthExclList: BitMap;
    posAvailBalPostExclList: BitMap;
    posFeeDescription: string;
    posWarningCodeList: BitMap;
    postAtmBalanceInquiries: boolean | null;
    postAtmStatements: boolean | null;
    preAuthExpHoldMatchDays: number | null;
    preAuthFmHistoryOption: number | null;
    preAuthHoldTime: number | null;
    preAuthHoldUnits: number | null;
    preAuthMatchVariance: number | null;
    preAuthMaxHoldDays: number | null;
    preAuthTeHoldTime: number | null;
    preAuthTeHoldUnits: number | null;
    prependRegEComments: boolean | null;
    relAltCourtesyPayFee1: OnlineMainRelAltCourtesyPayFee1_2[];
    relAltCourtesyPayFee2: OnlineMainRelAltCourtesyPayFee2_2[];
    relAltCourtesyPayFee3: OnlineMainRelAltCourtesyPayFee3_2[];
    relAltCourtesyPayFee4: OnlineMainRelAltCourtesyPayFee4_2[];
    relAltCourtesyPayFee5: OnlineMainRelAltCourtesyPayFee5_2[];
    relAltCourtesyPayFee6: OnlineMainRelAltCourtesyPayFee6_2[];
    relAltCourtesyPayTier1: OnlineMainRelAltCourtesyPayTier1_2[];
    relAltCourtesyPayTier2: OnlineMainRelAltCourtesyPayTier2_2[];
    relAltCourtesyPayTier3: OnlineMainRelAltCourtesyPayTier3_2[];
    relAltCourtesyPayTier4: OnlineMainRelAltCourtesyPayTier4_2[];
    relAltCourtesyPayTier5: OnlineMainRelAltCourtesyPayTier5_2[];
    relAltCourtesyPayTier6: OnlineMainRelAltCourtesyPayTier6_2[];
    relCodeList: OnlineMainRelCodeList_2[];
    relCourtesyPayFee1: OnlineMainRelCourtesyPayFee1_2[];
    relCourtesyPayFee2: OnlineMainRelCourtesyPayFee2_2[];
    relCourtesyPayFee3: OnlineMainRelCourtesyPayFee3_2[];
    relCourtesyPayFee4: OnlineMainRelCourtesyPayFee4_2[];
    relCourtesyPayFee5: OnlineMainRelCourtesyPayFee5_2[];
    relCourtesyPayFee6: OnlineMainRelCourtesyPayFee6_2[];
    relCourtesyPayTier1: OnlineMainRelCourtesyPayTier1_2[];
    relCourtesyPayTier2: OnlineMainRelCourtesyPayTier2_2[];
    relCourtesyPayTier3: OnlineMainRelCourtesyPayTier3_2[];
    relCourtesyPayTier4: OnlineMainRelCourtesyPayTier4_2[];
    relCourtesyPayTier5: OnlineMainRelCourtesyPayTier5_2[];
    relCourtesyPayTier6: OnlineMainRelCourtesyPayTier6_2[];
    relNsfFee: OnlineMainRelNsfFee_2[];
    relOverdrawAddonXfrFee: OnlineMainRelOverdrawAddonXfrFee_2[];
    relOverdrawComboXfrFee: OnlineMainRelOverdrawComboXfrFee_2[];
    relOverdrawWdXfrFee: OnlineMainRelOverdrawWdXfrFee_2[];
    relOvlFee: OnlineMainRelOvlFee_2[];
    reportTitle: string;
    sigAvailBalAuthExclList: BitMap;
    sigAvailBalPostExclList: BitMap;
    sigPreAuthGasHoldTime: number | null;
    sigPreAuthGasHoldUnits: number | null;
    sigWarningCodeList: BitMap;
    useFeeStatusfromAuth: string;
    useLowQualMatchFeeStatus: string;
    useNetworkPreAuthHoldTime: boolean | null;
    usePostExclListonFinReq: string;
    visaMultiCrrncyIsaFeeGl: number | null;
    visaSglCrrncyIsaFeeGl: number | null;
    waiveFeeforAuthAdvice: string;
    waiveFeeonNoHoldMatch: string;
    waiveFeeonNoHoldRecur: string;
    wdBelowAvailableOption: number | null;
    wdWarningCodeList: BitMap;
    version1: VersionType;
}
