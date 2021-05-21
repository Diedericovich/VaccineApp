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
  user?: User ;
  userProfile: FormGroup = new FormGroup({
    email: new FormControl( '', [Validators.required, Validators.minLength(4), Validators.maxLength(100)]),
    password: new FormControl('', [Validators.required, Validators.minLength(4), Validators.maxLength(50)]),
    firstName: new FormControl('', [Validators.required, Validators.maxLength(30)]),
    surName: new FormControl('', [Validators.required, Validators.maxLength(55)]),
    address: new FormControl('', [Validators.required, Validators.maxLength(100)]),
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
        this.userProfile.setValue( this.user);
      });
    }
  }
  // this.data.currentUser?.subscribe(user => this.user = user )
  updateUser(user: User) {
    this.userService.updateUser(this.user).subscribe();
    if (user) {
      localStorage.setItem('user', JSON.stringify(user));
    }
    this.router.navigateByUrl('landing/user-details');
  }
}
