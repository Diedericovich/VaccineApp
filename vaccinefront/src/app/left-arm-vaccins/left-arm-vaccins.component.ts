import { Component, OnInit } from '@angular/core';
import { VACCINES } from '../mock-vaccines-leftarm';
import { Vaccine } from '../vaccine';
@Component({
  selector: 'app-left-arm-vaccins',
  templateUrl: './left-arm-vaccins.component.html',
  styleUrls: ['./left-arm-vaccins.component.css']
})
export class LeftArmVaccinsComponent implements OnInit {
vaccines = VACCINES;
selectedVaccine?: Vaccine;
  
onSelect(vaccine: Vaccine): void {
  this.selectedVaccine = vaccine;
}
  constructor() { }

  ngOnInit(): void {
  }

}
