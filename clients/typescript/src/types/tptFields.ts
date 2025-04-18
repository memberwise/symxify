import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface TptFields {
    blankLinesValue: boolean;
    blankLinesValueSpecified: boolean;
    blankLines: boolean | null;
    checkDetailLinesValue: boolean;
    checkDetailLinesValueSpecified: boolean;
    checkDetailLines: boolean | null;
    compressionValue: boolean;
    compressionValueSpecified: boolean;
    compression: boolean | null;
    customFormatValue: boolean;
    customFormatValueSpecified: boolean;
    customFormat: boolean | null;
    documentAccountCodeValue: boolean;
    documentAccountCodeValueSpecified: boolean;
    documentAccountCode: boolean | null;
    documentNumberValue: boolean;
    documentNumberValueSpecified: boolean;
    documentNumber: boolean | null;
    formsValue: boolean;
    formsValueSpecified: boolean;
    forms: boolean | null;
    linesPerPageValue: boolean;
    linesPerPageValueSpecified: boolean;
    linesPerPage: boolean | null;
    printerValue: boolean;
    printerValueSpecified: boolean;
    printer: boolean | null;
    printerTypeValue: boolean;
    printerTypeValueSpecified: boolean;
    printerType: boolean | null;
    queueNumberValue: boolean;
    queueNumberValueSpecified: boolean;
    queueNumber: boolean | null;
    queueSubNumberValue: boolean;
    queueSubNumberValueSpecified: boolean;
    queueSubNumber: boolean | null;
    queueSubTypeValue: boolean;
    queueSubTypeValueSpecified: boolean;
    queueSubType: boolean | null;
    queueTypesValue: boolean;
    queueTypesValueSpecified: boolean;
    queueTypes: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}