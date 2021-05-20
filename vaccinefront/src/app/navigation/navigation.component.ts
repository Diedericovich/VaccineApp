import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from '../services/account.service';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.css']
})
export class NavigationComponent implements OnInit {

  title = 'Vaxx.id';
  model: any = {};
  loggedIn: boolean = false;

  constructor(private accountService: AccountService, private userService: UserService, private router: Router) { }

  ngOnInit(): void {
  }

login(): void {
  this.accountService.login(this.model)
  .subscribe(x => {
    this.loggedIn = true;
    console.log(x);
    this.router.navigateByUrl('user-details'); 
  },
  error => { console.log(error);
  }
  );
  
  //this.userService.getUserByEmail(JSON.parse(localStorage.getItem('user')||'{}').email)
  //console.log(this.dataStore.changeUser);
}

}
