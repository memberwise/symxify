import { IrsName } from "./irsName";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface IrsNameSearchPagedSelectFieldsResponse {
    irsName: IrsName[];
    irsNameSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}