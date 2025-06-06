import { VersionType } from "./versionType";
export interface CheckOrderDefaultFields {
    accent: boolean | null;
    acctAddrInkColor: boolean | null;
    billingCode: boolean | null;
    branch: boolean | null;
    busBindingStyle: boolean | null;
    busCaptions: number[];
    busNumCopies: boolean | null;
    busVoucherNumber: boolean | null;
    businessSerial: boolean | null;
    chargeShipping: boolean | null;
    checkOrderProcessor: boolean | null;
    checkStyle: boolean | null;
    checkType: boolean | null;
    coverStyle: boolean | null;
    cutInkColor: boolean | null;
    cutNumber: boolean | null;
    imprintFont: boolean | null;
    imprintJustify: boolean | null;
    lastOrderDate: boolean | null;
    numberSigLines: boolean | null;
    overSigFont: boolean | null;
    overSigJustify: boolean | null;
    phantom: boolean | null;
    poNumber: boolean | null;
    processor: boolean | null;
    promoNumber: boolean | null;
    quantity: boolean | null;
    rerunReason: boolean | null;
    shipMethod: boolean | null;
    shipTo: boolean | null;
    sigFigure: boolean | null;
    startNumber: boolean | null;
    taxExemptCode: boolean | null;
    titleInkColor: boolean | null;
    version1: VersionType;
}
