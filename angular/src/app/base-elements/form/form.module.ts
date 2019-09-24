import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DynamicFormComponent } from './form-builder/dynamic-form.component';
import { FormInputComponent } from './form-field/form-input/form-input.component';
import { DynamicFormFieldDirective } from './form-field/dynamic-form-field.directive';
import { FormCheckboxComponent } from './form-field/form-checkbox/form-checkbox.component';
import { FormDropDownListComponent } from './form-field/form-drop-down-list/form-drop-down-list.component';
import { FormDatePickerComponent } from './form-field/form-date-picker/form-date-picker.component';
import { FormRadioComponent } from './form-field/form-radio/form-radio.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FormFieldFocusDirective } from './form-field/form-input/form-field-focus.directive';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SubmitButtonComponent } from './form-field/submit-button/submit-button.component';
import { DatePickerComponent } from '../date-picker/date-picker.component';
import { ShowDatePickerDirective } from './form-field/form-date-picker/show-date-picker.directive';
import { OutsideDirective } from './form-field/form-date-picker/outside.directive';
import { ShowDropDownListDirective } from './form-field/form-drop-down-list/show-drop-down-list.directive';
import { FormErrorComponent } from './form-field/form-error/form-error.component';
import { HasScrollDirective } from './form-field/form-drop-down-list/has-scroll.directive';
import { ShowErrorDirective } from './form-field/form-error/show-error.directive';
import { FormInputNumberComponent } from './form-field/form-input-number/form-input-number.component';
import { FormContainerComponent } from './form-container/form-container.component';
import { DatePickerModule } from '../date-picker/date-picker.module';
import { SvgModule } from '../app-svg/svg.module';

@NgModule({
  declarations: [
    DynamicFormComponent,
    FormInputComponent,
    DynamicFormFieldDirective,
    FormCheckboxComponent,
    FormDropDownListComponent,
    FormDatePickerComponent,
    FormRadioComponent,
    FormFieldFocusDirective,
    SubmitButtonComponent,
    ShowDatePickerDirective,
    OutsideDirective,
    ShowDropDownListDirective,
    FormErrorComponent,
    HasScrollDirective,
    ShowErrorDirective,
    FormInputNumberComponent,
    FormContainerComponent
  ],
  exports: [
    DynamicFormComponent,
    FormInputComponent,
    DynamicFormFieldDirective,
    FormCheckboxComponent,
    FormDropDownListComponent,
    FormDatePickerComponent,
    FormRadioComponent,
    FormFieldFocusDirective,
    SubmitButtonComponent,
    ShowDatePickerDirective,
    OutsideDirective,
    ShowDropDownListDirective,
    FormErrorComponent,
    HasScrollDirective,
    ShowErrorDirective,
    FormInputNumberComponent,
    FormContainerComponent
  ],
  entryComponents: [
    FormInputComponent,
    FormCheckboxComponent,
    FormDropDownListComponent,
    FormDatePickerComponent,
    FormRadioComponent,
    DatePickerComponent,
    FormInputNumberComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    DatePickerModule,
    SvgModule
  ]
})
export class FormModule { }
