import { MiscPmtAccountMask } from "./miscPmtAccountMask";
import { MiscPmtFicsDataSourceName } from "./miscPmtFicsDataSourceName";
import { MiscPmtMpQuestionFormat } from "./miscPmtMpQuestionFormat";
import { MiscPmtOnlineDbPassword } from "./miscPmtOnlineDbPassword";
import { MiscPmtOnlineDbUserId } from "./miscPmtOnlineDbUserId";
import { MiscPmtOnlineGlobalAppPasswd } from "./miscPmtOnlineGlobalAppPasswd";
import { MiscPmtOnlineGlobalAppUserId } from "./miscPmtOnlineGlobalAppUserId";
import { MiscPmtProcTranCodePayment1 } from "./miscPmtProcTranCodePayment1";
import { MiscPmtProcTranCodePayment10 } from "./miscPmtProcTranCodePayment10";
import { MiscPmtProcTranCodePayment2 } from "./miscPmtProcTranCodePayment2";
import { MiscPmtProcTranCodePayment3 } from "./miscPmtProcTranCodePayment3";
import { MiscPmtProcTranCodePayment4 } from "./miscPmtProcTranCodePayment4";
import { MiscPmtProcTranCodePayment5 } from "./miscPmtProcTranCodePayment5";
import { MiscPmtProcTranCodePayment6 } from "./miscPmtProcTranCodePayment6";
import { MiscPmtProcTranCodePayment7 } from "./miscPmtProcTranCodePayment7";
import { MiscPmtProcTranCodePayment8 } from "./miscPmtProcTranCodePayment8";
import { MiscPmtProcTranCodePayment9 } from "./miscPmtProcTranCodePayment9";
import { MiscPmtProcTranCodePmtDesc1 } from "./miscPmtProcTranCodePmtDesc1";
import { MiscPmtProcTranCodePmtDesc10 } from "./miscPmtProcTranCodePmtDesc10";
import { MiscPmtProcTranCodePmtDesc2 } from "./miscPmtProcTranCodePmtDesc2";
import { MiscPmtProcTranCodePmtDesc3 } from "./miscPmtProcTranCodePmtDesc3";
import { MiscPmtProcTranCodePmtDesc4 } from "./miscPmtProcTranCodePmtDesc4";
import { MiscPmtProcTranCodePmtDesc5 } from "./miscPmtProcTranCodePmtDesc5";
import { MiscPmtProcTranCodePmtDesc6 } from "./miscPmtProcTranCodePmtDesc6";
import { MiscPmtProcTranCodePmtDesc7 } from "./miscPmtProcTranCodePmtDesc7";
import { MiscPmtProcTranCodePmtDesc8 } from "./miscPmtProcTranCodePmtDesc8";
import { MiscPmtProcTranCodePmtDesc9 } from "./miscPmtProcTranCodePmtDesc9";
import { MiscPmtProcessorAbbreviation } from "./miscPmtProcessorAbbreviation";
import { MiscPmtProcessorAcctVerCode } from "./miscPmtProcessorAcctVerCode";
import { MiscPmtProcessorCode } from "./miscPmtProcessorCode";
import { MiscPmtProcessorName } from "./miscPmtProcessorName";
import { MiscPmtTrackingTypes } from "./miscPmtTrackingTypes";
import { MiscPmtTransactionGlCode } from "./miscPmtTransactionGlCode";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface MiscPmt {
    accountMask: MiscPmtAccountMask[];
    accountMaskSpecified: boolean;
    ficsDataSourceName: MiscPmtFicsDataSourceName[];
    ficsDataSourceNameSpecified: boolean;
    mpQuestionFormat: MiscPmtMpQuestionFormat[];
    mpQuestionFormatSpecified: boolean;
    onlineDbPassword: MiscPmtOnlineDbPassword[];
    onlineDbPasswordSpecified: boolean;
    onlineDbUserId: MiscPmtOnlineDbUserId[];
    onlineDbUserIdSpecified: boolean;
    onlineGlobalAppPasswd: MiscPmtOnlineGlobalAppPasswd[];
    onlineGlobalAppPasswdSpecified: boolean;
    onlineGlobalAppUserId: MiscPmtOnlineGlobalAppUserId[];
    onlineGlobalAppUserIdSpecified: boolean;
    procTranCodePayment1: MiscPmtProcTranCodePayment1[];
    procTranCodePayment1Specified: boolean;
    procTranCodePayment10: MiscPmtProcTranCodePayment10[];
    procTranCodePayment10Specified: boolean;
    procTranCodePayment2: MiscPmtProcTranCodePayment2[];
    procTranCodePayment2Specified: boolean;
    procTranCodePayment3: MiscPmtProcTranCodePayment3[];
    procTranCodePayment3Specified: boolean;
    procTranCodePayment4: MiscPmtProcTranCodePayment4[];
    procTranCodePayment4Specified: boolean;
    procTranCodePayment5: MiscPmtProcTranCodePayment5[];
    procTranCodePayment5Specified: boolean;
    procTranCodePayment6: MiscPmtProcTranCodePayment6[];
    procTranCodePayment6Specified: boolean;
    procTranCodePayment7: MiscPmtProcTranCodePayment7[];
    procTranCodePayment7Specified: boolean;
    procTranCodePayment8: MiscPmtProcTranCodePayment8[];
    procTranCodePayment8Specified: boolean;
    procTranCodePayment9: MiscPmtProcTranCodePayment9[];
    procTranCodePayment9Specified: boolean;
    procTranCodePmtDesc1: MiscPmtProcTranCodePmtDesc1[];
    procTranCodePmtDesc1Specified: boolean;
    procTranCodePmtDesc10: MiscPmtProcTranCodePmtDesc10[];
    procTranCodePmtDesc10Specified: boolean;
    procTranCodePmtDesc2: MiscPmtProcTranCodePmtDesc2[];
    procTranCodePmtDesc2Specified: boolean;
    procTranCodePmtDesc3: MiscPmtProcTranCodePmtDesc3[];
    procTranCodePmtDesc3Specified: boolean;
    procTranCodePmtDesc4: MiscPmtProcTranCodePmtDesc4[];
    procTranCodePmtDesc4Specified: boolean;
    procTranCodePmtDesc5: MiscPmtProcTranCodePmtDesc5[];
    procTranCodePmtDesc5Specified: boolean;
    procTranCodePmtDesc6: MiscPmtProcTranCodePmtDesc6[];
    procTranCodePmtDesc6Specified: boolean;
    procTranCodePmtDesc7: MiscPmtProcTranCodePmtDesc7[];
    procTranCodePmtDesc7Specified: boolean;
    procTranCodePmtDesc8: MiscPmtProcTranCodePmtDesc8[];
    procTranCodePmtDesc8Specified: boolean;
    procTranCodePmtDesc9: MiscPmtProcTranCodePmtDesc9[];
    procTranCodePmtDesc9Specified: boolean;
    processorAbbreviation: MiscPmtProcessorAbbreviation[];
    processorAbbreviationSpecified: boolean;
    processorAcctVerCode: MiscPmtProcessorAcctVerCode[];
    processorAcctVerCodeSpecified: boolean;
    processorCode: MiscPmtProcessorCode[];
    processorCodeSpecified: boolean;
    processorName: MiscPmtProcessorName[];
    processorNameSpecified: boolean;
    processorPromptOrderValue: number;
    processorPromptOrderValueSpecified: boolean;
    processorPromptOrder: number | null;
    trackingTypes: MiscPmtTrackingTypes[];
    trackingTypesSpecified: boolean;
    transactionGlCode: MiscPmtTransactionGlCode[];
    transactionGlCodeSpecified: boolean;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}