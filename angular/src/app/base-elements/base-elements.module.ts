import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DatePickerComponent } from './date-picker/date-picker.component';
import { CellActiveDirective } from './date-picker/cell-active.directive';
import { DatePickerMonthComponent } from './date-picker/date-picker-month/date-picker-month.component';
import { DatePickerYearComponent } from './date-picker/date-picker-year/date-picker-year.component';
import { DatePickerViewDirective } from './date-picker/date-picker-view.directive';
import { AppSvgComponent } from './app-svg/app-svg.component';
import { GridBuilderComponent } from './grid/grid-builder/grid-builder.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    DatePickerComponent,
    CellActiveDirective,
    DatePickerMonthComponent,
    DatePickerYearComponent,
    DatePickerViewDirective,
    AppSvgComponent,
    GridBuilderComponent
  ],
  exports: [
    DatePickerComponent,
    AppSvgComponent,
    GridBuilderComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
  ]
})
export class BaseElementsModule { }
