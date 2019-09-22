import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormField } from '../form-field/models/FormField';
import { FormGroup } from '@angular/forms';
import { element } from 'protractor';
import { MarkAsTouched } from './form-extensions';

@Component({
  selector: 'app-dynamic-form',
  templateUrl: './dynamic-form.component.html',
  styleUrls: ['./dynamic-form.component.sass']
})
export class DynamicFormComponent {
  @Input() schema: FormField[];
  @Input() group: FormGroup;
  @Output() submit = new EventEmitter();

  submitForm() {
    if (this.group.valid) {
      this.submit.emit(this.group);
    } else {
      if (this.group.untouched) {
        MarkAsTouched(this.group);
      }
    }
  }
}
