import { Component, OnInit } from '@angular/core';
import { User } from '../interfaces/user';
import { Appointment } from '../interfaces/appointment';
import { UserService } from '../services/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.css'],
})
export class UserDetailsComponent implements OnInit {
  user?: User;
  email?: string;

  constructor(
    private router: Router,
    private userService: UserService
        ) {}

  ngOnInit(): void {
    this.email = JSON.parse(localStorage.getItem('user') || '{}').email;
    if (this.email) {
      this.userService.getUserByEmail(this.email).subscribe((x) => {
        this.user = x;
      });
    }
  }

}
