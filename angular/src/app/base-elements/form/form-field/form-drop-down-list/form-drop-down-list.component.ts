import {
  Component,
  ElementRef,
  HostListener, OnInit,
  Renderer2,
  ViewChild
} from '@angular/core';
import { FormInputComponent } from '../form-input/form-input.component';
import { FormField, Option } from '../models/FormField';
import { AbstractControl, FormControl } from '@angular/forms';
import { FormGroupField } from '../models/FormGroupFields';

@Component({
  selector: 'app-form-drop-down-list',
  templateUrl: './form-drop-down-list.component.html',
  styleUrls: ['./form-drop-down-list.component.sass']
})
export class FormDropDownListComponent extends FormGroupField implements OnInit {
  isShow;
  labelFormField: FormField;
  @ViewChild('input') input: FormInputComponent;

  @HostListener('document:click', ['$event']) appShowDropDownList(event) {
    if (!this.elementRef.nativeElement.children[0].contains(event.target)) {
      this.isShow = false;
      this.input.forceFocus = false;
    }
  }

  constructor(private elementRef: ElementRef, private renderer: Renderer2) {
    super();
  }
  ngOnInit(): void {
    super.ngOnInit();
    const initialOption = this.formField.options.find(x => x.value === this.formControl.value);
    this.labelFormField = {...this.formField, nameField: this.getLabelFormFieldName()};
    this.group.addControl(this.getLabelFormFieldName(), new FormControl({}, this.formControl.validator));
    this.group.controls[this.getLabelFormFieldName()].setValue(initialOption.label);
  }

  getLabelFormFieldName() {
    return `${this.formField.nameField}label`;
  }

  chooseOption(option: Option) {
    this.group.controls[this.getLabelFormFieldName()].setValue(option.label);
    this.formControl.setValue(option.value);
    this.input.forceFocus = false;
    this.isShow = false;
  }

  focusChangeEvent($event) {
    if ($event) {
      this.input.forceFocus = $event;
      this.isShow = $event;
    }
  }

  tabKeyEventHandler($event: boolean) {
    this.input.forceFocus = false;
    this.isShow = false;
  }

  inputValueChanged($event) {
    console.log($event)
  }
}
