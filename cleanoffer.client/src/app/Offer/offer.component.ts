import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-offer',
  templateUrl: './offer.component.html',
  styleUrls: ['./offer.component.css']
})
export class OfferComponent {
  offer = {
    city: '',
    squareMeters: 0,
    windowCleaning: false,
    balconyCleaning: false,
    trashRemoval: false,
    totalPrice: undefined
  };

  constructor(private http: HttpClient)
  {

  }



  calculateOffer() {
    this.http.post('https://localhost:7031/api/offer', this.offer).subscribe((result: any) => {
      this.offer.totalPrice = result.totalPrice;
    });
  }
}
