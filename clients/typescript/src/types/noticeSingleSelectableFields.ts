import { NoticeFields } from "./noticeFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface NoticeSingleSelectableFields {
    includeAllNoticeFieldsValue: boolean;
    includeAllNoticeFieldsValueSpecified: boolean;
    includeAllNoticeFields: boolean | null;
    noticeFields: NoticeFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}