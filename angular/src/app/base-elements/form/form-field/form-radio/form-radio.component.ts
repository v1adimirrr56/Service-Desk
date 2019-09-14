import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { FormField, Option } from '../models/FormField';

@Component({
  selector: 'app-form-radio',
  templateUrl: './form-radio.component.html',
  styleUrls: ['./form-radio.component.sass']
})
export class FormRadioComponent implements OnInit {
  group: FormGroup;
  formField: FormField;

  ngOnInit(): void {
    this.formField.options = [
      new Option('1', 'First'),
      new Option('2', 'Second')
    ];
  }
}
