import { Component, OnInit, Output, EventEmitter} from '@angular/core';
import { Register } from '../interfaces/register';
import { Appointment } from '../interfaces/appointment';
import { Router } from '@angular/router';
import { AccountService } from '../services/account.service';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  verify?: string;
register: Register = {
  email: "",
  password: "",
  firstName: "",
  surName:"",
  address:"",
  birthDate : new Date(),
};
@Output() boolEvent = new EventEmitter<boolean>();
  constructor(private router: Router, private accountService : AccountService) { }

  ngOnInit(): void {
    // this.data.currentUser.subscribe(user => this.user = user )
  }
  Register(): void {
  if (this.register) {
    this.accountService
    .register(this.register)
    .subscribe(x => {
      this.boolEvent.emit(true);
      window.location.href = 'landing/body/home';


      
    }, retVal => {console.log(retVal)} );

  }
  }
  Cancel(): void {
    
  }
}
