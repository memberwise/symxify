import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface ShareAnalysisPlanFields {
    cashAmountFreeValue: boolean;
    cashAmountFreeValueSpecified: boolean;
    cashAmountFree: boolean | null;
    cashAtmTotalsValue: boolean;
    cashAtmTotalsValueSpecified: boolean;
    cashAtmTotals: boolean | null;
    cashRateValue: boolean;
    cashRateValueSpecified: boolean;
    cashRate: boolean | null;
    charge: number[];
    chargeSpecified: boolean;
    chargeType: number[];
    chargeTypeSpecified: boolean;
    definedCodeValue: boolean;
    definedCodeValueSpecified: boolean;
    definedCode: boolean | null;
    descriptionValue: boolean;
    descriptionValueSpecified: boolean;
    description: boolean | null;
    earnRateMethodValue: boolean;
    earnRateMethodValueSpecified: boolean;
    earnRateMethod: boolean | null;
    effectiveDateValue: boolean;
    effectiveDateValueSpecified: boolean;
    effectiveDate: boolean | null;
    expirationDateValue: boolean;
    expirationDateValueSpecified: boolean;
    expirationDate: boolean | null;
    free: number[];
    freeSpecified: boolean;
    locatorValue: boolean;
    locatorValueSpecified: boolean;
    locator: boolean | null;
    maintenanceChargeValue: boolean;
    maintenanceChargeValueSpecified: boolean;
    maintenanceCharge: boolean | null;
    maximumChargeValue: boolean;
    maximumChargeValueSpecified: boolean;
    maximumCharge: boolean | null;
    minimumChargeValue: boolean;
    minimumChargeValueSpecified: boolean;
    minimumCharge: boolean | null;
    planValue: boolean;
    planValueSpecified: boolean;
    plan: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    tier1BalanceValue: boolean;
    tier1BalanceValueSpecified: boolean;
    tier1Balance: boolean | null;
    tier1EarnRateValue: boolean;
    tier1EarnRateValueSpecified: boolean;
    tier1EarnRate: boolean | null;
    tier2BalanceValue: boolean;
    tier2BalanceValueSpecified: boolean;
    tier2Balance: boolean | null;
    tier2EarnRateValue: boolean;
    tier2EarnRateValueSpecified: boolean;
    tier2EarnRate: boolean | null;
    tier3BalanceValue: boolean;
    tier3BalanceValueSpecified: boolean;
    tier3Balance: boolean | null;
    tier3EarnRateValue: boolean;
    tier3EarnRateValueSpecified: boolean;
    tier3EarnRate: boolean | null;
    tier4BalanceValue: boolean;
    tier4BalanceValueSpecified: boolean;
    tier4Balance: boolean | null;
    tier4EarnRateValue: boolean;
    tier4EarnRateValueSpecified: boolean;
    tier4EarnRate: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
