import { VersionType } from "./versionType";

export interface PreferenceDefault_2 {
    audioAccess: string;
    audioAccess2: string;
    audioEnable: number | null;
    billPayCountLimit: number | null;
    billPayLimit: number | null;
    billPayMax: number | null;
    depCountLimit: number | null;
    depLimit: number | null;
    depMax: number | null;
    hbEnable: number | null;
    hbMode: number | null;
    interactMode: number | null;
    language: number | null;
    listTransactions: number | null;
    reference: string;
    tranCodes: string;
    type: number | null;
    userCode: number | null;
    wdCashCountLimit: number | null;
    wdCashLimit: number | null;
    wdCashMax: number | null;
    wdCheckCountLimit: number | null;
    wdCheckLimit: number | null;
    wdCheckMax: number | null;
    xferCountLimit: number | null;
    xferLimit: number | null;
    xferMax: number | null;
    version1: VersionType;
}