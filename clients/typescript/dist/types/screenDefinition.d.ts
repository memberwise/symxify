import { ScreenDefinitionField1 } from "./screenDefinitionField1";
import { ScreenDefinitionField5 } from "./screenDefinitionField5";
import { ScreenDefinitionLCol } from "./screenDefinitionLCol";
import { ScreenDefinitionLine } from "./screenDefinitionLine";
import { ScreenDefinitionRCol } from "./screenDefinitionRCol";
import { ScreenDefinitionRow } from "./screenDefinitionRow";
import { ScreenDefinitionSide } from "./screenDefinitionSide";
import { ScreenDefinitionSubField } from "./screenDefinitionSubField";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface ScreenDefinition {
    field1: ScreenDefinitionField1[];
    field1Specified: boolean;
    field5: ScreenDefinitionField5[];
    field5Specified: boolean;
    lCol: ScreenDefinitionLCol[];
    lColSpecified: boolean;
    line: ScreenDefinitionLine[];
    lineSpecified: boolean;
    rCol: ScreenDefinitionRCol[];
    rColSpecified: boolean;
    row: ScreenDefinitionRow[];
    rowSpecified: boolean;
    screenSelectionValue: number;
    screenSelectionValueSpecified: boolean;
    screenSelection: number | null;
    side: ScreenDefinitionSide[];
    sideSpecified: boolean;
    subField: ScreenDefinitionSubField[];
    subFieldSpecified: boolean;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
