import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface Collateral_2 {
    collateralAppStatusValue: number;
    collateralAppStatusValueSpecified: boolean;
    collateralAppStatus: number | null;
    collateralOwner: string;
    createDateValue: string | null;
    createDateValueSpecified: boolean;
    createDate: string | null;
    description: string;
    expireDateValue: string | null;
    expireDateValueSpecified: boolean;
    expireDate: string | null;
    fmLastPurgeDateValue: string | null;
    fmLastPurgeDateValueSpecified: boolean;
    fmLastPurgeDate: string | null;
    lastFmDateValue: string | null;
    lastFmDateValueSpecified: boolean;
    lastFmDate: string | null;
    number: string;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    requiredDocumentList: string;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    userChar1: string;
    userChar2: string;
    userChar3: string;
    userChar4: string;
    userChar5: string;
    userChar6: string;
    valueValue: number;
    valueValueSpecified: boolean;
    value: number | null;
    valueDateValue: string | null;
    valueDateValueSpecified: boolean;
    valueDate: string | null;
    valueSource: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}