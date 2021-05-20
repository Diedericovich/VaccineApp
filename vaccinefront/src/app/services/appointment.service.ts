import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Appointment } from '../appointment';
import { UserService } from './user.service';
import { User } from '../user';

@Injectable({
  providedIn: 'root'
})
export class AppointmentService {
  constructor(private http: HttpClient) { }
  //TODO: #54 link to API = need to be filled in!!
  private appointmentUrl = 'https://localhost:44317/api/Appointment';
  httpOptions = {
    headers: new HttpHeaders({'Content-Type':'application/json'})
  };


  
  addAppointment(userId: number, vaccinId: number ): Observable<Appointment>{
    
    const url = `${this.appointmentUrl}/${userId}/${vaccinId}`;
    return this.http.post<Appointment>(url, this.httpOptions);
  } 




}
