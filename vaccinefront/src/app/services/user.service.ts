import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../interfaces/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }
  //TODO: link to API = need to be filled in!!
  private userUrl = 'https://localhost:44317/api/User';
  httpOptions = {
    headers: new HttpHeaders({'Content-Type':'application/json'})
  };

  getUser(id: number): Observable<User> {
    const url = `${this.userUrl}/${id}`;
    const user = this.http.get<User>(url);
    return user;
  }
  getUserByEmail(email: string): Observable<User> {
    const url = `${this.userUrl}/${email}`;
    const user = this.http.get<User>(url);
    return user;
  }

  getUsers(): Observable<User[]>{
    const users = this.http.get<User[]>(this.userUrl);
    return users;
  }

  addUser(user: User): Observable<User>{
    return this.http.post<User>(this.userUrl, user, this.httpOptions);
  } 

  updateUser(user: User| undefined): Observable<any> {
    return this.http.put(this.userUrl, user, this.httpOptions);
  }

  deleteUser(user: User): Observable<User> {
    const url = `${this.userUrl}/${user.id}`;
    return this.http.delete<User>(url, this.httpOptions);
  }

}


