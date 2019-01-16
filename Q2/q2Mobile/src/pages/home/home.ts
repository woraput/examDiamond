import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { Products, GlobalVarible, Carts } from '../../app/models';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  public products: Products[];
  cart: Carts = new Carts;
  numOf: number;
  balance: number;
  constructor(public navCtrl: NavController, private http: HttpClient) {

  }

  ionViewDidEnter() {
    this.http.get<Products[]>(GlobalVarible.host + "/api/POS/Get").subscribe(
      (data) => {
        this.products = data;
        console.log(JSON.stringify(data));
        console.log(this.products);

      }
    )
  }

  addToCart(name: string, price: number) {
    this.cart.name = name;
    this.cart.price = price;
    this.http.post(GlobalVarible.host + "/api/POS/AddProductToCart", this.cart).subscribe(
      (success) => {
        console.log("send", this.products);

        this.navCtrl.popToRoot();
      }
    );
  }

  addProduct() {
    this.navCtrl.push("AddProductPage")
  }
}