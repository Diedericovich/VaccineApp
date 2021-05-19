import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Account } from './account';
import { map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class AccountService {
  private accountUrl = "https://localhost:44317/api/account"
  currentUser?: Account;

  constructor(private http: HttpClient) { }


  login(model: any): Observable<any> {
    let url = `${this.accountUrl}/login`;
    return this.http.post(url, model)
      .pipe(
        map(
          (response: any) => {
            const user: Account = response;
            if (user) {
              localStorage.setItem('user', JSON.stringify(user));
              this.currentUser = user;
            }
          })
      );
  };

}