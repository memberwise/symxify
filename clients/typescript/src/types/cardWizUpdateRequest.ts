import { CardWizFields_2 } from "./cardWizFields_2";

export interface CardWizUpdateRequest {
    cardWizCardTypeValue: number;
    cardWizCardTypeValueSpecified: boolean;
    cardWizCardType: number | null;
    cardWizFields: CardWizFields_2;
}