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
  private appointmentUrl = 'https://localhost:44334/api/appointments';
  httpOptions = {
    headers: new HttpHeaders({'Content-Type':'application/json'})
  };


  getAppointment(id: number): Observable<Appointment> {
    const url = `${this.appointmentUrl}/${id}`;
    const appointment = this.http.get<Appointment>(url);
    return appointment;
  }

  getAppointments(): Observable<Appointment[]>{
    const appointments = this.http.get<Appointment[]>(this.appointmentUrl);
    return appointments;
  }

  addAppointment(appointment: Appointment): Observable<Appointment>{
    return this.http.post<Appointment>(this.appointmentUrl, appointment, this.httpOptions);
  } 

  updateAppointment(appointment: Appointment| undefined): Observable<any> {
    return this.http.put(this.appointmentUrl, appointment, this.httpOptions);
  }

  deleteAppointment(appointment: Appointment): Observable<Appointment> {
    const url = `${this.appointmentUrl}/${appointment.id}`;
    return this.http.delete<Appointment>(url, this.httpOptions);
  }



}
