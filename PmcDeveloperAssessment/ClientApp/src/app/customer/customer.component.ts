import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html'
})
export class CustomerComponent {
  public customers: CustomerAddress[];
  public selectedCustomer: any;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.getData(baseUrl);
  }

  getData(baseUrl: string): void {

  }
}

interface CustomerAddress {
  customerId: string;
  customerDateCreated: Date | string;
  customerDateModified: Date | string;
  firstName: string;
  lastName: string;
  phone: string;
  addressId: string;
  emailAddress: string;
  spouseFirstName: string;
  spouceLastName: string;
  homeOwner: string;
  address1: string;
  address2: string;
  city: string;
  state: string;
  zip: string;
  addressDateCreated: Date | string;
  addressDateModified: Date | string;
}
