import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TorsoVaccinsComponent } from './torso-vaccins.component';

describe('TorsoVaccinsComponent', () => {
  let component: TorsoVaccinsComponent;
  let fixture: ComponentFixture<TorsoVaccinsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TorsoVaccinsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TorsoVaccinsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
