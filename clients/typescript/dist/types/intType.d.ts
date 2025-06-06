import { IntTypeBalXferVarRateIndicator } from "./intTypeBalXferVarRateIndicator";
import { IntTypeBalanceXfrInterestRate } from "./intTypeBalanceXfrInterestRate";
import { IntTypeBalanceXfrSplitBal } from "./intTypeBalanceXfrSplitBal";
import { IntTypeBalanceXfrSplitRate } from "./intTypeBalanceXfrSplitRate";
import { IntTypeCashAdvVarRateIndicator } from "./intTypeCashAdvVarRateIndicator";
import { IntTypeCashAdvanceInterestRate } from "./intTypeCashAdvanceInterestRate";
import { IntTypeCashAdvanceSplitBal } from "./intTypeCashAdvanceSplitBal";
import { IntTypeCashAdvanceSplitRate } from "./intTypeCashAdvanceSplitRate";
import { IntTypePromoBtDraftRangeHigh } from "./intTypePromoBtDraftRangeHigh";
import { IntTypePromoBtDraftRangeLow } from "./intTypePromoBtDraftRangeLow";
import { IntTypePromoCaDraftRangeHigh } from "./intTypePromoCaDraftRangeHigh";
import { IntTypePromoCaDraftRangeLow } from "./intTypePromoCaDraftRangeLow";
import { IntTypePromoExpirationDate } from "./intTypePromoExpirationDate";
import { IntTypePromoExpirationDays } from "./intTypePromoExpirationDays";
import { IntTypePromoNewTransApplication } from "./intTypePromoNewTransApplication";
import { IntTypePromoTerminationDate } from "./intTypePromoTerminationDate";
import { IntTypePromoTerminationDays } from "./intTypePromoTerminationDays";
import { IntTypePurchaseInterestRate } from "./intTypePurchaseInterestRate";
import { IntTypePurchaseSplitBal } from "./intTypePurchaseSplitBal";
import { IntTypePurchaseSplitRate } from "./intTypePurchaseSplitRate";
import { IntTypePurchaseVarRateIndicator } from "./intTypePurchaseVarRateIndicator";
import { IntTypeRateSetPmtApplication } from "./intTypeRateSetPmtApplication";
import { VersionType } from "./versionType";
export interface IntType {
    balXferVarRateIndicator: IntTypeBalXferVarRateIndicator[];
    balanceXfrGraceOption: number | null;
    balanceXfrInterestRate: IntTypeBalanceXfrInterestRate[];
    balanceXfrSplitBal: IntTypeBalanceXfrSplitBal[];
    balanceXfrSplitRate: IntTypeBalanceXfrSplitRate[];
    balanceXfrTranBase: number | null;
    balanceXfrTranFeeCode: number | null;
    balanceXfrTranMax: number | null;
    balanceXfrTranMin: number | null;
    balanceXfrTranOption: number | null;
    balanceXfrTranRate: number | null;
    btDraftRangeHigh: string;
    btDraftRangeLow: string;
    btInterestPeriodOption: number | null;
    caDraftRangeHigh: string;
    caDraftRangeLow: string;
    caInterestPeriodOption: number | null;
    cashAdvTranBase: number | null;
    cashAdvTranFeeCode: number | null;
    cashAdvTranMax: number | null;
    cashAdvTranMin: number | null;
    cashAdvTranOption: number | null;
    cashAdvTranRate: number | null;
    cashAdvVarRateIndicator: IntTypeCashAdvVarRateIndicator[];
    cashAdvanceGraceOption: number | null;
    cashAdvanceInterestRate: IntTypeCashAdvanceInterestRate[];
    cashAdvanceSplitBal: IntTypeCashAdvanceSplitBal[];
    cashAdvanceSplitRate: IntTypeCashAdvanceSplitRate[];
    creditBalanceOption: number | null;
    cutoffDefaultDays: number | null;
    cutoffDefaultOption: number | null;
    description: string;
    fixedPaymentServiceCode: number | null;
    graceApplicationOrder: string;
    graceCreditVoucherOption: number | null;
    graceDayCount: number | null;
    gracePeriodEligibility: number | null;
    interestType: number | null;
    interestTypeMethod: number | null;
    maximumApr: number | null;
    paymentApplication: string;
    paymentCalculationType: number | null;
    paymentMinimum: number | null;
    paymentOrder: number | null;
    paymentOverlimitOption: number | null;
    paymentPercentage: number | null;
    paymentRoundToIncrement: number | null;
    paymentRoundingMethod: number | null;
    pmtApplicationPriority: string;
    promoBtDraftRangeHigh: IntTypePromoBtDraftRangeHigh[];
    promoBtDraftRangeLow: IntTypePromoBtDraftRangeLow[];
    promoCaDraftRangeHigh: IntTypePromoCaDraftRangeHigh[];
    promoCaDraftRangeLow: IntTypePromoCaDraftRangeLow[];
    promoExpirationDate: IntTypePromoExpirationDate[];
    promoExpirationDays: IntTypePromoExpirationDays[];
    promoNewTransApplication: IntTypePromoNewTransApplication[];
    promoTerminationDate: IntTypePromoTerminationDate[];
    promoTerminationDays: IntTypePromoTerminationDays[];
    puInterestPeriodOption: number | null;
    purchaseGraceOption: number | null;
    purchaseInterestRate: IntTypePurchaseInterestRate[];
    purchaseSplitBal: IntTypePurchaseSplitBal[];
    purchaseSplitRate: IntTypePurchaseSplitRate[];
    purchaseVarRateIndicator: IntTypePurchaseVarRateIndicator[];
    rateSetPmtApplication: IntTypeRateSetPmtApplication[];
    version1: VersionType;
}
