import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface CheckFields {
    accountCodeValue: boolean;
    accountCodeValueSpecified: boolean;
    accountCode: boolean | null;
    accountNumberValue: boolean;
    accountNumberValueSpecified: boolean;
    accountNumber: boolean | null;
    amountValue: boolean;
    amountValueSpecified: boolean;
    amount: boolean | null;
    branchValue: boolean;
    branchValueSpecified: boolean;
    branch: boolean | null;
    checkNumberAssignedValue: boolean;
    checkNumberAssignedValueSpecified: boolean;
    checkNumberAssigned: boolean | null;
    escheatDateValue: boolean;
    escheatDateValueSpecified: boolean;
    escheatDate: boolean | null;
    fmLastPurgeDateValue: boolean;
    fmLastPurgeDateValueSpecified: boolean;
    fmLastPurgeDate: boolean | null;
    globalSequenceValue: boolean;
    globalSequenceValueSpecified: boolean;
    globalSequence: boolean | null;
    globalSequenceDateValue: boolean;
    globalSequenceDateValueSpecified: boolean;
    globalSequenceDate: boolean | null;
    idValue: boolean;
    idValueSpecified: boolean;
    id: boolean | null;
    idTypeValue: boolean;
    idTypeValueSpecified: boolean;
    idType: boolean | null;
    issueDateValue: boolean;
    issueDateValueSpecified: boolean;
    issueDate: boolean | null;
    numberValue: boolean;
    numberValueSpecified: boolean;
    number: boolean | null;
    payee: number[];
    payeeSpecified: boolean;
    postDateValue: boolean;
    postDateValueSpecified: boolean;
    postDate: boolean | null;
    reconciliationDateValue: boolean;
    reconciliationDateValueSpecified: boolean;
    reconciliationDate: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    referenceValue: boolean;
    referenceValueSpecified: boolean;
    reference: boolean | null;
    reference2Value: boolean;
    reference2ValueSpecified: boolean;
    reference2: boolean | null;
    reference3Value: boolean;
    reference3ValueSpecified: boolean;
    reference3: boolean | null;
    sequenceNumberValue: boolean;
    sequenceNumberValueSpecified: boolean;
    sequenceNumber: boolean | null;
    sourceValue: boolean;
    sourceValueSpecified: boolean;
    source: boolean | null;
    sourceGlCodeValue: boolean;
    sourceGlCodeValueSpecified: boolean;
    sourceGlCode: boolean | null;
    statusValue: boolean;
    statusValueSpecified: boolean;
    status: boolean | null;
    stopPmtDateValue: boolean;
    stopPmtDateValueSpecified: boolean;
    stopPmtDate: boolean | null;
    tracerNumberValue: boolean;
    tracerNumberValueSpecified: boolean;
    tracerNumber: boolean | null;
    voidDateValue: boolean;
    voidDateValueSpecified: boolean;
    voidDate: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}