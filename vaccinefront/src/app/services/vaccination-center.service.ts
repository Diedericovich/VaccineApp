import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { VaccinationCenter } from '../interfaces/vaccinationcenter';

@Injectable({
  providedIn: 'root'
})
export class VaccinationCenterService {

  constructor(private http: HttpClient) { }
  private url = 'https://localhost:44317/api/VaccinationCenter';
  httpOptions = {
    headers: new HttpHeaders({Authorization: `Bearer ${JSON.parse(localStorage.getItem('user')||'{}').token}`})
  };
  getCenters(): Observable<VaccinationCenter[]>{
    const centers = this.http.get<VaccinationCenter[]>(this.url, this.httpOptions);
    return centers
  }
}
