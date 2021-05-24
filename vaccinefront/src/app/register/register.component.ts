import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { AccountService } from '../services/account.service';
import { FormControl, FormGroup, Validators } from '@angular/forms';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  verify?: string;
  registerUser: FormGroup = new FormGroup({
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
    firstName: new FormControl('', [
      Validators.required,
      Validators.maxLength(30),
    ]),
    surName: new FormControl('', [
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
  @Output() boolEvent = new EventEmitter<boolean>();
  constructor(private accountService: AccountService) {}

  ngOnInit(): void {}
  register(): void {
    if (this.registerUser) {
      this.accountService.register(this.registerUser.value).subscribe(
        (x) => {
          this.boolEvent.emit(true);
          window.location.href = 'landing/body/home';
        },
        (error) => {
          console.log(error);
          this.validationErrors.pop();
          this.validationErrors.push(error.error);
        }
      );
    }
  }
  cancel(): void {
    window.location.href = '/';
  }
}
