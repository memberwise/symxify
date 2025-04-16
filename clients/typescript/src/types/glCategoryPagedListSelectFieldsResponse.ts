import { GlCategory } from "./glCategory";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface GlCategoryPagedListSelectFieldsResponse {
    glCategory: GlCategory[];
    glCategorySpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}