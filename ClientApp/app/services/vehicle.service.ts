import { HttpService } from './http.service';
import { Injectable } from '@angular/core';

@Injectable()
export class VehicleService {

  constructor(private httpService: HttpService) { }

  getMakes() {
    return this.httpService.get('/api/makes', {});
  }

  getFeatures() {
    return this.httpService.get('/api/features', {});
  }

}
