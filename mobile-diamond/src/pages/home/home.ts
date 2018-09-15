import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  constructor(public navCtrl: NavController) {
     ionViewDidEnter() { //api get
    this.http.get<Locker[]>(GlobalVarible.host + "http://node21.codenvy.io:40916/api/values/" + number)
      .subscribe(data => {
        this. = data;
      });

     }
  }

    CheckNumber()
    {
    
    }   
}
