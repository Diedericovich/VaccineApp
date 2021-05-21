import { Component, OnInit } from '@angular/core';
import { Login } from '../interfaces/login';
import { UserService } from '../services/user.service';
import { User } from '../interfaces/user';

@Component({
  selector: 'app-body',
  templateUrl: './body.component.html',
  styleUrls: ['./body.component.css']
})
export class BodyComponent implements OnInit {
user? : User;
loggedInUser? : Login;
  constructor(private userService: UserService) { }

  ngOnInit(): void {
        this.loggedInUser = JSON.parse(localStorage.getItem('User')||'{}');
    if (this.loggedInUser!=null) {
      this.userService.getUserByEmail(this.loggedInUser.email).subscribe(user => this.user = user);
      console.log(this.user);     
    }
  }

}
