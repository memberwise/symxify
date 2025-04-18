import { PreferencePrevHbPassword_2 } from "./preferencePrevHbPassword_2";
import { PreferencePrevHbPasswordHash2_2 } from "./preferencePrevHbPasswordHash2_2";
import { PreferencePrevHbPasswordHash3_2 } from "./preferencePrevHbPasswordHash3_2";
import { PreferencePrevHbPasswordHash4_2 } from "./preferencePrevHbPasswordHash4_2";
import { PreferencePrevHbPasswordMode_2 } from "./preferencePrevHbPasswordMode_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface Preference_2 {
    audLastLogonDateValue: string | null;
    audLastLogonDateValueSpecified: boolean;
    audLastLogonDate: string | null;
    audLastLogonTimeValue: number;
    audLastLogonTimeValueSpecified: boolean;
    audLastLogonTime: number | null;
    audioAccess: string;
    audioAccess2: string;
    audioAccessModeValue: number;
    audioAccessModeValueSpecified: boolean;
    audioAccessMode: number | null;
    audioAccessMode2Value: number;
    audioAccessMode2ValueSpecified: boolean;
    audioAccessMode2: number | null;
    audioCallCountValue: number;
    audioCallCountValueSpecified: boolean;
    audioCallCount: number | null;
    audioCallMinutesValue: number;
    audioCallMinutesValueSpecified: boolean;
    audioCallMinutes: number | null;
    audioEnableValue: number;
    audioEnableValueSpecified: boolean;
    audioEnable: number | null;
    billPayAmountValue: number;
    billPayAmountValueSpecified: boolean;
    billPayAmount: number | null;
    billPayCountValue: number;
    billPayCountValueSpecified: boolean;
    billPayCount: number | null;
    billPayCountLimitValue: number;
    billPayCountLimitValueSpecified: boolean;
    billPayCountLimit: number | null;
    billPayLimitValue: number;
    billPayLimitValueSpecified: boolean;
    billPayLimit: number | null;
    billPayMaxValue: number;
    billPayMaxValueSpecified: boolean;
    billPayMax: number | null;
    businessFax: string;
    depAmountValue: number;
    depAmountValueSpecified: boolean;
    depAmount: number | null;
    depCountValue: number;
    depCountValueSpecified: boolean;
    depCount: number | null;
    depCountLimitValue: number;
    depCountLimitValueSpecified: boolean;
    depCountLimit: number | null;
    depLimitValue: number;
    depLimitValueSpecified: boolean;
    depLimit: number | null;
    depMaxValue: number;
    depMaxValueSpecified: boolean;
    depMax: number | null;
    emailAddrChgDateValue: string | null;
    emailAddrChgDateValueSpecified: boolean;
    emailAddrChgDate: string | null;
    emailAddrChgTimeValue: number;
    emailAddrChgTimeValueSpecified: boolean;
    emailAddrChgTime: number | null;
    emailAddress: string;
    hbCallCountValue: number;
    hbCallCountValueSpecified: boolean;
    hbCallCount: number | null;
    hbCallMinutesValue: number;
    hbCallMinutesValueSpecified: boolean;
    hbCallMinutes: number | null;
    hbEnableValue: number;
    hbEnableValueSpecified: boolean;
    hbEnable: number | null;
    hbLastLogonDateValue: string | null;
    hbLastLogonDateValueSpecified: boolean;
    hbLastLogonDate: string | null;
    hbLastLogonTimeValue: number;
    hbLastLogonTimeValueSpecified: boolean;
    hbLastLogonTime: number | null;
    hbModeValue: number;
    hbModeValueSpecified: boolean;
    hbMode: number | null;
    hbPassword: string;
    hbPassword2: string;
    hbPasswordModeValue: number;
    hbPasswordModeValueSpecified: boolean;
    hbPasswordMode: number | null;
    hbPasswordMode2Value: number;
    hbPasswordMode2ValueSpecified: boolean;
    hbPasswordMode2: number | null;
    hbUsername: string;
    homeFax: string;
    interactModeValue: number;
    interactModeValueSpecified: boolean;
    interactMode: number | null;
    invalidPwdAttmptsValue: number;
    invalidPwdAttmptsValueSpecified: boolean;
    invalidPwdAttmpts: number | null;
    languageValue: number;
    languageValueSpecified: boolean;
    language: number | null;
    lastAccessChangeDateValue: string | null;
    lastAccessChangeDateValueSpecified: boolean;
    lastAccessChangeDate: string | null;
    lastHbPwChangeDateValue: string | null;
    lastHbPwChangeDateValueSpecified: boolean;
    lastHbPwChangeDate: string | null;
    lastLogonDateValue: string | null;
    lastLogonDateValueSpecified: boolean;
    lastLogonDate: string | null;
    lastLogonTimeValue: number;
    lastLogonTimeValueSpecified: boolean;
    lastLogonTime: number | null;
    lastTranDateValue: string | null;
    lastTranDateValueSpecified: boolean;
    lastTranDate: string | null;
    listTransactionsValue: number;
    listTransactionsValueSpecified: boolean;
    listTransactions: number | null;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    lockCountValue: number;
    lockCountValueSpecified: boolean;
    lockCount: number | null;
    lockedValue: number;
    lockedValueSpecified: boolean;
    locked: number | null;
    prevHbPassword: PreferencePrevHbPassword_2[];
    prevHbPasswordSpecified: boolean;
    prevHbPasswordHash2: PreferencePrevHbPasswordHash2_2[];
    prevHbPasswordHash2Specified: boolean;
    prevHbPasswordHash3: PreferencePrevHbPasswordHash3_2[];
    prevHbPasswordHash3Specified: boolean;
    prevHbPasswordHash4: PreferencePrevHbPasswordHash4_2[];
    prevHbPasswordHash4Specified: boolean;
    prevHbPasswordMode: PreferencePrevHbPasswordMode_2[];
    prevHbPasswordModeSpecified: boolean;
    pwdResetDateValue: string | null;
    pwdResetDateValueSpecified: boolean;
    pwdResetDate: string | null;
    pwdResetProbationValue: number;
    pwdResetProbationValueSpecified: boolean;
    pwdResetProbation: number | null;
    pwdResetRqstDateValue: string | null;
    pwdResetRqstDateValueSpecified: boolean;
    pwdResetRqstDate: string | null;
    pwdResetRqstNoticeValue: number;
    pwdResetRqstNoticeValueSpecified: boolean;
    pwdResetRqstNotice: number | null;
    pwdResetRqstTimeValue: number;
    pwdResetRqstTimeValueSpecified: boolean;
    pwdResetRqstTime: number | null;
    pwdResetimeValue: number;
    pwdResetimeValueSpecified: boolean;
    pwdResetime: number | null;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    reference: string;
    securityAnswer: string;
    securityQuestion: string;
    tranCodes: string;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    userCodeValue: number;
    userCodeValueSpecified: boolean;
    userCode: number | null;
    wdCashAmountValue: number;
    wdCashAmountValueSpecified: boolean;
    wdCashAmount: number | null;
    wdCashCountValue: number;
    wdCashCountValueSpecified: boolean;
    wdCashCount: number | null;
    wdCashCountLimitValue: number;
    wdCashCountLimitValueSpecified: boolean;
    wdCashCountLimit: number | null;
    wdCashLimitValue: number;
    wdCashLimitValueSpecified: boolean;
    wdCashLimit: number | null;
    wdCashMaxValue: number;
    wdCashMaxValueSpecified: boolean;
    wdCashMax: number | null;
    wdCheckAmountValue: number;
    wdCheckAmountValueSpecified: boolean;
    wdCheckAmount: number | null;
    wdCheckCountValue: number;
    wdCheckCountValueSpecified: boolean;
    wdCheckCount: number | null;
    wdCheckCountLimitValue: number;
    wdCheckCountLimitValueSpecified: boolean;
    wdCheckCountLimit: number | null;
    wdCheckLimitValue: number;
    wdCheckLimitValueSpecified: boolean;
    wdCheckLimit: number | null;
    wdCheckMaxValue: number;
    wdCheckMaxValueSpecified: boolean;
    wdCheckMax: number | null;
    xferAmountValue: number;
    xferAmountValueSpecified: boolean;
    xferAmount: number | null;
    xferCountValue: number;
    xferCountValueSpecified: boolean;
    xferCount: number | null;
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