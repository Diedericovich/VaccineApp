import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AccountService } from '../services/account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  loginUser: FormGroup = new FormGroup({
    email: new FormControl('', [
      Validators.required,
      Validators.minLength(4),
      Validators.maxLength(100),
    ]),
    password: new FormControl('', [
      Validators.required,
      Validators.minLength(4),
      Validators.maxLength(50),
    ]),
  });
  validationErrors: string[] = [];
  isRegistering: boolean = false;
  @Output() boolEvent = new EventEmitter<boolean>();

  constructor(private accountService: AccountService, private router: Router) {}

  ngOnInit(): void {}

  login(): void {
    this.accountService.login(this.loginUser.value).subscribe(
      (x) => {
        console.log(x);
        this.boolEvent.emit(true);
        console.log('emitted');
        this.router.navigateByUrl('landing/body');
      },
      (error) => {
        this.validationErrors.push(error.error);
        console.log(error);
      }
    );
  }
  register(): void {
    console.log('supp doc?');
    this.isRegistering = true;
  }
}
