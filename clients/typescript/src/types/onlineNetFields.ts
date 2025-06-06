import { VersionType } from "./versionType";

export interface OnlineNetFields {
    acquirerProcessorId: boolean | null;
    acquirerSecurityCode: boolean | null;
    acquirerSettlementTime: boolean | null;
    clientId: boolean | null;
    dataProcessingCenter: boolean | null;
    financialInstitutionId: boolean | null;
    forcePostFinTrnLimitUsage: boolean | null;
    glCode: boolean | null;
    holdMatchWeight: boolean | null;
    holdMatchWeightIncrementals: boolean | null;
    issuerSecurityCode: boolean | null;
    issuerSettlementTime: boolean | null;
    logicalNetwork: boolean | null;
    masterCardCcaFeeComment: boolean | null;
    masterCardCcaFeeGlCode: boolean | null;
    masterCardIcaFeeComment: boolean | null;
    masterCardIcaFeeGlCode: boolean | null;
    networkManagesPreAuthHolds: boolean | null;
    networkMessageFormat: boolean | null;
    otherAccountMiscId: boolean | null;
    otherAccountType: boolean | null;
    partialApprovalCardTypes: boolean | null;
    password: boolean | null;
    pinPartialApprovalOption: boolean | null;
    postAdministrativeMessages: boolean | null;
    principalId: boolean | null;
    requestAdvicePairs: boolean | null;
    returnBalOnNonAtmTrans: boolean | null;
    returnedBalances: boolean | null;
    routingTransitNumber: boolean | null;
    sigPartialApprovalOption: boolean | null;
    systemId: boolean | null;
    terminalIdOption: boolean | null;
    tokenizationNoteCode: boolean | null;
    updateCardStatusReason: boolean | null;
    useAcctsinOnlineMessage: boolean | null;
    validateOnlineMsgAcct: boolean | null;
    visaMultiCrrncyIsaFeeCmnt: boolean | null;
    visaMultiCrrncyIsaFeeGl: boolean | null;
    visaSglCrrncyIsaFeeCmnt: boolean | null;
    visaSglCrrncyIsaFeeGl: boolean | null;
    warnonOverdraw: boolean | null;
    version1: VersionType;
}