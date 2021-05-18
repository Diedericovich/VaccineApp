import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AllVaccinsComponent } from './all-vaccins.component';

describe('AllVaccinsComponent', () => {
  let component: AllVaccinsComponent;
  let fixture: ComponentFixture<AllVaccinsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AllVaccinsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AllVaccinsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
