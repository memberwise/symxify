import { ItcInstallation } from "./itcInstallation";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface ItcInstallationSelectFieldsResponse {
    itcInstallation: ItcInstallation;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
