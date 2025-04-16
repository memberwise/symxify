import { ShareAlternateAddress_2 } from "./shareAlternateAddress_2";
import { ShareAlternatePhone_2 } from "./shareAlternatePhone_2";
import { ShareAuthFeeOption_2 } from "./shareAuthFeeOption_2";
import { ShareFeeCount_2 } from "./shareFeeCount_2";
import { ShareInsuranceBalanceAge_2 } from "./shareInsuranceBalanceAge_2";
import { ShareOdtAuthFeeSrcCodeList_2 } from "./shareOdtAuthFeeSrcCodeList_2";
import { SharePayeeLine_2 } from "./sharePayeeLine_2";
import { SharePayeePhone_2 } from "./sharePayeePhone_2";
import { SharePreMthDivAccrued_2 } from "./sharePreMthDivAccrued_2";
import { SharePreMthDivEarned_2 } from "./sharePreMthDivEarned_2";
import { SharePreMthDivPaid_2 } from "./sharePreMthDivPaid_2";
import { ShareService_2 } from "./shareService_2";
import { ShareWarningCode_2 } from "./shareWarningCode_2";
import { ShareWarningExpiration_2 } from "./shareWarningExpiration_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface Share_2 {
    activityDateValue: string | null;
    activityDateValueSpecified: boolean;
    activityDate: string | null;
    alternateAddress: ShareAlternateAddress_2[];
    alternateAddressSpecified: boolean;
    alternateNameLocatorValue: number;
    alternateNameLocatorValueSpecified: boolean;
    alternateNameLocator: number | null;
    alternateNameTypeValue: number;
    alternateNameTypeValueSpecified: boolean;
    alternateNameType: number | null;
    alternatePhone: ShareAlternatePhone_2[];
    alternatePhoneSpecified: boolean;
    amortizationSchdValue: number;
    amortizationSchdValueSpecified: boolean;
    amortizationSchd: number | null;
    amortizationSchdTypeValue: number;
    amortizationSchdTypeValueSpecified: boolean;
    amortizationSchdType: number | null;
    analysisGroupPrimaryAcct: string;
    analysisGroupPrimaryId: string;
    analysisPmtAcct: string;
    analysisPmtIdTypeValue: number;
    analysisPmtIdTypeValueSpecified: boolean;
    analysisPmtIdType: number | null;
    analysisPmtSlId: string;
    authFeeOption: ShareAuthFeeOption_2[];
    authFeeOptionSpecified: boolean;
    availableBalanceValue: number;
    availableBalanceValueSpecified: boolean;
    availableBalance: number | null;
    balanceValue: number;
    balanceValueSpecified: boolean;
    balance: number | null;
    bondIntLastYearValue: number;
    bondIntLastYearValueSpecified: boolean;
    bondIntLastYear: number | null;
    bondIntYtdValue: number;
    bondIntYtdValueSpecified: boolean;
    bondIntYtd: number | null;
    branchValue: number;
    branchValueSpecified: boolean;
    branch: number | null;
    bumpEffectiveDateValue: string | null;
    bumpEffectiveDateValueSpecified: boolean;
    bumpEffectiveDate: string | null;
    bumpExpirationDateValue: string | null;
    bumpExpirationDateValueSpecified: boolean;
    bumpExpirationDate: string | null;
    bumpRateValue: number;
    bumpRateValueSpecified: boolean;
    bumpRate: number | null;
    callItemSchdValue: number;
    callItemSchdValueSpecified: boolean;
    callItemSchd: number | null;
    callItemSchdTypeValue: number;
    callItemSchdTypeValueSpecified: boolean;
    callItemSchdType: number | null;
    cappedFeesAmountCapValue: number;
    cappedFeesAmountCapValueSpecified: boolean;
    cappedFeesAmountCap: number | null;
    cappedFeesAmtPeriodValue: number;
    cappedFeesAmtPeriodValueSpecified: boolean;
    cappedFeesAmtPeriod: number | null;
    cappedFeesCntPeriodValue: number;
    cappedFeesCntPeriodValueSpecified: boolean;
    cappedFeesCntPeriod: number | null;
    cappedFeesCountCapValue: number;
    cappedFeesCountCapValueSpecified: boolean;
    cappedFeesCountCap: number | null;
    cddivAccrLastYrValue: number;
    cddivAccrLastYrValueSpecified: boolean;
    cddivAccrLastYr: number | null;
    cddivAccrYtdValue: number;
    cddivAccrYtdValueSpecified: boolean;
    cddivAccrYtd: number | null;
    certificateNumber: string;
    chapter4WithheldLstYrValue: number;
    chapter4WithheldLstYrValueSpecified: boolean;
    chapter4WithheldLstYr: number | null;
    chapter4WithheldYtdValue: number;
    chapter4WithheldYtdValueSpecified: boolean;
    chapter4WithheldYtd: number | null;
    chapter4WithholdingCodeValue: number;
    chapter4WithholdingCodeValueSpecified: boolean;
    chapter4WithholdingCode: number | null;
    chargeOffAmountValue: number;
    chargeOffAmountValueSpecified: boolean;
    chargeOffAmount: number | null;
    chargeOffDateValue: string | null;
    chargeOffDateValueSpecified: boolean;
    chargeOffDate: string | null;
    chargeOffTypeValue: number;
    chargeOffTypeValueSpecified: boolean;
    chargeOffType: number | null;
    checkDigits: string;
    closeDateValue: string | null;
    closeDateValueSpecified: boolean;
    closeDate: string | null;
    corporateUserTransferCodeValue: number;
    corporateUserTransferCodeValueSpecified: boolean;
    corporateUserTransferCode: number | null;
    courtesyFeeLyValue: number;
    courtesyFeeLyValueSpecified: boolean;
    courtesyFeeLy: number | null;
    courtesyFeeMtdValue: number;
    courtesyFeeMtdValueSpecified: boolean;
    courtesyFeeMtd: number | null;
    courtesyFeeYtdValue: number;
    courtesyFeeYtdValueSpecified: boolean;
    courtesyFeeYtd: number | null;
    courtesyPayLastYearValue: number;
    courtesyPayLastYearValueSpecified: boolean;
    courtesyPayLastYear: number | null;
    courtesyPayMonthToDateValue: number;
    courtesyPayMonthToDateValueSpecified: boolean;
    courtesyPayMonthToDate: number | null;
    courtesyPayYtdValue: number;
    courtesyPayYtdValueSpecified: boolean;
    courtesyPayYtd: number | null;
    createdAtBranchValue: number;
    createdAtBranchValueSpecified: boolean;
    createdAtBranch: number | null;
    createdByUserValue: number;
    createdByUserValueSpecified: boolean;
    createdByUser: number | null;
    creditReportComment: string;
    creditReportCompliance: string;
    creditReportConsumerInfo: string;
    creditReportConsumerInfoDateValue: string | null;
    creditReportConsumerInfoDateValueSpecified: boolean;
    creditReportConsumerInfoDate: string | null;
    creditReportLastStatusValue: number;
    creditReportLastStatusValueSpecified: boolean;
    creditReportLastStatus: number | null;
    creditReportNumber: string;
    creditReportOccurDateValue: string | null;
    creditReportOccurDateValueSpecified: boolean;
    creditReportOccurDate: string | null;
    creditReportOriginalAmountRptdValue: number;
    creditReportOriginalAmountRptdValueSpecified: boolean;
    creditReportOriginalAmountRptd: number | null;
    creditReportingCodeValue: number;
    creditReportingCodeValueSpecified: boolean;
    creditReportingCode: number | null;
    cuTotalsUseCodeValue: number;
    cuTotalsUseCodeValueSpecified: boolean;
    cuTotalsUseCode: number | null;
    currDivPayableValue: number;
    currDivPayableValueSpecified: boolean;
    currDivPayable: number | null;
    currMonthPaidDivValue: number;
    currMonthPaidDivValueSpecified: boolean;
    currMonthPaidDiv: number | null;
    description: string;
    divAccrualValue: number;
    divAccrualValueSpecified: boolean;
    divAccrual: number | null;
    divAccrualDateValue: string | null;
    divAccrualDateValueSpecified: boolean;
    divAccrualDate: string | null;
    divDisbUpdtActvtyDValue: number;
    divDisbUpdtActvtyDValueSpecified: boolean;
    divDisbUpdtActvtyD: number | null;
    divFromOpenValue: number;
    divFromOpenValueSpecified: boolean;
    divFromOpen: number | null;
    divLastYearValue: number;
    divLastYearValueSpecified: boolean;
    divLastYear: number | null;
    divPeriodBalDaysValue: number;
    divPeriodBalDaysValueSpecified: boolean;
    divPeriodBalDays: number | null;
    divPeriodStartValue: string | null;
    divPeriodStartValueSpecified: boolean;
    divPeriodStart: string | null;
    divPostCodeValue: number;
    divPostCodeValueSpecified: boolean;
    divPostCode: number | null;
    divRateValue: number;
    divRateValueSpecified: boolean;
    divRate: number | null;
    divTypeValue: number;
    divTypeValueSpecified: boolean;
    divType: number | null;
    divYtdValue: number;
    divYtdValueSpecified: boolean;
    divYtd: number | null;
    dividendDueValue: number;
    dividendDueValueSpecified: boolean;
    dividendDue: number | null;
    dividendRateMarginValue: number;
    dividendRateMarginValueSpecified: boolean;
    dividendRateMargin: number | null;
    dividendRateMarginSignValue: number;
    dividendRateMarginSignValueSpecified: boolean;
    dividendRateMarginSign: number | null;
    dividendRateMaxValue: number;
    dividendRateMaxValueSpecified: boolean;
    dividendRateMax: number | null;
    dividendRateMinValue: number;
    dividendRateMinValueSpecified: boolean;
    dividendRateMin: number | null;
    dividendRatePeriodDateValue: string | null;
    dividendRatePeriodDateValueSpecified: boolean;
    dividendRatePeriodDate: string | null;
    dividendRatePeriodFreqValue: number;
    dividendRatePeriodFreqValueSpecified: boolean;
    dividendRatePeriodFreq: number | null;
    escrowLastYearValue: number;
    escrowLastYearValueSpecified: boolean;
    escrowLastYear: number | null;
    escrowYtdValue: number;
    escrowYtdValueSpecified: boolean;
    escrowYtd: number | null;
    escrowedLoanId: string;
    extAchXfrDailyLimitInValue: number;
    extAchXfrDailyLimitInValueSpecified: boolean;
    extAchXfrDailyLimitIn: number | null;
    extAchXfrDailyLimitOutValue: number;
    extAchXfrDailyLimitOutValueSpecified: boolean;
    extAchXfrDailyLimitOut: number | null;
    feeCount: ShareFeeCount_2[];
    feeCountSpecified: boolean;
    feeExemptCrtsyBalValue: number;
    feeExemptCrtsyBalValueSpecified: boolean;
    feeExemptCrtsyBal: number | null;
    id: string;
    insuranceBalanceAge: ShareInsuranceBalanceAge_2[];
    insuranceBalanceAgeSpecified: boolean;
    insuranceMaximumValue: number;
    insuranceMaximumValueSpecified: boolean;
    insuranceMaximum: number | null;
    insuranceTypeValue: number;
    insuranceTypeValueSpecified: boolean;
    insuranceType: number | null;
    irs1042SUfidValue: number;
    irs1042SUfidValueSpecified: boolean;
    irs1042SUfid: number | null;
    irsCodeValue: number;
    irsCodeValueSpecified: boolean;
    irsCode: number | null;
    irsPlanValue: number;
    irsPlanValueSpecified: boolean;
    irsPlan: number | null;
    lastAccrualUpdateDateValue: string | null;
    lastAccrualUpdateDateValueSpecified: boolean;
    lastAccrualUpdateDate: string | null;
    lastCrReportDateValue: string | null;
    lastCrReportDateValueSpecified: boolean;
    lastCrReportDate: string | null;
    lastDirectDepAmtValue: number;
    lastDirectDepAmtValueSpecified: boolean;
    lastDirectDepAmt: number | null;
    lastDirectDepDateValue: string | null;
    lastDirectDepDateValueSpecified: boolean;
    lastDirectDepDate: string | null;
    lastDivAmountValue: number;
    lastDivAmountValueSpecified: boolean;
    lastDivAmount: number | null;
    lastDivDateValue: string | null;
    lastDivDateValueSpecified: boolean;
    lastDivDate: string | null;
    lastFmDateValue: string | null;
    lastFmDateValueSpecified: boolean;
    lastFmDate: string | null;
    lastPurgeDateValue: string | null;
    lastPurgeDateValueSpecified: boolean;
    lastPurgeDate: string | null;
    lastTranDateValue: string | null;
    lastTranDateValueSpecified: boolean;
    lastTranDate: string | null;
    ledgerAccrualValue: number;
    ledgerAccrualValueSpecified: boolean;
    ledgerAccrual: number | null;
    ledgerAccrualDateValue: string | null;
    ledgerAccrualDateValueSpecified: boolean;
    ledgerAccrualDate: string | null;
    loanPaymentHoldValue: number;
    loanPaymentHoldValueSpecified: boolean;
    loanPaymentHold: number | null;
    maturityDateValue: string | null;
    maturityDateValueSpecified: boolean;
    maturityDate: string | null;
    maturityPostCodeValue: number;
    maturityPostCodeValueSpecified: boolean;
    maturityPostCode: number | null;
    mcDivLastYearValue: number;
    mcDivLastYearValueSpecified: boolean;
    mcDivLastYear: number | null;
    mcDivYtdValue: number;
    mcDivYtdValueSpecified: boolean;
    mcDivYtd: number | null;
    memberBranchSupportValue: number;
    memberBranchSupportValueSpecified: boolean;
    memberBranchSupport: number | null;
    memberUserTransferCodeValue: number;
    memberUserTransferCodeValueSpecified: boolean;
    memberUserTransferCode: number | null;
    micrAcctNumber: string;
    minimumBalanceValue: number;
    minimumBalanceValueSpecified: boolean;
    minimumBalance: number | null;
    minimumDepositValue: number;
    minimumDepositValueSpecified: boolean;
    minimumDeposit: number | null;
    minimumWithdrawalValue: number;
    minimumWithdrawalValueSpecified: boolean;
    minimumWithdrawal: number | null;
    mtdAccruedDivsValue: number;
    mtdAccruedDivsValueSpecified: boolean;
    mtdAccruedDivs: number | null;
    mtdEarnedDivsValue: number;
    mtdEarnedDivsValueSpecified: boolean;
    mtdEarnedDivs: number | null;
    mtdPaidDivsValue: number;
    mtdPaidDivsValueSpecified: boolean;
    mtdPaidDivs: number | null;
    mtdPriorRateAccrualValue: number;
    mtdPriorRateAccrualValueSpecified: boolean;
    mtdPriorRateAccrual: number | null;
    negativeBalanceDateValue: string | null;
    negativeBalanceDateValueSpecified: boolean;
    negativeBalanceDate: string | null;
    negativeBalanceNoticeDateValue: string | null;
    negativeBalanceNoticeDateValueSpecified: boolean;
    negativeBalanceNoticeDate: string | null;
    negativeBalanceNoticeNumberValue: number;
    negativeBalanceNoticeNumberValueSpecified: boolean;
    negativeBalanceNoticeNumber: number | null;
    negativeBalanceNoticeTypeValue: number;
    negativeBalanceNoticeTypeValueSpecified: boolean;
    negativeBalanceNoticeType: number | null;
    nickname: string;
    nsfFeeLyValue: number;
    nsfFeeLyValueSpecified: boolean;
    nsfFeeLy: number | null;
    nsfFeeMtdValue: number;
    nsfFeeMtdValueSpecified: boolean;
    nsfFeeMtd: number | null;
    nsfFeeYtdValue: number;
    nsfFeeYtdValueSpecified: boolean;
    nsfFeeYtd: number | null;
    nsfLastYearValue: number;
    nsfLastYearValueSpecified: boolean;
    nsfLastYear: number | null;
    nsfMonthToDateValue: number;
    nsfMonthToDateValueSpecified: boolean;
    nsfMonthToDate: number | null;
    nsfYtdValue: number;
    nsfYtdValueSpecified: boolean;
    nsfYtd: number | null;
    odtAuthFeeSrcCodeList: ShareOdtAuthFeeSrcCodeList_2[];
    odtAuthFeeSrcCodeListSpecified: boolean;
    openDateValue: string | null;
    openDateValueSpecified: boolean;
    openDate: string | null;
    originalBalanceValue: number;
    originalBalanceValueSpecified: boolean;
    originalBalance: number | null;
    originalDepositValue: number;
    originalDepositValueSpecified: boolean;
    originalDeposit: number | null;
    originalDepositDateValue: string | null;
    originalDepositDateValueSpecified: boolean;
    originalDepositDate: string | null;
    overdraftFeeLastYrValue: number;
    overdraftFeeLastYrValueSpecified: boolean;
    overdraftFeeLastYr: number | null;
    overdraftFeeYtdValue: number;
    overdraftFeeYtdValueSpecified: boolean;
    overdraftFeeYtd: number | null;
    overdraftToleranceValue: number;
    overdraftToleranceValueSpecified: boolean;
    overdraftTolerance: number | null;
    payeeLine: SharePayeeLine_2[];
    payeeLineSpecified: boolean;
    payeeNameLocatorValue: number;
    payeeNameLocatorValueSpecified: boolean;
    payeeNameLocator: number | null;
    payeeNameTypeValue: number;
    payeeNameTypeValueSpecified: boolean;
    payeeNameType: number | null;
    payeePhone: SharePayeePhone_2[];
    payeePhoneSpecified: boolean;
    penaltyLastYearValue: number;
    penaltyLastYearValueSpecified: boolean;
    penaltyLastYear: number | null;
    penaltyTypeValue: number;
    penaltyTypeValueSpecified: boolean;
    penaltyType: number | null;
    penaltyYtdValue: number;
    penaltyYtdValueSpecified: boolean;
    penaltyYtd: number | null;
    periodicCapValue: number;
    periodicCapValueSpecified: boolean;
    periodicCap: number | null;
    periodicStartRateValue: number;
    periodicStartRateValueSpecified: boolean;
    periodicStartRate: number | null;
    positivePayDraftValue: number;
    positivePayDraftValueSpecified: boolean;
    positivePayDraft: number | null;
    preMthDivAccrued: SharePreMthDivAccrued_2[];
    preMthDivAccruedSpecified: boolean;
    preMthDivEarned: SharePreMthDivEarned_2[];
    preMthDivEarnedSpecified: boolean;
    preMthDivPaid: SharePreMthDivPaid_2[];
    preMthDivPaidSpecified: boolean;
    putItemSchdValue: number;
    putItemSchdValueSpecified: boolean;
    putItemSchd: number | null;
    putItemSchdTypeValue: number;
    putItemSchdTypeValueSpecified: boolean;
    putItemSchdType: number | null;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    reference: string;
    regDCheckCountValue: number;
    regDCheckCountValueSpecified: boolean;
    regDCheckCount: number | null;
    regDCtrStartDayValue: number;
    regDCtrStartDayValueSpecified: boolean;
    regDCtrStartDay: number | null;
    regDTransferCountValue: number;
    regDTransferCountValueSpecified: boolean;
    regDTransferCount: number | null;
    regECountValue: number;
    regECountValueSpecified: boolean;
    regECount: number | null;
    renewShareTypeValue: number;
    renewShareTypeValueSpecified: boolean;
    renewShareType: number | null;
    renewTermFreqValue: number;
    renewTermFreqValueSpecified: boolean;
    renewTermFreq: number | null;
    renewTermPeriodValue: number;
    renewTermPeriodValueSpecified: boolean;
    renewTermPeriod: number | null;
    service: ShareService_2[];
    serviceSpecified: boolean;
    shareCodeValue: number;
    shareCodeValueSpecified: boolean;
    shareCode: number | null;
    stateWithholdingCodeValue: number;
    stateWithholdingCodeValueSpecified: boolean;
    stateWithholdingCode: number | null;
    stateWithholdingLastQtrValue: number;
    stateWithholdingLastQtrValueSpecified: boolean;
    stateWithholdingLastQtr: number | null;
    stateWithholdingLastYearValue: number;
    stateWithholdingLastYearValueSpecified: boolean;
    stateWithholdingLastYear: number | null;
    stateWithholdingQtdValue: number;
    stateWithholdingQtdValueSpecified: boolean;
    stateWithholdingQtd: number | null;
    stateWithholdingYtdValue: number;
    stateWithholdingYtdValueSpecified: boolean;
    stateWithholdingYtd: number | null;
    statementDateValue: string | null;
    statementDateValueSpecified: boolean;
    statementDate: string | null;
    statementGroupValue: number;
    statementGroupValueSpecified: boolean;
    statementGroup: number | null;
    statementMailCodeValue: number;
    statementMailCodeValueSpecified: boolean;
    statementMailCode: number | null;
    statementPrevDateValue: string | null;
    statementPrevDateValueSpecified: boolean;
    statementPrevDate: string | null;
    sweepBalanceTypeValue: number;
    sweepBalanceTypeValueSpecified: boolean;
    sweepBalanceType: number | null;
    sweepPriorityValue: number;
    sweepPriorityValueSpecified: boolean;
    sweepPriority: number | null;
    sweepTargetMaximumValue: number;
    sweepTargetMaximumValueSpecified: boolean;
    sweepTargetMaximum: number | null;
    sweepTargetMinimumValue: number;
    sweepTargetMinimumValueSpecified: boolean;
    sweepTargetMinimum: number | null;
    termFrequencyValue: number;
    termFrequencyValueSpecified: boolean;
    termFrequency: number | null;
    termPeriodValue: number;
    termPeriodValueSpecified: boolean;
    termPeriod: number | null;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    unpaidFeeLastYearValue: number;
    unpaidFeeLastYearValueSpecified: boolean;
    unpaidFeeLastYear: number | null;
    unpaidFeeYtdValue: number;
    unpaidFeeYtdValueSpecified: boolean;
    unpaidFeeYtd: number | null;
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
    warningCode: ShareWarningCode_2[];
    warningCodeSpecified: boolean;
    warningExpiration: ShareWarningExpiration_2[];
    warningExpirationSpecified: boolean;
    withdrawalCountValue: number;
    withdrawalCountValueSpecified: boolean;
    withdrawalCount: number | null;
    withdrawalFeeCountValue: number;
    withdrawalFeeCountValueSpecified: boolean;
    withdrawalFeeCount: number | null;
    withdrawalFeeTypeValue: number;
    withdrawalFeeTypeValueSpecified: boolean;
    withdrawalFeeType: number | null;
    withdrawalLimitValue: number;
    withdrawalLimitValueSpecified: boolean;
    withdrawalLimit: number | null;
    withdrawnFromOpenValue: number;
    withdrawnFromOpenValueSpecified: boolean;
    withdrawnFromOpen: number | null;
    withholdingCodeValue: number;
    withholdingCodeValueSpecified: boolean;
    withholdingCode: number | null;
    withholdingLastYearValue: number;
    withholdingLastYearValueSpecified: boolean;
    withholdingLastYear: number | null;
    withholdingYtdValue: number;
    withholdingYtdValueSpecified: boolean;
    withholdingYtd: number | null;
    xfrLastYearValue: number;
    xfrLastYearValueSpecified: boolean;
    xfrLastYear: number | null;
    xfrMonthToDateValue: number;
    xfrMonthToDateValueSpecified: boolean;
    xfrMonthToDate: number | null;
    xfrYtdValue: number;
    xfrYtdValueSpecified: boolean;
    xfrYtd: number | null;
    yearEndBalanceValue: number;
    yearEndBalanceValueSpecified: boolean;
    yearEndBalance: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
