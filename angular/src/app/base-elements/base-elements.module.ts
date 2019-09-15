import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DatePickerComponent } from './date-picker/date-picker.component';
import { CellActiveDirective } from './date-picker/cell-active.directive';
import { FormModule } from './form/form.module';

@NgModule({
  declarations: [
    DatePickerComponent,
    CellActiveDirective
  ],
  exports: [
    DatePickerComponent
  ],
  imports: [
    CommonModule
  ]
})
export class BaseElementsModule { }
