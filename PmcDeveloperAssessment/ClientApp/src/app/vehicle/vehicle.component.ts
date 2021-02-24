import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-vehicle',
  templateUrl: './vehicle.component.html'
})
export class VehicleComponent {
  public vehicles: CustomerVehicle[];

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.getData(baseUrl);
  }

  getData(baseUrl: string): void {
    this.http.get<CustomerVehicle[]>(baseUrl + 'vehicle/customerVehicles').subscribe(result => {
      this.vehicles = result;
    }, error => console.error(error));
  }
}

interface CustomerVehicle {
  customerVehicleId: string;
  vehicleId: string | null;
  vehicleYear: string;
  make: string;
  model: string;
  trim: string;
  style: string;
  vinPattern: string;
  vehicleType: string;
  bodyType: string;
  bodySubType: string;
  doors: string;
  msrp: string;
  plant: string;
}
