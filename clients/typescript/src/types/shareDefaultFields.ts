import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface ShareDefaultFields {
    amortizationSchdValue: boolean;
    amortizationSchdValueSpecified: boolean;
    amortizationSchd: boolean | null;
    amortizationSchdTypeValue: boolean;
    amortizationSchdTypeValueSpecified: boolean;
    amortizationSchdType: boolean | null;
    authFeeOption: number[];
    authFeeOptionSpecified: boolean;
    bumpEffectiveDateValue: boolean;
    bumpEffectiveDateValueSpecified: boolean;
    bumpEffectiveDate: boolean | null;
    bumpExpirationDateValue: boolean;
    bumpExpirationDateValueSpecified: boolean;
    bumpExpirationDate: boolean | null;
    bumpRateValue: boolean;
    bumpRateValueSpecified: boolean;
    bumpRate: boolean | null;
    callItemSchdValue: boolean;
    callItemSchdValueSpecified: boolean;
    callItemSchd: boolean | null;
    callItemSchdTypeValue: boolean;
    callItemSchdTypeValueSpecified: boolean;
    callItemSchdType: boolean | null;
    cappedFeesAmountCapValue: boolean;
    cappedFeesAmountCapValueSpecified: boolean;
    cappedFeesAmountCap: boolean | null;
    cappedFeesCountCapValue: boolean;
    cappedFeesCountCapValueSpecified: boolean;
    cappedFeesCountCap: boolean | null;
    certificateNumberValue: boolean;
    certificateNumberValueSpecified: boolean;
    certificateNumber: boolean | null;
    chapter4WithholdingCodeValue: boolean;
    chapter4WithholdingCodeValueSpecified: boolean;
    chapter4WithholdingCode: boolean | null;
    checkDigitsValue: boolean;
    checkDigitsValueSpecified: boolean;
    checkDigits: boolean | null;
    closeDateValue: boolean;
    closeDateValueSpecified: boolean;
    closeDate: boolean | null;
    corporateUserTransferCodeValue: boolean;
    corporateUserTransferCodeValueSpecified: boolean;
    corporateUserTransferCode: boolean | null;
    creditReportingCodeValue: boolean;
    creditReportingCodeValueSpecified: boolean;
    creditReportingCode: boolean | null;
    cuTotalsUseCodeValue: boolean;
    cuTotalsUseCodeValueSpecified: boolean;
    cuTotalsUseCode: boolean | null;
    descriptionValue: boolean;
    descriptionValueSpecified: boolean;
    description: boolean | null;
    divDisbUpdtActvtyDValue: boolean;
    divDisbUpdtActvtyDValueSpecified: boolean;
    divDisbUpdtActvtyD: boolean | null;
    divPostCodeValue: boolean;
    divPostCodeValueSpecified: boolean;
    divPostCode: boolean | null;
    divRateValue: boolean;
    divRateValueSpecified: boolean;
    divRate: boolean | null;
    divTypeValue: boolean;
    divTypeValueSpecified: boolean;
    divType: boolean | null;
    dividendRateMarginValue: boolean;
    dividendRateMarginValueSpecified: boolean;
    dividendRateMargin: boolean | null;
    dividendRateMarginSignValue: boolean;
    dividendRateMarginSignValueSpecified: boolean;
    dividendRateMarginSign: boolean | null;
    dividendRateMaxValue: boolean;
    dividendRateMaxValueSpecified: boolean;
    dividendRateMax: boolean | null;
    dividendRateMinValue: boolean;
    dividendRateMinValueSpecified: boolean;
    dividendRateMin: boolean | null;
    dividendRatePeriodDateValue: boolean;
    dividendRatePeriodDateValueSpecified: boolean;
    dividendRatePeriodDate: boolean | null;
    dividendRatePeriodFreqValue: boolean;
    dividendRatePeriodFreqValueSpecified: boolean;
    dividendRatePeriodFreq: boolean | null;
    extAchXfrDailyLimitInValue: boolean;
    extAchXfrDailyLimitInValueSpecified: boolean;
    extAchXfrDailyLimitIn: boolean | null;
    extAchXfrDailyLimitOutValue: boolean;
    extAchXfrDailyLimitOutValueSpecified: boolean;
    extAchXfrDailyLimitOut: boolean | null;
    insuranceMaximumValue: boolean;
    insuranceMaximumValueSpecified: boolean;
    insuranceMaximum: boolean | null;
    insuranceTypeValue: boolean;
    insuranceTypeValueSpecified: boolean;
    insuranceType: boolean | null;
    irsCodeValue: boolean;
    irsCodeValueSpecified: boolean;
    irsCode: boolean | null;
    irsPlanValue: boolean;
    irsPlanValueSpecified: boolean;
    irsPlan: boolean | null;
    maturityDateValue: boolean;
    maturityDateValueSpecified: boolean;
    maturityDate: boolean | null;
    maturityPostCodeValue: boolean;
    maturityPostCodeValueSpecified: boolean;
    maturityPostCode: boolean | null;
    memberBranchSupportValue: boolean;
    memberBranchSupportValueSpecified: boolean;
    memberBranchSupport: boolean | null;
    memberUserTransferCodeValue: boolean;
    memberUserTransferCodeValueSpecified: boolean;
    memberUserTransferCode: boolean | null;
    minimumBalanceValue: boolean;
    minimumBalanceValueSpecified: boolean;
    minimumBalance: boolean | null;
    minimumDepositValue: boolean;
    minimumDepositValueSpecified: boolean;
    minimumDeposit: boolean | null;
    minimumWithdrawalValue: boolean;
    minimumWithdrawalValueSpecified: boolean;
    minimumWithdrawal: boolean | null;
    negativeBalanceNoticeNumberValue: boolean;
    negativeBalanceNoticeNumberValueSpecified: boolean;
    negativeBalanceNoticeNumber: boolean | null;
    negativeBalanceNoticeTypeValue: boolean;
    negativeBalanceNoticeTypeValueSpecified: boolean;
    negativeBalanceNoticeType: boolean | null;
    nicknameValue: boolean;
    nicknameValueSpecified: boolean;
    nickname: boolean | null;
    odtAuthFeeSrcCodeList: number[];
    odtAuthFeeSrcCodeListSpecified: boolean;
    overdraftToleranceValue: boolean;
    overdraftToleranceValueSpecified: boolean;
    overdraftTolerance: boolean | null;
    penaltyTypeValue: boolean;
    penaltyTypeValueSpecified: boolean;
    penaltyType: boolean | null;
    periodicCapValue: boolean;
    periodicCapValueSpecified: boolean;
    periodicCap: boolean | null;
    periodicStartRateValue: boolean;
    periodicStartRateValueSpecified: boolean;
    periodicStartRate: boolean | null;
    putItemSchdValue: boolean;
    putItemSchdValueSpecified: boolean;
    putItemSchd: boolean | null;
    putItemSchdTypeValue: boolean;
    putItemSchdTypeValueSpecified: boolean;
    putItemSchdType: boolean | null;
    referenceValue: boolean;
    referenceValueSpecified: boolean;
    reference: boolean | null;
    regDCtrStartDayValue: boolean;
    regDCtrStartDayValueSpecified: boolean;
    regDCtrStartDay: boolean | null;
    renewShareTypeValue: boolean;
    renewShareTypeValueSpecified: boolean;
    renewShareType: boolean | null;
    renewTermFreqValue: boolean;
    renewTermFreqValueSpecified: boolean;
    renewTermFreq: boolean | null;
    renewTermPeriodValue: boolean;
    renewTermPeriodValueSpecified: boolean;
    renewTermPeriod: boolean | null;
    service: number[];
    serviceSpecified: boolean;
    shareCodeValue: boolean;
    shareCodeValueSpecified: boolean;
    shareCode: boolean | null;
    shareTypeValue: boolean;
    shareTypeValueSpecified: boolean;
    shareType: boolean | null;
    stateWithholdingCodeValue: boolean;
    stateWithholdingCodeValueSpecified: boolean;
    stateWithholdingCode: boolean | null;
    statementGroupValue: boolean;
    statementGroupValueSpecified: boolean;
    statementGroup: boolean | null;
    statementMailCodeValue: boolean;
    statementMailCodeValueSpecified: boolean;
    statementMailCode: boolean | null;
    sweepBalanceTypeValue: boolean;
    sweepBalanceTypeValueSpecified: boolean;
    sweepBalanceType: boolean | null;
    sweepPriorityValue: boolean;
    sweepPriorityValueSpecified: boolean;
    sweepPriority: boolean | null;
    sweepTargetMaximumValue: boolean;
    sweepTargetMaximumValueSpecified: boolean;
    sweepTargetMaximum: boolean | null;
    sweepTargetMinimumValue: boolean;
    sweepTargetMinimumValueSpecified: boolean;
    sweepTargetMinimum: boolean | null;
    termFrequencyValue: boolean;
    termFrequencyValueSpecified: boolean;
    termFrequency: boolean | null;
    termPeriodValue: boolean;
    termPeriodValueSpecified: boolean;
    termPeriod: boolean | null;
    typeValue: boolean;
    typeValueSpecified: boolean;
    type: boolean | null;
    userAmount1Value: boolean;
    userAmount1ValueSpecified: boolean;
    userAmount1: boolean | null;
    userAmount2Value: boolean;
    userAmount2ValueSpecified: boolean;
    userAmount2: boolean | null;
    userChar1Value: boolean;
    userChar1ValueSpecified: boolean;
    userChar1: boolean | null;
    userChar2Value: boolean;
    userChar2ValueSpecified: boolean;
    userChar2: boolean | null;
    userChar3Value: boolean;
    userChar3ValueSpecified: boolean;
    userChar3: boolean | null;
    userChar4Value: boolean;
    userChar4ValueSpecified: boolean;
    userChar4: boolean | null;
    userDate1Value: boolean;
    userDate1ValueSpecified: boolean;
    userDate1: boolean | null;
    userDate2Value: boolean;
    userDate2ValueSpecified: boolean;
    userDate2: boolean | null;
    warningCode: number[];
    warningCodeSpecified: boolean;
    withdrawalFeeTypeValue: boolean;
    withdrawalFeeTypeValueSpecified: boolean;
    withdrawalFeeType: boolean | null;
    withdrawalLimitValue: boolean;
    withdrawalLimitValueSpecified: boolean;
    withdrawalLimit: boolean | null;
    withholdingCodeValue: boolean;
    withholdingCodeValueSpecified: boolean;
    withholdingCode: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}