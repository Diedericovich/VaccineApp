import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-landingpage',
  templateUrl: './landingpage.component.html',
  styleUrls: ['./landingpage.component.css'],
})
export class LandingpageComponent implements OnInit {
  isLoggedIn: boolean = false;
  constructor() {}

  ngOnInit(): void {
    console.log('entered');

    if (localStorage.getItem('user') != null) {
      console.log('loggedin');
      this.isLoggedIn = true;
    }
  }
  receiverBool($event: boolean) {
    console.log('reveived');
    this.isLoggedIn = $event;
  }
}
