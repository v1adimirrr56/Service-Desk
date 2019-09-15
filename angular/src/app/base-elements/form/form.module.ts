import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilderComponent } from './form-builder/form-builder.component';
import { FormInputComponent } from './form-field/form-input/form-input.component';
import { DynamicFormFieldDirective } from './form-field/dynamic-form-field.directive';
import { FormCheckboxComponent } from './form-field/form-checkbox/form-checkbox.component';
import { FormDropDownListComponent } from './form-field/form-drop-down-list/form-drop-down-list.component';
import { FormDatePickerComponent } from './form-field/form-date-picker/form-date-picker.component';
import { FormRadioComponent } from './form-field/form-radio/form-radio.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FormFieldFocusDirective } from './form-field/form-field-focus.directive';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormLabelFocusFilledDirective } from './form-field/form-label-focus-filled.directive';
import { BaseElementsModule } from '../base-elements.module';
import { SubmitButtonComponent } from './form-field/submit-button/submit-button.component';

@NgModule({
  declarations: [
    FormBuilderComponent,
    FormInputComponent,
    DynamicFormFieldDirective,
    FormCheckboxComponent,
    FormDropDownListComponent,
    FormDatePickerComponent,
    FormRadioComponent,
    FormFieldFocusDirective,
    FormLabelFocusFilledDirective,
    SubmitButtonComponent
  ],
  exports: [
    FormBuilderComponent
  ],
  entryComponents: [
    FormInputComponent,
    FormCheckboxComponent,
    FormDropDownListComponent,
    FormDatePickerComponent,
    FormRadioComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    BaseElementsModule
  ]
})
export class FormModule { }
