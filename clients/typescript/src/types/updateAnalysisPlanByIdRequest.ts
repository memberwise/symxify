import { AdminCredentialsChoice } from "./adminCredentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { AnalysisPlanFields_2 } from "./analysisPlanFields_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface UpdateAnalysisPlanByIdRequest {
    analysisPlanIndexAnalysisPlanValue: number;
    analysisPlanIndexAnalysisPlanValueSpecified: boolean;
    analysisPlanIndexAnalysisPlan: number | null;
    credentials: AdminCredentialsChoice;
    deviceInformation: DeviceInformation;
    analysisPlanFields: AnalysisPlanFields_2;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
    branchIdValue: number;
    branchIdValueSpecified: boolean;
    branchId: number | null;
}