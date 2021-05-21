import { Component, OnInit, Input } from '@angular/core';
import { AppointmentService } from '../services/appointment.service';
import { UserService } from '../services/user.service';
import { User } from '../interfaces/user';
import { Vaccine } from '../interfaces/vaccine';
@Component({
  selector: 'app-vaccine-detail',
  templateUrl: './vaccine-detail.component.html',
  styleUrls: ['./vaccine-detail.component.css']
})
export class VaccineDetailComponent implements OnInit {
  user? : User;
  @Input() vaccine?: Vaccine;
  constructor(private userService: UserService, private appointmentService : AppointmentService) { }
  ngOnInit(): void {
    this.user = JSON.parse(localStorage.getItem('fullUser')||'{}');

  }
  createAppointment() {
  if (this.user && this.vaccine) {
    this.appointmentService.addAppointment(this.user.id, this.vaccine.id).subscribe();
    this.userService.getUser(this.user.id).subscribe(x => { this.user = x; localStorage.setItem('fullUser',JSON.stringify(this.user));})

  }

  }

}
