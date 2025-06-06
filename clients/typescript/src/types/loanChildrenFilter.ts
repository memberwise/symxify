import { LoanBankruptcyFilter } from "./loanBankruptcyFilter";
import { LoanBillingFilter } from "./loanBillingFilter";
import { LoanCheckOrderFilter } from "./loanCheckOrderFilter";
import { LoanEscrowFilter } from "./loanEscrowFilter";
import { LoanEscrowAnalysisFilter } from "./loanEscrowAnalysisFilter";
import { LoanHoldFilter } from "./loanHoldFilter";
import { LoanLnSegmentFilter } from "./loanLnSegmentFilter";
import { LoanNameFilter } from "./loanNameFilter";
import { LoanNoteFilter } from "./loanNoteFilter";
import { LoanPledgeFilter } from "./loanPledgeFilter";
import { LoanRateChangeFilter } from "./loanRateChangeFilter";
import { LoanScheduleFilter } from "./loanScheduleFilter";
import { LoanTrackingFilter } from "./loanTrackingFilter";
import { LoanTransactionFilter } from "./loanTransactionFilter";
import { LoanTransferFilter } from "./loanTransferFilter";
import { VersionType } from "./versionType";

export interface LoanChildrenFilter {
    loanBankruptcyFilter: LoanBankruptcyFilter;
    loanBillingFilter: LoanBillingFilter;
    loanCheckOrderFilter: LoanCheckOrderFilter;
    loanEscrowFilter: LoanEscrowFilter;
    loanEscrowAnalysisFilter: LoanEscrowAnalysisFilter;
    loanHoldFilter: LoanHoldFilter;
    loanLnSegmentFilter: LoanLnSegmentFilter;
    loanNameFilter: LoanNameFilter;
    loanNoteFilter: LoanNoteFilter;
    loanPledgeFilter: LoanPledgeFilter;
    loanRateChangeFilter: LoanRateChangeFilter;
    loanScheduleFilter: LoanScheduleFilter;
    loanTrackingFilter: LoanTrackingFilter;
    loanTransactionFilter: LoanTransactionFilter;
    loanTransferFilter: LoanTransferFilter;
    version1: VersionType;
}