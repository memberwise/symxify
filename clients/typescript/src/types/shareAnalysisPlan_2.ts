import { ShareAnalysisPlanCharge_2 } from "./shareAnalysisPlanCharge_2";
import { ShareAnalysisPlanChargeType_2 } from "./shareAnalysisPlanChargeType_2";
import { ShareAnalysisPlanFree_2 } from "./shareAnalysisPlanFree_2";
import { VersionType } from "./versionType";

export interface ShareAnalysisPlan_2 {
    cashAmountFree: number | null;
    cashAtmTotals: number | null;
    cashRate: number | null;
    charge: ShareAnalysisPlanCharge_2[];
    chargeType: ShareAnalysisPlanChargeType_2[];
    definedCode: number | null;
    description: string;
    earnRateMethod: number | null;
    effectiveDate: string | null;
    expirationDate: string | null;
    free: ShareAnalysisPlanFree_2[];
    locator: number | null;
    maintenanceCharge: number | null;
    maximumCharge: number | null;
    minimumCharge: number | null;
    plan: number | null;
    recordChangeDate: string | null;
    tier1Balance: number | null;
    tier1EarnRate: number | null;
    tier2Balance: number | null;
    tier2EarnRate: number | null;
    tier3Balance: number | null;
    tier3EarnRate: number | null;
    tier4Balance: number | null;
    tier4EarnRate: number | null;
    version1: VersionType;
}