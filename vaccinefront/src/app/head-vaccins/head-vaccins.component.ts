import { Component, OnInit } from '@angular/core';
import { VACCINES } from '../mock-vaccines';
import { Vaccine } from '../vaccine';
import { VaccineService } from '../vaccine.service';
@Component({
  selector: 'app-head-vaccins',
  templateUrl: './head-vaccins.component.html',
  styleUrls: ['./head-vaccins.component.css']
})
export class HeadVaccinsComponent implements OnInit {
vaccines: Vaccine [] = [];
selectedVaccine?: Vaccine;

onSelect(vaccine: Vaccine): void {
  this.selectedVaccine = vaccine;
}
constructor(private vaccineService: VaccineService ) { }

ngOnInit(): void {
  this.getHeadVaccines();
}

getHeadVaccines(): void {
// ....
};

}
