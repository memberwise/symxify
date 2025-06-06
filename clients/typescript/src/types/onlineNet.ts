import { BitMap } from "./bitMap";
import { VersionType } from "./versionType";

export interface OnlineNet {
    acquirerProcessorId: string;
    acquirerSecurityCode: string;
    acquirerSettlementTime: string;
    clientId: string;
    dataProcessingCenter: string;
    financialInstitutionId: string;
    forcePostFinTrnLimitUsage: string;
    glCode: number | null;
    holdMatchWeight: number | null;
    holdMatchWeightIncrementals: number | null;
    issuerSecurityCode: string;
    issuerSettlementTime: string;
    logicalNetwork: string;
    masterCardCcaFeeComment: string;
    masterCardCcaFeeGlCode: number | null;
    masterCardIcaFeeComment: string;
    masterCardIcaFeeGlCode: number | null;
    networkManagesPreAuthHolds: boolean | null;
    networkMessageFormat: number | null;
    otherAccountMiscId: number | null;
    otherAccountType: number | null;
    partialApprovalCardTypes: BitMap;
    password: string;
    pinPartialApprovalOption: number | null;
    postAdministrativeMessages: boolean | null;
    principalId: string;
    requestAdvicePairs: boolean | null;
    returnBalOnNonAtmTrans: BitMap;
    returnedBalances: number | null;
    routingTransitNumber: string;
    sigPartialApprovalOption: number | null;
    systemId: string;
    terminalIdOption: number | null;
    tokenizationNoteCode: number | null;
    updateCardStatusReason: boolean | null;
    useAcctsinOnlineMessage: boolean | null;
    validateOnlineMsgAcct: boolean | null;
    visaMultiCrrncyIsaFeeCmnt: string;
    visaMultiCrrncyIsaFeeGl: number | null;
    visaSglCrrncyIsaFeeCmnt: string;
    visaSglCrrncyIsaFeeGl: number | null;
    warnonOverdraw: boolean | null;
    version1: VersionType;
}