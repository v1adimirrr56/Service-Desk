import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DatePickerComponent } from './date-picker/date-picker.component';
import { CellActiveDirective } from './date-picker/cell-active.directive';
import { DatePickerMonthComponent } from './date-picker/date-picker-month/date-picker-month.component';
import { DatePickerYearComponent } from './date-picker/date-picker-year/date-picker-year.component';
import { DatePickerViewDirective } from './date-picker/date-picker-view.directive';
import { CreateDatepickerComponent } from './date-picker/create-datepicker/create-datepicker.component';
import { AppSvgComponent } from './app-svg/app-svg.component';

@NgModule({
  declarations: [
    DatePickerComponent,
    CellActiveDirective,
    DatePickerMonthComponent,
    DatePickerYearComponent,
    DatePickerViewDirective,
    CreateDatepickerComponent,
    AppSvgComponent
  ],
  exports: [
    DatePickerComponent,
    CreateDatepickerComponent,
    AppSvgComponent
  ],
  imports: [
    CommonModule
  ]
})
export class BaseElementsModule { }
