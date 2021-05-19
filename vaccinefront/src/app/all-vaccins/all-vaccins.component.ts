import { Component, OnInit } from '@angular/core';
import { VACCINES } from '../mock-vaccines';
import { Vaccine } from '../vaccine';
@Component({
  selector: 'app-all-vaccins',
  templateUrl: './all-vaccins.component.html',
  styleUrls: ['./all-vaccins.component.css']
})
export class AllVaccinsComponent implements OnInit {
  vaccines = VACCINES;
  selectedVaccine?: Vaccine;
  
  onSelect(vaccine: Vaccine): void {
    this.selectedVaccine = vaccine;
  }
  
  constructor() { }

  ngOnInit(): void {
  }

}
