import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Register } from './register';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {

  constructor(private http: HttpClient) { }
  //TODO: #54 link to API = need to be filled in!!
  private registerUrl = 'https://localhost:44334/api/register';
  httpOptions = {
    headers: new HttpHeaders({'Content-Type':'application/json'})
  };


  // id vervangen door ...?

  getRegister(id: number): Observable<Register> {
    const url = `${this.registerUrl}/${id}`;
    const register = this.http.get<Register>(url);
    return register;
  }

  getRegisters(): Observable<Register[]>{
    const registers = this.http.get<Register[]>(this.registerUrl);
    return registers;
  }

  addRegister(register: Register): Observable<Register>{
    return this.http.post<Register>(this.registerUrl, register, this.httpOptions);
  } 

  updateRegister(register: Register| undefined): Observable<any> {
    return this.http.put(this.registerUrl, register, this.httpOptions);
  }

// TODO: geen ID in class register, dus id van register kan niet gebruikt worden

  // deleteRegister(register: Register): Observable<Register> {
  //   const url = `${this.registerUrl}/${register.id}`;
  //   return this.http.delete<Register>(url, this.httpOptions);
  // }



}
