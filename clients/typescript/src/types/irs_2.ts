import { IrsContrLastYear_2 } from "./irsContrLastYear_2";
import { IrsContrThisYear_2 } from "./irsContrThisYear_2";
import { IrsDistrLastYear_2 } from "./irsDistrLastYear_2";
import { IrsDistrThisYear_2 } from "./irsDistrThisYear_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface Irs_2 {
    actualMaxContributionValue: number;
    actualMaxContributionValueSpecified: boolean;
    actualMaxContribution: number | null;
    contrLastYear: IrsContrLastYear_2[];
    contrLastYearSpecified: boolean;
    contrThisYear: IrsContrThisYear_2[];
    contrThisYearSpecified: boolean;
    contributionYearValue: number;
    contributionYearValueSpecified: boolean;
    contributionYear: number | null;
    distrLastYear: IrsDistrLastYear_2[];
    distrLastYearSpecified: boolean;
    distrThisYear: IrsDistrThisYear_2[];
    distrThisYearSpecified: boolean;
    fairMarketValueDeathValue: number;
    fairMarketValueDeathValueSpecified: boolean;
    fairMarketValueDeath: number | null;
    fairMarketValueLastYearValue: number;
    fairMarketValueLastYearValueSpecified: boolean;
    fairMarketValueLastYear: number | null;
    iraRmdValue: number;
    iraRmdValueSpecified: boolean;
    iraRmd: number | null;
    irsCodeValue: number;
    irsCodeValueSpecified: boolean;
    irsCode: number | null;
    irsHolderBirthDateValue: string | null;
    irsHolderBirthDateValueSpecified: boolean;
    irsHolderBirthDate: string | null;
    irsHolderSpouseBirthDateValue: string | null;
    irsHolderSpouseBirthDateValueSpecified: boolean;
    irsHolderSpouseBirthDate: string | null;
    irsPlanValue: number;
    irsPlanValueSpecified: boolean;
    irsPlan: number | null;
    lastDistribTypeValue: number;
    lastDistribTypeValueSpecified: boolean;
    lastDistribType: number | null;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    maxContributionValue: number;
    maxContributionValueSpecified: boolean;
    maxContribution: number | null;
    msaHolderCodeValue: number;
    msaHolderCodeValueSpecified: boolean;
    msaHolderCode: number | null;
    openDateValue: string | null;
    openDateValueSpecified: boolean;
    openDate: string | null;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    rmdTableOptionValue: number;
    rmdTableOptionValueSpecified: boolean;
    rmdTableOption: number | null;
    ssn: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}