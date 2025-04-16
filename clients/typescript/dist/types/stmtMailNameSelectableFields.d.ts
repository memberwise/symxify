import { StmtMailNameFields } from "./stmtMailNameFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface StmtMailNameSelectableFields {
    includeAllStmtMailNameFieldsValue: boolean;
    includeAllStmtMailNameFieldsValueSpecified: boolean;
    includeAllStmtMailNameFields: boolean | null;
    stmtMailNameFields: StmtMailNameFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
