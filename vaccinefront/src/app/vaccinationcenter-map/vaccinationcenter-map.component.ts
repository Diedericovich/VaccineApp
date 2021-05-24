import { Component, OnInit } from '@angular/core';
import * as mapboxgl from 'mapbox-gl';
import { environment } from '../../environments/environment';
import { VaccinationCenter } from '../interfaces/vaccinationcenter';
import { MapBoxService } from '../services/map-box.service';
import { VaccinationCenterService } from '../services/vaccination-center.service';


@Component({
  selector: 'app-maptest',
  templateUrl: './vaccinationcenter-map.html',
  styleUrls: ['./vaccinationcenter-map.component.css']
})
export class VaccinationCenterMapComponent implements OnInit {
  centers: VaccinationCenter[] = [];
  map?: mapboxgl.Map;
  selectedLocation?: VaccinationCenter;
  bounds = [
    [49.443950, 1.856807], // Southwest coordinates
    [51.736159, 7.041192] // Northeast coordinates
  ];
  constructor(private mapboxService: MapBoxService, private centerService: VaccinationCenterService) { }

  ngOnInit(): void {
    this.generateMap();
    this.placeCentersOnMap();
  }
  generateMap() {
    (mapboxgl as any).accessToken = environment.mapboxKey;
    let temp: GeoJSON.FeatureCollection;
    this.map = new mapboxgl.Map({
      container: 'map',
      //style: 'mapbox://styles/cyberdark/ckoxhja9m0tfr17o5xlwucaxs',
      style: 'mapbox://styles/mapbox/streets-v11',
      center: [4.248005, 50.8911041], // starting position
      zoom: 5, // starting zoom
      maxBounds: [1.856807, 49.443950, 7.041192, 51.736159]
    });
  }

  placeCentersOnMap() {
    this.centerService.getCenters().subscribe(x => {
      this.centers = x;
      this.centers.forEach((center) => {
        this.getCoords(center);
      })
    });
  }

  getCoords(center: VaccinationCenter) {
    let coords: GeoJSON.FeatureCollection;
    this.mapboxService.getGeocoding(center.location).subscribe(x => {
      coords = x;
      if (coords.features[0].geometry.type === 'Point') {
        let long = coords.features[0].geometry.coordinates[0];
        let lat = coords.features[0].geometry.coordinates[1];
        console.log("yes");
        if (this.map) {
          let marker1 = new mapboxgl.Marker()
            .setLngLat([long, lat])
            .setPopup(new mapboxgl.Popup({ offset: 25 }) // add popups
              .setHTML('<h3>' + center.name + '</h3><p>' + center.location + '</p>'))
            .addTo(this.map);
        }
      }
    });
  };
  setCenter(location: VaccinationCenter) {
    if (this.map) {
      this.selectedLocation = location;
      this.mapboxService.getGeocoding(location.location).subscribe(x => {
        let coords = x;
        if (coords.features[0].geometry.type === 'Point') {
          let long = coords.features[0].geometry.coordinates[0];
          let lat = coords.features[0].geometry.coordinates[1];
          if (this.map) {
            this.map.setCenter([long, lat]);
            this.map.setZoom(17);
          }
        }
      });
    }
  }
}

