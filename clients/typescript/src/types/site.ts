import { SiteCashOrderTypeList } from "./siteCashOrderTypeList";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface Site {
    city: string;
    closeDateValue: string;
    closeDateValueSpecified: boolean;
    closeDate: string | null;
    contactPhone: string;
    extraAddress: string;
    faxPhone: string;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    recordChangeDateValue: string;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    siteCashOrderTypeList: SiteCashOrderTypeList;
    siteContactName: string;
    siteId: string;
    siteName: string;
    siteNumberValue: number;
    siteNumberValueSpecified: boolean;
    siteNumber: number | null;
    siteSettleShareId: string;
    state: string;
    street: string;
    zipCode: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}