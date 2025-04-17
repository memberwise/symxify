import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface GlSubaccount_2 {
    accrualAmountValue: number;
    accrualAmountValueSpecified: boolean;
    accrualAmount: number | null;
    accrualEffectDateValue: string | null;
    accrualEffectDateValueSpecified: boolean;
    accrualEffectDate: string | null;
    accrualPostDateValue: string | null;
    accrualPostDateValueSpecified: boolean;
    accrualPostDate: string | null;
    accrualPostThruDateValue: string | null;
    accrualPostThruDateValueSpecified: boolean;
    accrualPostThruDate: string | null;
    accrualStartDateValue: string | null;
    accrualStartDateValueSpecified: boolean;
    accrualStartDate: string | null;
    accruedAmountValue: number;
    accruedAmountValueSpecified: boolean;
    accruedAmount: number | null;
    accruedCountValue: number;
    accruedCountValueSpecified: boolean;
    accruedCount: number | null;
    acquisitionDateValue: string | null;
    acquisitionDateValueSpecified: boolean;
    acquisitionDate: string | null;
    commentOne: string;
    commentTwo: string;
    currentValueValue: number;
    currentValueValueSpecified: boolean;
    currentValue: number | null;
    dispositionValue: number;
    dispositionValueSpecified: boolean;
    disposition: number | null;
    firstMonthMethodValue: number;
    firstMonthMethodValueSpecified: boolean;
    firstMonthMethod: number | null;
    glOffset: string;
    id: string;
    insMaturityDateValue: string | null;
    insMaturityDateValueSpecified: boolean;
    insMaturityDate: string | null;
    insTypeDescription: string;
    insuranceType: string;
    lastFmDateValue: string | null;
    lastFmDateValueSpecified: boolean;
    lastFmDate: string | null;
    limitValueValue: number;
    limitValueValueSpecified: boolean;
    limitValue: number | null;
    maturityDateValue: string | null;
    maturityDateValueSpecified: boolean;
    maturityDate: string | null;
    methodValue: number;
    methodValueSpecified: boolean;
    method: number | null;
    name: string;
    originalValueValue: number;
    originalValueValueSpecified: boolean;
    originalValue: number | null;
    processValue: number;
    processValueSpecified: boolean;
    process: number | null;
    rateValue: number;
    rateValueSpecified: boolean;
    rate: number | null;
    rateBaseValue: number;
    rateBaseValueSpecified: boolean;
    rateBase: number | null;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    saleAmountValue: number;
    saleAmountValueSpecified: boolean;
    saleAmount: number | null;
    saleDateValue: string | null;
    saleDateValueSpecified: boolean;
    saleDate: string | null;
    taxAmountValue: number;
    taxAmountValueSpecified: boolean;
    taxAmount: number | null;
    taxCategory: string;
    taxDateValue: string | null;
    taxDateValueSpecified: boolean;
    taxDate: string | null;
    taxDescription: string;
    taxLocation: string;
    termFrequencyValue: number;
    termFrequencyValueSpecified: boolean;
    termFrequency: number | null;
    termPeriodValue: number;
    termPeriodValueSpecified: boolean;
    termPeriod: number | null;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
