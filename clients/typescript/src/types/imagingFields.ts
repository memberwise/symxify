import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface ImagingFields {
    tellerTransactionsMemberId: number[];
    tellerTransactionsMemberIdSpecified: boolean;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}