import { CtrAccountList } from "./ctrAccountList";
import { CtrBranchList } from "./ctrBranchList";
import { CtrFmHistoryList } from "./ctrFmHistoryList";
import { CtrForeignList } from "./ctrForeignList";
import { CtrNoteList } from "./ctrNoteList";
import { CtrPersonList } from "./ctrPersonList";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface Ctr {
    ackByUser: string;
    ackDateValue: string;
    ackDateValueSpecified: boolean;
    ackDate: string | null;
    ackErrorByUser: string;
    ackErrorDateValue: string;
    ackErrorDateValueSpecified: boolean;
    ackErrorDate: string | null;
    approveAmendByUser: string;
    approveAmendDateValue: string;
    approveAmendDateValueSpecified: boolean;
    approveAmendDate: string | null;
    approveByUser: string;
    approveDateValue: string;
    approveDateValueSpecified: boolean;
    approveDate: string | null;
    approver: string;
    approverTitle: string;
    backFileFlagValue: number;
    backFileFlagValueSpecified: boolean;
    backFileFlag: number | null;
    batchSequenceValue: number;
    batchSequenceValueSpecified: boolean;
    batchSequence: number | null;
    branchRouting: string;
    cashinBillsInsertValue: number;
    cashinBillsInsertValueSpecified: boolean;
    cashinBillsInsert: number | null;
    cashinCurrWagerValue: number;
    cashinCurrWagerValueSpecified: boolean;
    cashinCurrWager: number | null;
    cashinCurrXchngValue: number;
    cashinCurrXchngValueSpecified: boolean;
    cashinCurrXchng: number | null;
    cashinDepositValue: number;
    cashinDepositValueSpecified: boolean;
    cashinDeposit: number | null;
    cashinFundsXferValue: number;
    cashinFundsXferValueSpecified: boolean;
    cashinFundsXfer: number | null;
    cashinGamingInsValue: number;
    cashinGamingInsValueSpecified: boolean;
    cashinGamingIns: number | null;
    cashinNegInsValue: number;
    cashinNegInsValueSpecified: boolean;
    cashinNegIns: number | null;
    cashinOtherValue: number;
    cashinOtherValueSpecified: boolean;
    cashinOther: number | null;
    cashinOtherDesc: string;
    cashinPaymentValue: number;
    cashinPaymentValueSpecified: boolean;
    cashinPayment: number | null;
    cashinPrepaidValue: number;
    cashinPrepaidValueSpecified: boolean;
    cashinPrepaid: number | null;
    cashinTotalValue: number;
    cashinTotalValueSpecified: boolean;
    cashinTotal: number | null;
    cashoutAdvOnCredValue: number;
    cashoutAdvOnCredValueSpecified: boolean;
    cashoutAdvOnCred: number | null;
    cashoutCurrXchngValue: number;
    cashoutCurrXchngValueSpecified: boolean;
    cashoutCurrXchng: number | null;
    cashoutFundsXferValue: number;
    cashoutFundsXferValueSpecified: boolean;
    cashoutFundsXfer: number | null;
    cashoutGamingInsValue: number;
    cashoutGamingInsValueSpecified: boolean;
    cashoutGamingIns: number | null;
    cashoutNegInsValue: number;
    cashoutNegInsValueSpecified: boolean;
    cashoutNegIns: number | null;
    cashoutOtherValue: number;
    cashoutOtherValueSpecified: boolean;
    cashoutOther: number | null;
    cashoutOtherDesc: string;
    cashoutPayOnWagersValue: number;
    cashoutPayOnWagersValueSpecified: boolean;
    cashoutPayOnWagers: number | null;
    cashoutPrepaidValue: number;
    cashoutPrepaidValueSpecified: boolean;
    cashoutPrepaid: number | null;
    cashoutPromoValue: number;
    cashoutPromoValueSpecified: boolean;
    cashoutPromo: number | null;
    cashoutTotalValue: number;
    cashoutTotalValueSpecified: boolean;
    cashoutTotal: number | null;
    cashoutTravelValue: number;
    cashoutTravelValueSpecified: boolean;
    cashoutTravel: number | null;
    cashoutWithdrawValue: number;
    cashoutWithdrawValueSpecified: boolean;
    cashoutWithdraw: number | null;
    contactOffice: string;
    contactPhone: string;
    contactPhoneExt: string;
    createByUser: string;
    createDateValue: string;
    createDateValueSpecified: boolean;
    createDate: string | null;
    ctrAccountList: CtrAccountList;
    ctrBranchList: CtrBranchList;
    ctrFmHistoryList: CtrFmHistoryList;
    ctrForeignList: CtrForeignList;
    ctrNoteList: CtrNoteList;
    ctrPersonList: CtrPersonList;
    dcNumber: string;
    exemptByUser: string;
    exemptDateValue: string;
    exemptDateValueSpecified: boolean;
    exemptDate: string | null;
    federalRegulatorValue: number;
    federalRegulatorValueSpecified: boolean;
    federalRegulator: number | null;
    fiIdNumber: string;
    fiIdNumberType: string;
    fiOtherType: string;
    fiType: string;
    filingDateValue: string;
    filingDateValueSpecified: boolean;
    filingDate: string | null;
    filingType: string;
    fmPurgeDateValue: string;
    fmPurgeDateValueSpecified: boolean;
    fmPurgeDate: string | null;
    incompleteByUser: string;
    incompleteDateValue: string;
    incompleteDateValueSpecified: boolean;
    incompleteDate: string | null;
    lastFmDateValue: string;
    lastFmDateValueSpecified: boolean;
    lastFmDate: string | null;
    lastSubmitDateValue: string;
    lastSubmitDateValueSpecified: boolean;
    lastSubmitDate: string | null;
    nonReportByUser: string;
    nonReportDateValue: string;
    nonReportDateValueSpecified: boolean;
    nonReportDate: string | null;
    number: string;
    preparer: string;
    reSubAmendByUser: string;
    reSubAmendDateValue: string;
    reSubAmendDateValueSpecified: boolean;
    reSubAmendDate: string | null;
    recordChangeDateValue: string;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    rsnAggregateFlagValue: number;
    rsnAggregateFlagValueSpecified: boolean;
    rsnAggregateFlag: number | null;
    rsnArmCarFlagValue: number;
    rsnArmCarFlagValueSpecified: boolean;
    rsnArmCarFlag: number | null;
    rsnAtmFlagValue: number;
    rsnAtmFlagValueSpecified: boolean;
    rsnAtmFlag: number | null;
    rsnMailShipFlagValue: number;
    rsnMailShipFlagValueSpecified: boolean;
    rsnMailShipFlag: number | null;
    rsnNgtDepFlagValue: number;
    rsnNgtDepFlagValueSpecified: boolean;
    rsnNgtDepFlag: number | null;
    rsnShBrFlagValue: number;
    rsnShBrFlagValueSpecified: boolean;
    rsnShBrFlag: number | null;
    statusValue: number;
    statusValueSpecified: boolean;
    status: number | null;
    statusDateValue: string;
    statusDateValueSpecified: boolean;
    statusDate: string | null;
    submitByUser: string;
    submitDateValue: string;
    submitDateValueSpecified: boolean;
    submitDate: string | null;
    tcc: string;
    tranDateValue: string;
    tranDateValueSpecified: boolean;
    tranDate: string | null;
    tranSeq: string;
    verifyAmendByUser: string;
    verifyAmendDateValue: string;
    verifyAmendDateValueSpecified: boolean;
    verifyAmendDate: string | null;
    verifyByUser: string;
    verifyDateValue: string;
    verifyDateValueSpecified: boolean;
    verifyDate: string | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
