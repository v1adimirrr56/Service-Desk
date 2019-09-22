import { Component, OnInit } from '@angular/core';
import { FormGroupField } from '../models/FormGroupFields';
import { Validators } from '@angular/forms';

@Component({
  selector: 'app-form-checkbox',
  templateUrl: './form-checkbox.component.html',
  styleUrls: ['./form-checkbox.component.sass']
})
export class FormCheckboxComponent extends FormGroupField implements OnInit {
  constructor() {
    super();
  }

  ngOnInit(): void {
    super.ngOnInit();
  }

}
