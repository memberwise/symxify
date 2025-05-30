import { ShareAnalysisPlanCharge } from "./shareAnalysisPlanCharge";
import { ShareAnalysisPlanChargeType } from "./shareAnalysisPlanChargeType";
import { ShareAnalysisPlanFree } from "./shareAnalysisPlanFree";
import { VersionType } from "./versionType";

export interface ShareAnalysisPlan {
    cashAmountFree: number | null;
    cashAtmTotals: number | null;
    cashRate: number | null;
    charge: ShareAnalysisPlanCharge[];
    chargeType: ShareAnalysisPlanChargeType[];
    definedCode: number | null;
    description: string;
    earnRateMethod: number | null;
    effectiveDate: string | null;
    expirationDate: string | null;
    free: ShareAnalysisPlanFree[];
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