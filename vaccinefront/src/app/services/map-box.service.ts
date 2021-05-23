import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class MapBoxService {

  constructor(private http: HttpClient) { }
  private url = "https://api.mapbox.com/geocoding/v5/mapbox.places/";
  private endUrl = ".json?access_token=";
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };
  getGeocoding(address: string): Observable<GeoJSON.FeatureCollection> {
    const url = `https://api.mapbox.com/geocoding/v5/mapbox.places/${address}.json?access_token=${environment.mapboxKey}`;
    return this.http.get<any>(url);
  }
  getDirections(geocodes: number[]): Observable<GeoJSON.FeatureCollection> {
    const url = `https://api.mapbox.com/directions/v5/mapbox/cycling/${geocodes[0]},${geocodes[1]};${geocodes[2]},${geocodes[3]}?geometries=geojson`
    return this.http.get<any>(url);
  }
}
