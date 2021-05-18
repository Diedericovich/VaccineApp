import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VaccineDetailComponent } from './vaccine-detail.component';

describe('VaccineDetailComponent', () => {
  let component: VaccineDetailComponent;
  let fixture: ComponentFixture<VaccineDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VaccineDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VaccineDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
