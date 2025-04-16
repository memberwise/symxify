import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface TrackingFields {
    creationDateValue: boolean;
    creationDateValueSpecified: boolean;
    creationDate: boolean | null;
    creationTimeValue: boolean;
    creationTimeValueSpecified: boolean;
    creationTime: boolean | null;
    expireDateValue: boolean;
    expireDateValueSpecified: boolean;
    expireDate: boolean | null;
    fmLastDateValue: boolean;
    fmLastDateValueSpecified: boolean;
    fmLastDate: boolean | null;
    idValue: boolean;
    idValueSpecified: boolean;
    id: boolean | null;
    idTypeValue: boolean;
    idTypeValueSpecified: boolean;
    idType: boolean | null;
    locatorValue: boolean;
    locatorValueSpecified: boolean;
    locator: boolean | null;
    recordChangeDateValue: boolean;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: boolean | null;
    trackingCodeValue: boolean;
    trackingCodeValueSpecified: boolean;
    trackingCode: boolean | null;
    typeValue: boolean;
    typeValueSpecified: boolean;
    type: boolean | null;
    userAmount1Value: boolean;
    userAmount1ValueSpecified: boolean;
    userAmount1: boolean | null;
    userAmount10Value: boolean;
    userAmount10ValueSpecified: boolean;
    userAmount10: boolean | null;
    userAmount11Value: boolean;
    userAmount11ValueSpecified: boolean;
    userAmount11: boolean | null;
    userAmount12Value: boolean;
    userAmount12ValueSpecified: boolean;
    userAmount12: boolean | null;
    userAmount13Value: boolean;
    userAmount13ValueSpecified: boolean;
    userAmount13: boolean | null;
    userAmount14Value: boolean;
    userAmount14ValueSpecified: boolean;
    userAmount14: boolean | null;
    userAmount15Value: boolean;
    userAmount15ValueSpecified: boolean;
    userAmount15: boolean | null;
    userAmount16Value: boolean;
    userAmount16ValueSpecified: boolean;
    userAmount16: boolean | null;
    userAmount17Value: boolean;
    userAmount17ValueSpecified: boolean;
    userAmount17: boolean | null;
    userAmount18Value: boolean;
    userAmount18ValueSpecified: boolean;
    userAmount18: boolean | null;
    userAmount19Value: boolean;
    userAmount19ValueSpecified: boolean;
    userAmount19: boolean | null;
    userAmount2Value: boolean;
    userAmount2ValueSpecified: boolean;
    userAmount2: boolean | null;
    userAmount20Value: boolean;
    userAmount20ValueSpecified: boolean;
    userAmount20: boolean | null;
    userAmount3Value: boolean;
    userAmount3ValueSpecified: boolean;
    userAmount3: boolean | null;
    userAmount4Value: boolean;
    userAmount4ValueSpecified: boolean;
    userAmount4: boolean | null;
    userAmount5Value: boolean;
    userAmount5ValueSpecified: boolean;
    userAmount5: boolean | null;
    userAmount6Value: boolean;
    userAmount6ValueSpecified: boolean;
    userAmount6: boolean | null;
    userAmount7Value: boolean;
    userAmount7ValueSpecified: boolean;
    userAmount7: boolean | null;
    userAmount8Value: boolean;
    userAmount8ValueSpecified: boolean;
    userAmount8: boolean | null;
    userAmount9Value: boolean;
    userAmount9ValueSpecified: boolean;
    userAmount9: boolean | null;
    userChar1Value: boolean;
    userChar1ValueSpecified: boolean;
    userChar1: boolean | null;
    userChar10Value: boolean;
    userChar10ValueSpecified: boolean;
    userChar10: boolean | null;
    userChar11Value: boolean;
    userChar11ValueSpecified: boolean;
    userChar11: boolean | null;
    userChar12Value: boolean;
    userChar12ValueSpecified: boolean;
    userChar12: boolean | null;
    userChar13Value: boolean;
    userChar13ValueSpecified: boolean;
    userChar13: boolean | null;
    userChar14Value: boolean;
    userChar14ValueSpecified: boolean;
    userChar14: boolean | null;
    userChar15Value: boolean;
    userChar15ValueSpecified: boolean;
    userChar15: boolean | null;
    userChar16Value: boolean;
    userChar16ValueSpecified: boolean;
    userChar16: boolean | null;
    userChar17Value: boolean;
    userChar17ValueSpecified: boolean;
    userChar17: boolean | null;
    userChar18Value: boolean;
    userChar18ValueSpecified: boolean;
    userChar18: boolean | null;
    userChar19Value: boolean;
    userChar19ValueSpecified: boolean;
    userChar19: boolean | null;
    userChar2Value: boolean;
    userChar2ValueSpecified: boolean;
    userChar2: boolean | null;
    userChar20Value: boolean;
    userChar20ValueSpecified: boolean;
    userChar20: boolean | null;
    userChar3Value: boolean;
    userChar3ValueSpecified: boolean;
    userChar3: boolean | null;
    userChar4Value: boolean;
    userChar4ValueSpecified: boolean;
    userChar4: boolean | null;
    userChar5Value: boolean;
    userChar5ValueSpecified: boolean;
    userChar5: boolean | null;
    userChar6Value: boolean;
    userChar6ValueSpecified: boolean;
    userChar6: boolean | null;
    userChar7Value: boolean;
    userChar7ValueSpecified: boolean;
    userChar7: boolean | null;
    userChar8Value: boolean;
    userChar8ValueSpecified: boolean;
    userChar8: boolean | null;
    userChar9Value: boolean;
    userChar9ValueSpecified: boolean;
    userChar9: boolean | null;
    userCode1Value: boolean;
    userCode1ValueSpecified: boolean;
    userCode1: boolean | null;
    userCode10Value: boolean;
    userCode10ValueSpecified: boolean;
    userCode10: boolean | null;
    userCode11Value: boolean;
    userCode11ValueSpecified: boolean;
    userCode11: boolean | null;
    userCode12Value: boolean;
    userCode12ValueSpecified: boolean;
    userCode12: boolean | null;
    userCode13Value: boolean;
    userCode13ValueSpecified: boolean;
    userCode13: boolean | null;
    userCode14Value: boolean;
    userCode14ValueSpecified: boolean;
    userCode14: boolean | null;
    userCode15Value: boolean;
    userCode15ValueSpecified: boolean;
    userCode15: boolean | null;
    userCode16Value: boolean;
    userCode16ValueSpecified: boolean;
    userCode16: boolean | null;
    userCode17Value: boolean;
    userCode17ValueSpecified: boolean;
    userCode17: boolean | null;
    userCode18Value: boolean;
    userCode18ValueSpecified: boolean;
    userCode18: boolean | null;
    userCode19Value: boolean;
    userCode19ValueSpecified: boolean;
    userCode19: boolean | null;
    userCode2Value: boolean;
    userCode2ValueSpecified: boolean;
    userCode2: boolean | null;
    userCode20Value: boolean;
    userCode20ValueSpecified: boolean;
    userCode20: boolean | null;
    userCode3Value: boolean;
    userCode3ValueSpecified: boolean;
    userCode3: boolean | null;
    userCode4Value: boolean;
    userCode4ValueSpecified: boolean;
    userCode4: boolean | null;
    userCode5Value: boolean;
    userCode5ValueSpecified: boolean;
    userCode5: boolean | null;
    userCode6Value: boolean;
    userCode6ValueSpecified: boolean;
    userCode6: boolean | null;
    userCode7Value: boolean;
    userCode7ValueSpecified: boolean;
    userCode7: boolean | null;
    userCode8Value: boolean;
    userCode8ValueSpecified: boolean;
    userCode8: boolean | null;
    userCode9Value: boolean;
    userCode9ValueSpecified: boolean;
    userCode9: boolean | null;
    userDate1Value: boolean;
    userDate1ValueSpecified: boolean;
    userDate1: boolean | null;
    userDate10Value: boolean;
    userDate10ValueSpecified: boolean;
    userDate10: boolean | null;
    userDate11Value: boolean;
    userDate11ValueSpecified: boolean;
    userDate11: boolean | null;
    userDate12Value: boolean;
    userDate12ValueSpecified: boolean;
    userDate12: boolean | null;
    userDate13Value: boolean;
    userDate13ValueSpecified: boolean;
    userDate13: boolean | null;
    userDate14Value: boolean;
    userDate14ValueSpecified: boolean;
    userDate14: boolean | null;
    userDate15Value: boolean;
    userDate15ValueSpecified: boolean;
    userDate15: boolean | null;
    userDate16Value: boolean;
    userDate16ValueSpecified: boolean;
    userDate16: boolean | null;
    userDate17Value: boolean;
    userDate17ValueSpecified: boolean;
    userDate17: boolean | null;
    userDate18Value: boolean;
    userDate18ValueSpecified: boolean;
    userDate18: boolean | null;
    userDate19Value: boolean;
    userDate19ValueSpecified: boolean;
    userDate19: boolean | null;
    userDate2Value: boolean;
    userDate2ValueSpecified: boolean;
    userDate2: boolean | null;
    userDate20Value: boolean;
    userDate20ValueSpecified: boolean;
    userDate20: boolean | null;
    userDate3Value: boolean;
    userDate3ValueSpecified: boolean;
    userDate3: boolean | null;
    userDate4Value: boolean;
    userDate4ValueSpecified: boolean;
    userDate4: boolean | null;
    userDate5Value: boolean;
    userDate5ValueSpecified: boolean;
    userDate5: boolean | null;
    userDate6Value: boolean;
    userDate6ValueSpecified: boolean;
    userDate6: boolean | null;
    userDate7Value: boolean;
    userDate7ValueSpecified: boolean;
    userDate7: boolean | null;
    userDate8Value: boolean;
    userDate8ValueSpecified: boolean;
    userDate8: boolean | null;
    userDate9Value: boolean;
    userDate9ValueSpecified: boolean;
    userDate9: boolean | null;
    userIdValue: boolean;
    userIdValueSpecified: boolean;
    userId: boolean | null;
    userNumber1Value: boolean;
    userNumber1ValueSpecified: boolean;
    userNumber1: boolean | null;
    userNumber10Value: boolean;
    userNumber10ValueSpecified: boolean;
    userNumber10: boolean | null;
    userNumber11Value: boolean;
    userNumber11ValueSpecified: boolean;
    userNumber11: boolean | null;
    userNumber12Value: boolean;
    userNumber12ValueSpecified: boolean;
    userNumber12: boolean | null;
    userNumber13Value: boolean;
    userNumber13ValueSpecified: boolean;
    userNumber13: boolean | null;
    userNumber14Value: boolean;
    userNumber14ValueSpecified: boolean;
    userNumber14: boolean | null;
    userNumber15Value: boolean;
    userNumber15ValueSpecified: boolean;
    userNumber15: boolean | null;
    userNumber16Value: boolean;
    userNumber16ValueSpecified: boolean;
    userNumber16: boolean | null;
    userNumber17Value: boolean;
    userNumber17ValueSpecified: boolean;
    userNumber17: boolean | null;
    userNumber18Value: boolean;
    userNumber18ValueSpecified: boolean;
    userNumber18: boolean | null;
    userNumber19Value: boolean;
    userNumber19ValueSpecified: boolean;
    userNumber19: boolean | null;
    userNumber2Value: boolean;
    userNumber2ValueSpecified: boolean;
    userNumber2: boolean | null;
    userNumber20Value: boolean;
    userNumber20ValueSpecified: boolean;
    userNumber20: boolean | null;
    userNumber3Value: boolean;
    userNumber3ValueSpecified: boolean;
    userNumber3: boolean | null;
    userNumber4Value: boolean;
    userNumber4ValueSpecified: boolean;
    userNumber4: boolean | null;
    userNumber5Value: boolean;
    userNumber5ValueSpecified: boolean;
    userNumber5: boolean | null;
    userNumber6Value: boolean;
    userNumber6ValueSpecified: boolean;
    userNumber6: boolean | null;
    userNumber7Value: boolean;
    userNumber7ValueSpecified: boolean;
    userNumber7: boolean | null;
    userNumber8Value: boolean;
    userNumber8ValueSpecified: boolean;
    userNumber8: boolean | null;
    userNumber9Value: boolean;
    userNumber9ValueSpecified: boolean;
    userNumber9: boolean | null;
    userRate1Value: boolean;
    userRate1ValueSpecified: boolean;
    userRate1: boolean | null;
    userRate10Value: boolean;
    userRate10ValueSpecified: boolean;
    userRate10: boolean | null;
    userRate11Value: boolean;
    userRate11ValueSpecified: boolean;
    userRate11: boolean | null;
    userRate12Value: boolean;
    userRate12ValueSpecified: boolean;
    userRate12: boolean | null;
    userRate13Value: boolean;
    userRate13ValueSpecified: boolean;
    userRate13: boolean | null;
    userRate14Value: boolean;
    userRate14ValueSpecified: boolean;
    userRate14: boolean | null;
    userRate15Value: boolean;
    userRate15ValueSpecified: boolean;
    userRate15: boolean | null;
    userRate16Value: boolean;
    userRate16ValueSpecified: boolean;
    userRate16: boolean | null;
    userRate17Value: boolean;
    userRate17ValueSpecified: boolean;
    userRate17: boolean | null;
    userRate18Value: boolean;
    userRate18ValueSpecified: boolean;
    userRate18: boolean | null;
    userRate19Value: boolean;
    userRate19ValueSpecified: boolean;
    userRate19: boolean | null;
    userRate2Value: boolean;
    userRate2ValueSpecified: boolean;
    userRate2: boolean | null;
    userRate20Value: boolean;
    userRate20ValueSpecified: boolean;
    userRate20: boolean | null;
    userRate3Value: boolean;
    userRate3ValueSpecified: boolean;
    userRate3: boolean | null;
    userRate4Value: boolean;
    userRate4ValueSpecified: boolean;
    userRate4: boolean | null;
    userRate5Value: boolean;
    userRate5ValueSpecified: boolean;
    userRate5: boolean | null;
    userRate6Value: boolean;
    userRate6ValueSpecified: boolean;
    userRate6: boolean | null;
    userRate7Value: boolean;
    userRate7ValueSpecified: boolean;
    userRate7: boolean | null;
    userRate8Value: boolean;
    userRate8ValueSpecified: boolean;
    userRate8: boolean | null;
    userRate9Value: boolean;
    userRate9ValueSpecified: boolean;
    userRate9: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}