import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { VaccinationCenter } from './vaccinationcenter';

@Injectable({
  providedIn: 'root'
})
export class VaccinationcenterService {

  constructor(private http: HttpClient) { }
  //TODO: #54 link to API = need to be filled in!!
  private vaccinationCenterUrl = 'https://localhost:44334/api/vaccinationcenters';
  httpOptions = {
    headers: new HttpHeaders({'Content-Type':'application/json'})
  };



  getVaccinationCenter(id: number): Observable<VaccinationCenter> {
    const url = `${this.vaccinationCenterUrl}/${id}`;
    const vaccinationcenter = this.http.get<VaccinationCenter>(url);
    return vaccinationcenter;
  }

  getVaccinationCenters(): Observable<VaccinationCenter[]>{
    const vaccinationcenters = this.http.get<VaccinationCenter[]>(this.vaccinationCenterUrl);
    return vaccinationcenters;
  }

  addVaccinationCenter(vaccinationcenter: VaccinationCenter): Observable<VaccinationCenter>{
    return this.http.post<VaccinationCenter>(this.vaccinationCenterUrl, vaccinationcenter, this.httpOptions);
  } 

  updateVaccination(vaccinationcenter: VaccinationCenter| undefined): Observable<any> {
    return this.http.put(this.vaccinationCenterUrl, vaccinationcenter, this.httpOptions);
  }

  deleteVaccination(vaccinationcenter: VaccinationCenter): Observable<VaccinationCenter> {
    const url = `${this.vaccinationCenterUrl}/${vaccinationcenter.id}`;
    return this.http.delete<VaccinationCenter>(url, this.httpOptions);
  }








}
