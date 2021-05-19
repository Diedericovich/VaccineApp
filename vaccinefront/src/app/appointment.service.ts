import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Appointment } from './appointment';

@Injectable({
  providedIn: 'root'
})
export class AppointmentService {

  constructor(private http: HttpClient) { }
  //TODO: #54 link to API = need to be filled in!!
  private appointmentUrl = 'https://localhost:44317/api/api/Appointment';
  httpOptions = {
    headers: new HttpHeaders({'Content-Type':'application/json'})
  };


  
  // addAppointment(userId: Number, vaccinId: Number ): Observable<Appointment>{
  //   return this.http.post<Appointment>(this.appointmentUrl, userId, vaccinId, this.httpOptions);
  // } 




}
