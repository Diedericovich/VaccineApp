import { HttpClient , HttpHeaders} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MapBoxService {

  constructor(private http: HttpClient) { }
  private url = "https://api.mapbox.com/geocoding/v5/mapbox.places/";
  private endUrl =".json?access_token=pk.eyJ1IjoiY3liZXJkYXJrIiwiYSI6ImNrb3ZtdDJrbzA5bm0ycXBlaWQ0MmtnZjQifQ.NHdesdchvpDXhsv4ORaNLA";
  httpOptions = {
    headers: new HttpHeaders({'Content-Type':'application/json'})
  };
  getGeocoding(address: string): Observable<GeoJSON.FeatureCollection>{
    const url = `https://api.mapbox.com/geocoding/v5/mapbox.places/${address}.json?access_token=pk.eyJ1IjoiY3liZXJkYXJrIiwiYSI6ImNrb3ZtdDJrbzA5bm0ycXBlaWQ0MmtnZjQifQ.NHdesdchvpDXhsv4ORaNLA`;
    return this.http.get<any>(url);
  }
}
