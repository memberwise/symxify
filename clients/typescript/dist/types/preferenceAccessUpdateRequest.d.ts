import { PreferenceAccessFields_2 } from "./preferenceAccessFields_2";
export interface PreferenceAccessUpdateRequest {
    preferenceAccessLocatorValue: number;
    preferenceAccessLocatorValueSpecified: boolean;
    preferenceAccessLocator: number | null;
    preferenceAccessFields: PreferenceAccessFields_2;
}
