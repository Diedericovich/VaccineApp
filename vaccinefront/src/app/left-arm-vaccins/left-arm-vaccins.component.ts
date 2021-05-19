import { Component, OnInit } from '@angular/core';
import { Vaccine } from '../vaccine';
import { VaccineService } from '../services/vaccine.service';
@Component({
  selector: 'app-left-arm-vaccins',
  templateUrl: './left-arm-vaccins.component.html',
  styleUrls: ['./left-arm-vaccins.component.css']
})
export class LeftArmVaccinsComponent implements OnInit {
vaccines: Vaccine[] | undefined;
selectedVaccine?: Vaccine;
  
onSelect(vaccine: Vaccine): void {
  this.selectedVaccine = vaccine;
}
  constructor(private vaccineService : VaccineService) { }

  ngOnInit(): void {
    this.vaccineService.getVaccinesByBodyPart("Left Arm").subscribe(x => {this.vaccines=x})
  }

}
