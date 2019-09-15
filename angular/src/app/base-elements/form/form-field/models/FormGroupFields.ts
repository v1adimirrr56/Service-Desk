import { FormGroup } from '@angular/forms';
import { FormField } from './FormField';

export class FormGroupFields {
  formGroup: FormGroup;
  formFields: FormField[];
}

export class FormGroupField {
  public group: FormGroup;
  public formField: FormField;
}
