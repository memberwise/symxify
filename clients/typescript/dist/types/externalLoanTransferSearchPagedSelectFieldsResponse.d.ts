import { ExternalLoanTransfer } from "./externalLoanTransfer";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface ExternalLoanTransferSearchPagedSelectFieldsResponse {
    externalLoanTransfer: ExternalLoanTransfer[];
    externalLoanTransferSpecified: boolean;
    token: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
}
