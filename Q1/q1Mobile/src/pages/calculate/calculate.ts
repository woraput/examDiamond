import { LoanInterest, GlobalVarible } from './../../app/models';
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
  loanInterest: LoanInterest = new LoanInterest;
  private result: any;
  constructor(public navCtrl: NavController, private http: HttpClient, public navParams: NavParams) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad CalculatePage');
    this.loanInterest.interestRate = this.navParams.data;
    console.log("num", this.loanInterest.interestRate);
  }

  calculate() {
    console.log(this.loanInterest.balance);
    console.log(this.loanInterest.year);

    this.http.post(GlobalVarible.host + "/api/Calculate/", this.loanInterest).subscribe(
      (data) => {
        this.http.get(GlobalVarible.host + "/api/Calculate/").subscribe(
          (data) => {
            // alert(JSON.stringify(data));
            console.log(data);
            this.result = data;
            console.log(this.result);
          }
        )
      }
    )
  }

  back() {
    this.navCtrl.popToRoot();
  }

}
