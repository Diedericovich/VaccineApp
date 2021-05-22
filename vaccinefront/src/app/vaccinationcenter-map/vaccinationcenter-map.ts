import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MaptestComponent } from './vaccinationcenter-map.component';

describe('MaptestComponent', () => {
  let component: MaptestComponent;
  let fixture: ComponentFixture<MaptestComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MaptestComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MaptestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
