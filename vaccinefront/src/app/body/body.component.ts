import { Component, OnInit } from '@angular/core';
import { Login } from '../interfaces/login';
import { UserService } from '../services/user.service';
import { User } from '../interfaces/user';
import { Router } from '@angular/router';

@Component({
  selector: 'app-body',
  templateUrl: './body.component.html',
  styleUrls: ['./body.component.css'],
})
export class BodyComponent implements OnInit {
  user?: User;
  loggedInUser?: Login;
  bodypart?: string = '';
  constructor(private userService: UserService, private router: Router) {
    this.selectBodypart('');
  }

  ngOnInit(): void {
    this.loggedInUser = JSON.parse(localStorage.getItem('User') || '{}');
    if (this.loggedInUser != null) {
      this.userService
        .getUserByEmail(this.loggedInUser.email)
        .subscribe((user) => (this.user = user));
      console.log(this.user);
    }
  }
  selectBodypart(bodypart: string) {
    switch (bodypart) {
      case 'head':
        this.bodypart = bodypart;
        this.router.navigateByUrl('landing/body/head');
        break;
      case 'torso':
        this.bodypart = bodypart;
        this.router.navigateByUrl('landing/body/torso');

        break;
      case 'leftarm':
        this.bodypart = bodypart;
        this.router.navigateByUrl('landing/body/leftarm');

        break;
      case 'rightarm':
        this.bodypart = bodypart;
        this.router.navigateByUrl('landing/body/rightarm');

        break;
      case 'legs':
        this.bodypart = bodypart;
        this.router.navigateByUrl('landing/body/legs');

        break;
      default:
        this.bodypart = '';
        break;
    }
  }
}
