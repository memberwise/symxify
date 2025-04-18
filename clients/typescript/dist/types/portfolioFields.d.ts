import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface PortfolioFields {
    availableBalanceValue: boolean;
    availableBalanceValueSpecified: boolean;
    availableBalance: boolean | null;
    balanceValue: boolean;
    balanceValueSpecified: boolean;
    balance: boolean | null;
    closeDateValue: boolean;
    closeDateValueSpecified: boolean;
    closeDate: boolean | null;
    descriptionValue: boolean;
    descriptionValueSpecified: boolean;
    description: boolean | null;
    fmLastDateValue: boolean;
    fmLastDateValueSpecified: boolean;
    fmLastDate: boolean | null;
    idValue: boolean;
    idValueSpecified: boolean;
    id: boolean | null;
    notePurgeDateValue: boolean;
    notePurgeDateValueSpecified: boolean;
    notePurgeDate: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
