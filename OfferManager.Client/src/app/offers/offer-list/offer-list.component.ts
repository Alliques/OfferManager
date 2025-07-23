import { HttpClient } from '@angular/common/http';
import { Component, Input, OnChanges } from '@angular/core';

@Component({
    selector: 'app-offer-list',
    templateUrl: './offer-list.component.html',
    styleUrl: './offer-list.component.css',
})
export class OfferListComponent implements OnChanges {
    @Input() query: string = '';
    offers: any[] = [];
    total: number = 0;

    constructor(private http: HttpClient) {}

    ngOnChanges() {
        this.http.get<any>(`/api/offer`).subscribe((result) => {
            this.offers = result.offers;
            this.total = result.totalCount;
        });
    }
}
