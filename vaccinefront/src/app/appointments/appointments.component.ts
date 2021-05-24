import { Component, Input, OnInit } from '@angular/core';
import { User } from '../interfaces/user';
import { Appointment } from '../interfaces/appointment';
import { AppointmentService } from '../services/appointment.service';
import { UserService } from '../services/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-appointments',
  templateUrl: './appointments.component.html',
  styleUrls: ['./appointments.component.css'],
})
export class AppointmentsComponent implements OnInit {
  user?: User;
  email?: string;
  completed: boolean = false;

  constructor(
    private appointmentService: AppointmentService,
    private userService: UserService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.email = JSON.parse(localStorage.getItem('user') || '{}').email;

    if (this.email) {
      this.userService.getUserByEmail(this.email).subscribe((x) => {
        this.user = x;
      });
    }
  }
  CancelAppointment(appointmentId: number): void {
    this.appointmentService
      .updateAppointmentStatus(appointmentId, 2)
      .subscribe();
    this.reloadCurrentRoute();
  }

  reloadCurrentRoute() {
    let currentUrl = this.router.url;
    this.router.navigateByUrl('/', { skipLocationChange: true }).then(() => {
      this.router.navigate([currentUrl]);
    });
  }
  scheduled() {
    return (
      this.user?.appointments.filter(
        (appointment) => appointment.status.id == 1
      ) || []
    );
  }
  canceledAndCompleted() {
    return (
      this.user?.appointments.filter(
        (appointment) => appointment.status.id >= 2
      ) || []
    );
  }
  switchButton(): void {
    this.completed = !this.completed;
  }
}
