import { Component, OnInit } from '@angular/core';
import { VACCINES  } from '../mock-vaccinestorso';
import { Vaccine } from '../vaccine';

@Component({
  selector: 'app-torso-vaccins',
  templateUrl: './torso-vaccins.component.html',
  styleUrls: ['./torso-vaccins.component.css']
})
export class TorsoVaccinsComponent implements OnInit {
  vaccines = VACCINES;
  selectedVaccine?: Vaccine;
  
  onSelect(vaccine: Vaccine): void {
    this.selectedVaccine = vaccine;
  }
  constructor() { }

  ngOnInit(): void {
  }

}
