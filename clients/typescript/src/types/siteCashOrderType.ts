import { SiteCashOrderTypeCashOrderTypeCoinBag } from "./siteCashOrderTypeCashOrderTypeCoinBag";
import { SiteCashOrderTypeCashOrderTypeCoinRoll } from "./siteCashOrderTypeCashOrderTypeCoinRoll";
import { SiteCashOrderTypeCashOrderTypeComment } from "./siteCashOrderTypeCashOrderTypeComment";
import { SiteCashOrderTypeCashOrderTypeCurrFit } from "./siteCashOrderTypeCashOrderTypeCurrFit";
import { SiteCashOrderTypeCashOrderTypeCurrNew } from "./siteCashOrderTypeCashOrderTypeCurrNew";
import { SiteCashOrderTypeDeliveryDays } from "./siteCashOrderTypeDeliveryDays";
import { VersionType } from "./versionType";

export interface SiteCashOrderType {
    activeFlag: number | null;
    applyHandlingFee: number | null;
    cashOrderTypeCoinBag: SiteCashOrderTypeCashOrderTypeCoinBag[];
    cashOrderTypeCoinRoll: SiteCashOrderTypeCashOrderTypeCoinRoll[];
    cashOrderTypeComment: SiteCashOrderTypeCashOrderTypeComment[];
    cashOrderTypeCurrFit: SiteCashOrderTypeCashOrderTypeCurrFit[];
    cashOrderTypeCurrNew: SiteCashOrderTypeCashOrderTypeCurrNew[];
    cashOrderTypeDelCharge: number | null;
    cashOrderTypeMaxOrder: number | null;
    cashOrderTypeMinOrder: number | null;
    cashOrderTypeName: string;
    cashOrderTypeSpecDelCharge: number | null;
    closeDate: string | null;
    delFrequency: number | null;
    deliveryDays: SiteCashOrderTypeDeliveryDays[];
    locationCode: string;
    locator: number | null;
    orderLimiting: number | null;
    recordChangeDate: string | null;
    specHandlingFee: number | null;
    vendorNumber: number | null;
    version1: VersionType;
}