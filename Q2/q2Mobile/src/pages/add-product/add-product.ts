import { Products, GlobalVarible } from './../../app/models';
import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

/**
 * Generated class for the AddProductPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-add-product',
  templateUrl: 'add-product.html',
})
export class AddProductPage {
   products: Products = new Products;
  constructor(public navCtrl: NavController, private http: HttpClient, public navParams: NavParams) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad AddProductPage');
  }

  addProduct() {
    console.log(this.products.name);
    console.log(this.products.price);

    this.http.post(GlobalVarible.host + "/api/POS/AddProduct", this.products).subscribe(
      (success) => {
        console.log("send", this.products);

        this.navCtrl.popToRoot();
      }
    );
  }

}
