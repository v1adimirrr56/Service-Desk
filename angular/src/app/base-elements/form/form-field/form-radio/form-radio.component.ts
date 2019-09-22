import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { FormField, Option } from '../models/FormField';
import { FormGroupField } from '../models/FormGroupFields';

@Component({
  selector: 'app-form-radio',
  templateUrl: './form-radio.component.html',
  styleUrls: ['./form-radio.component.sass']
})
export class FormRadioComponent extends FormGroupField implements OnInit {
  constructor() {
    super();
  }

  ngOnInit(): void {
    super.ngOnInit();
  }
}
