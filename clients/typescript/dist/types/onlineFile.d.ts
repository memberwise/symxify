import { OnlineFileThirdPartyPayments } from "./onlineFileThirdPartyPayments";
import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";
export interface OnlineFile {
    availBalExclList: string;
    availBalInclOdProtectionValue: boolean;
    availBalInclOdProtectionValueSpecified: boolean;
    availBalInclOdProtection: boolean | null;
    availBalInclOdToleranceValue: boolean;
    availBalInclOdToleranceValueSpecified: boolean;
    availBalInclOdTolerance: boolean | null;
    bonusAwardsTrackingTypeValue: number;
    bonusAwardsTrackingTypeValueSpecified: boolean;
    bonusAwardsTrackingType: number | null;
    cardFraudNoteExpDaysValue: number;
    cardFraudNoteExpDaysValueSpecified: boolean;
    cardFraudNoteExpDays: number | null;
    cardTypeValue: number;
    cardTypeValueSpecified: boolean;
    cardType: number | null;
    digitalIssueTrackingTypeValue: number;
    digitalIssueTrackingTypeValueSpecified: boolean;
    digitalIssueTrackingType: number | null;
    excludedStatusReasonCodes: string;
    fileRecordValue: number;
    fileRecordValueSpecified: boolean;
    fileRecord: number | null;
    fileTypeValue: number;
    fileTypeValueSpecified: boolean;
    fileType: number | null;
    fileUpdateMethodValue: number;
    fileUpdateMethodValueSpecified: boolean;
    fileUpdateMethod: number | null;
    fraudControlTrackingTypeValue: number;
    fraudControlTrackingTypeValueSpecified: boolean;
    fraudControlTrackingType: number | null;
    fwdUpdateToPinNetworkValue: boolean;
    fwdUpdateToPinNetworkValueSpecified: boolean;
    fwdUpdateToPinNetwork: boolean | null;
    fwdUpdatesfrmOtherNetworks: string;
    fwdUpdatetoVisaMasterCardValue: boolean;
    fwdUpdatetoVisaMasterCardValueSpecified: boolean;
    fwdUpdatetoVisaMasterCard: boolean | null;
    highPriorityMsgOptionValue: number;
    highPriorityMsgOptionValueSpecified: boolean;
    highPriorityMsgOption: number | null;
    institutionId: string;
    limitGroupId: string;
    minimumBalanceChangeValue: number;
    minimumBalanceChangeValueSpecified: boolean;
    minimumBalanceChange: number | null;
    networkMessageFormatValue: number;
    networkMessageFormatValueSpecified: boolean;
    networkMessageFormat: number | null;
    onlineCardOrderingValue: boolean;
    onlineCardOrderingValueSpecified: boolean;
    onlineCardOrdering: boolean | null;
    purgeDaysValue: number;
    purgeDaysValueSpecified: boolean;
    purgeDays: number | null;
    receiveCardFraudNoteCodeValue: number;
    receiveCardFraudNoteCodeValueSpecified: boolean;
    receiveCardFraudNoteCode: number | null;
    sendActivationMessageValue: boolean;
    sendActivationMessageValueSpecified: boolean;
    sendActivationMessage: boolean | null;
    sendBalancesValue: boolean;
    sendBalancesValueSpecified: boolean;
    sendBalances: boolean | null;
    sendCardFraudNoteCodeValue: number;
    sendCardFraudNoteCodeValueSpecified: boolean;
    sendCardFraudNoteCode: number | null;
    sendNewCardOptionValue: number;
    sendNewCardOptionValueSpecified: boolean;
    sendNewCardOption: number | null;
    sendPinOffsetMessageValue: boolean;
    sendPinOffsetMessageValueSpecified: boolean;
    sendPinOffsetMessage: boolean | null;
    suffixFormatValue: number;
    suffixFormatValueSpecified: boolean;
    suffixFormat: number | null;
    thirdPartyPayments: OnlineFileThirdPartyPayments[];
    thirdPartyPaymentsSpecified: boolean;
    useMailOverrideValue: boolean;
    useMailOverrideValueSpecified: boolean;
    useMailOverride: boolean | null;
    vauAbuOptOutWarningCodeValue: number;
    vauAbuOptOutWarningCodeValueSpecified: boolean;
    vauAbuOptOutWarningCode: number | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}
