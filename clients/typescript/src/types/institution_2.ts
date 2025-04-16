import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface Institution_2 {
    branchValue: number;
    branchValueSpecified: boolean;
    branch: number | null;
    cfpbWebAddress1: string;
    cfpbWebAddress2: string;
    city: string;
    countryCode: string;
    ctrApprover: string;
    ctrApproverTitle: string;
    ctrContact: string;
    ctrContactPhone: string;
    ctrContactPhoneExt: string;
    ctrPreparer: string;
    ein: string;
    extraAddress: string;
    fiEmail: string;
    fiPhone: string;
    hudPhone: string;
    hudWebAddress1: string;
    hudWebAddress2: string;
    name: string;
    routingNumber: string;
    state: string;
    street: string;
    telephone: string;
    websiteAddr: string;
    zipCode: string;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}