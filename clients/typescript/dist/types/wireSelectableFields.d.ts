import { WireFields } from "./wireFields";
import { WireBeneficiaryAdvSelectableFields } from "./wireBeneficiaryAdvSelectableFields";
import { WireBeneficiaryFiAdvSelectableFields } from "./wireBeneficiaryFiAdvSelectableFields";
import { WireBeneficiaryFiInfoSelectableFields } from "./wireBeneficiaryFiInfoSelectableFields";
import { WireBeneficiaryInfoSelectableFields } from "./wireBeneficiaryInfoSelectableFields";
import { WireDrawdownDebitAcctAdvSelectableFields } from "./wireDrawdownDebitAcctAdvSelectableFields";
import { WireFiToFiInfoSelectableFields } from "./wireFiToFiInfoSelectableFields";
import { WireFmHistorySelectableFields } from "./wireFmHistorySelectableFields";
import { WireIntermedFiAdvSelectableFields } from "./wireIntermedFiAdvSelectableFields";
import { WireIntermedFiInfoSelectableFields } from "./wireIntermedFiInfoSelectableFields";
import { WireOfacDetailsSelectableFields } from "./wireOfacDetailsSelectableFields";
import { WireReceiverFiInfoSelectableFields } from "./wireReceiverFiInfoSelectableFields";
import { WireServiceMessageSelectableFields } from "./wireServiceMessageSelectableFields";
import { WireUscAuditInfoSelectableFields } from "./wireUscAuditInfoSelectableFields";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface WireSelectableFields {
    includeAllWireFieldsValue: boolean;
    includeAllWireFieldsValueSpecified: boolean;
    includeAllWireFields: boolean | null;
    wireFields: WireFields;
    wireBeneficiaryAdvSelectableFields: WireBeneficiaryAdvSelectableFields;
    wireBeneficiaryFiAdvSelectableFields: WireBeneficiaryFiAdvSelectableFields;
    wireBeneficiaryFiInfoSelectableFields: WireBeneficiaryFiInfoSelectableFields;
    wireBeneficiaryInfoSelectableFields: WireBeneficiaryInfoSelectableFields;
    wireDrawdownDebitAcctAdvSelectableFields: WireDrawdownDebitAcctAdvSelectableFields;
    wireFiToFiInfoSelectableFields: WireFiToFiInfoSelectableFields;
    wireFmHistorySelectableFields: WireFmHistorySelectableFields;
    wireIntermedFiAdvSelectableFields: WireIntermedFiAdvSelectableFields;
    wireIntermedFiInfoSelectableFields: WireIntermedFiInfoSelectableFields;
    wireOfacDetailsSelectableFields: WireOfacDetailsSelectableFields;
    wireReceiverFiInfoSelectableFields: WireReceiverFiInfoSelectableFields;
    wireServiceMessageSelectableFields: WireServiceMessageSelectableFields;
    wireUscAuditInfoSelectableFields: WireUscAuditInfoSelectableFields;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
