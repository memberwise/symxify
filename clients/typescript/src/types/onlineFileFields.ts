import { VersionType } from "./versionType";
import { XmlElement } from "./xmlElement";

export interface OnlineFileFields {
    availBalExclListValue: boolean;
    availBalExclListValueSpecified: boolean;
    availBalExclList: boolean | null;
    availBalInclOdProtectionValue: boolean;
    availBalInclOdProtectionValueSpecified: boolean;
    availBalInclOdProtection: boolean | null;
    availBalInclOdToleranceValue: boolean;
    availBalInclOdToleranceValueSpecified: boolean;
    availBalInclOdTolerance: boolean | null;
    bonusAwardsTrackingTypeValue: boolean;
    bonusAwardsTrackingTypeValueSpecified: boolean;
    bonusAwardsTrackingType: boolean | null;
    cardFraudNoteExpDaysValue: boolean;
    cardFraudNoteExpDaysValueSpecified: boolean;
    cardFraudNoteExpDays: boolean | null;
    cardTypeValue: boolean;
    cardTypeValueSpecified: boolean;
    cardType: boolean | null;
    digitalIssueTrackingTypeValue: boolean;
    digitalIssueTrackingTypeValueSpecified: boolean;
    digitalIssueTrackingType: boolean | null;
    excludedStatusReasonCodesValue: boolean;
    excludedStatusReasonCodesValueSpecified: boolean;
    excludedStatusReasonCodes: boolean | null;
    fileRecordValue: boolean;
    fileRecordValueSpecified: boolean;
    fileRecord: boolean | null;
    fileTypeValue: boolean;
    fileTypeValueSpecified: boolean;
    fileType: boolean | null;
    fileUpdateMethodValue: boolean;
    fileUpdateMethodValueSpecified: boolean;
    fileUpdateMethod: boolean | null;
    fraudControlTrackingTypeValue: boolean;
    fraudControlTrackingTypeValueSpecified: boolean;
    fraudControlTrackingType: boolean | null;
    fwdUpdateToPinNetworkValue: boolean;
    fwdUpdateToPinNetworkValueSpecified: boolean;
    fwdUpdateToPinNetwork: boolean | null;
    fwdUpdatesfrmOtherNetworksValue: boolean;
    fwdUpdatesfrmOtherNetworksValueSpecified: boolean;
    fwdUpdatesfrmOtherNetworks: boolean | null;
    fwdUpdatetoVisaMasterCardValue: boolean;
    fwdUpdatetoVisaMasterCardValueSpecified: boolean;
    fwdUpdatetoVisaMasterCard: boolean | null;
    highPriorityMsgOptionValue: boolean;
    highPriorityMsgOptionValueSpecified: boolean;
    highPriorityMsgOption: boolean | null;
    institutionIdValue: boolean;
    institutionIdValueSpecified: boolean;
    institutionId: boolean | null;
    limitGroupIdValue: boolean;
    limitGroupIdValueSpecified: boolean;
    limitGroupId: boolean | null;
    minimumBalanceChangeValue: boolean;
    minimumBalanceChangeValueSpecified: boolean;
    minimumBalanceChange: boolean | null;
    networkMessageFormatValue: boolean;
    networkMessageFormatValueSpecified: boolean;
    networkMessageFormat: boolean | null;
    onlineCardOrderingValue: boolean;
    onlineCardOrderingValueSpecified: boolean;
    onlineCardOrdering: boolean | null;
    purgeDaysValue: boolean;
    purgeDaysValueSpecified: boolean;
    purgeDays: boolean | null;
    receiveCardFraudNoteCodeValue: boolean;
    receiveCardFraudNoteCodeValueSpecified: boolean;
    receiveCardFraudNoteCode: boolean | null;
    sendActivationMessageValue: boolean;
    sendActivationMessageValueSpecified: boolean;
    sendActivationMessage: boolean | null;
    sendBalancesValue: boolean;
    sendBalancesValueSpecified: boolean;
    sendBalances: boolean | null;
    sendCardFraudNoteCodeValue: boolean;
    sendCardFraudNoteCodeValueSpecified: boolean;
    sendCardFraudNoteCode: boolean | null;
    sendNewCardOptionValue: boolean;
    sendNewCardOptionValueSpecified: boolean;
    sendNewCardOption: boolean | null;
    sendPinOffsetMessageValue: boolean;
    sendPinOffsetMessageValueSpecified: boolean;
    sendPinOffsetMessage: boolean | null;
    suffixFormatValue: boolean;
    suffixFormatValueSpecified: boolean;
    suffixFormat: boolean | null;
    thirdPartyPayments: number[];
    thirdPartyPaymentsSpecified: boolean;
    useMailOverrideValue: boolean;
    useMailOverrideValueSpecified: boolean;
    useMailOverride: boolean | null;
    vauAbuOptOutWarningCodeValue: boolean;
    vauAbuOptOutWarningCodeValueSpecified: boolean;
    vauAbuOptOutWarningCode: boolean | null;
    version1: VersionType;
    any: XmlElement[];
    anySpecified: boolean;
}