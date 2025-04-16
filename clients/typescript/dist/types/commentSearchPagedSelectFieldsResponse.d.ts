import { Comment } from "./comment";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface CommentSearchPagedSelectFieldsResponse {
    comment: Comment[];
    commentSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
