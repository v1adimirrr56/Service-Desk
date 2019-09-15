import { Component, OnInit } from '@angular/core';
import { FormGroupField } from '../models/FormGroupFields';
import { Option } from '../models/FormField';

@Component({
  selector: 'app-form-drop-down-list',
  templateUrl: './form-drop-down-list.component.html',
  styleUrls: ['./form-drop-down-list.component.sass']
})
export class FormDropDownListComponent extends FormGroupField implements OnInit{
  isFocus: boolean;
  inputValue;

  ngOnInit(): void {
    this.formField.options = [
      new Option('1', 'Drop 1'),
      new Option('2', 'Drop 2')
    ];
  }
}
