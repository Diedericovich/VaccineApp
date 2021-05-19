import { Component, OnInit } from '@angular/core';
import { AccountService } from '../account.service';

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.css']
})
export class NavigationComponent implements OnInit {
  title = 'Vaxx.id';
  model: any = {};
  loggedIn: boolean = false;

  constructor(private accountService: AccountService) { }

  ngOnInit(): void {
  }

login(): void {
  this.accountService.login(this.model)
  .subscribe(x => {
    this.loggedIn = true;
    console.log(x);
  },
  error => { console.log(error);
  }
  );
}

}
