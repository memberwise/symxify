import { CredentialsChoice } from "./credentialsChoice";
import { DeviceInformation } from "./deviceInformation";
import { PagingRequestContext } from "./pagingRequestContext";
import { LoanBankruptcyPrepetitionBalSingleSelectableFields } from "./loanBankruptcyPrepetitionBalSingleSelectableFields";
import { LoanBankruptcyPrepetitionBalSearchFilter } from "./loanBankruptcyPrepetitionBalSearchFilter";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface LoanBankruptcyPrepetitionBalSearchPagedSelectFieldsRequest {
    accountNumber: string;
    loanId: string;
    loanBankruptcyId: string;
    credentials: CredentialsChoice;
    deviceInformation: DeviceInformation;
    pagingRequestContext: PagingRequestContext;
    selectableFields: LoanBankruptcyPrepetitionBalSingleSelectableFields;
    searchFilter: LoanBankruptcyPrepetitionBalSearchFilter;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
    messageId: string;
    branchIdValue: number;
    branchIdValueSpecified: boolean;
    branchId: number | null;
}
