import { Component, OnInit } from '@angular/core';
import { User } from '../interfaces/user';
import { Appointment } from '../interfaces/appointment';
import { Router } from '@angular/router';
import { UserService } from '../services/user.service';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-edit-profile',
  templateUrl: './edit-profile.component.html',
  styleUrls: ['./edit-profile.component.css'],
})
export class EditProfileComponent implements OnInit {
  user?: User;
  userProfile: FormGroup = new FormGroup({
    email: new FormControl('', [
      Validators.required,
      Validators.minLength(4),
      Validators.maxLength(100),
    ]),
    firstName: new FormControl('', [
      Validators.required,
      Validators.maxLength(30),
    ]),
    surname: new FormControl('', [
      Validators.required,
      Validators.maxLength(55),
    ]),
    address: new FormControl('', [
      Validators.required,
      Validators.maxLength(100),
    ]),
    birthDate: new FormControl('', Validators.required),
  });

  validationErrors: string[] = [];

  email?: string;

  constructor(private router: Router, private userService: UserService) {}

  ngOnInit(): void {
    this.email = JSON.parse(localStorage.getItem('user') || '{}').email;
    if (this.email) {
      this.userService.getUserByEmail(this.email).subscribe((x) => {
        this.user = x;
        this.userProfile.setValue({
          email: this.user.email,
          firstName: this.user.firstName,
          surname: this.user.surname,
          address: this.user.address,
          birthDate: this.user.birthDate,
        });
      });
    }
  }

  updateUser(user: User) {
    if (user) {
      user.email = this.userProfile.value.email;
      user.firstName = this.userProfile.value.firstName;
      user.surname = this.userProfile.value.surname;
      user.address = this.userProfile.value.address;
      user.birthDate = this.userProfile.value.birthDate;

      this.userService.updateUser(this.user).subscribe();
      let localStorageUser = JSON.parse(localStorage.getItem('user') || '{}');
      localStorageUser.email = user.email;
      localStorage.setItem('user', JSON.stringify(localStorageUser));
      this.router.navigateByUrl('landing/user-details');
    }
  }

}
