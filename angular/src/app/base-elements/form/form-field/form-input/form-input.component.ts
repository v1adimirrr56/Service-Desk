import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormField } from '../models/FormField';
import { FormGroup } from '@angular/forms';
import { FormGroupField } from '../models/FormGroupFields';

@Component({
  selector: 'app-input',
  templateUrl: './form-input.component.html',
  styleUrls: ['./form-input.component.sass']
})
export class FormInputComponent extends FormGroupField implements OnInit {
  @Input() group: FormGroup;
  @Input() formField: FormField;
  @Input() typeInput = 'text';
  @Input() forceFocus;
  @Output() formFieldFocusChanged = new EventEmitter();
  @Output() tabKeyEvent = new EventEmitter();
  @Output() inputValueChanged = new EventEmitter();

  getInputValue() {
    return this.group.get(this.formField.nameField).value;
  }

  focusChanged($event) {
    this.formFieldFocusChanged.emit($event);
  }

  tabKeyEventHandler($event: boolean) {
    this.tabKeyEvent.emit($event);
  }

  ngOnInit(): void {
    super.ngOnInit();
  }

  changeEvent($event) {
    this.inputValueChanged.emit(this.formControl.value);
  }
}
