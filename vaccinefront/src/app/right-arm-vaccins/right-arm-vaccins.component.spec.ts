import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RightArmVaccinsComponent } from './right-arm-vaccins.component';

describe('RightArmVaccinsComponent', () => {
  let component: RightArmVaccinsComponent;
  let fixture: ComponentFixture<RightArmVaccinsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RightArmVaccinsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RightArmVaccinsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
