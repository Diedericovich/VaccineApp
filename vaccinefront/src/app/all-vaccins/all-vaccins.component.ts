import { Component, OnInit } from '@angular/core';
import { Vaccine } from '../vaccine';
import { VaccineService } from '../services/vaccine.service';
@Component({
  selector: 'app-all-vaccins',
  templateUrl: './all-vaccins.component.html',
  styleUrls: ['./all-vaccins.component.css']
})
export class AllVaccinsComponent implements OnInit {
  vaccines: Vaccine [] = [];
  selectedVaccine?: Vaccine;
  
  onSelect(vaccine: Vaccine): void {
    this.selectedVaccine = vaccine;
  }
  
  constructor(private vaccineService: VaccineService ) { }

  ngOnInit(): void {
    this.getVaccines();
  }

getVaccines(): void {
  this.vaccineService.getVaccines()
    .subscribe(x => this.vaccines = x);
    
}



}
