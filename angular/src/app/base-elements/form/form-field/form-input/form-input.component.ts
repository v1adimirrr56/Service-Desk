import { Component } from '@angular/core';
import { FormField } from '../models/FormField';
import { FormGroup } from '@angular/forms';
import { FormGroupField } from '../models/FormGroupFields';

@Component({
  selector: 'app-input',
  templateUrl: './form-input.component.html',
  styleUrls: ['./form-input.component.sass']
})
export class FormInputComponent extends FormGroupField {
  isFocus: boolean;
  inputValue;
}
