import { Component, OnInit } from '@angular/core';
import { Vaccine } from '../vaccine';
import { VaccineService } from '../services/vaccine.service';
@Component({
  selector: 'app-head-vaccins',
  templateUrl: './head-vaccins.component.html',
  styleUrls: ['./head-vaccins.component.css']
})
export class HeadVaccinsComponent implements OnInit {
  vaccines: Vaccine[] | undefined;
  selectedVaccine?: Vaccine;

onSelect(vaccine: Vaccine): void {
  this.selectedVaccine = vaccine;
}
constructor(private vaccineService: VaccineService ) { }

ngOnInit(): void {
  this.vaccineService.getVaccinesByBodyPart("Head").subscribe(x => {this.vaccines=x})
}

getHeadVaccines(): void {
// ....
};

}
