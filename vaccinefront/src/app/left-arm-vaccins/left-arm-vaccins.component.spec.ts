import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LeftArmVaccinsComponent } from './left-arm-vaccins.component';

describe('LeftArmVaccinsComponent', () => {
  let component: LeftArmVaccinsComponent;
  let fixture: ComponentFixture<LeftArmVaccinsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LeftArmVaccinsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LeftArmVaccinsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
