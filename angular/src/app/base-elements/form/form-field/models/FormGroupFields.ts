import { AbstractControl, FormControl, FormGroup } from '@angular/forms';
import { FormField } from './FormField';
import { OnInit } from '@angular/core';

export class FormGroupFields {
  formGroup: FormGroup;
  formFields: FormField[];
}

export class FormGroupField implements OnInit {
  public group: FormGroup;
  public formField: FormField;
  public formControlName;
  public formControl: AbstractControl;

  ngOnInit(): void {
    this.formControlName = this.formField.nameField;
    this.formControl = this.group.controls[this.formField.nameField];
  }
}
