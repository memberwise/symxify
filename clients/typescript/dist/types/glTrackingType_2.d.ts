import { GlTrackingTypeUserRate20_2 } from "./glTrackingTypeUserRate20_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface GlTrackingType_2 {
    description: string;
    parentClosingOptionValue: boolean;
    parentClosingOptionValueSpecified: boolean;
    parentClosingOption: boolean | null;
    recordSelectionValue: number;
    recordSelectionValueSpecified: boolean;
    recordSelection: number | null;
    trackingTypeValue: number;
    trackingTypeValueSpecified: boolean;
    trackingType: number | null;
    userRate20: GlTrackingTypeUserRate20_2[];
    userRate20Specified: boolean;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
