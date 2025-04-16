import { PmtAppMethodCurrentExcessOrder_2 } from "./pmtAppMethodCurrentExcessOrder_2";
import { PmtAppMethodDqExcessOrder_2 } from "./pmtAppMethodDqExcessOrder_2";
import { PmtAppMethodGracePmtExcessOrder_2 } from "./pmtAppMethodGracePmtExcessOrder_2";
import { PmtAppMethodPaymentOrder_2 } from "./pmtAppMethodPaymentOrder_2";
import { PmtAppMethodPrepaidExcessOrder_2 } from "./pmtAppMethodPrepaidExcessOrder_2";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface PmtAppMethod_2 {
    createAddlPrincipalCommentValue: boolean;
    createAddlPrincipalCommentValueSpecified: boolean;
    createAddlPrincipalComment: boolean | null;
    currentExcessOrder: PmtAppMethodCurrentExcessOrder_2[];
    currentExcessOrderSpecified: boolean;
    definedCodeValue: number;
    definedCodeValueSpecified: boolean;
    definedCode: number | null;
    description: string;
    dqExcessOrder: PmtAppMethodDqExcessOrder_2[];
    dqExcessOrderSpecified: boolean;
    gracePmtExcessOrder: PmtAppMethodGracePmtExcessOrder_2[];
    gracePmtExcessOrderSpecified: boolean;
    includeEscrowUnpdinPmtDueValue: boolean;
    includeEscrowUnpdinPmtDueValueSpecified: boolean;
    includeEscrowUnpdinPmtDue: boolean | null;
    paymentOrder: PmtAppMethodPaymentOrder_2[];
    paymentOrderSpecified: boolean;
    prepaidExcessOrder: PmtAppMethodPrepaidExcessOrder_2[];
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