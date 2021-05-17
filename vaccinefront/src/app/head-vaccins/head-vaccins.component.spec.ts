import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HeadVaccinsComponent } from './head-vaccins.component';

describe('HeadVaccinsComponent', () => {
  let component: HeadVaccinsComponent;
  let fixture: ComponentFixture<HeadVaccinsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HeadVaccinsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HeadVaccinsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
