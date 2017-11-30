import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { VehicleService } from '../../services/vehicle.service';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {

  vehicleForm: FormGroup;
  makes: any[];
  models: any[];
  features: any[];
  vehicle: any = {};

  constructor(
    private formBuilder: FormBuilder,
    private vehicleService: VehicleService) { }

  ngOnInit() {
    this.vehicleForm = this.formBuilder.group({
      make: ['', Validators.required],
      model: ['', Validators.required],
      features: this.formBuilder.array([''])
    });

    this.vehicleService.getMakes().subscribe(
      (data: any) => {
        this.makes = data;
      }
    );

    this.vehicleService.getFeatures().subscribe(
      (data: any) => {
        this.features = data;
      }
    );
  }

  onMakeChangedHandler() {
    const selectedMake = this.makes.find(make => make.id == this.vehicle.make);
    this.models = selectedMake ? selectedMake.models : [];
  }

}
