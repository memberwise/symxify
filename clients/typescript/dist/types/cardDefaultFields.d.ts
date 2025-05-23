import { VersionType } from "./versionType";
export interface CardDefaultFields {
    atmCountLimit: boolean | null;
    authCountLimit: boolean | null;
    authLimit: boolean | null;
    billPayCountLimit: boolean | null;
    billPayLimit: boolean | null;
    billPayMax: boolean | null;
    blockCode: boolean | null;
    cardType: boolean | null;
    chkId: boolean | null;
    countLimit: number[];
    credDebCountLimit: boolean | null;
    credDebLimit: boolean | null;
    creditCardId: boolean | null;
    depCountLimit: boolean | null;
    depLimit: boolean | null;
    depMax: boolean | null;
    description: boolean | null;
    digitalIssueExcept: boolean | null;
    digitalIssueStatus: boolean | null;
    effectiveDate: boolean | null;
    emvChipProfile: boolean | null;
    expirationDate: boolean | null;
    instantIssue: boolean | null;
    issueCode: boolean | null;
    issueDate: boolean | null;
    limit: number[];
    limitAmount: boolean | null;
    limitDays: boolean | null;
    locId: boolean | null;
    miscCountLimit: boolean | null;
    miscId: number[];
    miscLimit: boolean | null;
    nameType: boolean | null;
    onlineCardIssue: boolean | null;
    onlineRushIssue: boolean | null;
    perItemLimit: number[];
    pinActual: boolean | null;
    pinEncrypted: boolean | null;
    pinOffset: boolean | null;
    posCountLimit: boolean | null;
    posLimit: boolean | null;
    reclassCode: boolean | null;
    reissueCode: boolean | null;
    reissueMonths: boolean | null;
    savId: boolean | null;
    service: number[];
    singleUsageMax: boolean | null;
    status: boolean | null;
    suffix: boolean | null;
    type: boolean | null;
    usageLimit: boolean | null;
    warningCode: number[];
    wdCheckCountLimit: boolean | null;
    wdCheckLimit: boolean | null;
    wdCheckMax: boolean | null;
    xferCountLimit: boolean | null;
    xferLimit: boolean | null;
    xferMax: boolean | null;
    version1: VersionType;
}
