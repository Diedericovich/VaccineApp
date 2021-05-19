import { Component, OnInit } from '@angular/core';
import { VaccineService } from '../services/vaccine.service';
import { Vaccine } from '../vaccine';
@Component({
  selector: 'app-legs-vaccins',
  templateUrl: './legs-vaccins.component.html',
  styleUrls: ['./legs-vaccins.component.css']
})
export class LegsVaccinsComponent implements OnInit {
  vaccines: Vaccine[] | undefined;
  selectedVaccine?: Vaccine;
    
  onSelect(vaccine: Vaccine): void {
    this.selectedVaccine = vaccine;
  }
  constructor(private vaccineService : VaccineService) { }

  ngOnInit(): void {
    this.vaccineService.getVaccinesByBodyPart("Legs").subscribe(x => {this.vaccines=x})
  }

}
