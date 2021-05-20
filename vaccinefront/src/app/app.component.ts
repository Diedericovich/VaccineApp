import { Component, OnInit, ViewChild } from '@angular/core';
import { LoginComponent } from './login/login.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  isLoggedIn: boolean = false;
  
  ngOnInit(): void {
    console.log('entered')

    if (localStorage.getItem('user')!= null)
     {
       console.log('loggedin')
       this.isLoggedIn = true;
     }
  }
  receiverBool($event : boolean) {
    console.log('reveived');
    this.isLoggedIn = $event;
  }
}
