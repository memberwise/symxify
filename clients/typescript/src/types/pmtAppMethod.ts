import { PmtAppMethodCurrentExcessOrder } from "./pmtAppMethodCurrentExcessOrder";
import { PmtAppMethodDqExcessOrder } from "./pmtAppMethodDqExcessOrder";
import { PmtAppMethodGracePmtExcessOrder } from "./pmtAppMethodGracePmtExcessOrder";
import { PmtAppMethodPaymentOrder } from "./pmtAppMethodPaymentOrder";
import { PmtAppMethodPrepaidExcessOrder } from "./pmtAppMethodPrepaidExcessOrder";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface PmtAppMethod {
    createAddlPrincipalCommentValue: boolean;
    createAddlPrincipalCommentValueSpecified: boolean;
    createAddlPrincipalComment: boolean | null;
    currentExcessOrder: PmtAppMethodCurrentExcessOrder[];
    currentExcessOrderSpecified: boolean;
    definedCodeValue: number;
    definedCodeValueSpecified: boolean;
    definedCode: number | null;
    description: string;
    dqExcessOrder: PmtAppMethodDqExcessOrder[];
    dqExcessOrderSpecified: boolean;
    gracePmtExcessOrder: PmtAppMethodGracePmtExcessOrder[];
    gracePmtExcessOrderSpecified: boolean;
    includeEscrowUnpdinPmtDueValue: boolean;
    includeEscrowUnpdinPmtDueValueSpecified: boolean;
    includeEscrowUnpdinPmtDue: boolean | null;
    paymentOrder: PmtAppMethodPaymentOrder[];
    paymentOrderSpecified: boolean;
    prepaidExcessOrder: PmtAppMethodPrepaidExcessOrder[];
    prepaidExcessOrderSpecified: boolean;
    thresholdPaymentIndicatorValue: number;
    thresholdPaymentIndicatorValueSpecified: boolean;
    thresholdPaymentIndicator: number | null;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}