import { ExecutionHeader } from "./executionHeader";
import { ExecutionResponseBody } from "./executionResponseBody";
import { VersionType } from "./versionType";

export interface PowerOnExecutionResponse {
    header: ExecutionHeader;
    body: ExecutionResponseBody;
    version1: VersionType;
}