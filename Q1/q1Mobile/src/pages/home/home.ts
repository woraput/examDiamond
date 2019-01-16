import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  private numOfInterest: number;
  constructor(public navCtrl: NavController, public navParams: NavParams) {

  }

  goCalculate() {
    this.navCtrl.push("CalculatePage", this.numOfInterest);
    console.log(this.numOfInterest);

  }
}
