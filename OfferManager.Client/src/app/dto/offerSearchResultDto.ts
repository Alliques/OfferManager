import { Offer } from './offer';

export interface OfferSearchResultDto {
    offers: Offer[];
    totalCount: number;
}
