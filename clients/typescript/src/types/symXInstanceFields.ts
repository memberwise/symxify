import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface SymXInstanceFields {
    crudLoggingThresholdValue: boolean;
    crudLoggingThresholdValueSpecified: boolean;
    crudLoggingThreshold: boolean | null;
    descriptionValue: boolean;
    descriptionValueSpecified: boolean;
    description: boolean | null;
    instanceIdValue: boolean;
    instanceIdValueSpecified: boolean;
    instanceId: boolean | null;
    internalListSizeValue: boolean;
    internalListSizeValueSpecified: boolean;
    internalListSize: boolean | null;
    internalProviderKeyStoreValue: boolean;
    internalProviderKeyStoreValueSpecified: boolean;
    internalProviderKeyStore: boolean | null;
    nameValue: boolean;
    nameValueSpecified: boolean;
    name: boolean | null;
    otherLoggingThresholdValue: boolean;
    otherLoggingThresholdValueSpecified: boolean;
    otherLoggingThreshold: boolean | null;
    powerOnLoggingThresholdValue: boolean;
    powerOnLoggingThresholdValueSpecified: boolean;
    powerOnLoggingThreshold: boolean | null;
    tokenValidityValue: boolean;
    tokenValidityValueSpecified: boolean;
    tokenValidity: boolean | null;
    transactionsLoggingThresholdValue: boolean;
    transactionsLoggingThresholdValueSpecified: boolean;
    transactionsLoggingThreshold: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}