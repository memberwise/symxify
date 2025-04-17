import { DepositReportType } from "./depositReportType";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
import { BaseResponse } from "./baseResponse";
export interface ResetDepositBalancesResponse extends BaseResponse {
    depositReport: DepositReportType;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
