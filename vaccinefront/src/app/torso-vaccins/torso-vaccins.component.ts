import { Component, OnInit } from '@angular/core';
import { VaccineService } from '../services/vaccine.service';
import { Vaccine } from '../vaccine';

@Component({
  selector: 'app-torso-vaccins',
  templateUrl: './torso-vaccins.component.html',
  styleUrls: ['./torso-vaccins.component.css']
})
export class TorsoVaccinsComponent implements OnInit {
  vaccines: Vaccine[] = [];
  selectedVaccine?: Vaccine;
  
  onSelect(vaccine: Vaccine): void {
    this.selectedVaccine = vaccine;
  }
  constructor(private vaccineService : VaccineService) { }

  ngOnInit(): void {
    this.vaccineService.getVaccinesByBodyPart("Torso").
    subscribe(x => this.vaccines=x);
  }

}
