import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface LoanBankruptcyFields {
    closeDateValue: boolean;
    closeDateValueSpecified: boolean;
    closeDate: boolean | null;
    descriptionValue: boolean;
    descriptionValueSpecified: boolean;
    description: boolean | null;
    effectDateValue: boolean;
    effectDateValueSpecified: boolean;
    effectDate: boolean | null;
    expireDateValue: boolean;
    expireDateValueSpecified: boolean;
    expireDate: boolean | null;
    idValue: boolean;
    idValueSpecified: boolean;
    id: boolean | null;
    openDateValue: boolean;
    openDateValueSpecified: boolean;
    openDate: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    typeValue: boolean;
    typeValueSpecified: boolean;
    type: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}