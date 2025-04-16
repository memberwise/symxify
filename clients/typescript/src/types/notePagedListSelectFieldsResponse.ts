import { Note } from "./note";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface NotePagedListSelectFieldsResponse {
    note: Note[];
    noteSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}