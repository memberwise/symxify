import { CdmCassDenom6DuressAuto1Notes_2 } from "./cdmCassDenom6DuressAuto1Notes_2";
import { CdmCassDenom6DuressAuto2Notes_2 } from "./cdmCassDenom6DuressAuto2Notes_2";
import { CdmCassDenom6DuressAuto3Notes_2 } from "./cdmCassDenom6DuressAuto3Notes_2";
import { CdmCassetteDenomAutomixNotes_2 } from "./cdmCassetteDenomAutomixNotes_2";
import { CdmCassetteDenomination_2 } from "./cdmCassetteDenomination_2";
import { BitMap } from "./bitMap";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface Cdm_2 {
    cassDenom6DuressAuto1Notes: CdmCassDenom6DuressAuto1Notes_2[];
    cassDenom6DuressAuto1NotesSpecified: boolean;
    cassDenom6DuressAuto2Notes: CdmCassDenom6DuressAuto2Notes_2[];
    cassDenom6DuressAuto2NotesSpecified: boolean;
    cassDenom6DuressAuto3Notes: CdmCassDenom6DuressAuto3Notes_2[];
    cassDenom6DuressAuto3NotesSpecified: boolean;
    cassetteDenomAutomixNotes: CdmCassetteDenomAutomixNotes_2[];
    cassetteDenomAutomixNotesSpecified: boolean;
    cassetteDenomination: CdmCassetteDenomination_2[];
    cassetteDenominationSpecified: boolean;
    cdmPropertyValue: number;
    cdmPropertyValueSpecified: boolean;
    cdmProperty: number | null;
    cdmDuressDispAmtValue: number;
    cdmDuressDispAmtValueSpecified: boolean;
    cdmDuressDispAmt: number | null;
    cdmDuressSilentAlarmValue: boolean;
    cdmDuressSilentAlarmValueSpecified: boolean;
    cdmDuressSilentAlarm: boolean | null;
    consoleFileName: string;
    consoleFileNameExt: string;
    leftCoinDispenserValue: boolean;
    leftCoinDispenserValueSpecified: boolean;
    leftCoinDispenser: boolean | null;
    machineTypeValue: number;
    machineTypeValueSpecified: boolean;
    machineType: number | null;
    recyclerValue: boolean;
    recyclerValueSpecified: boolean;
    recycler: boolean | null;
    remoteDeviceValue: boolean;
    remoteDeviceValueSpecified: boolean;
    remoteDevice: boolean | null;
    rightCoinDispenserValue: boolean;
    rightCoinDispenserValueSpecified: boolean;
    rightCoinDispenser: boolean | null;
    userIds: BitMap;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
