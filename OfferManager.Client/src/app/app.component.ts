import { Component } from '@angular/core';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
})
export class AppComponent {
    query: string = '';
    activeTab: 'suppliers' | 'search' | 'offers' = 'suppliers';

    searchOffers(q: string) {
        this.query = q;
        this.activeTab = 'offers'; // переключаемся на офферы после поиска
    }

    selectTab(tab: 'suppliers' | 'search' | 'offers') {
        this.activeTab = tab;
    }
}
