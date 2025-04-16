import { LoanEscrowAnalysisNewEscrowPayment } from "./loanEscrowAnalysisNewEscrowPayment";
import { LoanEscrowAnalysisNewPaymentDate } from "./loanEscrowAnalysisNewPaymentDate";
import { LoanEscrowAnalysisPrevNewEscrowPmt } from "./loanEscrowAnalysisPrevNewEscrowPmt";
import { LoanEscrowAnalysisPrevNewPmtDate } from "./loanEscrowAnalysisPrevNewPmtDate";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface LoanEscrowAnalysis {
    actionDeficiencyValue: number;
    actionDeficiencyValueSpecified: boolean;
    actionDeficiency: number | null;
    actionShortageValue: number;
    actionShortageValueSpecified: boolean;
    actionShortage: number | null;
    actualInitialDisclValue: string;
    actualInitialDisclValueSpecified: boolean;
    actualInitialDiscl: string | null;
    amtAddedRoundingValue: number;
    amtAddedRoundingValueSpecified: boolean;
    amtAddedRounding: number | null;
    amtCoverDeficiencyValue: number;
    amtCoverDeficiencyValueSpecified: boolean;
    amtCoverDeficiency: number | null;
    amtCoverShortageValue: number;
    amtCoverShortageValueSpecified: boolean;
    amtCoverShortage: number | null;
    analysisGroupValue: number;
    analysisGroupValueSpecified: boolean;
    analysisGroup: number | null;
    analysisThruDateValue: string;
    analysisThruDateValueSpecified: boolean;
    analysisThruDate: string | null;
    changeEscrowPmtValue: number;
    changeEscrowPmtValueSpecified: boolean;
    changeEscrowPmt: number | null;
    closingRequestValue: number;
    closingRequestValueSpecified: boolean;
    closingRequest: number | null;
    currentBalanceValue: number;
    currentBalanceValueSpecified: boolean;
    currentBalance: number | null;
    currentDueDay1Value: number;
    currentDueDay1ValueSpecified: boolean;
    currentDueDay1: number | null;
    currentDueDay2Value: number;
    currentDueDay2ValueSpecified: boolean;
    currentDueDay2: number | null;
    currentPaymentValue: number;
    currentPaymentValueSpecified: boolean;
    currentPayment: number | null;
    currentPaymentFreqValue: number;
    currentPaymentFreqValueSpecified: boolean;
    currentPaymentFreq: number | null;
    cushionValue: number;
    cushionValueSpecified: boolean;
    cushion: number | null;
    dateAnalysisCalcValue: string;
    dateAnalysisCalcValueSpecified: boolean;
    dateAnalysisCalc: string | null;
    dateInitDisclNeedValue: string;
    dateInitDisclNeedValueSpecified: boolean;
    dateInitDisclNeed: string | null;
    deficiencyValue: number;
    deficiencyValueSpecified: boolean;
    deficiency: number | null;
    expectedBegStmtBalValue: number;
    expectedBegStmtBalValueSpecified: boolean;
    expectedBegStmtBal: number | null;
    finalAnalysisDateValue: string;
    finalAnalysisDateValueSpecified: boolean;
    finalAnalysisDate: string | null;
    forecastBegStmtBalValue: number;
    forecastBegStmtBalValueSpecified: boolean;
    forecastBegStmtBal: number | null;
    initialDisclThirdValue: number;
    initialDisclThirdValueSpecified: boolean;
    initialDisclThird: number | null;
    lastAnalysisProcessedValue: number;
    lastAnalysisProcessedValueSpecified: boolean;
    lastAnalysisProcessed: number | null;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    newEscrowPayment: LoanEscrowAnalysisNewEscrowPayment[];
    newEscrowPaymentSpecified: boolean;
    newPaymentDate: LoanEscrowAnalysisNewPaymentDate[];
    newPaymentDateSpecified: boolean;
    nextAnalysisDateValue: string;
    nextAnalysisDateValueSpecified: boolean;
    nextAnalysisDate: string | null;
    nextPaymentDueDateValue: string;
    nextPaymentDueDateValueSpecified: boolean;
    nextPaymentDueDate: string | null;
    noticeClosingDateValue: string;
    noticeClosingDateValueSpecified: boolean;
    noticeClosingDate: string | null;
    noticeClosingFeeValue: number;
    noticeClosingFeeValueSpecified: boolean;
    noticeClosingFee: number | null;
    noticeDateValue: string;
    noticeDateValueSpecified: boolean;
    noticeDate: string | null;
    overageValue: number;
    overageValueSpecified: boolean;
    overage: number | null;
    overageRefundedValue: number;
    overageRefundedValueSpecified: boolean;
    overageRefunded: number | null;
    pmtReducedOverageValue: number;
    pmtReducedOverageValueSpecified: boolean;
    pmtReducedOverage: number | null;
    prevActionDeficValue: number;
    prevActionDeficValueSpecified: boolean;
    prevActionDefic: number | null;
    prevActionShortageValue: number;
    prevActionShortageValueSpecified: boolean;
    prevActionShortage: number | null;
    prevAmtAddedRoundValue: number;
    prevAmtAddedRoundValueSpecified: boolean;
    prevAmtAddedRound: number | null;
    prevAmtCoverDefValue: number;
    prevAmtCoverDefValueSpecified: boolean;
    prevAmtCoverDef: number | null;
    prevAmtCoverShortValue: number;
    prevAmtCoverShortValueSpecified: boolean;
    prevAmtCoverShort: number | null;
    prevAnalyThruDateValue: string;
    prevAnalyThruDateValueSpecified: boolean;
    prevAnalyThruDate: string | null;
    prevAnalysisDateValue: string;
    prevAnalysisDateValueSpecified: boolean;
    prevAnalysisDate: string | null;
    prevBalanceValue: number;
    prevBalanceValueSpecified: boolean;
    prevBalance: number | null;
    prevChgEscrowPmtValue: number;
    prevChgEscrowPmtValueSpecified: boolean;
    prevChgEscrowPmt: number | null;
    prevCushionValue: number;
    prevCushionValueSpecified: boolean;
    prevCushion: number | null;
    prevDateAnalyCalcValue: string;
    prevDateAnalyCalcValueSpecified: boolean;
    prevDateAnalyCalc: string | null;
    prevDeficiencyValue: number;
    prevDeficiencyValueSpecified: boolean;
    prevDeficiency: number | null;
    prevDueDay1Value: number;
    prevDueDay1ValueSpecified: boolean;
    prevDueDay1: number | null;
    prevDueDay2Value: number;
    prevDueDay2ValueSpecified: boolean;
    prevDueDay2: number | null;
    prevExpBegStmtBalValue: number;
    prevExpBegStmtBalValueSpecified: boolean;
    prevExpBegStmtBal: number | null;
    prevFcastBegStmtBlValue: number;
    prevFcastBegStmtBlValueSpecified: boolean;
    prevFcastBegStmtBl: number | null;
    prevNewEscrowPmt: LoanEscrowAnalysisPrevNewEscrowPmt[];
    prevNewEscrowPmtSpecified: boolean;
    prevNewPmtDate: LoanEscrowAnalysisPrevNewPmtDate[];
    prevNewPmtDateSpecified: boolean;
    prevOverRefundedValue: number;
    prevOverRefundedValueSpecified: boolean;
    prevOverRefunded: number | null;
    prevOverageValue: number;
    prevOverageValueSpecified: boolean;
    prevOverage: number | null;
    prevPaymentValue: number;
    prevPaymentValueSpecified: boolean;
    prevPayment: number | null;
    prevPaymentDueDateValue: string;
    prevPaymentDueDateValueSpecified: boolean;
    prevPaymentDueDate: string | null;
    prevPaymentFreqValue: number;
    prevPaymentFreqValueSpecified: boolean;
    prevPaymentFreq: number | null;
    prevPmtReducedOverValue: number;
    prevPmtReducedOverValueSpecified: boolean;
    prevPmtReducedOver: number | null;
    prevRequiredPmtValue: number;
    prevRequiredPmtValueSpecified: boolean;
    prevRequiredPmt: number | null;
    prevShortageValue: number;
    prevShortageValueSpecified: boolean;
    prevShortage: number | null;
    priorAnalysisSourceValue: number;
    priorAnalysisSourceValueSpecified: boolean;
    priorAnalysisSource: number | null;
    recordChangeDateValue: string;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    remainOpenOptionValue: number;
    remainOpenOptionValueSpecified: boolean;
    remainOpenOption: number | null;
    requiredNewPaymentValue: number;
    requiredNewPaymentValueSpecified: boolean;
    requiredNewPayment: number | null;
    shortageValue: number;
    shortageValueSpecified: boolean;
    shortage: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}