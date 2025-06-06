import { VersionType } from "./versionType";

export interface CollateralCollHold_2 {
    accountNumber: string;
    amount: number | null;
    effectiveDate: string | null;
    expirationDate: string | null;
    id: string;
    idType: number | null;
    locator: number | null;
    recordChangeDate: string | null;
    version1: VersionType;
}