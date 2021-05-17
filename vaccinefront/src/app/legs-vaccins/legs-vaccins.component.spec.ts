import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LegsVaccinsComponent } from './legs-vaccins.component';

describe('LegsVaccinsComponent', () => {
  let component: LegsVaccinsComponent;
  let fixture: ComponentFixture<LegsVaccinsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LegsVaccinsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LegsVaccinsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
