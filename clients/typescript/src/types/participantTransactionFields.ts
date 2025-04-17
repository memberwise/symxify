import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface ParticipantTransactionFields {
    actionCodeValue: boolean;
    actionCodeValueSpecified: boolean;
    actionCode: boolean | null;
    activityDateValue: boolean;
    activityDateValueSpecified: boolean;
    activityDate: boolean | null;
    adjustmentFlagValue: boolean;
    adjustmentFlagValueSpecified: boolean;
    adjustmentFlag: boolean | null;
    agIdValue: boolean;
    agIdValueSpecified: boolean;
    agId: boolean | null;
    balanceChangeValue: boolean;
    balanceChangeValueSpecified: boolean;
    balanceChange: boolean | null;
    batchSequenceValue: boolean;
    batchSequenceValueSpecified: boolean;
    batchSequence: boolean | null;
    branchValue: boolean;
    branchValueSpecified: boolean;
    branch: boolean | null;
    commentValue: boolean;
    commentValueSpecified: boolean;
    comment: boolean | null;
    commentFlagValue: boolean;
    commentFlagValueSpecified: boolean;
    commentFlag: boolean | null;
    consoleNumberValue: boolean;
    consoleNumberValueSpecified: boolean;
    consoleNumber: boolean | null;
    descriptionValue: boolean;
    descriptionValueSpecified: boolean;
    description: boolean | null;
    effectiveDateValue: boolean;
    effectiveDateValueSpecified: boolean;
    effectiveDate: boolean | null;
    loanIdValue: boolean;
    loanIdValueSpecified: boolean;
    loanId: boolean | null;
    memberBranchValue: boolean;
    memberBranchValueSpecified: boolean;
    memberBranch: boolean | null;
    newBalanceValue: boolean;
    newBalanceValueSpecified: boolean;
    newBalance: boolean | null;
    participantNumberValue: boolean;
    participantNumberValueSpecified: boolean;
    participantNumber: boolean | null;
    participantTypeValue: boolean;
    participantTypeValueSpecified: boolean;
    participantType: boolean | null;
    poolNumberValue: boolean;
    poolNumberValueSpecified: boolean;
    poolNumber: boolean | null;
    postDateValue: boolean;
    postDateValueSpecified: boolean;
    postDate: boolean | null;
    postTimeValue: boolean;
    postTimeValueSpecified: boolean;
    postTime: boolean | null;
    sequenceNumberValue: boolean;
    sequenceNumberValueSpecified: boolean;
    sequenceNumber: boolean | null;
    sourceCodeValue: boolean;
    sourceCodeValueSpecified: boolean;
    sourceCode: boolean | null;
    subActionCodeValue: boolean;
    subActionCodeValueSpecified: boolean;
    subActionCode: boolean | null;
    userNumberValue: boolean;
    userNumberValueSpecified: boolean;
    userNumber: boolean | null;
    userOverrideValue: boolean;
    userOverrideValueSpecified: boolean;
    userOverride: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}