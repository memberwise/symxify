import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface DisclosureFields {
    closedEndDisclosureFormatValue: boolean;
    closedEndDisclosureFormatValueSpecified: boolean;
    closedEndDisclosureFormat: boolean | null;
    disabilityDescriptionValue: boolean;
    disabilityDescriptionValueSpecified: boolean;
    disabilityDescription: boolean | null;
    fedLine1: number[];
    fedLine1Specified: boolean;
    fedLine2: number[];
    fedLine2Specified: boolean;
    jointDisabilityDescriptionValue: boolean;
    jointDisabilityDescriptionValueSpecified: boolean;
    jointDisabilityDescription: boolean | null;
    jointLifeDescriptionValue: boolean;
    jointLifeDescriptionValueSpecified: boolean;
    jointLifeDescription: boolean | null;
    secLine1: number[];
    secLine1Specified: boolean;
    secLine2: number[];
    secLine2Specified: boolean;
    singleLifeDescriptionValue: boolean;
    singleLifeDescriptionValueSpecified: boolean;
    singleLifeDescription: boolean | null;
    useExtraAddressValue: boolean;
    useExtraAddressValueSpecified: boolean;
    useExtraAddress: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}