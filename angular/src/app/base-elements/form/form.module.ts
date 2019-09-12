import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilderComponent } from './form-builder/form-builder.component';
import { FormInputComponent } from './form-field/form-input/form-input.component';
import { DynamicFormFieldDirective } from './form-field/dynamic-form-field.directive';
import { FormCheckboxComponent } from './form-field/form-checkbox/form-checkbox.component';
import { FormDropDownListComponent } from './form-field/form-drop-down-list/form-drop-down-list.component';
import { FormDateTimePickerComponent } from './form-field/form-date-time-picker/form-date-time-picker.component';
import { FormRadioComponent } from './form-field/form-radio/form-radio.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FormFieldActiveDirective } from './form-field/form-field-active.directive';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    FormBuilderComponent,
    FormInputComponent,
    DynamicFormFieldDirective,
    FormCheckboxComponent,
    FormDropDownListComponent,
    FormDateTimePickerComponent,
    FormRadioComponent,
    FormFieldActiveDirective
  ],
  exports: [
    FormBuilderComponent
  ],
  entryComponents: [
    FormInputComponent,
    FormCheckboxComponent,
    FormDropDownListComponent,
    FormDateTimePickerComponent,
    FormRadioComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule
  ]
})
export class FormModule { }
