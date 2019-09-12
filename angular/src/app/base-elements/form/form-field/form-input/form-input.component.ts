import { Component } from '@angular/core';
import { FormField } from '../models/FormField';
import { FormGroup } from '@angular/forms';
import { focusBlurFormInput } from '../animations/form-input-animation';
import { focusBlurFormLabel } from '../animations/form-label-animation';
import { FormFieldState } from '../models/FormFieldState';

@Component({
  selector: 'app-input',
  templateUrl: './form-input.component.html',
  styleUrls: ['./form-input.component.sass'],
  animations: [
    focusBlurFormInput(),
    focusBlurFormLabel()
  ]
})
export class FormInputComponent {
  group: FormGroup;
  formField: FormField;
  formFieldState: FormFieldState = {
    isActive: false,
    isFillUp: false
  };

  stateLabel() {
    if (this.formFieldState.isFillUp) {
      return 'fillUp';
    }
    if (this.formFieldState.isActive) {
      return 'focus';
    }
    return 'blur';
  }
}
