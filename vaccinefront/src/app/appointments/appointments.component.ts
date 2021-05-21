import { Component, Input, OnInit } from '@angular/core';
import { User } from '../interfaces/user';
import { Appointment } from '../interfaces/appointment';
import { AppointmentService } from '../services/appointment.service';
import { UserService } from '../services/user.service';


@Component({
  selector: 'app-appointments',
  templateUrl: './appointments.component.html',
  styleUrls: ['./appointments.component.css']
})
export class AppointmentsComponent implements OnInit {
  user?: User ;
  email?: string;

    constructor(private appointmentService : AppointmentService, private userService : UserService) { }

  ngOnInit(): void {
    this.email = JSON.parse(localStorage.getItem('user')||'{}').email;

   // this.user = JSON.parse(localStorage.getItem('fullUser')||'{}');
if (this.email) {
  this.userService.getUserByEmail(this.email).subscribe(x => {this.user= x})
}
  }
  CancelAppointment(appointmentId: number):void {
    this.appointmentService.updateAppointmentStatus(appointmentId, 2).subscribe();
    console.log('ok ok, I got here...');
  }
}
