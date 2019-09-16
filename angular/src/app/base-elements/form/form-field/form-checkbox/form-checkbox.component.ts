import { Component, OnInit } from '@angular/core';
import { FormGroupField } from '../models/FormGroupFields';
import { Option } from '../models/FormField';

@Component({
  selector: 'app-form-checkbox',
  templateUrl: './form-checkbox.component.html'
})
export class FormCheckboxComponent extends FormGroupField implements OnInit {
  ngOnInit(): void {
  }

}
