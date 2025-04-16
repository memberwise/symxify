import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface UserFmFields {
    accountVerificationValue: boolean;
    accountVerificationValueSpecified: boolean;
    accountVerification: boolean | null;
    activPurgeDateValue: boolean;
    activPurgeDateValueSpecified: boolean;
    activPurgeDate: boolean | null;
    activeModeValue: boolean;
    activeModeValueSpecified: boolean;
    activeMode: boolean | null;
    archiveDateValue: boolean;
    archiveDateValueSpecified: boolean;
    archiveDate: boolean | null;
    assignedBranchValue: boolean;
    assignedBranchValueSpecified: boolean;
    assignedBranch: boolean | null;
    casTrackingCodeValue: boolean;
    casTrackingCodeValueSpecified: boolean;
    casTrackingCode: boolean | null;
    checkTapeColsValue: boolean;
    checkTapeColsValueSpecified: boolean;
    checkTapeCols: boolean | null;
    configurationGroupValue: boolean;
    configurationGroupValueSpecified: boolean;
    configurationGroup: boolean | null;
    deptNameValue: boolean;
    deptNameValueSpecified: boolean;
    deptName: boolean | null;
    directoryValue: boolean;
    directoryValueSpecified: boolean;
    directory: boolean | null;
    displayItem: number[];
    displayItemSpecified: boolean;
    emailValue: boolean;
    emailValueSpecified: boolean;
    email: boolean | null;
    extensionValue: boolean;
    extensionValueSpecified: boolean;
    extension: boolean | null;
    functions: number[];
    functionsSpecified: boolean;
    invalidPasswordAttemptCountValue: boolean;
    invalidPasswordAttemptCountValueSpecified: boolean;
    invalidPasswordAttemptCount: boolean | null;
    invalidPinAttemptCountValue: boolean;
    invalidPinAttemptCountValueSpecified: boolean;
    invalidPinAttemptCount: boolean | null;
    jobFunctionValue: boolean;
    jobFunctionValueSpecified: boolean;
    jobFunction: boolean | null;
    jobTitleValue: boolean;
    jobTitleValueSpecified: boolean;
    jobTitle: boolean | null;
    lastCheckSeqValue: boolean;
    lastCheckSeqValueSpecified: boolean;
    lastCheckSeq: boolean | null;
    lastConsoleValue: boolean;
    lastConsoleValueSpecified: boolean;
    lastConsole: boolean | null;
    lastInvalidPasswordDateValue: boolean;
    lastInvalidPasswordDateValueSpecified: boolean;
    lastInvalidPasswordDate: boolean | null;
    lastInvalidPasswordTimeValue: boolean;
    lastInvalidPasswordTimeValueSpecified: boolean;
    lastInvalidPasswordTime: boolean | null;
    lastInvalidPinDateValue: boolean;
    lastInvalidPinDateValueSpecified: boolean;
    lastInvalidPinDate: boolean | null;
    lastInvalidPinTimeValue: boolean;
    lastInvalidPinTimeValueSpecified: boolean;
    lastInvalidPinTime: boolean | null;
    lastLogonDateValue: boolean;
    lastLogonDateValueSpecified: boolean;
    lastLogonDate: boolean | null;
    lastLogonTimeValue: boolean;
    lastLogonTimeValueSpecified: boolean;
    lastLogonTime: boolean | null;
    locationValue: boolean;
    locationValueSpecified: boolean;
    location: boolean | null;
    managersNameValue: boolean;
    managersNameValueSpecified: boolean;
    managersName: boolean | null;
    nameValue: boolean;
    nameValueSpecified: boolean;
    name: boolean | null;
    note2: number[];
    note2Specified: boolean;
    numberValue: boolean;
    numberValueSpecified: boolean;
    number: boolean | null;
    onlineAccessValue: boolean;
    onlineAccessValueSpecified: boolean;
    onlineAccess: boolean | null;
    passwordChgDateValue: boolean;
    passwordChgDateValueSpecified: boolean;
    passwordChgDate: boolean | null;
    passwordHash1Value: boolean;
    passwordHash1ValueSpecified: boolean;
    passwordHash1: boolean | null;
    passwordHash2Value: boolean;
    passwordHash2ValueSpecified: boolean;
    passwordHash2: boolean | null;
    passwordHash3Value: boolean;
    passwordHash3ValueSpecified: boolean;
    passwordHash3: boolean | null;
    passwordHash4Value: boolean;
    passwordHash4ValueSpecified: boolean;
    passwordHash4: boolean | null;
    passwordModeValue: boolean;
    passwordModeValueSpecified: boolean;
    passwordMode: boolean | null;
    phoneValue: boolean;
    phoneValueSpecified: boolean;
    phone: boolean | null;
    pinValue: boolean;
    pinValueSpecified: boolean;
    pin: boolean | null;
    pinActiveModeValue: boolean;
    pinActiveModeValueSpecified: boolean;
    pinActiveMode: boolean | null;
    pinChangeDateValue: boolean;
    pinChangeDateValueSpecified: boolean;
    pinChangeDate: boolean | null;
    previousLogOnTimeValue: boolean;
    previousLogOnTimeValueSpecified: boolean;
    previousLogOnTime: boolean | null;
    previousLogonDateValue: boolean;
    previousLogonDateValueSpecified: boolean;
    previousLogonDate: boolean | null;
    previousPasswordHash1: number[];
    previousPasswordHash1Specified: boolean;
    previousPasswordHash2: number[];
    previousPasswordHash2Specified: boolean;
    previousPasswordHash3: number[];
    previousPasswordHash3Specified: boolean;
    previousPasswordHash4: number[];
    previousPasswordHash4Specified: boolean;
    previousPasswordMode: number[];
    previousPasswordModeSpecified: boolean;
    priorDayTapeTotal: number[];
    priorDayTapeTotalSpecified: boolean;
    privilege: number[];
    privilegeSpecified: boolean;
    privilegeGroup: number[];
    privilegeGroupSpecified: boolean;
    prtCheckIndexValue: boolean;
    prtCheckIndexValueSpecified: boolean;
    prtCheckIndex: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    restrictedAccounts: number[];
    restrictedAccountsSpecified: boolean;
    secondaryIdValue: boolean;
    secondaryIdValueSpecified: boolean;
    secondaryId: boolean | null;
    securityAmount: number[];
    securityAmountSpecified: boolean;
    securityCode: number[];
    securityCodeSpecified: boolean;
    ssoDomainUserSub1Value: boolean;
    ssoDomainUserSub1ValueSpecified: boolean;
    ssoDomainUserSub1: boolean | null;
    ssoDomainUserSub2Value: boolean;
    ssoDomainUserSub2ValueSpecified: boolean;
    ssoDomainUserSub2: boolean | null;
    ssoDomainUserSub3Value: boolean;
    ssoDomainUserSub3ValueSpecified: boolean;
    ssoDomainUserSub3: boolean | null;
    ssoDomainUserSub4Value: boolean;
    ssoDomainUserSub4ValueSpecified: boolean;
    ssoDomainUserSub4: boolean | null;
    tapeTotal: number[];
    tapeTotalSpecified: boolean;
    tempPasswordExpirationDateValue: boolean;
    tempPasswordExpirationDateValueSpecified: boolean;
    tempPasswordExpirationDate: boolean | null;
    tempPasswordExpirationTimeValue: boolean;
    tempPasswordExpirationTimeValueSpecified: boolean;
    tempPasswordExpirationTime: boolean | null;
    temporaryPasswordValue: boolean;
    temporaryPasswordValueSpecified: boolean;
    temporaryPassword: boolean | null;
    temporaryPinValue: boolean;
    temporaryPinValueSpecified: boolean;
    temporaryPin: boolean | null;
    typeValue: boolean;
    typeValueSpecified: boolean;
    type: boolean | null;
    workList: number[];
    workListSpecified: boolean;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}