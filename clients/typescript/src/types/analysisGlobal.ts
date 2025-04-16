import { AnalysisGlobalCounter } from "./analysisGlobalCounter";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface AnalysisGlobal {
    analyzedSharePromptSettingValue: number;
    analyzedSharePromptSettingValueSpecified: boolean;
    analyzedSharePromptSetting: number | null;
    counter: AnalysisGlobalCounter[];
    counterSpecified: boolean;
    investableBalanceCalcTypeValue: number;
    investableBalanceCalcTypeValueSpecified: boolean;
    investableBalanceCalcType: number | null;
    nonAnlyzdShrPromptSettingValue: number;
    nonAnlyzdShrPromptSettingValueSpecified: boolean;
    nonAnlyzdShrPromptSetting: number | null;
    onUsCountSettingValue: number;
    onUsCountSettingValueSpecified: boolean;
    onUsCountSetting: number | null;
    reserveCalculationTypeValue: number;
    reserveCalculationTypeValueSpecified: boolean;
    reserveCalculationType: number | null;
    reserveRateValue: number;
    reserveRateValueSpecified: boolean;
    reserveRate: number | null;
    usePromptSettingsValue: boolean;
    usePromptSettingsValueSpecified: boolean;
    usePromptSettings: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}