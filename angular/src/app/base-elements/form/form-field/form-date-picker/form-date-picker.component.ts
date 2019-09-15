import {
  AfterViewInit,
  ChangeDetectorRef,
  Component,
  ElementRef,
  EventEmitter,
  OnInit,
  Output,
  QueryList,
  Renderer2,
  ViewChildren
} from '@angular/core';
import { FormGroup } from '@angular/forms';
import { FormField } from '../models/FormField';
import { FormGroupField } from '../models/FormGroupFields';

@Component({
  selector: 'app-form-date-picker',
  templateUrl: './form-date-picker.component.html',
  styleUrls: ['./form-date-picker.component.sass']
})
export class FormDatePickerComponent extends FormGroupField {


}
