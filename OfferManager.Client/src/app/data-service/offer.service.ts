import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Offer } from '../dto/offer';
import { OfferSearchResultDto } from '../dto/offerSearchResultDto';
import { SupplierStat } from '../dto/supplierStat';

@Injectable({
    providedIn: 'root',
})
export class OfferService {
    constructor(private http: HttpClient) {}

    getAllOffers(): Observable<Offer[]> {
        return this.http.get<Offer[]>('/api/offer');
    }

    searchOffers(query: string): Observable<OfferSearchResultDto> {
        return this.http.get<OfferSearchResultDto>(
            `/api/offer?query=${encodeURIComponent(query)}`
        );
    }

    getTopSuppliers(): Observable<SupplierStat[]> {
        return this.http.get<SupplierStat[]>(`/api/supplier?top=3`);
    }
}
