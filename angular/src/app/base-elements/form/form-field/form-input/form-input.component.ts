import { Component } from '@angular/core';
import { FormField } from '../models/FormField';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-input',
  templateUrl: './form-input.component.html',
  styleUrls: ['./form-input.component.sass']
})
export class FormInputComponent {
  group: FormGroup;
  formField: FormField;
  isFocus: boolean;
  inputValue;
}
