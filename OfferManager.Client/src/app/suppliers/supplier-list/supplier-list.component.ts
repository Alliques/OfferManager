import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-supplier-list',
    templateUrl: './supplier-list.component.html',
    styleUrl: './supplier-list.component.css',
})
export class SupplierListComponent implements OnInit {
    suppliers: any[] = [];

    constructor(private http: HttpClient) {}

    ngOnInit() {
        this.http.get<any[]>(`/api/supplier?top=3`).subscribe((data) => {
            this.suppliers = data;
        });
    }
}
