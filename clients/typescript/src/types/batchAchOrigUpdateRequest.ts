import { BatchAchOrigFields_2 } from "./batchAchOrigFields_2";

export interface BatchAchOrigUpdateRequest {
    batchAchOrigLocatorValue: number;
    batchAchOrigLocatorValueSpecified: boolean;
    batchAchOrigLocator: number | null;
    batchAchOrigFields: BatchAchOrigFields_2;
}