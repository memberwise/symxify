import { InvoiceList } from "./invoiceList";
import { VendorFmHistoryList } from "./vendorFmHistoryList";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface Vendor {
    achGroupNumber: string;
    addressTypeValue: number;
    addressTypeValueSpecified: boolean;
    addressType: number | null;
    altEmail: string;
    city: string;
    comment1: string;
    companyDisc: string;
    companyEntryDesc: string;
    contact: string;
    contact2: string;
    contact2Desc: string;
    contact2Ext: string;
    contact2Phone: string;
    contactDesc: string;
    creditLastYearValue: number;
    creditLastYearValueSpecified: boolean;
    creditLastYear: number | null;
    creditYtdValue: number;
    creditYtdValueSpecified: boolean;
    creditYtd: number | null;
    customerId: string;
    debitLastYearValue: number;
    debitLastYearValueSpecified: boolean;
    debitLastYear: number | null;
    debitYtdValue: number;
    debitYtdValueSpecified: boolean;
    debitYtd: number | null;
    dfiAccount: string;
    email: string;
    extraAddress: string;
    fax: string;
    fmLastPurgeDateValue: string;
    fmLastPurgeDateValueSpecified: boolean;
    fmLastPurgeDate: string | null;
    glAcctsPay: string;
    glDiscount: string;
    glExpense: string;
    glNameAcctsPay: string;
    glNameDiscount: string;
    glNameExpense: string;
    invoiceList: InvoiceList;
    irsAmountCodeValue: number;
    irsAmountCodeValueSpecified: boolean;
    irsAmountCode: number | null;
    irsCorrectionValue: number;
    irsCorrectionValueSpecified: boolean;
    irsCorrection: number | null;
    irsNameControl: string;
    irsReportingValue: number;
    irsReportingValueSpecified: boolean;
    irsReporting: number | null;
    irsReportingName: string;
    lastFmDateValue: string;
    lastFmDateValueSpecified: boolean;
    lastFmDate: string | null;
    lastPaymentAmountValue: number;
    lastPaymentAmountValueSpecified: boolean;
    lastPaymentAmount: number | null;
    lastPaymentDateValue: string;
    lastPaymentDateValueSpecified: boolean;
    lastPaymentDate: string | null;
    name: string;
    number: string;
    payee: string;
    phone: string;
    phoneExtension: string;
    rdfiRt: string;
    receivingComp: string;
    recordChangeDateValue: string;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    restrictionLevelValue: number;
    restrictionLevelValueSpecified: boolean;
    restrictionLevel: number | null;
    ssn: string;
    ssnTypeValue: number;
    ssnTypeValueSpecified: boolean;
    ssnType: number | null;
    state: string;
    street: string;
    unpaidBalanceValue: number;
    unpaidBalanceValueSpecified: boolean;
    unpaidBalance: number | null;
    vendorFmHistoryList: VendorFmHistoryList;
    zipCode: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}