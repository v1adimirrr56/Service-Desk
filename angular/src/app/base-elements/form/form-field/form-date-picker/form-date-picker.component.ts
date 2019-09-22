import {
  Component, ElementRef, ViewChild
} from '@angular/core';
import { FormGroupField } from '../models/FormGroupFields';
import { OnInit } from '@angular/core/src/metadata/lifecycle_hooks';
import { FormInputComponent } from '../form-input/form-input.component';

@Component({
  selector: 'app-form-date-picker',
  templateUrl: './form-date-picker.component.html',
  styleUrls: ['./form-date-picker.component.sass']
})
export class FormDatePickerComponent extends FormGroupField implements OnInit {
  isShow: boolean;
  @ViewChild('input') input: FormInputComponent;

  constructor(private elementRef: ElementRef) {
    super();
  }
  ngOnInit(): void {
    super.ngOnInit();
    const date = new Date(this.formControl.value).toLocaleDateString('en-US');
    this.formControl.setValue(date);
    this.input.forceFocus = true;
  }

  chooseDate($event) {
    const date = new Date($event).toLocaleDateString('en-US');
    this.group.get(this.formField.nameField).setValue(date);
    this.input.forceFocus = false;
    this.isShow = false;
  }

  clickHandler($event) {
    this.isShow = true;
    this.input.forceFocus = true;
  }

  outsideEvent($event: boolean) {
    this.isShow = false;
    this.input.forceFocus = false;
  }
}
