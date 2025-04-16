import { ShareDefaultAuthFeeOption } from "./shareDefaultAuthFeeOption";
import { ShareDefaultOdtAuthFeeSrcCodeList } from "./shareDefaultOdtAuthFeeSrcCodeList";
import { ShareDefaultService } from "./shareDefaultService";
import { ShareDefaultWarningCode } from "./shareDefaultWarningCode";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface ShareDefault {
    amortizationSchdValue: number;
    amortizationSchdValueSpecified: boolean;
    amortizationSchd: number | null;
    amortizationSchdTypeValue: number;
    amortizationSchdTypeValueSpecified: boolean;
    amortizationSchdType: number | null;
    authFeeOption: ShareDefaultAuthFeeOption[];
    authFeeOptionSpecified: boolean;
    bumpEffectiveDateValue: string;
    bumpEffectiveDateValueSpecified: boolean;
    bumpEffectiveDate: string | null;
    bumpExpirationDateValue: string;
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
    cappedFeesCountCapValue: number;
    cappedFeesCountCapValueSpecified: boolean;
    cappedFeesCountCap: number | null;
    certificateNumber: string;
    chapter4WithholdingCodeValue: number;
    chapter4WithholdingCodeValueSpecified: boolean;
    chapter4WithholdingCode: number | null;
    checkDigits: string;
    closeDateValue: string;
    closeDateValueSpecified: boolean;
    closeDate: string | null;
    corporateUserTransferCodeValue: number;
    corporateUserTransferCodeValueSpecified: boolean;
    corporateUserTransferCode: number | null;
    creditReportingCodeValue: number;
    creditReportingCodeValueSpecified: boolean;
    creditReportingCode: number | null;
    cuTotalsUseCodeValue: number;
    cuTotalsUseCodeValueSpecified: boolean;
    cuTotalsUseCode: number | null;
    description: string;
    divDisbUpdtActvtyDValue: number;
    divDisbUpdtActvtyDValueSpecified: boolean;
    divDisbUpdtActvtyD: number | null;
    divPostCodeValue: number;
    divPostCodeValueSpecified: boolean;
    divPostCode: number | null;
    divRateValue: number;
    divRateValueSpecified: boolean;
    divRate: number | null;
    divTypeValue: number;
    divTypeValueSpecified: boolean;
    divType: number | null;
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
    dividendRatePeriodDateValue: string;
    dividendRatePeriodDateValueSpecified: boolean;
    dividendRatePeriodDate: string | null;
    dividendRatePeriodFreqValue: number;
    dividendRatePeriodFreqValueSpecified: boolean;
    dividendRatePeriodFreq: number | null;
    extAchXfrDailyLimitInValue: number;
    extAchXfrDailyLimitInValueSpecified: boolean;
    extAchXfrDailyLimitIn: number | null;
    extAchXfrDailyLimitOutValue: number;
    extAchXfrDailyLimitOutValueSpecified: boolean;
    extAchXfrDailyLimitOut: number | null;
    insuranceMaximumValue: number;
    insuranceMaximumValueSpecified: boolean;
    insuranceMaximum: number | null;
    insuranceTypeValue: number;
    insuranceTypeValueSpecified: boolean;
    insuranceType: number | null;
    irsCodeValue: number;
    irsCodeValueSpecified: boolean;
    irsCode: number | null;
    irsPlanValue: number;
    irsPlanValueSpecified: boolean;
    irsPlan: number | null;
    maturityDateValue: string;
    maturityDateValueSpecified: boolean;
    maturityDate: string | null;
    maturityPostCodeValue: number;
    maturityPostCodeValueSpecified: boolean;
    maturityPostCode: number | null;
    memberBranchSupportValue: number;
    memberBranchSupportValueSpecified: boolean;
    memberBranchSupport: number | null;
    memberUserTransferCodeValue: number;
    memberUserTransferCodeValueSpecified: boolean;
    memberUserTransferCode: number | null;
    minimumBalanceValue: number;
    minimumBalanceValueSpecified: boolean;
    minimumBalance: number | null;
    minimumDepositValue: number;
    minimumDepositValueSpecified: boolean;
    minimumDeposit: number | null;
    minimumWithdrawalValue: number;
    minimumWithdrawalValueSpecified: boolean;
    minimumWithdrawal: number | null;
    negativeBalanceNoticeNumberValue: number;
    negativeBalanceNoticeNumberValueSpecified: boolean;
    negativeBalanceNoticeNumber: number | null;
    negativeBalanceNoticeTypeValue: number;
    negativeBalanceNoticeTypeValueSpecified: boolean;
    negativeBalanceNoticeType: number | null;
    nickname: string;
    odtAuthFeeSrcCodeList: ShareDefaultOdtAuthFeeSrcCodeList[];
    odtAuthFeeSrcCodeListSpecified: boolean;
    overdraftToleranceValue: number;
    overdraftToleranceValueSpecified: boolean;
    overdraftTolerance: number | null;
    penaltyTypeValue: number;
    penaltyTypeValueSpecified: boolean;
    penaltyType: number | null;
    periodicCapValue: number;
    periodicCapValueSpecified: boolean;
    periodicCap: number | null;
    periodicStartRateValue: number;
    periodicStartRateValueSpecified: boolean;
    periodicStartRate: number | null;
    putItemSchdValue: number;
    putItemSchdValueSpecified: boolean;
    putItemSchd: number | null;
    putItemSchdTypeValue: number;
    putItemSchdTypeValueSpecified: boolean;
    putItemSchdType: number | null;
    reference: string;
    regDCtrStartDayValue: number;
    regDCtrStartDayValueSpecified: boolean;
    regDCtrStartDay: number | null;
    renewShareTypeValue: number;
    renewShareTypeValueSpecified: boolean;
    renewShareType: number | null;
    renewTermFreqValue: number;
    renewTermFreqValueSpecified: boolean;
    renewTermFreq: number | null;
    renewTermPeriodValue: number;
    renewTermPeriodValueSpecified: boolean;
    renewTermPeriod: number | null;
    service: ShareDefaultService[];
    serviceSpecified: boolean;
    shareCodeValue: number;
    shareCodeValueSpecified: boolean;
    shareCode: number | null;
    shareTypeValue: number;
    shareTypeValueSpecified: boolean;
    shareType: number | null;
    stateWithholdingCodeValue: number;
    stateWithholdingCodeValueSpecified: boolean;
    stateWithholdingCode: number | null;
    statementGroupValue: number;
    statementGroupValueSpecified: boolean;
    statementGroup: number | null;
    statementMailCodeValue: number;
    statementMailCodeValueSpecified: boolean;
    statementMailCode: number | null;
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
    userDate1Value: string;
    userDate1ValueSpecified: boolean;
    userDate1: string | null;
    userDate2Value: string;
    userDate2ValueSpecified: boolean;
    userDate2: string | null;
    warningCode: ShareDefaultWarningCode[];
    warningCodeSpecified: boolean;
    withdrawalFeeTypeValue: number;
    withdrawalFeeTypeValueSpecified: boolean;
    withdrawalFeeType: number | null;
    withdrawalLimitValue: number;
    withdrawalLimitValueSpecified: boolean;
    withdrawalLimit: number | null;
    withholdingCodeValue: number;
    withholdingCodeValueSpecified: boolean;
    withholdingCode: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}