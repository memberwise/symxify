import { Preference } from "./preference";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface PreferenceSearchPagedSelectFieldsResponse {
    preference: Preference[];
    preferenceSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
