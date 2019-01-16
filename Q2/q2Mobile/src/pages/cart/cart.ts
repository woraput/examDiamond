import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { Carts, GlobalVarible } from '../../app/models';
import { HttpClient } from '@angular/common/http';

/**
 * Generated class for the CartPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-cart',
  templateUrl: 'cart.html',
})
export class CartPage {
  cart: Carts[];

  constructor(public navCtrl: NavController, private http: HttpClient, public navParams: NavParams) {
  }

  ionViewDidEnter() {
    this.http.get<Carts[]>(GlobalVarible.host + "/api/POS/GetCart").subscribe(
      (data) => {
        this.cart = data;
        // console.log(JSON.stringify(data));
        console.log(this.cart);

      }
    )
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad CartPage');
  }


  back() {
    this.navCtrl.push("HomePage");
  }
}
