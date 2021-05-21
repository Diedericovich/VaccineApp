import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Appointment } from '../interfaces/appointment';
import { UserService } from './user.service';
import { User } from '../interfaces/user';
import { Vaccine } from '../interfaces/vaccine';
import { Status } from '../interfaces/status';

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
  
  updateAppointmentStatus(appointmentId: number, statusId : number): Observable<any> {
    const url = `${this.appointmentUrl}/${appointmentId}/${statusId}`;
    return this.http.put(url, this.httpOptions);
  }

  addAppointment(userId: number, vaccinId: number ): Observable<Appointment>{
    
    const url = `${this.appointmentUrl}/${userId}/${vaccinId}`;
    return this.http.post<Appointment>(url, this.httpOptions);
  } 



}
