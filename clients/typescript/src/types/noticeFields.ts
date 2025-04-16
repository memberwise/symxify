import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface NoticeFields {
    daysBetweenNotices: number[];
    daysBetweenNoticesSpecified: boolean;
    descriptionValue: boolean;
    descriptionValueSpecified: boolean;
    description: boolean | null;
    line1: number[];
    line1Specified: boolean;
    line2: number[];
    line2Specified: boolean;
    line3: number[];
    line3Specified: boolean;
    line4: number[];
    line4Specified: boolean;
    negativeInfoMessage: number[];
    negativeInfoMessageSpecified: boolean;
    negativeInfoPrintPositionValue: boolean;
    negativeInfoPrintPositionValueSpecified: boolean;
    negativeInfoPrintPosition: boolean | null;
    noticeDescrTypeValue: boolean;
    noticeDescrTypeValueSpecified: boolean;
    noticeDescrType: boolean | null;
    noticeTypeValue: boolean;
    noticeTypeValueSpecified: boolean;
    noticeType: boolean | null;
    useWarningGraceDaysValue: boolean;
    useWarningGraceDaysValueSpecified: boolean;
    useWarningGraceDays: boolean | null;
    warningGraceDaysValue: boolean;
    warningGraceDaysValueSpecified: boolean;
    warningGraceDays: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}