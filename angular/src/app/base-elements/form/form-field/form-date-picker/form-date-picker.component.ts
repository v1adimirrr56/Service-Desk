import {
  Component, HostListener,
} from '@angular/core';
import { FormGroupField } from '../models/FormGroupFields';

@Component({
  selector: 'app-form-date-picker',
  templateUrl: './form-date-picker.component.html',
  styleUrls: ['./form-date-picker.component.sass']
})
export class FormDatePickerComponent extends FormGroupField {
  isShow: boolean;

  clickHandler() {
    this.isShow = !this.isShow;
  }
}
