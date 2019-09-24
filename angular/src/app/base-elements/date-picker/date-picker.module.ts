import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DatePickerMonthComponent } from './date-picker-month/date-picker-month.component';
import { DatePickerYearComponent } from './date-picker-year/date-picker-year.component';
import { DatePickerViewDirective } from './date-picker-view.directive';
import { DatePickerComponent } from './date-picker.component';
import { CellActiveDirective } from './cell-active.directive';
import { SvgModule } from '../app-svg/svg.module';

@NgModule({
  declarations: [
    CellActiveDirective,
    DatePickerMonthComponent,
    DatePickerYearComponent,
    DatePickerViewDirective,
    DatePickerComponent,
  ],
  exports: [
    DatePickerComponent
  ],
  imports: [
    CommonModule,
    SvgModule
  ]
})
export class DatePickerModule { }
