import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

/**
 * Generated class for the CalculatePage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-calculate',
  templateUrl: 'calculate.html',
})
export class CalculatePage {
  private numOfInterest: number;
  private year: number;
  private balance: number;
  private result: any;
  constructor(public navCtrl: NavController, private http: HttpClient, public navParams: NavParams) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad CalculatePage');
    this.numOfInterest = this.navParams.data;
    console.log("num", this.numOfInterest);
  }

  calculate() {
    console.log(this.year);
    console.log(this.balance);

    this.http.get("https://localhost:5001/api/Calculate/" + this.balance + '/' + this.numOfInterest + '/' + this.year).subscribe(
      (data) => {
        // alert(JSON.stringify(data));
        console.log(data);
        this.result = data;
        console.log(this.result);


      }
    )
  }

  back() {
    this.navCtrl.popToRoot();
  }

}
