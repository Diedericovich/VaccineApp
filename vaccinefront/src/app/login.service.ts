import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Login } from './login';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private http: HttpClient) { }
  //TODO: #54 link to API = need to be filled in!!
  private loginUrl = 'https://localhost:44334/api/login';
  httpOptions = {
    headers: new HttpHeaders({'Content-Type':'application/json'})
  };


  // id vervangen door ...?

  getLogin(id: number): Observable<Login> {
    const url = `${this.loginUrl}/${id}`;
    const login = this.http.get<Login>(url);
    return login;
  }

  getLogins(): Observable<Login[]>{
    const logins = this.http.get<Login[]>(this.loginUrl);
    return logins;
  }

  addLogin(login: Login): Observable<Login>{
    return this.http.post<Login>(this.loginUrl, login, this.httpOptions);
  } 

  updateLogin(login: Login| undefined): Observable<any> {
    return this.http.put(this.loginUrl, login, this.httpOptions);
  }


// TODO: geen ID in login register, dus id van login kan niet gebruikt worden


  // deleteLogin(login: Login): Observable<Login> {
  //   const url = `${this.loginUrl}/${login.id}`;
  //   return this.http.delete<Login>(url, this.httpOptions);
  // }







}
