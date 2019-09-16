import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { MONTHS } from '../Months';

@Component({
  selector: 'app-date-picker-month',
  templateUrl: './date-picker-month.component.html',
  styleUrls: ['./date-picker-month.component.sass']
})
export class DatePickerMonthComponent implements OnInit {
  months = MONTHS;
  @Output() chooseMonthChanged = new EventEmitter<string>();
  constructor() { }

  ngOnInit() {
  }

  chooseMonth($event) {
    this.chooseMonthChanged.emit($event.target.nativeElement);
  }

}
