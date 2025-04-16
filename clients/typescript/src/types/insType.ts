import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface InsType {
    consolidationCodeValue: number;
    consolidationCodeValueSpecified: boolean;
    consolidationCode: number | null;
    definedCodeValue: number;
    definedCodeValueSpecified: boolean;
    definedCode: number | null;
    disabilityInsuranceTableValue: number;
    disabilityInsuranceTableValueSpecified: boolean;
    disabilityInsuranceTable: number | null;
    insuranceTypeValue: number;
    insuranceTypeValueSpecified: boolean;
    insuranceType: number | null;
    lifeInsuranceTableValue: number;
    lifeInsuranceTableValueSpecified: boolean;
    lifeInsuranceTable: number | null;
    longDescription: string;
    maxDisDirectInsTypeValue: number;
    maxDisDirectInsTypeValueSpecified: boolean;
    maxDisDirectInsType: number | null;
    maxLifeDirectInsTypeValue: number;
    maxLifeDirectInsTypeValueSpecified: boolean;
    maxLifeDirectInsType: number | null;
    secondInsuredAsPrimeDisValue: boolean;
    secondInsuredAsPrimeDisValueSpecified: boolean;
    secondInsuredAsPrimeDis: boolean | null;
    secondInsuredAsPrimeLifeValue: boolean;
    secondInsuredAsPrimeLifeValueSpecified: boolean;
    secondInsuredAsPrimeLife: boolean | null;
    shortDescription: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}