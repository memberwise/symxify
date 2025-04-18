import { CardDefaultCountLimit } from "./cardDefaultCountLimit";
import { CardDefaultLimit } from "./cardDefaultLimit";
import { CardDefaultMiscId } from "./cardDefaultMiscId";
import { CardDefaultPerItemLimit } from "./cardDefaultPerItemLimit";
import { CardDefaultService } from "./cardDefaultService";
import { CardDefaultWarningCode } from "./cardDefaultWarningCode";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface CardDefault {
    atmCountLimitValue: number;
    atmCountLimitValueSpecified: boolean;
    atmCountLimit: number | null;
    authCountLimitValue: number;
    authCountLimitValueSpecified: boolean;
    authCountLimit: number | null;
    authLimitValue: number;
    authLimitValueSpecified: boolean;
    authLimit: number | null;
    billPayCountLimitValue: number;
    billPayCountLimitValueSpecified: boolean;
    billPayCountLimit: number | null;
    billPayLimitValue: number;
    billPayLimitValueSpecified: boolean;
    billPayLimit: number | null;
    billPayMaxValue: number;
    billPayMaxValueSpecified: boolean;
    billPayMax: number | null;
    blockCode: string;
    cardTypeValue: number;
    cardTypeValueSpecified: boolean;
    cardType: number | null;
    chkId: string;
    countLimit: CardDefaultCountLimit[];
    countLimitSpecified: boolean;
    credDebCountLimitValue: number;
    credDebCountLimitValueSpecified: boolean;
    credDebCountLimit: number | null;
    credDebLimitValue: number;
    credDebLimitValueSpecified: boolean;
    credDebLimit: number | null;
    creditCardId: string;
    depCountLimitValue: number;
    depCountLimitValueSpecified: boolean;
    depCountLimit: number | null;
    depLimitValue: number;
    depLimitValueSpecified: boolean;
    depLimit: number | null;
    depMaxValue: number;
    depMaxValueSpecified: boolean;
    depMax: number | null;
    description: string;
    digitalIssueExcept: string;
    digitalIssueStatusValue: number;
    digitalIssueStatusValueSpecified: boolean;
    digitalIssueStatus: number | null;
    effectiveDateValue: string;
    effectiveDateValueSpecified: boolean;
    effectiveDate: string | null;
    emvChipProfile: string;
    expirationDateValue: string;
    expirationDateValueSpecified: boolean;
    expirationDate: string | null;
    instantIssueValue: number;
    instantIssueValueSpecified: boolean;
    instantIssue: number | null;
    issueCodeValue: number;
    issueCodeValueSpecified: boolean;
    issueCode: number | null;
    issueDateValue: string;
    issueDateValueSpecified: boolean;
    issueDate: string | null;
    limit: CardDefaultLimit[];
    limitSpecified: boolean;
    limitAmountValue: number;
    limitAmountValueSpecified: boolean;
    limitAmount: number | null;
    limitDaysValue: number;
    limitDaysValueSpecified: boolean;
    limitDays: number | null;
    locId: string;
    miscCountLimitValue: number;
    miscCountLimitValueSpecified: boolean;
    miscCountLimit: number | null;
    miscId: CardDefaultMiscId[];
    miscIdSpecified: boolean;
    miscLimitValue: number;
    miscLimitValueSpecified: boolean;
    miscLimit: number | null;
    nameTypeValue: number;
    nameTypeValueSpecified: boolean;
    nameType: number | null;
    onlineCardIssueValue: number;
    onlineCardIssueValueSpecified: boolean;
    onlineCardIssue: number | null;
    onlineRushIssueValue: number;
    onlineRushIssueValueSpecified: boolean;
    onlineRushIssue: number | null;
    perItemLimit: CardDefaultPerItemLimit[];
    perItemLimitSpecified: boolean;
    pinActualValue: number;
    pinActualValueSpecified: boolean;
    pinActual: number | null;
    pinEncrypted: string;
    pinOffsetValue: number;
    pinOffsetValueSpecified: boolean;
    pinOffset: number | null;
    posCountLimitValue: number;
    posCountLimitValueSpecified: boolean;
    posCountLimit: number | null;
    posLimitValue: number;
    posLimitValueSpecified: boolean;
    posLimit: number | null;
    reclassCode: string;
    reissueCodeValue: number;
    reissueCodeValueSpecified: boolean;
    reissueCode: number | null;
    reissueMonthsValue: number;
    reissueMonthsValueSpecified: boolean;
    reissueMonths: number | null;
    savId: string;
    service: CardDefaultService[];
    serviceSpecified: boolean;
    singleUsageMaxValue: number;
    singleUsageMaxValueSpecified: boolean;
    singleUsageMax: number | null;
    statusValue: number;
    statusValueSpecified: boolean;
    status: number | null;
    suffix: string;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    usageLimitValue: number;
    usageLimitValueSpecified: boolean;
    usageLimit: number | null;
    warningCode: CardDefaultWarningCode[];
    warningCodeSpecified: boolean;
    wdCheckCountLimitValue: number;
    wdCheckCountLimitValueSpecified: boolean;
    wdCheckCountLimit: number | null;
    wdCheckLimitValue: number;
    wdCheckLimitValueSpecified: boolean;
    wdCheckLimit: number | null;
    wdCheckMaxValue: number;
    wdCheckMaxValueSpecified: boolean;
    wdCheckMax: number | null;
    xferCountLimitValue: number;
    xferCountLimitValueSpecified: boolean;
    xferCountLimit: number | null;
    xferLimitValue: number;
    xferLimitValueSpecified: boolean;
    xferLimit: number | null;
    xferMaxValue: number;
    xferMaxValueSpecified: boolean;
    xferMax: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}