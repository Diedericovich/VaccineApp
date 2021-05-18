import { TestBed } from '@angular/core/testing';

import { VaccinationcenterService } from './vaccinationcenter.service';

describe('VaccinationcenterService', () => {
  let service: VaccinationcenterService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(VaccinationcenterService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
