import { ShareAnalysisPlanCharge_2 } from "./shareAnalysisPlanCharge_2";
import { ShareAnalysisPlanChargeType_2 } from "./shareAnalysisPlanChargeType_2";
import { ShareAnalysisPlanFree_2 } from "./shareAnalysisPlanFree_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface ShareAnalysisPlan_2 {
    cashAmountFreeValue: number;
    cashAmountFreeValueSpecified: boolean;
    cashAmountFree: number | null;
    cashAtmTotalsValue: number;
    cashAtmTotalsValueSpecified: boolean;
    cashAtmTotals: number | null;
    cashRateValue: number;
    cashRateValueSpecified: boolean;
    cashRate: number | null;
    charge: ShareAnalysisPlanCharge_2[];
    chargeSpecified: boolean;
    chargeType: ShareAnalysisPlanChargeType_2[];
    chargeTypeSpecified: boolean;
    definedCodeValue: number;
    definedCodeValueSpecified: boolean;
    definedCode: number | null;
    description: string;
    earnRateMethodValue: number;
    earnRateMethodValueSpecified: boolean;
    earnRateMethod: number | null;
    effectiveDateValue: string | null;
    effectiveDateValueSpecified: boolean;
    effectiveDate: string | null;
    expirationDateValue: string | null;
    expirationDateValueSpecified: boolean;
    expirationDate: string | null;
    free: ShareAnalysisPlanFree_2[];
    freeSpecified: boolean;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    maintenanceChargeValue: number;
    maintenanceChargeValueSpecified: boolean;
    maintenanceCharge: number | null;
    maximumChargeValue: number;
    maximumChargeValueSpecified: boolean;
    maximumCharge: number | null;
    minimumChargeValue: number;
    minimumChargeValueSpecified: boolean;
    minimumCharge: number | null;
    planValue: number;
    planValueSpecified: boolean;
    plan: number | null;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    tier1BalanceValue: number;
    tier1BalanceValueSpecified: boolean;
    tier1Balance: number | null;
    tier1EarnRateValue: number;
    tier1EarnRateValueSpecified: boolean;
    tier1EarnRate: number | null;
    tier2BalanceValue: number;
    tier2BalanceValueSpecified: boolean;
    tier2Balance: number | null;
    tier2EarnRateValue: number;
    tier2EarnRateValueSpecified: boolean;
    tier2EarnRate: number | null;
    tier3BalanceValue: number;
    tier3BalanceValueSpecified: boolean;
    tier3Balance: number | null;
    tier3EarnRateValue: number;
    tier3EarnRateValueSpecified: boolean;
    tier3EarnRate: number | null;
    tier4BalanceValue: number;
    tier4BalanceValueSpecified: boolean;
    tier4Balance: number | null;
    tier4EarnRateValue: number;
    tier4EarnRateValueSpecified: boolean;
    tier4EarnRate: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
