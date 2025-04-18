import { NoticeDaysBetweenNotices } from "./noticeDaysBetweenNotices";
import { NoticeLine1 } from "./noticeLine1";
import { NoticeLine2 } from "./noticeLine2";
import { NoticeLine3 } from "./noticeLine3";
import { NoticeLine4 } from "./noticeLine4";
import { NoticeNegativeInfoMessage } from "./noticeNegativeInfoMessage";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface Notice {
    daysBetweenNotices: NoticeDaysBetweenNotices[];
    daysBetweenNoticesSpecified: boolean;
    description: string;
    line1: NoticeLine1[];
    line1Specified: boolean;
    line2: NoticeLine2[];
    line2Specified: boolean;
    line3: NoticeLine3[];
    line3Specified: boolean;
    line4: NoticeLine4[];
    line4Specified: boolean;
    negativeInfoMessage: NoticeNegativeInfoMessage[];
    negativeInfoMessageSpecified: boolean;
    negativeInfoPrintPositionValue: number;
    negativeInfoPrintPositionValueSpecified: boolean;
    negativeInfoPrintPosition: number | null;
    noticeDescrTypeValue: number;
    noticeDescrTypeValueSpecified: boolean;
    noticeDescrType: number | null;
    noticeTypeValue: number;
    noticeTypeValueSpecified: boolean;
    noticeType: number | null;
    useWarningGraceDaysValue: number;
    useWarningGraceDaysValueSpecified: boolean;
    useWarningGraceDays: number | null;
    warningGraceDaysValue: number;
    warningGraceDaysValueSpecified: boolean;
    warningGraceDays: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
