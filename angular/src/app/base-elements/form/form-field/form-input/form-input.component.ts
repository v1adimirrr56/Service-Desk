import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormField } from '../models/FormField';
import { FormGroup } from '@angular/forms';
import { FormGroupField } from '../models/FormGroupFields';

@Component({
  selector: 'app-input',
  templateUrl: './form-input.component.html',
  styleUrls: ['./form-input.component.sass']
})
export class FormInputComponent extends FormGroupField {
  @Input() isFocus = false;
  @Input() forceActive = false;
  inputValue
  @Input('inputValue') set setinputValue(value) {
    console.log(value)
    this.inputValue = value;
  }
  @Input() group: FormGroup;
  @Input() formField: FormField;

  @Output() isFocusChange = new EventEmitter<boolean>();

  focusChanged($event) {
    this.isFocus = $event;
    this.isFocusChange.emit($event);
  }
}
