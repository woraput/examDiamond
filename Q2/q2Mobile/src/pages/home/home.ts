import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { Products, GlobalVarible } from '../../app/models';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  public products: Products[];

  constructor(public navCtrl: NavController, private http: HttpClient) {

  }

  ionViewDidEnter() {
    this.http.get<Products[]>(GlobalVarible.host + "/api/POS").subscribe(
      (data) => {
        this.products = data;
        console.log(JSON.stringify(data));
        console.log(this.products);

      }
    )
  }

  addProduct() {
    this.navCtrl.push("AddProductPage")
  }
}