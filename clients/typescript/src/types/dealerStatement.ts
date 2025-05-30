import { DealerStatementClosedDealerMessage1 } from "./dealerStatementClosedDealerMessage1";
import { DealerStatementClosedDealerMessage2 } from "./dealerStatementClosedDealerMessage2";
import { DealerStatementInstitutionAddressLine } from "./dealerStatementInstitutionAddressLine";
import { DealerStatementMessageLine1 } from "./dealerStatementMessageLine1";
import { DealerStatementMessageLine2 } from "./dealerStatementMessageLine2";
import { VersionType } from "./versionType";

export interface DealerStatement {
    adjustments: string;
    chargebackAmount: string;
    closedDealerMessage1: DealerStatementClosedDealerMessage1[];
    closedDealerMessage2: DealerStatementClosedDealerMessage2[];
    dealerDormant: number | null;
    fees: string;
    format: number | null;
    holdbackAmount: string;
    inquiryLine: string;
    institutionAddressLine: DealerStatementInstitutionAddressLine[];
    messageLine1: DealerStatementMessageLine1[];
    messageLine2: DealerStatementMessageLine2[];
    negativeSignOption: number | null;
    numberoftimesGenerated: number | null;
    printDatesinHeader: boolean | null;
    printTransactionDates: boolean | null;
    printTransactionDetail: boolean | null;
    separateClosedDealer: boolean | null;
    statementCutoffDate: string | null;
    statementDates: string;
    statementGroupList: string;
    suppressDealerNumberZeros: boolean | null;
    totalDealerReserve: string;
    upfrontReserve: string;
    useCommas: boolean | null;
    useContactName: boolean | null;
    ytdTotalPrinting: boolean | null;
    version1: VersionType;
}