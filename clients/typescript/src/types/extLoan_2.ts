import { BitMap } from "./bitMap";
import { ExtLoanTranCodeAdvDesc_2 } from "./extLoanTranCodeAdvDesc_2";
import { ExtLoanTranCodeAdvance_2 } from "./extLoanTranCodeAdvance_2";
import { ExtLoanTranCodePayment_2 } from "./extLoanTranCodePayment_2";
import { ExtLoanTranCodePmtDesc_2 } from "./extLoanTranCodePmtDesc_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface ExtLoan_2 {
    accountMask: string;
    activityDateUpdateValue: boolean;
    activityDateUpdateValueSpecified: boolean;
    activityDateUpdate: boolean | null;
    advanceTransactionGlCodeValue: number;
    advanceTransactionGlCodeValueSpecified: boolean;
    advanceTransactionGlCode: number | null;
    allowAdvancesValue: boolean;
    allowAdvancesValueSpecified: boolean;
    allowAdvances: boolean | null;
    allowFreezeUnfreezeofCardValue: boolean;
    allowFreezeUnfreezeofCardValueSpecified: boolean;
    allowFreezeUnfreezeofCard: boolean | null;
    allowPartialPaymentsValue: boolean;
    allowPartialPaymentsValueSpecified: boolean;
    allowPartialPayments: boolean | null;
    externalDataSourceName: string;
    externalLoanTrackingType: BitMap;
    nearRealTimeRecordUpdateValue: boolean;
    nearRealTimeRecordUpdateValueSpecified: boolean;
    nearRealTimeRecordUpdate: boolean | null;
    onlineDbPassword: string;
    onlineDbUserId: string;
    onlineGlobalAppPasswd: string;
    onlineGlobalAppUserId: string;
    partialPaymentTranCode: string;
    paymentTransactionGlCodeValue: number;
    paymentTransactionGlCodeValueSpecified: boolean;
    paymentTransactionGlCode: number | null;
    processorValue: number;
    processorValueSpecified: boolean;
    processor: number | null;
    processorAbbreviation: string;
    processorAcctVerCodeValue: number;
    processorAcctVerCodeValueSpecified: boolean;
    processorAcctVerCode: number | null;
    processorCodeValue: number;
    processorCodeValueSpecified: boolean;
    processorCode: number | null;
    processorName: string;
    reportLostorStolenCardsValue: boolean;
    reportLostorStolenCardsValueSpecified: boolean;
    reportLostorStolenCards: boolean | null;
    tranCodeAdvDesc: ExtLoanTranCodeAdvDesc_2[];
    tranCodeAdvDescSpecified: boolean;
    tranCodeAdvance: ExtLoanTranCodeAdvance_2[];
    tranCodeAdvanceSpecified: boolean;
    tranCodePayment: ExtLoanTranCodePayment_2[];
    tranCodePaymentSpecified: boolean;
    tranCodePmtDesc: ExtLoanTranCodePmtDesc_2[];
    tranCodePmtDescSpecified: boolean;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}