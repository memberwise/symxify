import { CardDefaultCountLimit_2 } from "./cardDefaultCountLimit_2";
import { CardDefaultLimit_2 } from "./cardDefaultLimit_2";
import { CardDefaultMiscId_2 } from "./cardDefaultMiscId_2";
import { CardDefaultPerItemLimit_2 } from "./cardDefaultPerItemLimit_2";
import { CardDefaultService_2 } from "./cardDefaultService_2";
import { CardDefaultWarningCode_2 } from "./cardDefaultWarningCode_2";
import { VersionType } from "./versionType";

export interface CardDefault_2 {
    atmCountLimit: number | null;
    authCountLimit: number | null;
    authLimit: number | null;
    billPayCountLimit: number | null;
    billPayLimit: number | null;
    billPayMax: number | null;
    blockCode: string;
    cardType: number | null;
    chkId: string;
    countLimit: CardDefaultCountLimit_2[];
    credDebCountLimit: number | null;
    credDebLimit: number | null;
    creditCardId: string;
    depCountLimit: number | null;
    depLimit: number | null;
    depMax: number | null;
    description: string;
    digitalIssueExcept: string;
    digitalIssueStatus: number | null;
    effectiveDate: string | null;
    emvChipProfile: string;
    expirationDate: string | null;
    instantIssue: number | null;
    issueCode: number | null;
    issueDate: string | null;
    limit: CardDefaultLimit_2[];
    limitAmount: number | null;
    limitDays: number | null;
    locId: string;
    miscCountLimit: number | null;
    miscId: CardDefaultMiscId_2[];
    miscLimit: number | null;
    nameType: number | null;
    onlineCardIssue: number | null;
    onlineRushIssue: number | null;
    perItemLimit: CardDefaultPerItemLimit_2[];
    pinActual: number | null;
    pinEncrypted: string;
    pinOffset: number | null;
    posCountLimit: number | null;
    posLimit: number | null;
    reclassCode: string;
    reissueCode: number | null;
    reissueMonths: number | null;
    savId: string;
    service: CardDefaultService_2[];
    singleUsageMax: number | null;
    status: number | null;
    suffix: string;
    type: number | null;
    usageLimit: number | null;
    warningCode: CardDefaultWarningCode_2[];
    wdCheckCountLimit: number | null;
    wdCheckLimit: number | null;
    wdCheckMax: number | null;
    xferCountLimit: number | null;
    xferLimit: number | null;
    xferMax: number | null;
    version1: VersionType;
}