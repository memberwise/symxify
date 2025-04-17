import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface Remittance_2 {
    amountValue: number;
    amountValueSpecified: boolean;
    amount: number | null;
    confirmationNumber: string;
    confirmationSeqValue: number;
    confirmationSeqValueSpecified: boolean;
    confirmationSeq: number | null;
    consoleNumberValue: number;
    consoleNumberValueSpecified: boolean;
    consoleNumber: number | null;
    description: string;
    fundTypeValue: number;
    fundTypeValueSpecified: boolean;
    fundType: number | null;
    glCodeValue: number;
    glCodeValueSpecified: boolean;
    glCode: number | null;
    globalSequenceValue: number;
    globalSequenceValueSpecified: boolean;
    globalSequence: number | null;
    globalSequenceDateValue: string | null;
    globalSequenceDateValueSpecified: boolean;
    globalSequenceDate: string | null;
    memberAccount: string;
    payerValue: number;
    payerValueSpecified: boolean;
    payer: number | null;
    postDateValue: string | null;
    postDateValueSpecified: boolean;
    postDate: string | null;
    prevDueDateValue: string | null;
    prevDueDateValueSpecified: boolean;
    prevDueDate: string | null;
    processorAcct: string;
    processorCodeValue: number;
    processorCodeValueSpecified: boolean;
    processorCode: number | null;
    reconDateValue: string | null;
    reconDateValueSpecified: boolean;
    reconDate: string | null;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    remitDateValue: string | null;
    remitDateValueSpecified: boolean;
    remitDate: string | null;
    sequenceValue: number;
    sequenceValueSpecified: boolean;
    sequence: number | null;
    statusValue: number;
    statusValueSpecified: boolean;
    status: number | null;
    tranCode: string;
    tranTypeValue: number;
    tranTypeValueSpecified: boolean;
    tranType: number | null;
    userValue: number;
    userValueSpecified: boolean;
    user: number | null;
    voidDateValue: string | null;
    voidDateValueSpecified: boolean;
    voidDate: string | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
