import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface LoanAppFields {
    accountTypeValue: boolean;
    accountTypeValueSpecified: boolean;
    accountType: boolean | null;
    amortizationSchdValue: boolean;
    amortizationSchdValueSpecified: boolean;
    amortizationSchd: boolean | null;
    amortizationSchdTypeValue: boolean;
    amortizationSchdTypeValueSpecified: boolean;
    amortizationSchdType: boolean | null;
    applicationDateValue: boolean;
    applicationDateValueSpecified: boolean;
    applicationDate: boolean | null;
    applyAsBilledValue: boolean;
    applyAsBilledValueSpecified: boolean;
    applyAsBilled: boolean | null;
    appraisalOffsetValue: boolean;
    appraisalOffsetValueSpecified: boolean;
    appraisalOffset: boolean | null;
    appraisedAmountValue: boolean;
    appraisedAmountValueSpecified: boolean;
    appraisedAmount: boolean | null;
    approvalAmountValue: boolean;
    approvalAmountValueSpecified: boolean;
    approvalAmount: boolean | null;
    approvalCodeValue: boolean;
    approvalCodeValueSpecified: boolean;
    approvalCode: boolean | null;
    approvalDateValue: boolean;
    approvalDateValueSpecified: boolean;
    approvalDate: boolean | null;
    aprValue: boolean;
    aprValueSpecified: boolean;
    apr: boolean | null;
    assessorParcelNumberValue: boolean;
    assessorParcelNumberValueSpecified: boolean;
    assessorParcelNumber: boolean | null;
    balloonAmountValue: boolean;
    balloonAmountValueSpecified: boolean;
    balloonAmount: boolean | null;
    balloonDateValue: boolean;
    balloonDateValueSpecified: boolean;
    balloonDate: boolean | null;
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
    borrowDateValue: boolean;
    borrowDateValueSpecified: boolean;
    borrowDate: boolean | null;
    branchValue: boolean;
    branchValueSpecified: boolean;
    branch: boolean | null;
    btLimitMaxValue: boolean;
    btLimitMaxValueSpecified: boolean;
    btLimitMax: boolean | null;
    btPercentValue: boolean;
    btPercentValueSpecified: boolean;
    btPercent: boolean | null;
    bureauScore: number[];
    bureauScoreSpecified: boolean;
    caLimitMaxValue: boolean;
    caLimitMaxValueSpecified: boolean;
    caLimitMax: boolean | null;
    caPercentValue: boolean;
    caPercentValueSpecified: boolean;
    caPercent: boolean | null;
    callItemSchdValue: boolean;
    callItemSchdValueSpecified: boolean;
    callItemSchd: boolean | null;
    callItemSchdTypeValue: boolean;
    callItemSchdTypeValueSpecified: boolean;
    callItemSchdType: boolean | null;
    cancellationDateValue: boolean;
    cancellationDateValueSpecified: boolean;
    cancellationDate: boolean | null;
    cbiLocator: number[];
    cbiLocatorSpecified: boolean;
    censusTractValue: boolean;
    censusTractValueSpecified: boolean;
    censusTract: boolean | null;
    citySalesTaxRateValue: boolean;
    citySalesTaxRateValueSpecified: boolean;
    citySalesTaxRate: boolean | null;
    closingDateValue: boolean;
    closingDateValueSpecified: boolean;
    closingDate: boolean | null;
    cntySalesTaxRateValue: boolean;
    cntySalesTaxRateValueSpecified: boolean;
    cntySalesTaxRate: boolean | null;
    collateralCodeValue: boolean;
    collateralCodeValueSpecified: boolean;
    collateralCode: boolean | null;
    collateralDateValue: boolean;
    collateralDateValueSpecified: boolean;
    collateralDate: boolean | null;
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
    completedActions: number[];
    completedActionsSpecified: boolean;
    counterOfferExpireDateValue: boolean;
    counterOfferExpireDateValueSpecified: boolean;
    counterOfferExpireDate: boolean | null;
    counteredOrigAmtValue: boolean;
    counteredOrigAmtValueSpecified: boolean;
    counteredOrigAmt: boolean | null;
    createdAtBranchValue: boolean;
    createdAtBranchValueSpecified: boolean;
    createdAtBranch: boolean | null;
    createdByUserValue: boolean;
    createdByUserValueSpecified: boolean;
    createdByUser: boolean | null;
    creationDateValue: boolean;
    creationDateValueSpecified: boolean;
    creationDate: boolean | null;
    creditBureauValue: boolean;
    creditBureauValueSpecified: boolean;
    creditBureau: boolean | null;
    creditLimitValue: boolean;
    creditLimitValueSpecified: boolean;
    creditLimit: boolean | null;
    creditScoreValue: boolean;
    creditScoreValueSpecified: boolean;
    creditScore: boolean | null;
    creditScoreTypeValue: boolean;
    creditScoreTypeValueSpecified: boolean;
    creditScoreType: boolean | null;
    cuTotalCertIrasValue: boolean;
    cuTotalCertIrasValueSpecified: boolean;
    cuTotalCertIras: boolean | null;
    cuTotalClosedEndLoansValue: boolean;
    cuTotalClosedEndLoansValueSpecified: boolean;
    cuTotalClosedEndLoans: boolean | null;
    cuTotalClosedEndPaymentsValue: boolean;
    cuTotalClosedEndPaymentsValueSpecified: boolean;
    cuTotalClosedEndPayments: boolean | null;
    cuTotalCredCardPaymentsValue: boolean;
    cuTotalCredCardPaymentsValueSpecified: boolean;
    cuTotalCredCardPayments: boolean | null;
    cuTotalCreditCardLoansValue: boolean;
    cuTotalCreditCardLoansValueSpecified: boolean;
    cuTotalCreditCardLoans: boolean | null;
    cuTotalCreditLimitValue: boolean;
    cuTotalCreditLimitValueSpecified: boolean;
    cuTotalCreditLimit: boolean | null;
    cuTotalDraftsValue: boolean;
    cuTotalDraftsValueSpecified: boolean;
    cuTotalDrafts: boolean | null;
    cuTotalLocLoansValue: boolean;
    cuTotalLocLoansValueSpecified: boolean;
    cuTotalLocLoans: boolean | null;
    cuTotalLocPaymentsValue: boolean;
    cuTotalLocPaymentsValueSpecified: boolean;
    cuTotalLocPayments: boolean | null;
    cuTotalOpenEndLoansValue: boolean;
    cuTotalOpenEndLoansValueSpecified: boolean;
    cuTotalOpenEndLoans: boolean | null;
    cuTotalOpenEndPaymentsValue: boolean;
    cuTotalOpenEndPaymentsValueSpecified: boolean;
    cuTotalOpenEndPayments: boolean | null;
    cuTotalSharesValue: boolean;
    cuTotalSharesValueSpecified: boolean;
    cuTotalShares: boolean | null;
    cuTotalsAcctNumber: number[];
    cuTotalsAcctNumberSpecified: boolean;
    dealerCityValue: boolean;
    dealerCityValueSpecified: boolean;
    dealerCity: boolean | null;
    dealerCodeValue: boolean;
    dealerCodeValueSpecified: boolean;
    dealerCode: boolean | null;
    dealerCountyValue: boolean;
    dealerCountyValueSpecified: boolean;
    dealerCounty: boolean | null;
    dealerReserveValue: boolean;
    dealerReserveValueSpecified: boolean;
    dealerReserve: boolean | null;
    dealerStateValue: boolean;
    dealerStateValueSpecified: boolean;
    dealerState: boolean | null;
    debtRatio: number[];
    debtRatioSpecified: boolean;
    debtRatioType: number[];
    debtRatioTypeSpecified: boolean;
    decisionCodeValue: boolean;
    decisionCodeValueSpecified: boolean;
    decisionCode: boolean | null;
    decisionDateValue: boolean;
    decisionDateValueSpecified: boolean;
    decisionDate: boolean | null;
    denialDateValue: boolean;
    denialDateValueSpecified: boolean;
    denialDate: boolean | null;
    denialReason: number[];
    denialReasonSpecified: boolean;
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
    escrowAmountValue: boolean;
    escrowAmountValueSpecified: boolean;
    escrowAmount: boolean | null;
    escrowIdValue: boolean;
    escrowIdValueSpecified: boolean;
    escrowId: boolean | null;
    eventValue: boolean;
    eventValueSpecified: boolean;
    event: boolean | null;
    eventDateValue: boolean;
    eventDateValueSpecified: boolean;
    eventDate: boolean | null;
    exceedLevelPmtAmtValue: boolean;
    exceedLevelPmtAmtValueSpecified: boolean;
    exceedLevelPmtAmt: boolean | null;
    existIngLoanBalanceValue: boolean;
    existIngLoanBalanceValueSpecified: boolean;
    existIngLoanBalance: boolean | null;
    existIngLoanIdValue: boolean;
    existIngLoanIdValueSpecified: boolean;
    existIngLoanId: boolean | null;
    expirationDateValue: boolean;
    expirationDateValueSpecified: boolean;
    expirationDate: boolean | null;
    fasb91CodeValue: boolean;
    fasb91CodeValueSpecified: boolean;
    fasb91Code: boolean | null;
    firstDueDateValue: boolean;
    firstDueDateValueSpecified: boolean;
    firstDueDate: boolean | null;
    firstInsBirthDateValue: boolean;
    firstInsBirthDateValueSpecified: boolean;
    firstInsBirthDate: boolean | null;
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
    grossMonthlyPay1Value: boolean;
    grossMonthlyPay1ValueSpecified: boolean;
    grossMonthlyPay1: boolean | null;
    grossMonthlyPay2Value: boolean;
    grossMonthlyPay2ValueSpecified: boolean;
    grossMonthlyPay2: boolean | null;
    highRiskCodeValue: boolean;
    highRiskCodeValueSpecified: boolean;
    highRiskCode: boolean | null;
    hmdaActionTakenValue: boolean;
    hmdaActionTakenValueSpecified: boolean;
    hmdaActionTaken: boolean | null;
    hmdaActionTakenDateValue: boolean;
    hmdaActionTakenDateValueSpecified: boolean;
    hmdaActionTakenDate: boolean | null;
    hmdaAnnualIncomeValue: boolean;
    hmdaAnnualIncomeValueSpecified: boolean;
    hmdaAnnualIncome: boolean | null;
    hmdaAnnualIncomeNaValue: boolean;
    hmdaAnnualIncomeNaValueSpecified: boolean;
    hmdaAnnualIncomeNa: boolean | null;
    hmdaApplicationDateNaValue: boolean;
    hmdaApplicationDateNaValueSpecified: boolean;
    hmdaApplicationDateNa: boolean | null;
    hmdaAutoUnderwritingResOther: number[];
    hmdaAutoUnderwritingResOtherSpecified: boolean;
    hmdaAutoUnderwritingResult: number[];
    hmdaAutoUnderwritingResultSpecified: boolean;
    hmdaAutoUnderwritingSys: number[];
    hmdaAutoUnderwritingSysSpecified: boolean;
    hmdaAutoUnderwritingSysOther: number[];
    hmdaAutoUnderwritingSysOtherSpecified: boolean;
    hmdaBusOrCommPurposeIndValue: boolean;
    hmdaBusOrCommPurposeIndValueSpecified: boolean;
    hmdaBusOrCommPurposeInd: boolean | null;
    hmdaCensusTractValue: boolean;
    hmdaCensusTractValueSpecified: boolean;
    hmdaCensusTract: boolean | null;
    hmdaCensusTractNaValue: boolean;
    hmdaCensusTractNaValueSpecified: boolean;
    hmdaCensusTractNa: boolean | null;
    hmdaConstructionMethodValue: boolean;
    hmdaConstructionMethodValueSpecified: boolean;
    hmdaConstructionMethod: boolean | null;
    hmdaDebtRationAValue: boolean;
    hmdaDebtRationAValueSpecified: boolean;
    hmdaDebtRationA: boolean | null;
    hmdaDenialReasonOther: number[];
    hmdaDenialReasonOtherSpecified: boolean;
    hmdaDiscountPointsValue: boolean;
    hmdaDiscountPointsValueSpecified: boolean;
    hmdaDiscountPoints: boolean | null;
    hmdaDiscountPointsNaValue: boolean;
    hmdaDiscountPointsNaValueSpecified: boolean;
    hmdaDiscountPointsNa: boolean | null;
    hmdaHoePastAtUsValue: boolean;
    hmdaHoePastAtUsValueSpecified: boolean;
    hmdaHoePastAtUs: boolean | null;
    hmdaInitPayableToInstValue: boolean;
    hmdaInitPayableToInstValueSpecified: boolean;
    hmdaInitPayableToInst: boolean | null;
    hmdaIntOnlyPmtIndValue: boolean;
    hmdaIntOnlyPmtIndValueSpecified: boolean;
    hmdaIntOnlyPmtInd: boolean | null;
    hmdaInterestRateNaValue: boolean;
    hmdaInterestRateNaValueSpecified: boolean;
    hmdaInterestRateNa: boolean | null;
    hmdaIntroRatePeriodValue: boolean;
    hmdaIntroRatePeriodValueSpecified: boolean;
    hmdaIntroRatePeriod: boolean | null;
    hmdaIntroRatePeriodNaValue: boolean;
    hmdaIntroRatePeriodNaValueSpecified: boolean;
    hmdaIntroRatePeriodNa: boolean | null;
    hmdaLenderCreditsValue: boolean;
    hmdaLenderCreditsValueSpecified: boolean;
    hmdaLenderCredits: boolean | null;
    hmdaLenderCreditsNaValue: boolean;
    hmdaLenderCreditsNaValueSpecified: boolean;
    hmdaLenderCreditsNa: boolean | null;
    hmdaLienStatusValue: boolean;
    hmdaLienStatusValueSpecified: boolean;
    hmdaLienStatus: boolean | null;
    hmdaLoanPurposeValue: boolean;
    hmdaLoanPurposeValueSpecified: boolean;
    hmdaLoanPurpose: boolean | null;
    hmdaLoanTermNaValue: boolean;
    hmdaLoanTermNaValueSpecified: boolean;
    hmdaLoanTermNa: boolean | null;
    hmdaLoanToValueNaValue: boolean;
    hmdaLoanToValueNaValueSpecified: boolean;
    hmdaLoanToValueNa: boolean | null;
    hmdaLoanTypeValue: boolean;
    hmdaLoanTypeValueSpecified: boolean;
    hmdaLoanType: boolean | null;
    hmdaMfdHomeSecPropTypeValue: boolean;
    hmdaMfdHomeSecPropTypeValueSpecified: boolean;
    hmdaMfdHomeSecPropType: boolean | null;
    hmdaMfdHomelandPropIntValue: boolean;
    hmdaMfdHomelandPropIntValueSpecified: boolean;
    hmdaMfdHomelandPropInt: boolean | null;
    hmdaMultifamilyAffordUnitsValue: boolean;
    hmdaMultifamilyAffordUnitsValueSpecified: boolean;
    hmdaMultifamilyAffordUnits: boolean | null;
    hmdaMultifamilyAffordUnitsNaValue: boolean;
    hmdaMultifamilyAffordUnitsNaValueSpecified: boolean;
    hmdaMultifamilyAffordUnitsNa: boolean | null;
    hmdaNegAmortIndValue: boolean;
    hmdaNegAmortIndValueSpecified: boolean;
    hmdaNegAmortInd: boolean | null;
    hmdaNmlsrIdValue: boolean;
    hmdaNmlsrIdValueSpecified: boolean;
    hmdaNmlsrId: boolean | null;
    hmdaNmlsrIdNaValue: boolean;
    hmdaNmlsrIdNaValueSpecified: boolean;
    hmdaNmlsrIdNa: boolean | null;
    hmdaOccupancyTypeValue: boolean;
    hmdaOccupancyTypeValueSpecified: boolean;
    hmdaOccupancyType: boolean | null;
    hmdaOeLocIndValue: boolean;
    hmdaOeLocIndValueSpecified: boolean;
    hmdaOeLocInd: boolean | null;
    hmdaOriginationChargesValue: boolean;
    hmdaOriginationChargesValueSpecified: boolean;
    hmdaOriginationCharges: boolean | null;
    hmdaOriginationChargesNaValue: boolean;
    hmdaOriginationChargesNaValueSpecified: boolean;
    hmdaOriginationChargesNa: boolean | null;
    hmdaOtherNonAmortFeaturesValue: boolean;
    hmdaOtherNonAmortFeaturesValueSpecified: boolean;
    hmdaOtherNonAmortFeatures: boolean | null;
    hmdaPreapprovalValue: boolean;
    hmdaPreapprovalValueSpecified: boolean;
    hmdaPreapproval: boolean | null;
    hmdaPrepaymentPenaltyTermValue: boolean;
    hmdaPrepaymentPenaltyTermValueSpecified: boolean;
    hmdaPrepaymentPenaltyTerm: boolean | null;
    hmdaPrepaymentPenaltyTermNaValue: boolean;
    hmdaPrepaymentPenaltyTermNaValueSpecified: boolean;
    hmdaPrepaymentPenaltyTermNa: boolean | null;
    hmdaPropertyCityValue: boolean;
    hmdaPropertyCityValueSpecified: boolean;
    hmdaPropertyCity: boolean | null;
    hmdaPropertyCityNaValue: boolean;
    hmdaPropertyCityNaValueSpecified: boolean;
    hmdaPropertyCityNa: boolean | null;
    hmdaPropertyCountyValue: boolean;
    hmdaPropertyCountyValueSpecified: boolean;
    hmdaPropertyCounty: boolean | null;
    hmdaPropertyCountyNaValue: boolean;
    hmdaPropertyCountyNaValueSpecified: boolean;
    hmdaPropertyCountyNa: boolean | null;
    hmdaPropertyStateValue: boolean;
    hmdaPropertyStateValueSpecified: boolean;
    hmdaPropertyState: boolean | null;
    hmdaPropertyStateNaValue: boolean;
    hmdaPropertyStateNaValueSpecified: boolean;
    hmdaPropertyStateNa: boolean | null;
    hmdaPropertyStreetAddressValue: boolean;
    hmdaPropertyStreetAddressValueSpecified: boolean;
    hmdaPropertyStreetAddress: boolean | null;
    hmdaPropertyStreetAddressNaValue: boolean;
    hmdaPropertyStreetAddressNaValueSpecified: boolean;
    hmdaPropertyStreetAddressNa: boolean | null;
    hmdaPropertyValueValue: boolean;
    hmdaPropertyValueValueSpecified: boolean;
    hmdaPropertyValue: boolean | null;
    hmdaPropertyValueNaValue: boolean;
    hmdaPropertyValueNaValueSpecified: boolean;
    hmdaPropertyValueNa: boolean | null;
    hmdaPropertyZipCodeValue: boolean;
    hmdaPropertyZipCodeValueSpecified: boolean;
    hmdaPropertyZipCode: boolean | null;
    hmdaPropertyZipCodeNaValue: boolean;
    hmdaPropertyZipCodeNaValueSpecified: boolean;
    hmdaPropertyZipCodeNa: boolean | null;
    hmdaPurchaserTypeValue: boolean;
    hmdaPurchaserTypeValueSpecified: boolean;
    hmdaPurchaserType: boolean | null;
    hmdaRateSpreadValue: boolean;
    hmdaRateSpreadValueSpecified: boolean;
    hmdaRateSpread: boolean | null;
    hmdaRateSpreadNaValue: boolean;
    hmdaRateSpreadNaValueSpecified: boolean;
    hmdaRateSpreadNa: boolean | null;
    hmdaRateSpreadSignValue: boolean;
    hmdaRateSpreadSignValueSpecified: boolean;
    hmdaRateSpreadSign: boolean | null;
    hmdaRevMortIndValue: boolean;
    hmdaRevMortIndValueSpecified: boolean;
    hmdaRevMortInd: boolean | null;
    hmdaSubmissionOfApMethodValue: boolean;
    hmdaSubmissionOfApMethodValueSpecified: boolean;
    hmdaSubmissionOfApMethod: boolean | null;
    hmdaTotalLoanCostsValue: boolean;
    hmdaTotalLoanCostsValueSpecified: boolean;
    hmdaTotalLoanCosts: boolean | null;
    hmdaTotalLoanCostsNaValue: boolean;
    hmdaTotalLoanCostsNaValueSpecified: boolean;
    hmdaTotalLoanCostsNa: boolean | null;
    hmdaTotalPointsFeesValue: boolean;
    hmdaTotalPointsFeesValueSpecified: boolean;
    hmdaTotalPointsFees: boolean | null;
    hmdaTotalPointsFeesNaValue: boolean;
    hmdaTotalPointsFeesNaValueSpecified: boolean;
    hmdaTotalPointsFeesNa: boolean | null;
    hmdaTotalUnitsValue: boolean;
    hmdaTotalUnitsValueSpecified: boolean;
    hmdaTotalUnits: boolean | null;
    hmdaUniversalLoanIdentifier1Value: boolean;
    hmdaUniversalLoanIdentifier1ValueSpecified: boolean;
    hmdaUniversalLoanIdentifier1: boolean | null;
    hmdaUniversalLoanIdentifier2Value: boolean;
    hmdaUniversalLoanIdentifier2ValueSpecified: boolean;
    hmdaUniversalLoanIdentifier2: boolean | null;
    idValue: boolean;
    idValueSpecified: boolean;
    id: boolean | null;
    indirectDealerNumValue: boolean;
    indirectDealerNumValueSpecified: boolean;
    indirectDealerNum: boolean | null;
    indirectPlanIdValue: boolean;
    indirectPlanIdValueSpecified: boolean;
    indirectPlanId: boolean | null;
    infoRequestDateValue: boolean;
    infoRequestDateValueSpecified: boolean;
    infoRequestDate: boolean | null;
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
    lastFmDateValue: boolean;
    lastFmDateValueSpecified: boolean;
    lastFmDate: boolean | null;
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
    loanAmountValue: boolean;
    loanAmountValueSpecified: boolean;
    loanAmount: boolean | null;
    loanCodeValue: boolean;
    loanCodeValueSpecified: boolean;
    loanCode: boolean | null;
    loanDescriptionValue: boolean;
    loanDescriptionValueSpecified: boolean;
    loanDescription: boolean | null;
    loanMaturityDateValue: boolean;
    loanMaturityDateValueSpecified: boolean;
    loanMaturityDate: boolean | null;
    loanReferenceValue: boolean;
    loanReferenceValueSpecified: boolean;
    loanReference: boolean | null;
    loanToValueRatioValue: boolean;
    loanToValueRatioValueSpecified: boolean;
    loanToValueRatio: boolean | null;
    loanTypeValue: boolean;
    loanTypeValueSpecified: boolean;
    loanType: boolean | null;
    maxDueDateAdvancePeriodValue: boolean;
    maxDueDateAdvancePeriodValueSpecified: boolean;
    maxDueDateAdvancePeriod: boolean | null;
    militaryAprLoanValue: boolean;
    militaryAprLoanValueSpecified: boolean;
    militaryAprLoan: boolean | null;
    minimumPaymentValue: boolean;
    minimumPaymentValueSpecified: boolean;
    minimumPayment: boolean | null;
    mtgNumPropValue: boolean;
    mtgNumPropValueSpecified: boolean;
    mtgNumProp: boolean | null;
    netMonthlyPay1Value: boolean;
    netMonthlyPay1ValueSpecified: boolean;
    netMonthlyPay1: boolean | null;
    netMonthlyPay2Value: boolean;
    netMonthlyPay2ValueSpecified: boolean;
    netMonthlyPay2: boolean | null;
    newSegCutoffDaysValue: boolean;
    newSegCutoffDaysValueSpecified: boolean;
    newSegCutoffDays: boolean | null;
    newSegCutoffOptionValue: boolean;
    newSegCutoffOptionValueSpecified: boolean;
    newSegCutoffOption: boolean | null;
    notePurgeDateValue: boolean;
    notePurgeDateValueSpecified: boolean;
    notePurgeDate: boolean | null;
    origRiskGradeValue: boolean;
    origRiskGradeValueSpecified: boolean;
    origRiskGrade: boolean | null;
    originalRateValue: boolean;
    originalRateValueSpecified: boolean;
    originalRate: boolean | null;
    ovlAuthFeeValue: boolean;
    ovlAuthFeeValueSpecified: boolean;
    ovlAuthFee: boolean | null;
    ovlOptInValue: boolean;
    ovlOptInValueSpecified: boolean;
    ovlOptIn: boolean | null;
    paymentValue: boolean;
    paymentValueSpecified: boolean;
    payment: boolean | null;
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
    pendingDateValue: boolean;
    pendingDateValueSpecified: boolean;
    pendingDate: boolean | null;
    percentPrincipalValue: boolean;
    percentPrincipalValueSpecified: boolean;
    percentPrincipal: boolean | null;
    pmiAppraisedValueValue: boolean;
    pmiAppraisedValueValueSpecified: boolean;
    pmiAppraisedValue: boolean | null;
    pmiLtvRatioValue: boolean;
    pmiLtvRatioValueSpecified: boolean;
    pmiLtvRatio: boolean | null;
    pmiOriginalValueValue: boolean;
    pmiOriginalValueValueSpecified: boolean;
    pmiOriginalValue: boolean | null;
    pmiPurchasePriceValue: boolean;
    pmiPurchasePriceValueSpecified: boolean;
    pmiPurchasePrice: boolean | null;
    prefLocatorValue: boolean;
    prefLocatorValueSpecified: boolean;
    prefLocator: boolean | null;
    prepaidFinanceChgValue: boolean;
    prepaidFinanceChgValueSpecified: boolean;
    prepaidFinanceChg: boolean | null;
    processorCodeValue: boolean;
    processorCodeValueSpecified: boolean;
    processorCode: boolean | null;
    propertyAddressTypeValue: boolean;
    propertyAddressTypeValueSpecified: boolean;
    propertyAddressType: boolean | null;
    propertyJurisdictionValue: boolean;
    propertyJurisdictionValueSpecified: boolean;
    propertyJurisdiction: boolean | null;
    purposeCodeValue: boolean;
    purposeCodeValueSpecified: boolean;
    purposeCode: boolean | null;
    putItemSchdValue: boolean;
    putItemSchdValueSpecified: boolean;
    putItemSchd: boolean | null;
    putItemSchdTypeValue: boolean;
    putItemSchdTypeValueSpecified: boolean;
    putItemSchdType: boolean | null;
    queueValue: boolean;
    queueValueSpecified: boolean;
    queue: boolean | null;
    queueDateValue: boolean;
    queueDateValueSpecified: boolean;
    queueDate: boolean | null;
    queuePriorityValue: boolean;
    queuePriorityValueSpecified: boolean;
    queuePriority: boolean | null;
    queueTimeValue: boolean;
    queueTimeValueSpecified: boolean;
    queueTime: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    riskRateValue: boolean;
    riskRateValueSpecified: boolean;
    riskRate: boolean | null;
    salesTaxCityIndicatorValue: boolean;
    salesTaxCityIndicatorValueSpecified: boolean;
    salesTaxCityIndicator: boolean | null;
    salesTaxCountyIndicatorValue: boolean;
    salesTaxCountyIndicatorValueSpecified: boolean;
    salesTaxCountyIndicator: boolean | null;
    salesTaxRateValue: boolean;
    salesTaxRateValueSpecified: boolean;
    salesTaxRate: boolean | null;
    salesTaxStateIndicatorValue: boolean;
    salesTaxStateIndicatorValueSpecified: boolean;
    salesTaxStateIndicator: boolean | null;
    secondAppPaymentValue: boolean;
    secondAppPaymentValueSpecified: boolean;
    secondAppPayment: boolean | null;
    secondAppRequestValue: boolean;
    secondAppRequestValueSpecified: boolean;
    secondAppRequest: boolean | null;
    secondAppRequestAmtValue: boolean;
    secondAppRequestAmtValueSpecified: boolean;
    secondAppRequestAmt: boolean | null;
    secondInsBirthDateValue: boolean;
    secondInsBirthDateValueSpecified: boolean;
    secondInsBirthDate: boolean | null;
    securedCodeValue: boolean;
    securedCodeValueSpecified: boolean;
    securedCode: boolean | null;
    seg0DescriptionValue: boolean;
    seg0DescriptionValueSpecified: boolean;
    seg0Description: boolean | null;
    seg0PaymentValue: boolean;
    seg0PaymentValueSpecified: boolean;
    seg0Payment: boolean | null;
    seg0PaymentOrderValue: boolean;
    seg0PaymentOrderValueSpecified: boolean;
    seg0PaymentOrder: boolean | null;
    singlePremiumDisabilityValue: boolean;
    singlePremiumDisabilityValueSpecified: boolean;
    singlePremiumDisability: boolean | null;
    singlePremiumLifeValue: boolean;
    singlePremiumLifeValueSpecified: boolean;
    singlePremiumLife: boolean | null;
    stateSalesTaxRateValue: boolean;
    stateSalesTaxRateValueSpecified: boolean;
    stateSalesTaxRate: boolean | null;
    subTypeValue: boolean;
    subTypeValueSpecified: boolean;
    subType: boolean | null;
    termMonthsValue: boolean;
    termMonthsValueSpecified: boolean;
    termMonths: boolean | null;
    thirdAppPaymentValue: boolean;
    thirdAppPaymentValueSpecified: boolean;
    thirdAppPayment: boolean | null;
    thirdAppRequestValue: boolean;
    thirdAppRequestValueSpecified: boolean;
    thirdAppRequest: boolean | null;
    thirdAppRequestAmtValue: boolean;
    thirdAppRequestAmtValueSpecified: boolean;
    thirdAppRequestAmt: boolean | null;
    totalAssetsValue: boolean;
    totalAssetsValueSpecified: boolean;
    totalAssets: boolean | null;
    totalCreditLimitsValue: boolean;
    totalCreditLimitsValueSpecified: boolean;
    totalCreditLimits: boolean | null;
    totalExpensesValue: boolean;
    totalExpensesValueSpecified: boolean;
    totalExpenses: boolean | null;
    totalIncomeValue: boolean;
    totalIncomeValueSpecified: boolean;
    totalIncome: boolean | null;
    totalLiabilitiesValue: boolean;
    totalLiabilitiesValueSpecified: boolean;
    totalLiabilities: boolean | null;
    transferAccountIdValue: boolean;
    transferAccountIdValueSpecified: boolean;
    transferAccountId: boolean | null;
    transferAccountNumberValue: boolean;
    transferAccountNumberValueSpecified: boolean;
    transferAccountNumber: boolean | null;
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
    userQueueValue: boolean;
    userQueueValueSpecified: boolean;
    userQueue: boolean | null;
    userRate1Value: boolean;
    userRate1ValueSpecified: boolean;
    userRate1: boolean | null;
    userRate2Value: boolean;
    userRate2ValueSpecified: boolean;
    userRate2: boolean | null;
    vinValue: boolean;
    vinValueSpecified: boolean;
    vin: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}