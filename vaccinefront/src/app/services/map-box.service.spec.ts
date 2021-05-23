import { TestBed } from '@angular/core/testing';

import { MapBoxService } from './map-box.service';

describe('MapBoxService', () => {
  let service: MapBoxService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MapBoxService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
