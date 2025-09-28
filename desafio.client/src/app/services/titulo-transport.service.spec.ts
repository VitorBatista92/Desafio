import { TestBed } from '@angular/core/testing';

import { TituloTransportService } from './titulo-transport.service';

describe('TituloTransportService', () => {
  let service: TituloTransportService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TituloTransportService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
