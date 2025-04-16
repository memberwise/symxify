import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface LoanLnSegmentBilling_2 {
    billedDateValue: string | null;
    billedDateValueSpecified: boolean;
    billedDate: string | null;
    dueDateValue: string | null;
    dueDateValueSpecified: boolean;
    dueDate: string | null;
    escrowBilledValue: number;
    escrowBilledValueSpecified: boolean;
    escrowBilled: number | null;
    escrowPeriodValue: number;
    escrowPeriodValueSpecified: boolean;
    escrowPeriod: number | null;
    escrowRemainValue: number;
    escrowRemainValueSpecified: boolean;
    escrowRemain: number | null;
    feesBilledValue: number;
    feesBilledValueSpecified: boolean;
    feesBilled: number | null;
    feesRemainValue: number;
    feesRemainValueSpecified: boolean;
    feesRemain: number | null;
    id: string;
    interestBilledValue: number;
    interestBilledValueSpecified: boolean;
    interestBilled: number | null;
    interestRemainValue: number;
    interestRemainValueSpecified: boolean;
    interestRemain: number | null;
    lastPaymentDateValue: string | null;
    lastPaymentDateValueSpecified: boolean;
    lastPaymentDate: string | null;
    lateChargeBilledValue: number;
    lateChargeBilledValueSpecified: boolean;
    lateChargeBilled: number | null;
    lateChargePeriodValue: number;
    lateChargePeriodValueSpecified: boolean;
    lateChargePeriod: number | null;
    lateChargeRemainValue: number;
    lateChargeRemainValueSpecified: boolean;
    lateChargeRemain: number | null;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    paymentValue: number;
    paymentValueSpecified: boolean;
    payment: number | null;
    princIntBilledValue: number;
    princIntBilledValueSpecified: boolean;
    princIntBilled: number | null;
    princIntRemainValue: number;
    princIntRemainValueSpecified: boolean;
    princIntRemain: number | null;
    principalBilledValue: number;
    principalBilledValueSpecified: boolean;
    principalBilled: number | null;
    principalRemainValue: number;
    principalRemainValueSpecified: boolean;
    principalRemain: number | null;
    recordChangeDateValue: string | null;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    salesTaxBilledValue: number;
    salesTaxBilledValueSpecified: boolean;
    salesTaxBilled: number | null;
    salesTaxRemainValue: number;
    salesTaxRemainValueSpecified: boolean;
    salesTaxRemain: number | null;
    statusIndicatorValue: number;
    statusIndicatorValueSpecified: boolean;
    statusIndicator: number | null;
    totalBilledValue: number;
    totalBilledValueSpecified: boolean;
    totalBilled: number | null;
    totalRemainIngValue: number;
    totalRemainIngValueSpecified: boolean;
    totalRemainIng: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}