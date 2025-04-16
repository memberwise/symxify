import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface LoanAppDefaultFields {
    accountTypeValue: boolean;
    accountTypeValueSpecified: boolean;
    accountType: boolean | null;
    applicationTypeValue: boolean;
    applicationTypeValueSpecified: boolean;
    applicationType: boolean | null;
    applyAsBilledValue: boolean;
    applyAsBilledValueSpecified: boolean;
    applyAsBilled: boolean | null;
    approvalCodeValue: boolean;
    approvalCodeValueSpecified: boolean;
    approvalCode: boolean | null;
    billingDefaultDaysValue: boolean;
    billingDefaultDaysValueSpecified: boolean;
    billingDefaultDays: boolean | null;
    billingMethodValue: boolean;
    billingMethodValueSpecified: boolean;
    billingMethod: boolean | null;
    billingNoticeValue: boolean;
    billingNoticeValueSpecified: boolean;
    billingNotice: boolean | null;
    billingNoticeMinValue: boolean;
    billingNoticeMinValueSpecified: boolean;
    billingNoticeMin: boolean | null;
    branchValue: boolean;
    branchValueSpecified: boolean;
    branch: boolean | null;
    btLimitMaxValue: boolean;
    btLimitMaxValueSpecified: boolean;
    btLimitMax: boolean | null;
    btPercentValue: boolean;
    btPercentValueSpecified: boolean;
    btPercent: boolean | null;
    caLimitMaxValue: boolean;
    caLimitMaxValueSpecified: boolean;
    caLimitMax: boolean | null;
    caPercentValue: boolean;
    caPercentValueSpecified: boolean;
    caPercent: boolean | null;
    collateralCodeValue: boolean;
    collateralCodeValueSpecified: boolean;
    collateralCode: boolean | null;
    combinedCaBtLimitMaxValue: boolean;
    combinedCaBtLimitMaxValueSpecified: boolean;
    combinedCaBtLimitMax: boolean | null;
    combinedCaBtPercentValue: boolean;
    combinedCaBtPercentValueSpecified: boolean;
    combinedCaBtPercent: boolean | null;
    comboLnSegmentMaxValue: boolean;
    comboLnSegmentMaxValueSpecified: boolean;
    comboLnSegmentMax: boolean | null;
    comboPmtOrderMethValue: boolean;
    comboPmtOrderMethValueSpecified: boolean;
    comboPmtOrderMeth: boolean | null;
    comboSeg0PmtOrderValue: boolean;
    comboSeg0PmtOrderValueSpecified: boolean;
    comboSeg0PmtOrder: boolean | null;
    creationDateValue: boolean;
    creationDateValueSpecified: boolean;
    creationDate: boolean | null;
    creditBureauValue: boolean;
    creditBureauValueSpecified: boolean;
    creditBureau: boolean | null;
    creditLimitValue: boolean;
    creditLimitValueSpecified: boolean;
    creditLimit: boolean | null;
    creditScoreTypeValue: boolean;
    creditScoreTypeValueSpecified: boolean;
    creditScoreType: boolean | null;
    dealerCityValue: boolean;
    dealerCityValueSpecified: boolean;
    dealerCity: boolean | null;
    dealerCountyValue: boolean;
    dealerCountyValueSpecified: boolean;
    dealerCounty: boolean | null;
    dealerStateValue: boolean;
    dealerStateValueSpecified: boolean;
    dealerState: boolean | null;
    debtRatioType: number[];
    debtRatioTypeSpecified: boolean;
    denialDateValue: boolean;
    denialDateValueSpecified: boolean;
    denialDate: boolean | null;
    discountRateValue: boolean;
    discountRateValueSpecified: boolean;
    discountRate: boolean | null;
    dqCalculationMethodValue: boolean;
    dqCalculationMethodValueSpecified: boolean;
    dqCalculationMethod: boolean | null;
    dueDateAdvanceCodeValue: boolean;
    dueDateAdvanceCodeValueSpecified: boolean;
    dueDateAdvanceCode: boolean | null;
    dueDay1Value: boolean;
    dueDay1ValueSpecified: boolean;
    dueDay1: boolean | null;
    dueDay2Value: boolean;
    dueDay2ValueSpecified: boolean;
    dueDay2: boolean | null;
    ecoaCodeValue: boolean;
    ecoaCodeValueSpecified: boolean;
    ecoaCode: boolean | null;
    effectiveAprValue: boolean;
    effectiveAprValueSpecified: boolean;
    effectiveApr: boolean | null;
    effectiveDateValue: boolean;
    effectiveDateValueSpecified: boolean;
    effectiveDate: boolean | null;
    exceedLevelPmtAmtValue: boolean;
    exceedLevelPmtAmtValueSpecified: boolean;
    exceedLevelPmtAmt: boolean | null;
    expirationDateValue: boolean;
    expirationDateValueSpecified: boolean;
    expirationDate: boolean | null;
    fasb91CodeValue: boolean;
    fasb91CodeValueSpecified: boolean;
    fasb91Code: boolean | null;
    fixedDealerCityTaxRateValue: boolean;
    fixedDealerCityTaxRateValueSpecified: boolean;
    fixedDealerCityTaxRate: boolean | null;
    fixedDealerCountyTaxRateValue: boolean;
    fixedDealerCountyTaxRateValueSpecified: boolean;
    fixedDealerCountyTaxRate: boolean | null;
    fixedDealerStateTaxRateValue: boolean;
    fixedDealerStateTaxRateValueSpecified: boolean;
    fixedDealerStateTaxRate: boolean | null;
    fixedLesseeCityTaxRateValue: boolean;
    fixedLesseeCityTaxRateValueSpecified: boolean;
    fixedLesseeCityTaxRate: boolean | null;
    fixedLesseeCountyTaxRateValue: boolean;
    fixedLesseeCountyTaxRateValueSpecified: boolean;
    fixedLesseeCountyTaxRate: boolean | null;
    fixedLesseeStateTaxRateValue: boolean;
    fixedLesseeStateTaxRateValueSpecified: boolean;
    fixedLesseeStateTaxRate: boolean | null;
    formTypeValue: boolean;
    formTypeValueSpecified: boolean;
    formType: boolean | null;
    initialBcdSettingOptionValue: boolean;
    initialBcdSettingOptionValueSpecified: boolean;
    initialBcdSettingOption: boolean | null;
    insurabilityCodeValue: boolean;
    insurabilityCodeValueSpecified: boolean;
    insurabilityCode: boolean | null;
    insurance1ChosenValue: boolean;
    insurance1ChosenValueSpecified: boolean;
    insurance1Chosen: boolean | null;
    insurance2ChosenValue: boolean;
    insurance2ChosenValueSpecified: boolean;
    insurance2Chosen: boolean | null;
    insurance3ChosenValue: boolean;
    insurance3ChosenValueSpecified: boolean;
    insurance3Chosen: boolean | null;
    insuranceMaxValue: boolean;
    insuranceMaxValueSpecified: boolean;
    insuranceMax: boolean | null;
    insuranceTypeValue: boolean;
    insuranceTypeValueSpecified: boolean;
    insuranceType: boolean | null;
    interestRateValue: boolean;
    interestRateValueSpecified: boolean;
    interestRate: boolean | null;
    interestTypeValue: boolean;
    interestTypeValueSpecified: boolean;
    interestType: boolean | null;
    leaseDispositionDateValue: boolean;
    leaseDispositionDateValueSpecified: boolean;
    leaseDispositionDate: boolean | null;
    leaseDispositionFeeValue: boolean;
    leaseDispositionFeeValueSpecified: boolean;
    leaseDispositionFee: boolean | null;
    leaseTerminateDateValue: boolean;
    leaseTerminateDateValueSpecified: boolean;
    leaseTerminateDate: boolean | null;
    leaseTerminateFeeValue: boolean;
    leaseTerminateFeeValueSpecified: boolean;
    leaseTerminateFee: boolean | null;
    lesseeCityValue: boolean;
    lesseeCityValueSpecified: boolean;
    lesseeCity: boolean | null;
    lesseeCountyValue: boolean;
    lesseeCountyValueSpecified: boolean;
    lesseeCounty: boolean | null;
    lesseeStateValue: boolean;
    lesseeStateValueSpecified: boolean;
    lesseeState: boolean | null;
    levelPaymentAmtValue: boolean;
    levelPaymentAmtValueSpecified: boolean;
    levelPaymentAmt: boolean | null;
    levelPrincipalAmtValue: boolean;
    levelPrincipalAmtValueSpecified: boolean;
    levelPrincipalAmt: boolean | null;
    limitExpirationDateValue: boolean;
    limitExpirationDateValueSpecified: boolean;
    limitExpirationDate: boolean | null;
    loanCodeValue: boolean;
    loanCodeValueSpecified: boolean;
    loanCode: boolean | null;
    loanDescriptionValue: boolean;
    loanDescriptionValueSpecified: boolean;
    loanDescription: boolean | null;
    loanTypeValue: boolean;
    loanTypeValueSpecified: boolean;
    loanType: boolean | null;
    maxDueDateAdvancePeriodValue: boolean;
    maxDueDateAdvancePeriodValueSpecified: boolean;
    maxDueDateAdvancePeriod: boolean | null;
    minimumPaymentValue: boolean;
    minimumPaymentValueSpecified: boolean;
    minimumPayment: boolean | null;
    newSegCutoffDaysValue: boolean;
    newSegCutoffDaysValueSpecified: boolean;
    newSegCutoffDays: boolean | null;
    newSegCutoffOptionValue: boolean;
    newSegCutoffOptionValueSpecified: boolean;
    newSegCutoffOption: boolean | null;
    originalRateValue: boolean;
    originalRateValueSpecified: boolean;
    originalRate: boolean | null;
    ovlAuthFeeValue: boolean;
    ovlAuthFeeValueSpecified: boolean;
    ovlAuthFee: boolean | null;
    ovlOptInValue: boolean;
    ovlOptInValueSpecified: boolean;
    ovlOptIn: boolean | null;
    paymentCalcTypeValue: boolean;
    paymentCalcTypeValueSpecified: boolean;
    paymentCalcType: boolean | null;
    paymentFrequencyValue: boolean;
    paymentFrequencyValueSpecified: boolean;
    paymentFrequency: boolean | null;
    paymentMethodValue: boolean;
    paymentMethodValueSpecified: boolean;
    paymentMethod: boolean | null;
    paymentSkipStartDayValue: boolean;
    paymentSkipStartDayValueSpecified: boolean;
    paymentSkipStartDay: boolean | null;
    paymentSkipsValue: boolean;
    paymentSkipsValueSpecified: boolean;
    paymentSkips: boolean | null;
    paymentTypeValue: boolean;
    paymentTypeValueSpecified: boolean;
    paymentType: boolean | null;
    percentPrincipalValue: boolean;
    percentPrincipalValueSpecified: boolean;
    percentPrincipal: boolean | null;
    propertyAddressTypeValue: boolean;
    propertyAddressTypeValueSpecified: boolean;
    propertyAddressType: boolean | null;
    purposeCodeValue: boolean;
    purposeCodeValueSpecified: boolean;
    purposeCode: boolean | null;
    queuePriorityValue: boolean;
    queuePriorityValueSpecified: boolean;
    queuePriority: boolean | null;
    riskRateValue: boolean;
    riskRateValueSpecified: boolean;
    riskRate: boolean | null;
    salesTaxCityIndicatorValue: boolean;
    salesTaxCityIndicatorValueSpecified: boolean;
    salesTaxCityIndicator: boolean | null;
    salesTaxCountyIndicatorValue: boolean;
    salesTaxCountyIndicatorValueSpecified: boolean;
    salesTaxCountyIndicator: boolean | null;
    salesTaxStateIndicatorValue: boolean;
    salesTaxStateIndicatorValueSpecified: boolean;
    salesTaxStateIndicator: boolean | null;
    securedCodeValue: boolean;
    securedCodeValueSpecified: boolean;
    securedCode: boolean | null;
    seg0DescriptionValue: boolean;
    seg0DescriptionValueSpecified: boolean;
    seg0Description: boolean | null;
    seg0PaymentOrderValue: boolean;
    seg0PaymentOrderValueSpecified: boolean;
    seg0PaymentOrder: boolean | null;
    subTypeValue: boolean;
    subTypeValueSpecified: boolean;
    subType: boolean | null;
    termMonthsValue: boolean;
    termMonthsValueSpecified: boolean;
    termMonths: boolean | null;
    typeValue: boolean;
    typeValueSpecified: boolean;
    type: boolean | null;
    unamortizedFeesValue: boolean;
    unamortizedFeesValueSpecified: boolean;
    unamortizedFees: boolean | null;
    userAmount1Value: boolean;
    userAmount1ValueSpecified: boolean;
    userAmount1: boolean | null;
    userAmount10Value: boolean;
    userAmount10ValueSpecified: boolean;
    userAmount10: boolean | null;
    userAmount2Value: boolean;
    userAmount2ValueSpecified: boolean;
    userAmount2: boolean | null;
    userAmount3Value: boolean;
    userAmount3ValueSpecified: boolean;
    userAmount3: boolean | null;
    userAmount4Value: boolean;
    userAmount4ValueSpecified: boolean;
    userAmount4: boolean | null;
    userAmount5Value: boolean;
    userAmount5ValueSpecified: boolean;
    userAmount5: boolean | null;
    userAmount6Value: boolean;
    userAmount6ValueSpecified: boolean;
    userAmount6: boolean | null;
    userAmount7Value: boolean;
    userAmount7ValueSpecified: boolean;
    userAmount7: boolean | null;
    userAmount8Value: boolean;
    userAmount8ValueSpecified: boolean;
    userAmount8: boolean | null;
    userAmount9Value: boolean;
    userAmount9ValueSpecified: boolean;
    userAmount9: boolean | null;
    userChar1Value: boolean;
    userChar1ValueSpecified: boolean;
    userChar1: boolean | null;
    userChar2Value: boolean;
    userChar2ValueSpecified: boolean;
    userChar2: boolean | null;
    userChar3Value: boolean;
    userChar3ValueSpecified: boolean;
    userChar3: boolean | null;
    userChar4Value: boolean;
    userChar4ValueSpecified: boolean;
    userChar4: boolean | null;
    userCode1Value: boolean;
    userCode1ValueSpecified: boolean;
    userCode1: boolean | null;
    userCode10Value: boolean;
    userCode10ValueSpecified: boolean;
    userCode10: boolean | null;
    userCode2Value: boolean;
    userCode2ValueSpecified: boolean;
    userCode2: boolean | null;
    userCode3Value: boolean;
    userCode3ValueSpecified: boolean;
    userCode3: boolean | null;
    userCode4Value: boolean;
    userCode4ValueSpecified: boolean;
    userCode4: boolean | null;
    userCode5Value: boolean;
    userCode5ValueSpecified: boolean;
    userCode5: boolean | null;
    userCode6Value: boolean;
    userCode6ValueSpecified: boolean;
    userCode6: boolean | null;
    userCode7Value: boolean;
    userCode7ValueSpecified: boolean;
    userCode7: boolean | null;
    userCode8Value: boolean;
    userCode8ValueSpecified: boolean;
    userCode8: boolean | null;
    userCode9Value: boolean;
    userCode9ValueSpecified: boolean;
    userCode9: boolean | null;
    userDate1Value: boolean;
    userDate1ValueSpecified: boolean;
    userDate1: boolean | null;
    userDate10Value: boolean;
    userDate10ValueSpecified: boolean;
    userDate10: boolean | null;
    userDate2Value: boolean;
    userDate2ValueSpecified: boolean;
    userDate2: boolean | null;
    userDate3Value: boolean;
    userDate3ValueSpecified: boolean;
    userDate3: boolean | null;
    userDate4Value: boolean;
    userDate4ValueSpecified: boolean;
    userDate4: boolean | null;
    userDate5Value: boolean;
    userDate5ValueSpecified: boolean;
    userDate5: boolean | null;
    userDate6Value: boolean;
    userDate6ValueSpecified: boolean;
    userDate6: boolean | null;
    userDate7Value: boolean;
    userDate7ValueSpecified: boolean;
    userDate7: boolean | null;
    userDate8Value: boolean;
    userDate8ValueSpecified: boolean;
    userDate8: boolean | null;
    userDate9Value: boolean;
    userDate9ValueSpecified: boolean;
    userDate9: boolean | null;
    userNumber1Value: boolean;
    userNumber1ValueSpecified: boolean;
    userNumber1: boolean | null;
    userNumber2Value: boolean;
    userNumber2ValueSpecified: boolean;
    userNumber2: boolean | null;
    userRate1Value: boolean;
    userRate1ValueSpecified: boolean;
    userRate1: boolean | null;
    userRate2Value: boolean;
    userRate2ValueSpecified: boolean;
    userRate2: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
