import { Component, OnInit } from '@angular/core';
import { User } from '../user';
import { Appointment } from '../appointment';
@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.css']
})
export class UserDetailsComponent implements OnInit {
user?: User  ;
// = {
//   id:1,
//   email: "ward@impesoft.com",
//   firstName: "Ward",
//   surName:"Impe",
//   address:"Tervenen 47F, 9940, Ertvelde, België",
//   birthDate : new Date(1974, 4,19,4,50),
//   appointments: [] as Appointment[]
// }
save() :void {

}
  constructor() { }

  ngOnInit(): void {
    this.user = JSON.parse(localStorage.getItem('fullUser')||'{}');

  }

}
