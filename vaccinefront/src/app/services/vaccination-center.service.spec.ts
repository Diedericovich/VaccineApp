import { TestBed } from '@angular/core/testing';

import { VaccinationCenterService } from './vaccination-center.service';

describe('VaccinationCenterService', () => {
  let service: VaccinationCenterService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(VaccinationCenterService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
