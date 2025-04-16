import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface InsTableFields {
    balloonPremiumValue: boolean;
    balloonPremiumValueSpecified: boolean;
    balloonPremium: boolean | null;
    balloonPremiumBaseValue: boolean;
    balloonPremiumBaseValueSpecified: boolean;
    balloonPremiumBase: boolean | null;
    deviationFactorValue: boolean;
    deviationFactorValueSpecified: boolean;
    deviationFactor: boolean | null;
    formulaValue: boolean;
    formulaValueSpecified: boolean;
    formula: boolean | null;
    frequencyValue: boolean;
    frequencyValueSpecified: boolean;
    frequency: boolean | null;
    frequencyDayValue: boolean;
    frequencyDayValueSpecified: boolean;
    frequencyDay: boolean | null;
    insuranceCodeValue: boolean;
    insuranceCodeValueSpecified: boolean;
    insuranceCode: boolean | null;
    insuranceTableValue: boolean;
    insuranceTableValueSpecified: boolean;
    insuranceTable: boolean | null;
    longDescriptionValue: boolean;
    longDescriptionValueSpecified: boolean;
    longDescription: boolean | null;
    maxAgeValue: boolean;
    maxAgeValueSpecified: boolean;
    maxAge: boolean | null;
    maxInsurableAmountValue: boolean;
    maxInsurableAmountValueSpecified: boolean;
    maxInsurableAmount: boolean | null;
    maxJointAgeValue: boolean;
    maxJointAgeValueSpecified: boolean;
    maxJointAge: boolean | null;
    maxMonthlyBenefitValue: boolean;
    maxMonthlyBenefitValueSpecified: boolean;
    maxMonthlyBenefit: boolean | null;
    maxTerminMonthsValue: boolean;
    maxTerminMonthsValueSpecified: boolean;
    maxTerminMonths: boolean | null;
    premiumValue: boolean;
    premiumValueSpecified: boolean;
    premium: boolean | null;
    premiumBaseValue: boolean;
    premiumBaseValueSpecified: boolean;
    premiumBase: boolean | null;
    shortDescriptionValue: boolean;
    shortDescriptionValueSpecified: boolean;
    shortDescription: boolean | null;
    subFormulaValue: boolean;
    subFormulaValueSpecified: boolean;
    subFormula: boolean | null;
    termPremium: number[];
    termPremiumSpecified: boolean;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}