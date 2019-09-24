import { Component, Input, OnInit } from '@angular/core';
import { FormGroupField } from '../models/FormGroupFields';
import { FormGroup } from '@angular/forms';
import { FormField } from '../models/FormField';

@Component({
  selector: 'app-form-input-number',
  templateUrl: './form-input-number.component.html',
  styleUrls: ['./form-input-number.component.sass']
})
export class FormInputNumberComponent extends FormGroupField implements OnInit {
  @Input() group: FormGroup;
  @Input() formField: FormField;
  typeInput = 'number';
  ngOnInit(): void {
    super.ngOnInit();
  }

}
