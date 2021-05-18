import { Component, OnInit, Input } from '@angular/core';
import { Vaccine } from '../vaccine';
@Component({
  selector: 'app-vaccine-detail',
  templateUrl: './vaccine-detail.component.html',
  styleUrls: ['./vaccine-detail.component.css']
})
export class VaccineDetailComponent implements OnInit {
  @Input() vaccine?: Vaccine;
  constructor() { }

  ngOnInit(): void {
  }

}
