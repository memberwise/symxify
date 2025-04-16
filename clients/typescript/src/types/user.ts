import { ActivityList } from "./activityList";
import { UserDisplayItem } from "./userDisplayItem";
import { UserFunctions } from "./userFunctions";
import { UserNote2 } from "./userNote2";
import { UserPreviousPasswordMode } from "./userPreviousPasswordMode";
import { UserPriorDayTapeTotal } from "./userPriorDayTapeTotal";
import { UserPrivilege } from "./userPrivilege";
import { UserPrivilegeGroup } from "./userPrivilegeGroup";
import { UserRestrictedAccounts } from "./userRestrictedAccounts";
import { UserSecurityAmount } from "./userSecurityAmount";
import { UserSecurityCode } from "./userSecurityCode";
import { UserTapeTotal } from "./userTapeTotal";
import { UserTrackingList } from "./userTrackingList";
import { UserWorkList } from "./userWorkList";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface User {
    accountVerificationValue: number;
    accountVerificationValueSpecified: boolean;
    accountVerification: number | null;
    activPurgeDateValue: string;
    activPurgeDateValueSpecified: boolean;
    activPurgeDate: string | null;
    activeModeValue: number;
    activeModeValueSpecified: boolean;
    activeMode: number | null;
    activityList: ActivityList;
    archiveDateValue: string;
    archiveDateValueSpecified: boolean;
    archiveDate: string | null;
    assignedBranchValue: number;
    assignedBranchValueSpecified: boolean;
    assignedBranch: number | null;
    casTrackingCodeValue: number;
    casTrackingCodeValueSpecified: boolean;
    casTrackingCode: number | null;
    checkTapeColsValue: number;
    checkTapeColsValueSpecified: boolean;
    checkTapeCols: number | null;
    configurationGroupValue: number;
    configurationGroupValueSpecified: boolean;
    configurationGroup: number | null;
    deptName: string;
    directory: string;
    displayItem: UserDisplayItem[];
    displayItemSpecified: boolean;
    email: string;
    extension: string;
    functions: UserFunctions[];
    functionsSpecified: boolean;
    invalidPasswordAttemptCountValue: number;
    invalidPasswordAttemptCountValueSpecified: boolean;
    invalidPasswordAttemptCount: number | null;
    invalidPinAttemptCountValue: number;
    invalidPinAttemptCountValueSpecified: boolean;
    invalidPinAttemptCount: number | null;
    jobFunction: string;
    jobTitle: string;
    lastCheckSeqValue: number;
    lastCheckSeqValueSpecified: boolean;
    lastCheckSeq: number | null;
    lastConsoleValue: number;
    lastConsoleValueSpecified: boolean;
    lastConsole: number | null;
    lastInvalidPasswordDateValue: string;
    lastInvalidPasswordDateValueSpecified: boolean;
    lastInvalidPasswordDate: string | null;
    lastInvalidPasswordTimeValue: number;
    lastInvalidPasswordTimeValueSpecified: boolean;
    lastInvalidPasswordTime: number | null;
    lastInvalidPinDateValue: string;
    lastInvalidPinDateValueSpecified: boolean;
    lastInvalidPinDate: string | null;
    lastInvalidPinTimeValue: number;
    lastInvalidPinTimeValueSpecified: boolean;
    lastInvalidPinTime: number | null;
    lastLogonDateValue: string;
    lastLogonDateValueSpecified: boolean;
    lastLogonDate: string | null;
    lastLogonTimeValue: number;
    lastLogonTimeValueSpecified: boolean;
    lastLogonTime: number | null;
    location: string;
    managersName: string;
    name: string;
    note2: UserNote2[];
    note2Specified: boolean;
    numberValue: number;
    numberValueSpecified: boolean;
    number: number | null;
    onlineAccessValue: number;
    onlineAccessValueSpecified: boolean;
    onlineAccess: number | null;
    passwordChgDateValue: string;
    passwordChgDateValueSpecified: boolean;
    passwordChgDate: string | null;
    passwordModeValue: number;
    passwordModeValueSpecified: boolean;
    passwordMode: number | null;
    phone: string;
    pinActiveModeValue: number;
    pinActiveModeValueSpecified: boolean;
    pinActiveMode: number | null;
    pinChangeDateValue: string;
    pinChangeDateValueSpecified: boolean;
    pinChangeDate: string | null;
    previousLogOnTimeValue: number;
    previousLogOnTimeValueSpecified: boolean;
    previousLogOnTime: number | null;
    previousLogonDateValue: string;
    previousLogonDateValueSpecified: boolean;
    previousLogonDate: string | null;
    previousPasswordMode: UserPreviousPasswordMode[];
    previousPasswordModeSpecified: boolean;
    priorDayTapeTotal: UserPriorDayTapeTotal[];
    priorDayTapeTotalSpecified: boolean;
    privilege: UserPrivilege[];
    privilegeSpecified: boolean;
    privilegeGroup: UserPrivilegeGroup[];
    privilegeGroupSpecified: boolean;
    prtCheckIndexValue: number;
    prtCheckIndexValueSpecified: boolean;
    prtCheckIndex: number | null;
    recordChangeDateValue: string;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    restrictedAccounts: UserRestrictedAccounts[];
    restrictedAccountsSpecified: boolean;
    secondaryId: string;
    securityAmount: UserSecurityAmount[];
    securityAmountSpecified: boolean;
    securityCode: UserSecurityCode[];
    securityCodeSpecified: boolean;
    ssoDomainUser: string;
    ssoDomainUserSub1: string;
    ssoDomainUserSub2: string;
    ssoDomainUserSub3: string;
    ssoDomainUserSub4: string;
    tapeTotal: UserTapeTotal[];
    tapeTotalSpecified: boolean;
    tempPasswordExpirationDateValue: string;
    tempPasswordExpirationDateValueSpecified: boolean;
    tempPasswordExpirationDate: string | null;
    tempPasswordExpirationTimeValue: number;
    tempPasswordExpirationTimeValueSpecified: boolean;
    tempPasswordExpirationTime: number | null;
    temporaryPasswordValue: number;
    temporaryPasswordValueSpecified: boolean;
    temporaryPassword: number | null;
    temporaryPinValue: number;
    temporaryPinValueSpecified: boolean;
    temporaryPin: number | null;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    userTrackingList: UserTrackingList;
    workList: UserWorkList[];
    workListSpecified: boolean;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}