import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface ExternalAccountFields {
    acctTypeValue: boolean;
    acctTypeValueSpecified: boolean;
    acctType: boolean | null;
    creationDateValue: boolean;
    creationDateValueSpecified: boolean;
    creationDate: boolean | null;
    expirationDateValue: boolean;
    expirationDateValueSpecified: boolean;
    expirationDate: boolean | null;
    financialInstitutionNameValue: boolean;
    financialInstitutionNameValueSpecified: boolean;
    financialInstitutionName: boolean | null;
    locatorValue: boolean;
    locatorValueSpecified: boolean;
    locator: boolean | null;
    numberValue: boolean;
    numberValueSpecified: boolean;
    number: boolean | null;
    preNoteSentDateValue: boolean;
    preNoteSentDateValueSpecified: boolean;
    preNoteSentDate: boolean | null;
    primaryAccountHolderNameValue: boolean;
    primaryAccountHolderNameValueSpecified: boolean;
    primaryAccountHolderName: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    rtValue: boolean;
    rtValueSpecified: boolean;
    rt: boolean | null;
    statusValue: boolean;
    statusValueSpecified: boolean;
    status: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}