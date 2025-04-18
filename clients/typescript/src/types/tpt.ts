import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface Tpt {
    blankLinesValue: number;
    blankLinesValueSpecified: boolean;
    blankLines: number | null;
    checkDetailLinesValue: number;
    checkDetailLinesValueSpecified: boolean;
    checkDetailLines: number | null;
    compressionValue: number;
    compressionValueSpecified: boolean;
    compression: number | null;
    customFormatValue: boolean;
    customFormatValueSpecified: boolean;
    customFormat: boolean | null;
    documentAccountCodeValue: number;
    documentAccountCodeValueSpecified: boolean;
    documentAccountCode: number | null;
    documentNumberValue: number;
    documentNumberValueSpecified: boolean;
    documentNumber: number | null;
    forms: string;
    linesPerPageValue: number;
    linesPerPageValueSpecified: boolean;
    linesPerPage: number | null;
    printerValue: number;
    printerValueSpecified: boolean;
    printer: number | null;
    printerTypeValue: number;
    printerTypeValueSpecified: boolean;
    printerType: number | null;
    queueNumberValue: number;
    queueNumberValueSpecified: boolean;
    queueNumber: number | null;
    queueSubNumberValue: number;
    queueSubNumberValueSpecified: boolean;
    queueSubNumber: number | null;
    queueSubTypeValue: number;
    queueSubTypeValueSpecified: boolean;
    queueSubType: number | null;
    queueTypesValue: number;
    queueTypesValueSpecified: boolean;
    queueTypes: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}