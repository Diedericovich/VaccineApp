import { Component, OnInit} from '@angular/core';
import { Register } from '../register';
import { Appointment } from '../appointment';
import { Router } from '@angular/router';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
register: Register = {
  email: "ward@impesoft.com",
  password: "",
  firstName: "Ward",
  surName:"Impe",
  address:"Tervenen 47F, 9940, Ertvelde, België",
  birthDate : new Date(1974, 4,19,4,50),
};
Register(): void {
  
}
  constructor(private router: Router) { }

  ngOnInit(): void {
    // this.data.currentUser.subscribe(user => this.user = user )
  }

}
