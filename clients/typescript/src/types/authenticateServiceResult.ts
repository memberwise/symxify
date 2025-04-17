import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
import { CommonResult } from "./commonResult";

export interface AuthenticateServiceResult extends CommonResult {
    samlAssertion: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}