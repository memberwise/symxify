import { EftAddendaInfoList } from "./eftAddendaInfoList";
import { EftNameList } from "./eftNameList";
import { EftTransferList } from "./eftTransferList";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface Eft {
    amountCodeValue: number;
    amountCodeValueSpecified: boolean;
    amountCode: number | null;
    amountYtdValue: number;
    amountYtdValueSpecified: boolean;
    amountYtd: number | null;
    audioId: string;
    balanceValue: number;
    balanceValueSpecified: boolean;
    balance: number | null;
    batchAchOrigNumValue: number;
    batchAchOrigNumValueSpecified: boolean;
    batchAchOrigNum: number | null;
    countYtdValue: number;
    countYtdValueSpecified: boolean;
    countYtd: number | null;
    creditLimitValue: number;
    creditLimitValueSpecified: boolean;
    creditLimit: number | null;
    day1Value: number;
    day1ValueSpecified: boolean;
    day1: number | null;
    day2Value: number;
    day2ValueSpecified: boolean;
    day2: number | null;
    deferDateValue: string;
    deferDateValueSpecified: boolean;
    deferDate: string | null;
    distributionRatioValue: number;
    distributionRatioValueSpecified: boolean;
    distributionRatio: number | null;
    dqCountValue: number;
    dqCountValueSpecified: boolean;
    dqCount: number | null;
    effectiveDateValue: string;
    effectiveDateValueSpecified: boolean;
    effectiveDate: string | null;
    eftAddendaInfoList: EftAddendaInfoList;
    eftNameList: EftNameList;
    eftTransferList: EftTransferList;
    expirationDateValue: string;
    expirationDateValueSpecified: boolean;
    expirationDate: string | null;
    federalWithholdingValue: number;
    federalWithholdingValueSpecified: boolean;
    federalWithholding: number | null;
    frequencyValue: number;
    frequencyValueSpecified: boolean;
    frequency: number | null;
    glCodeValue: number;
    glCodeValueSpecified: boolean;
    glCode: number | null;
    groupNumber: string;
    id: string;
    idTypeValue: number;
    idTypeValueSpecified: boolean;
    idType: number | null;
    lastTranAmountValue: number;
    lastTranAmountValueSpecified: boolean;
    lastTranAmount: number | null;
    lastTranDateValue: string;
    lastTranDateValueSpecified: boolean;
    lastTranDate: string | null;
    locatorValue: number;
    locatorValueSpecified: boolean;
    locator: number | null;
    matchCode1Value: number;
    matchCode1ValueSpecified: boolean;
    matchCode1: number | null;
    matchCode2Value: number;
    matchCode2ValueSpecified: boolean;
    matchCode2: number | null;
    matchCode3Value: number;
    matchCode3ValueSpecified: boolean;
    matchCode3: number | null;
    matchCode4Value: number;
    matchCode4ValueSpecified: boolean;
    matchCode4: number | null;
    matchCode5Value: number;
    matchCode5ValueSpecified: boolean;
    matchCode5: number | null;
    matchCode6Value: number;
    matchCode6ValueSpecified: boolean;
    matchCode6: number | null;
    matchId1: string;
    matchId2: string;
    matchId3: string;
    matchId4: string;
    matchId5: string;
    matchId6: string;
    nextDateValue: string;
    nextDateValueSpecified: boolean;
    nextDate: string | null;
    payee: string;
    payeeCity: string;
    payeeExtraAddress: string;
    payeeName: string;
    payeeState: string;
    payeeStreet: string;
    payeeZipCode: string;
    postAmountValue: number;
    postAmountValueSpecified: boolean;
    postAmount: number | null;
    postFreqValue: number;
    postFreqValueSpecified: boolean;
    postFreq: number | null;
    preNoteSentDateValue: string;
    preNoteSentDateValueSpecified: boolean;
    preNoteSentDate: string | null;
    recordChangeDateValue: string;
    recordChangeDateValueSpecified: boolean;
    recordChangeDate: string | null;
    reference: string;
    reference2: string;
    regDCodeValue: number;
    regDCodeValueSpecified: boolean;
    regDCode: number | null;
    specificAmountValue: number;
    specificAmountValueSpecified: boolean;
    specificAmount: number | null;
    standardAmountValue: number;
    standardAmountValueSpecified: boolean;
    standardAmount: number | null;
    stateWithholdingValue: number;
    stateWithholdingValueSpecified: boolean;
    stateWithholding: number | null;
    status: string;
    typeValue: number;
    typeValueSpecified: boolean;
    type: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}