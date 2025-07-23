import { Component } from '@angular/core';
import { OfferService } from '../../data-service/offer.service';
import { Offer } from '../../dto/offer';

@Component({
    selector: 'app-search-bar',
    templateUrl: './search-bar.component.html',
    styleUrls: ['./search-bar.component.css'],
})
export class SearchBarComponent {
    query: string = '';
    results: Offer[] = [];
    total: number = 0;

    constructor(private offerService: OfferService) {}

    onInput(): void {
        const trimmed = this.query.trim();

        if (!trimmed) {
            this.results = [];
            this.total = 0;
            return;
        }

        this.offerService.searchOffers(trimmed).subscribe((res) => {
            this.results = res.offers;
            this.total = res.totalCount;
        });
    }
}
