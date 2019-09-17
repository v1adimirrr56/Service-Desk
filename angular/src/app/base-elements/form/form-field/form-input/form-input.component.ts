import { Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChange, SimpleChanges } from '@angular/core';
import { FormField } from '../models/FormField';
import { FormGroup } from '@angular/forms';
import { FormGroupField } from '../models/FormGroupFields';
import { $e } from 'codelyzer/angular/styles/chars';

@Component({
  selector: 'app-input',
  templateUrl: './form-input.component.html',
  styleUrls: ['./form-input.component.sass']
})
export class FormInputComponent extends FormGroupField {
  @Input() inputValue;
  @Input() group: FormGroup;
  @Input() formField: FormField;
  @Input() forceFocus;
  @Output() formFieldFocusChanged = new EventEmitter();
  @Output() tabKeyEvent = new EventEmitter();
  getInputValue() {
    return this.group.get(this.formField.nameField).value;
  }

  focusChanged($event) {
    this.formFieldFocusChanged.emit($event);
  }

  tabKeyEventHandler($event: boolean) {
    this.tabKeyEvent.emit($event);
  }
}
