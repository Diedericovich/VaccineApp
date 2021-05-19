import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Account } from '../account';
import { map } from 'rxjs/operators';
import { UserService } from './user.service';
import { User } from '../user';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  private accountUrl = "https://localhost:44317/api/Account"
  currentUser?: Account;
  fullUser? : User;
  constructor(private http: HttpClient, private userService : UserService) { }

  login(model: any): Observable<any> {
    let url = `${this.accountUrl}/Login`;
    return this.http.post(url, model)
      .pipe(
        map(
          (response: any) => {
            const user: Account = response;
            if (user) {
              localStorage.setItem('user', JSON.stringify(user));
              this.currentUser = user;
              this.userService.getUserByEmail(this.currentUser.email)
              .subscribe(fullUser => 
                {this.fullUser = fullUser; 
                localStorage.setItem('fullUser',JSON.stringify(this.fullUser));
            });
            }
          })
      );
    };
    

  
}