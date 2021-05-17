import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  registerUser: FormGroup = new FormGroup({
    name: new FormControl('', Validators.required),
    password: new FormControl('', [Validators.required, 
    Validators.minLength(4), Validators.maxLength(8)])
  });

  validationErrors: string[] = [];

  constructor(private accountService: AccountService) { }

  register(){
    this.accountService.register(this.registerUser.value).subscribe(response => {

    }, error => {
      console.log(error);
      this.validationErrors = error.error.errors;

      // TODO: Add errors to validation errors so they can be displayed
      
    });
  }


  ngOnInit(): void {
  }

}