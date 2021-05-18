import { Component, OnInit } from '@angular/core';
import { VACCINES } from '../mock-vaccines-rightarm';
import { Vaccine } from '../vaccine';
@Component({
  selector: 'app-right-arm-vaccins',
  templateUrl: './right-arm-vaccins.component.html',
  styleUrls: ['./right-arm-vaccins.component.css']
})
export class RightArmVaccinsComponent implements OnInit {
vaccines = VACCINES;
selectedVaccine?: Vaccine;
  
onSelect(vaccine: Vaccine): void {
  this.selectedVaccine = vaccine;
}
  constructor() { }

  ngOnInit(): void {
  }

}
