import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VaccinationCenterMapComponent } from './vaccinationcenter-map.component';

describe('VaccinationCenterMapComponent', () => {
  let component: VaccinationCenterMapComponent;
  let fixture: ComponentFixture<VaccinationCenterMapComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VaccinationCenterMapComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VaccinationCenterMapComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
