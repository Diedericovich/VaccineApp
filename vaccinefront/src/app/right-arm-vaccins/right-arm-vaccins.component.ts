import { Component, OnInit } from '@angular/core';
import { VaccineService } from '../services/vaccine.service';
import { Vaccine } from '../interfaces/vaccine';
@Component({
  selector: 'app-right-arm-vaccins',
  templateUrl: './right-arm-vaccins.component.html',
  styleUrls: ['./right-arm-vaccins.component.css'],
})
export class RightArmVaccinsComponent implements OnInit {
  vaccines: Vaccine[] | undefined;
  selectedVaccine?: Vaccine;

  onSelect(vaccine: Vaccine): void {
    this.selectedVaccine = vaccine;
  }
  constructor(private vaccineService: VaccineService) {}

  ngOnInit(): void {
    this.vaccineService.getVaccinesByBodyPart('Right Arm').subscribe((x) => {
      this.vaccines = x;
    });
  }
}
