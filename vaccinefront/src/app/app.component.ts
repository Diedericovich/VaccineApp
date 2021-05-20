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
    if (localStorage.getItem('user')!= null)
     {
       this.isLoggedIn = true;
     }
  }
  receiverBool($event:any) {
    this.isLoggedIn = $event;
  }
}
