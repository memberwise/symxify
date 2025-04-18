import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface StmtMessagesFields {
    definedCodeValue: boolean;
    definedCodeValueSpecified: boolean;
    definedCode: boolean | null;
    descriptionValue: boolean;
    descriptionValueSpecified: boolean;
    description: boolean | null;
    line1Value: boolean;
    line1ValueSpecified: boolean;
    line1: boolean | null;
    line10Value: boolean;
    line10ValueSpecified: boolean;
    line10: boolean | null;
    line11Value: boolean;
    line11ValueSpecified: boolean;
    line11: boolean | null;
    line12Value: boolean;
    line12ValueSpecified: boolean;
    line12: boolean | null;
    line2Value: boolean;
    line2ValueSpecified: boolean;
    line2: boolean | null;
    line3Value: boolean;
    line3ValueSpecified: boolean;
    line3: boolean | null;
    line4Value: boolean;
    line4ValueSpecified: boolean;
    line4: boolean | null;
    line5Value: boolean;
    line5ValueSpecified: boolean;
    line5: boolean | null;
    line6Value: boolean;
    line6ValueSpecified: boolean;
    line6: boolean | null;
    line7Value: boolean;
    line7ValueSpecified: boolean;
    line7: boolean | null;
    line8Value: boolean;
    line8ValueSpecified: boolean;
    line8: boolean | null;
    line9Value: boolean;
    line9ValueSpecified: boolean;
    line9: boolean | null;
    statementMessageCodeValue: boolean;
    statementMessageCodeValueSpecified: boolean;
    statementMessageCode: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}