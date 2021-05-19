import { Component, Input, OnInit } from '@angular/core';
import { User } from '../user';
import { Appointment } from '../appointment';


@Component({
  selector: 'app-appointments',
  templateUrl: './appointments.component.html',
  styleUrls: ['./appointments.component.css']
})
export class AppointmentsComponent implements OnInit {
  user: User = {
    id:1,
    email: "ward@impesoft.com",
    firstName: "Ward",
    surname:"Impe",
    address:"Tervenen 47F, 9940, Ertvelde, België",
    birthDate : new Date(1974, 4,19,4,50),
    appointments: [] as Appointment[]
  }
    constructor() { }

  ngOnInit(): void {
  }

}
