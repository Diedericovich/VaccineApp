import { Component, Input, OnInit } from '@angular/core';
import { User } from '../user';
import { Appointment } from '../appointment';


@Component({
  selector: 'app-appointments',
  templateUrl: './appointments.component.html',
  styleUrls: ['./appointments.component.css']
})
export class AppointmentsComponent implements OnInit {
  user?: User ;
    constructor() { }

  ngOnInit(): void {
    this.user = JSON.parse(localStorage.getItem('fullUser')||'{}');
  }

}
