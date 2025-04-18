import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface ReservePlanTracking {
    creationDateValue: string;
    creationDateValueSpecified: boolean;
    creationDate: string | null;
    creationTimeValue: number;
    creationTimeValueSpecified: boolean;
    creationTime: number | null;
    expireDateValue: string;
    expireDateValueSpecified: boolean;
    expireDate: string | null;
    fmLastDateValue: string;
    fmLastDateValueSpecified: boolean;
    fmLastDate: string | null;
    id: string;
    idTypeValue: number;
    idTypeValueSpecified: boolean;
    idType: number | null;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    recordChangeDateValue: string;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    trackingCodeValue: number;
    trackingCodeValueSpecified: boolean;
    trackingCode: number | null;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    userAmount1Value: number;
    userAmount1ValueSpecified: boolean;
    userAmount1: number | null;
    userAmount10Value: number;
    userAmount10ValueSpecified: boolean;
    userAmount10: number | null;
    userAmount11Value: number;
    userAmount11ValueSpecified: boolean;
    userAmount11: number | null;
    userAmount12Value: number;
    userAmount12ValueSpecified: boolean;
    userAmount12: number | null;
    userAmount13Value: number;
    userAmount13ValueSpecified: boolean;
    userAmount13: number | null;
    userAmount14Value: number;
    userAmount14ValueSpecified: boolean;
    userAmount14: number | null;
    userAmount15Value: number;
    userAmount15ValueSpecified: boolean;
    userAmount15: number | null;
    userAmount16Value: number;
    userAmount16ValueSpecified: boolean;
    userAmount16: number | null;
    userAmount17Value: number;
    userAmount17ValueSpecified: boolean;
    userAmount17: number | null;
    userAmount18Value: number;
    userAmount18ValueSpecified: boolean;
    userAmount18: number | null;
    userAmount19Value: number;
    userAmount19ValueSpecified: boolean;
    userAmount19: number | null;
    userAmount2Value: number;
    userAmount2ValueSpecified: boolean;
    userAmount2: number | null;
    userAmount20Value: number;
    userAmount20ValueSpecified: boolean;
    userAmount20: number | null;
    userAmount3Value: number;
    userAmount3ValueSpecified: boolean;
    userAmount3: number | null;
    userAmount4Value: number;
    userAmount4ValueSpecified: boolean;
    userAmount4: number | null;
    userAmount5Value: number;
    userAmount5ValueSpecified: boolean;
    userAmount5: number | null;
    userAmount6Value: number;
    userAmount6ValueSpecified: boolean;
    userAmount6: number | null;
    userAmount7Value: number;
    userAmount7ValueSpecified: boolean;
    userAmount7: number | null;
    userAmount8Value: number;
    userAmount8ValueSpecified: boolean;
    userAmount8: number | null;
    userAmount9Value: number;
    userAmount9ValueSpecified: boolean;
    userAmount9: number | null;
    userChar1: string;
    userChar10: string;
    userChar11: string;
    userChar12: string;
    userChar13: string;
    userChar14: string;
    userChar15: string;
    userChar16: string;
    userChar17: string;
    userChar18: string;
    userChar19: string;
    userChar2: string;
    userChar20: string;
    userChar3: string;
    userChar4: string;
    userChar5: string;
    userChar6: string;
    userChar7: string;
    userChar8: string;
    userChar9: string;
    userCode1Value: number;
    userCode1ValueSpecified: boolean;
    userCode1: number | null;
    userCode10Value: number;
    userCode10ValueSpecified: boolean;
    userCode10: number | null;
    userCode11Value: number;
    userCode11ValueSpecified: boolean;
    userCode11: number | null;
    userCode12Value: number;
    userCode12ValueSpecified: boolean;
    userCode12: number | null;
    userCode13Value: number;
    userCode13ValueSpecified: boolean;
    userCode13: number | null;
    userCode14Value: number;
    userCode14ValueSpecified: boolean;
    userCode14: number | null;
    userCode15Value: number;
    userCode15ValueSpecified: boolean;
    userCode15: number | null;
    userCode16Value: number;
    userCode16ValueSpecified: boolean;
    userCode16: number | null;
    userCode17Value: number;
    userCode17ValueSpecified: boolean;
    userCode17: number | null;
    userCode18Value: number;
    userCode18ValueSpecified: boolean;
    userCode18: number | null;
    userCode19Value: number;
    userCode19ValueSpecified: boolean;
    userCode19: number | null;
    userCode2Value: number;
    userCode2ValueSpecified: boolean;
    userCode2: number | null;
    userCode20Value: number;
    userCode20ValueSpecified: boolean;
    userCode20: number | null;
    userCode3Value: number;
    userCode3ValueSpecified: boolean;
    userCode3: number | null;
    userCode4Value: number;
    userCode4ValueSpecified: boolean;
    userCode4: number | null;
    userCode5Value: number;
    userCode5ValueSpecified: boolean;
    userCode5: number | null;
    userCode6Value: number;
    userCode6ValueSpecified: boolean;
    userCode6: number | null;
    userCode7Value: number;
    userCode7ValueSpecified: boolean;
    userCode7: number | null;
    userCode8Value: number;
    userCode8ValueSpecified: boolean;
    userCode8: number | null;
    userCode9Value: number;
    userCode9ValueSpecified: boolean;
    userCode9: number | null;
    userDate1Value: string;
    userDate1ValueSpecified: boolean;
    userDate1: string | null;
    userDate10Value: string;
    userDate10ValueSpecified: boolean;
    userDate10: string | null;
    userDate11Value: string;
    userDate11ValueSpecified: boolean;
    userDate11: string | null;
    userDate12Value: string;
    userDate12ValueSpecified: boolean;
    userDate12: string | null;
    userDate13Value: string;
    userDate13ValueSpecified: boolean;
    userDate13: string | null;
    userDate14Value: string;
    userDate14ValueSpecified: boolean;
    userDate14: string | null;
    userDate15Value: string;
    userDate15ValueSpecified: boolean;
    userDate15: string | null;
    userDate16Value: string;
    userDate16ValueSpecified: boolean;
    userDate16: string | null;
    userDate17Value: string;
    userDate17ValueSpecified: boolean;
    userDate17: string | null;
    userDate18Value: string;
    userDate18ValueSpecified: boolean;
    userDate18: string | null;
    userDate19Value: string;
    userDate19ValueSpecified: boolean;
    userDate19: string | null;
    userDate2Value: string;
    userDate2ValueSpecified: boolean;
    userDate2: string | null;
    userDate20Value: string;
    userDate20ValueSpecified: boolean;
    userDate20: string | null;
    userDate3Value: string;
    userDate3ValueSpecified: boolean;
    userDate3: string | null;
    userDate4Value: string;
    userDate4ValueSpecified: boolean;
    userDate4: string | null;
    userDate5Value: string;
    userDate5ValueSpecified: boolean;
    userDate5: string | null;
    userDate6Value: string;
    userDate6ValueSpecified: boolean;
    userDate6: string | null;
    userDate7Value: string;
    userDate7ValueSpecified: boolean;
    userDate7: string | null;
    userDate8Value: string;
    userDate8ValueSpecified: boolean;
    userDate8: string | null;
    userDate9Value: string;
    userDate9ValueSpecified: boolean;
    userDate9: string | null;
    userIdValue: number;
    userIdValueSpecified: boolean;
    userId: number | null;
    userNumber1Value: number;
    userNumber1ValueSpecified: boolean;
    userNumber1: number | null;
    userNumber10Value: number;
    userNumber10ValueSpecified: boolean;
    userNumber10: number | null;
    userNumber11Value: number;
    userNumber11ValueSpecified: boolean;
    userNumber11: number | null;
    userNumber12Value: number;
    userNumber12ValueSpecified: boolean;
    userNumber12: number | null;
    userNumber13Value: number;
    userNumber13ValueSpecified: boolean;
    userNumber13: number | null;
    userNumber14Value: number;
    userNumber14ValueSpecified: boolean;
    userNumber14: number | null;
    userNumber15Value: number;
    userNumber15ValueSpecified: boolean;
    userNumber15: number | null;
    userNumber16Value: number;
    userNumber16ValueSpecified: boolean;
    userNumber16: number | null;
    userNumber17Value: number;
    userNumber17ValueSpecified: boolean;
    userNumber17: number | null;
    userNumber18Value: number;
    userNumber18ValueSpecified: boolean;
    userNumber18: number | null;
    userNumber19Value: number;
    userNumber19ValueSpecified: boolean;
    userNumber19: number | null;
    userNumber2Value: number;
    userNumber2ValueSpecified: boolean;
    userNumber2: number | null;
    userNumber20Value: number;
    userNumber20ValueSpecified: boolean;
    userNumber20: number | null;
    userNumber3Value: number;
    userNumber3ValueSpecified: boolean;
    userNumber3: number | null;
    userNumber4Value: number;
    userNumber4ValueSpecified: boolean;
    userNumber4: number | null;
    userNumber5Value: number;
    userNumber5ValueSpecified: boolean;
    userNumber5: number | null;
    userNumber6Value: number;
    userNumber6ValueSpecified: boolean;
    userNumber6: number | null;
    userNumber7Value: number;
    userNumber7ValueSpecified: boolean;
    userNumber7: number | null;
    userNumber8Value: number;
    userNumber8ValueSpecified: boolean;
    userNumber8: number | null;
    userNumber9Value: number;
    userNumber9ValueSpecified: boolean;
    userNumber9: number | null;
    userRate1Value: number;
    userRate1ValueSpecified: boolean;
    userRate1: number | null;
    userRate10Value: number;
    userRate10ValueSpecified: boolean;
    userRate10: number | null;
    userRate11Value: number;
    userRate11ValueSpecified: boolean;
    userRate11: number | null;
    userRate12Value: number;
    userRate12ValueSpecified: boolean;
    userRate12: number | null;
    userRate13Value: number;
    userRate13ValueSpecified: boolean;
    userRate13: number | null;
    userRate14Value: number;
    userRate14ValueSpecified: boolean;
    userRate14: number | null;
    userRate15Value: number;
    userRate15ValueSpecified: boolean;
    userRate15: number | null;
    userRate16Value: number;
    userRate16ValueSpecified: boolean;
    userRate16: number | null;
    userRate17Value: number;
    userRate17ValueSpecified: boolean;
    userRate17: number | null;
    userRate18Value: number;
    userRate18ValueSpecified: boolean;
    userRate18: number | null;
    userRate19Value: number;
    userRate19ValueSpecified: boolean;
    userRate19: number | null;
    userRate2Value: number;
    userRate2ValueSpecified: boolean;
    userRate2: number | null;
    userRate20Value: number;
    userRate20ValueSpecified: boolean;
    userRate20: number | null;
    userRate3Value: number;
    userRate3ValueSpecified: boolean;
    userRate3: number | null;
    userRate4Value: number;
    userRate4ValueSpecified: boolean;
    userRate4: number | null;
    userRate5Value: number;
    userRate5ValueSpecified: boolean;
    userRate5: number | null;
    userRate6Value: number;
    userRate6ValueSpecified: boolean;
    userRate6: number | null;
    userRate7Value: number;
    userRate7ValueSpecified: boolean;
    userRate7: number | null;
    userRate8Value: number;
    userRate8ValueSpecified: boolean;
    userRate8: number | null;
    userRate9Value: number;
    userRate9ValueSpecified: boolean;
    userRate9: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}