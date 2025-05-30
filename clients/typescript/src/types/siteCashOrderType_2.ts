import { SiteCashOrderTypeCashOrderTypeCoinBag_2 } from "./siteCashOrderTypeCashOrderTypeCoinBag_2";
import { SiteCashOrderTypeCashOrderTypeCoinRoll_2 } from "./siteCashOrderTypeCashOrderTypeCoinRoll_2";
import { SiteCashOrderTypeCashOrderTypeComment_2 } from "./siteCashOrderTypeCashOrderTypeComment_2";
import { SiteCashOrderTypeCashOrderTypeCurrFit_2 } from "./siteCashOrderTypeCashOrderTypeCurrFit_2";
import { SiteCashOrderTypeCashOrderTypeCurrNew_2 } from "./siteCashOrderTypeCashOrderTypeCurrNew_2";
import { SiteCashOrderTypeDeliveryDays_2 } from "./siteCashOrderTypeDeliveryDays_2";
import { VersionType } from "./versionType";

export interface SiteCashOrderType_2 {
    activeFlag: number | null;
    applyHandlingFee: number | null;
    cashOrderTypeCoinBag: SiteCashOrderTypeCashOrderTypeCoinBag_2[];
    cashOrderTypeCoinRoll: SiteCashOrderTypeCashOrderTypeCoinRoll_2[];
    cashOrderTypeComment: SiteCashOrderTypeCashOrderTypeComment_2[];
    cashOrderTypeCurrFit: SiteCashOrderTypeCashOrderTypeCurrFit_2[];
    cashOrderTypeCurrNew: SiteCashOrderTypeCashOrderTypeCurrNew_2[];
    cashOrderTypeDelCharge: number | null;
    cashOrderTypeMaxOrder: number | null;
    cashOrderTypeMinOrder: number | null;
    cashOrderTypeName: string;
    cashOrderTypeSpecDelCharge: number | null;
    closeDate: string | null;
    delFrequency: number | null;
    deliveryDays: SiteCashOrderTypeDeliveryDays_2[];
    locationCode: string;
    locator: number | null;
    orderLimiting: number | null;
    recordChangeDate: string | null;
    specHandlingFee: number | null;
    vendorNumber: number | null;
    version1: VersionType;
}