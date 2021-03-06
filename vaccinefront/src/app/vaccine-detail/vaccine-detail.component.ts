import { Component, OnInit, Input } from '@angular/core';
import { AppointmentService } from '../services/appointment.service';
import { UserService } from '../services/user.service';
import { User } from '../interfaces/user';
import { Vaccine } from '../interfaces/vaccine';
import { Router } from '@angular/router';
@Component({
  selector: 'app-vaccine-detail',
  templateUrl: './vaccine-detail.component.html',
  styleUrls: ['./vaccine-detail.component.css'],
})
export class VaccineDetailComponent implements OnInit {
  @Input() vaccine?: Vaccine;
  constructor(
    private route: Router,
    private appointmentService: AppointmentService
  ) {}
  ngOnInit(): void {}
  createAppointment() {
    if (this.vaccine) {
      let userId = JSON.parse(localStorage.getItem('user') || '{}').id;
      this.appointmentService
        .addAppointment(userId, this.vaccine.id)
        .subscribe();
        window.location.href = 'landing/appointments';
    }
  }
}
