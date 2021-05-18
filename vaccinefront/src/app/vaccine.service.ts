import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Vaccine } from './vaccine';

@Injectable({
  providedIn: 'root'
})
export class VaccineService {

  constructor(private http: HttpClient) { }
  //TODO: link to API = need to be filled in!!
  private vaccineUrl = 'https://localhost:44334/api/vaccines';
  httpOptions = {
    headers: new HttpHeaders({'Content-Type':'application/json'})
  };

  getVaccine(id: number): Observable<Vaccine> {
    const url = `${this.vaccineUrl}/${id}`;
    const vaccine = this.http.get<Vaccine>(url);
    return vaccine;
  }

  getVaccins(): Observable<Vaccine[]>{
    const vaccines = this.http.get<Vaccine[]>(this.vaccineUrl);
    return vaccines;
  }

  addVaccin(vaccine: Vaccine): Observable<Vaccine>{
    return this.http.post<Vaccine>(this.vaccineUrl, vaccine, this.httpOptions);
  } 

  updateVaccin(vaccine: Vaccine| undefined): Observable<any> {
    return this.http.put(this.vaccineUrl, vaccine, this.httpOptions);
  }

  deleteVaccin(vaccine: Vaccine): Observable<Vaccine> {
    const url = `${this.vaccineUrl}/${vaccine.id}`;
    return this.http.delete<Vaccine>(url, this.httpOptions);
  }












}
