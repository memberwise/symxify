import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface CurrencyCtrlFields {
    buyRateValue: boolean;
    buyRateValueSpecified: boolean;
    buyRate: boolean | null;
    buyRateDescriptionValue: boolean;
    buyRateDescriptionValueSpecified: boolean;
    buyRateDescription: boolean | null;
    currencyDecimalPlacesValue: boolean;
    currencyDecimalPlacesValueSpecified: boolean;
    currencyDecimalPlaces: boolean | null;
    currencyMinimumUnitsValue: boolean;
    currencyMinimumUnitsValueSpecified: boolean;
    currencyMinimumUnits: boolean | null;
    currencyNameValue: boolean;
    currencyNameValueSpecified: boolean;
    currencyName: boolean | null;
    currencyShortNameValue: boolean;
    currencyShortNameValueSpecified: boolean;
    currencyShortName: boolean | null;
    fipsCountryCodeValue: boolean;
    fipsCountryCodeValueSpecified: boolean;
    fipsCountryCode: boolean | null;
    primeRateValue: boolean;
    primeRateValueSpecified: boolean;
    primeRate: boolean | null;
    primeRateDescriptionValue: boolean;
    primeRateDescriptionValueSpecified: boolean;
    primeRateDescription: boolean | null;
    sellRateValue: boolean;
    sellRateValueSpecified: boolean;
    sellRate: boolean | null;
    sellRateDescriptionValue: boolean;
    sellRateDescriptionValueSpecified: boolean;
    sellRateDescription: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}