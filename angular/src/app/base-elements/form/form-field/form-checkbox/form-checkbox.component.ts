import { Component, OnInit } from '@angular/core';
import { FormGroupField } from '../models/FormGroupFields';
import { Option } from '../models/FormField';

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
    this.formField.options = [
      new Option('1', 'First'),
      new Option('2', 'Second')
    ];
  }

}
