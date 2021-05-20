import { Component, OnInit } from '@angular/core';
import * as mapboxgl from 'mapbox-gl';
import { MapBoxService } from '../services/map-box.service';


@Component({
  selector: 'app-maptest',
  templateUrl: './maptest.component.html',
  styleUrls: ['./maptest.component.css']
})
export class MaptestComponent implements OnInit {
  map?: mapboxgl.Map
  temp?: GeoJSON.FeatureCollection;
  bounds = [
    [49.443950, 1.856807], // Southwest coordinates
    [51.736159, 7.041192] // Northeast coordinates
    ];
  constructor(private mapboxService: MapBoxService) { }

  ngOnInit(): void {
    (mapboxgl as any).accessToken = 'pk.eyJ1IjoiY3liZXJkYXJrIiwiYSI6ImNrb3ZtdDJrbzA5bm0ycXBlaWQ0MmtnZjQifQ.NHdesdchvpDXhsv4ORaNLA';
    this.map = new mapboxgl.Map({
      container: 'map',
      //style: 'mapbox://styles/cyberdark/ckoxhja9m0tfr17o5xlwucaxs',
      style: 'mapbox://styles/mapbox/streets-v11',
      center: [4.248005, 50.8911041], // starting position
      zoom: 9, // starting zoom
      maxBounds: [1.856807,49.443950, 7.041192,51.736159 ]
    });
    if (this.map) {
      let marker1 = new mapboxgl.Marker()
      .setLngLat([4.3773,50.8674])
      .setPopup(new mapboxgl.Popup({ offset: 25 }) // add popups
      .setHTML('<h3>' + 'VaxxCenterName' + '</h3><p>' + 'VaxxCenterLocation' + '</p>'))
      .addTo(this.map);
    }


  }
  test() {
    let temp: GeoJSON.FeatureCollection;
    this.mapboxService.getGeocoding("Neerstraat 150, Haacht Belgium").subscribe(x => { this.temp = x; console.log(this.temp.bbox); });
  }
  test2() {
    if (this.temp) {

      console.log(this.temp.features[0].geometry);
      // add markers to map
      if (this.temp.features[0].geometry.type === 'Point') {
        let long = this.temp.features[0].geometry.coordinates[0];
        let lat = this.temp.features[0].geometry.coordinates[1];


        if (this.map) {
          let marker1 = new mapboxgl.Marker()
          .setLngLat([long, lat])
          .setPopup(new mapboxgl.Popup({ offset: 25 }) // add popups
          .setHTML('<h3>' + 'VaxxCenterName' + '</h3><p>' + 'VaxxCenterLocation' + '</p>'))
          .addTo(this.map);
        }

      }
    }
  }

}
