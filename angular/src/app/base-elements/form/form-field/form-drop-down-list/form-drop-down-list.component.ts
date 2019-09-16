import { Component, OnInit, ViewChild } from '@angular/core';
import { FormGroupField } from '../models/FormGroupFields';
import { FormInputComponent } from '../form-input/form-input.component';

@Component({
  selector: 'app-form-drop-down-list',
  templateUrl: './form-drop-down-list.component.html',
  styleUrls: ['./form-drop-down-list.component.sass']
})
export class FormDropDownListComponent extends FormGroupField implements OnInit {
  isShow = true;
  forceActive: boolean;
  ngOnInit(): void {
    this.forceActive = true;
  }
  @ViewChild('input') inputComponent: FormInputComponent;

  chooseOption(label: string) {
    this.inputComponent.inputValue = label;
    this.forceActive = false;
  }

  focusChanged($event: boolean) {
    this.isShow = $event;
  }
}
