import { AnalysisFloatRoutingNumberFloatDays } from "./analysisFloatRoutingNumberFloatDays";
import { AnalysisFloatRoutingNumberPrefix } from "./analysisFloatRoutingNumberPrefix";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface AnalysisFloat {
    branchValue: number;
    branchValueSpecified: boolean;
    branch: number | null;
    branchReferenceValue: number;
    branchReferenceValueSpecified: boolean;
    branchReference: number | null;
    branchValidCodeValue: number;
    branchValidCodeValueSpecified: boolean;
    branchValidCode: number | null;
    foreignItemFloatDaysValue: number;
    foreignItemFloatDaysValueSpecified: boolean;
    foreignItemFloatDays: number | null;
    localFloatDaysValue: number;
    localFloatDaysValueSpecified: boolean;
    localFloatDays: number | null;
    nonlocalFloatDaysValue: number;
    nonlocalFloatDaysValueSpecified: boolean;
    nonlocalFloatDays: number | null;
    routingNumberFloatDays: AnalysisFloatRoutingNumberFloatDays[];
    routingNumberFloatDaysSpecified: boolean;
    routingNumberPrefix: AnalysisFloatRoutingNumberPrefix[];
    routingNumberPrefixSpecified: boolean;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}