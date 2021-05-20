import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from '../services/account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit  {
  model: any = {};
  @Output() boolEvent = new EventEmitter<boolean>();


  constructor(private accountService: AccountService, private router: Router) { }

  ngOnInit(): void {
  }


  login(): void {
    this.accountService.login(this.model)
    .subscribe(x => {
      console.log(x);
      this.boolEvent.emit(true);
      console.log('emitted');
      this.router.navigateByUrl('body'); 
    },
    error => { console.log(error);
    });
  }
  register(): void{
    
  }
    
}
