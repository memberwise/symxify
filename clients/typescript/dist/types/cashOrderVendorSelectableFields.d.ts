import { CashOrderVendorFields } from "./cashOrderVendorFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface CashOrderVendorSelectableFields {
    includeAllCashOrderVendorFieldsValue: boolean;
    includeAllCashOrderVendorFieldsValueSpecified: boolean;
    includeAllCashOrderVendorFields: boolean | null;
    cashOrderVendorFields: CashOrderVendorFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
