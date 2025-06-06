import { LoanAppEscrowAnalysisNewEscrowPayment_2 } from "./loanAppEscrowAnalysisNewEscrowPayment_2";
import { LoanAppEscrowAnalysisNewPaymentDate_2 } from "./loanAppEscrowAnalysisNewPaymentDate_2";
import { LoanAppEscrowAnalysisPrevNewEscrowPmt_2 } from "./loanAppEscrowAnalysisPrevNewEscrowPmt_2";
import { LoanAppEscrowAnalysisPrevNewPmtDate_2 } from "./loanAppEscrowAnalysisPrevNewPmtDate_2";
import { VersionType } from "./versionType";

export interface LoanAppEscrowAnalysis_2 {
    actionDeficiency: number | null;
    actionShortage: number | null;
    actualInitialDiscl: string | null;
    amtAddedRounding: number | null;
    amtCoverDeficiency: number | null;
    amtCoverShortage: number | null;
    analysisGroup: number | null;
    analysisThruDate: string | null;
    changeEscrowPmt: number | null;
    closingRequest: number | null;
    currentBalance: number | null;
    currentDueDay1: number | null;
    currentDueDay2: number | null;
    currentPayment: number | null;
    currentPaymentFreq: number | null;
    cushion: number | null;
    dateAnalysisCalc: string | null;
    dateInitDisclNeed: string | null;
    deficiency: number | null;
    expectedBegStmtBal: number | null;
    finalAnalysisDate: string | null;
    forecastBegStmtBal: number | null;
    initialDisclThird: number | null;
    lastAnalysisProcessed: number | null;
    locator: number | null;
    newEscrowPayment: LoanAppEscrowAnalysisNewEscrowPayment_2[];
    newPaymentDate: LoanAppEscrowAnalysisNewPaymentDate_2[];
    nextAnalysisDate: string | null;
    nextPaymentDueDate: string | null;
    noticeClosingDate: string | null;
    noticeClosingFee: number | null;
    noticeDate: string | null;
    overage: number | null;
    overageRefunded: number | null;
    pmtReducedOverage: number | null;
    prevActionDefic: number | null;
    prevActionShortage: number | null;
    prevAmtAddedRound: number | null;
    prevAmtCoverDef: number | null;
    prevAmtCoverShort: number | null;
    prevAnalyThruDate: string | null;
    prevAnalysisDate: string | null;
    prevBalance: number | null;
    prevChgEscrowPmt: number | null;
    prevCushion: number | null;
    prevDateAnalyCalc: string | null;
    prevDeficiency: number | null;
    prevDueDay1: number | null;
    prevDueDay2: number | null;
    prevExpBegStmtBal: number | null;
    prevFcastBegStmtBl: number | null;
    prevNewEscrowPmt: LoanAppEscrowAnalysisPrevNewEscrowPmt_2[];
    prevNewPmtDate: LoanAppEscrowAnalysisPrevNewPmtDate_2[];
    prevOverRefunded: number | null;
    prevOverage: number | null;
    prevPayment: number | null;
    prevPaymentDueDate: string | null;
    prevPaymentFreq: number | null;
    prevPmtReducedOver: number | null;
    prevRequiredPmt: number | null;
    prevShortage: number | null;
    priorAnalysisSource: number | null;
    recordChangeDate: string | null;
    remainOpenOption: number | null;
    requiredNewPayment: number | null;
    shortage: number | null;
    version1: VersionType;
}