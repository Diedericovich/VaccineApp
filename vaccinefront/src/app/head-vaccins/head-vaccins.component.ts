import { Component, OnInit } from '@angular/core';
import { VACCINES  } from '../mock-vaccineshead';
import { Vaccine } from '../vaccine';
@Component({
  selector: 'app-head-vaccins',
  templateUrl: './head-vaccins.component.html',
  styleUrls: ['./head-vaccins.component.css']
})
export class HeadVaccinsComponent implements OnInit {
vaccines = VACCINES;
selectedVaccine?: Vaccine;

onSelect(vaccine: Vaccine): void {
  this.selectedVaccine = vaccine;
}
  constructor() { }

  ngOnInit(): void {
  }

}
