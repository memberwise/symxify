import { IrsDistributionSourceId_2 } from "./irsDistributionSourceId_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface IrsDistribution_2 {
    amountValue: number;
    amountValueSpecified: boolean;
    amount: number | null;
    destinationAccount: string;
    destinationId: string;
    distributionCodeValue: number;
    distributionCodeValueSpecified: boolean;
    distributionCode: number | null;
    distributionDay1Value: number;
    distributionDay1ValueSpecified: boolean;
    distributionDay1: number | null;
    distributionDay2Value: number;
    distributionDay2ValueSpecified: boolean;
    distributionDay2: number | null;
    distributionFreqValue: number;
    distributionFreqValueSpecified: boolean;
    distributionFreq: number | null;
    distributionMethodValue: number;
    distributionMethodValueSpecified: boolean;
    distributionMethod: number | null;
    effectiveDateValue: string | null;
    effectiveDateValueSpecified: boolean;
    effectiveDate: string | null;
    expirationDateValue: string | null;
    expirationDateValueSpecified: boolean;
    expirationDate: string | null;
    fedWholdAmountValue: number;
    fedWholdAmountValueSpecified: boolean;
    fedWholdAmount: number | null;
    fedWholdCodeValue: number;
    fedWholdCodeValueSpecified: boolean;
    fedWholdCode: number | null;
    fedWholdPercentValue: number;
    fedWholdPercentValueSpecified: boolean;
    fedWholdPercent: number | null;
    lastDistributnAmtValue: number;
    lastDistributnAmtValueSpecified: boolean;
    lastDistributnAmt: number | null;
    lastDistributnDateValue: string | null;
    lastDistributnDateValueSpecified: boolean;
    lastDistributnDate: string | null;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    nextDistributnDateValue: string | null;
    nextDistributnDateValueSpecified: boolean;
    nextDistributnDate: string | null;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    regEValue: number;
    regEValueSpecified: boolean;
    regE: number | null;
    sourceId: IrsDistributionSourceId_2[];
    sourceIdSpecified: boolean;
    stateWholdAmountValue: number;
    stateWholdAmountValueSpecified: boolean;
    stateWholdAmount: number | null;
    stateWholdCodeValue: number;
    stateWholdCodeValueSpecified: boolean;
    stateWholdCode: number | null;
    stateWholdPercentValue: number;
    stateWholdPercentValueSpecified: boolean;
    stateWholdPercent: number | null;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
