import { PortfolioNoteFields_2 } from "./portfolioNoteFields_2";

export interface PortfolioNoteUpdateRequest {
    portfolioNoteLocator: number | null;
    portfolioNoteFields: PortfolioNoteFields_2;
}