import { Component, OnInit } from '@angular/core';
import { VACCINES } from '../mock-vaccines-legs';
import { Vaccine } from '../vaccine';
@Component({
  selector: 'app-legs-vaccins',
  templateUrl: './legs-vaccins.component.html',
  styleUrls: ['./legs-vaccins.component.css']
})
export class LegsVaccinsComponent implements OnInit {
  vaccines = VACCINES;
  selectedVaccine?: Vaccine;
    
  onSelect(vaccine: Vaccine): void {
    this.selectedVaccine = vaccine;
  }
  constructor() { }

  ngOnInit(): void {
  }

}
