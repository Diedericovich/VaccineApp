import { Component, Input, OnInit } from '@angular/core';
import { User } from '../user';
import { Appointment } from '../appointment';
import { AppointmentService } from '../services/appointment.service';
import { UserService } from '../services/user.service';


@Component({
  selector: 'app-appointments',
  templateUrl: './appointments.component.html',
  styleUrls: ['./appointments.component.css']
})
export class AppointmentsComponent implements OnInit {
  user?: User ;
    constructor(private appointmentService : AppointmentService, userService : UserService) { }

  ngOnInit(): void {
    this.user = JSON.parse(localStorage.getItem('fullUser')||'{}');
  }
  CancelAppointment(appointmentId: number):void {
    this.appointmentService.updateAppointmentStatus(appointmentId, 2)
    //console.log('ok ok, I got here...');
  }
}
