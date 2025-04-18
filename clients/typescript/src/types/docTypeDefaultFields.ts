import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface DocTypeDefaultFields {
    descriptionValue: boolean;
    descriptionValueSpecified: boolean;
    description: boolean | null;
    documentTypeValue: boolean;
    documentTypeValueSpecified: boolean;
    documentType: boolean | null;
    excpNoticeCountCpWorkValue: boolean;
    excpNoticeCountCpWorkValueSpecified: boolean;
    excpNoticeCountCpWork: boolean | null;
    excpNoticeOptionValue: boolean;
    excpNoticeOptionValueSpecified: boolean;
    excpNoticeOption: boolean | null;
    expireDateValue: boolean;
    expireDateValueSpecified: boolean;
    expireDate: boolean | null;
    typeValue: boolean;
    typeValueSpecified: boolean;
    type: boolean | null;
    userChar1Value: boolean;
    userChar1ValueSpecified: boolean;
    userChar1: boolean | null;
    userChar2Value: boolean;
    userChar2ValueSpecified: boolean;
    userChar2: boolean | null;
    userChar3Value: boolean;
    userChar3ValueSpecified: boolean;
    userChar3: boolean | null;
    userChar4Value: boolean;
    userChar4ValueSpecified: boolean;
    userChar4: boolean | null;
    userChar5Value: boolean;
    userChar5ValueSpecified: boolean;
    userChar5: boolean | null;
    userChar6Value: boolean;
    userChar6ValueSpecified: boolean;
    userChar6: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}